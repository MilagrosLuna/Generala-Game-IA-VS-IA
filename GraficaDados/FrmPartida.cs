using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_2TpParcialLabo;

namespace GraficaDados
{
    public partial class FrmPartida : Form
    {
        private Partida nuevaPartida;
        private Dado[] dados;
        private Jugador bot1;
        private Jugador bot2;
        private DataTable DatatablePuntuaciones;
        private DataView DataViewPuntuaciones;
        private FrmFinPartida finPartida;
        private CancellationTokenSource tokenSource;
        private CancellationToken token;
        private bool banderaClosing;
        private bool banderaBtnCancelar;

        /// <summary>
        /// inicializo los datos 
        /// </summary>
        /// <param name="contadorPartidas"></param>
        /// <param name="partida"></param>
        public FrmPartida(int contadorPartidas, Partida partida)
        {
            InitializeComponent();
            nuevaPartida = partida;
            nuevaPartida.Numero = contadorPartidas;

            String[] nombres = { "Mili","Mauro","Maxi","Nacho","Juanse","Facu","Arturo" };
            Random r = new Random();
            int random = r.Next(0, 7);
            bot1 = new Jugador(nombres[random]);
            random = r.Next(0, 7);
            bot2 = new Jugador(nombres[random]);

            finPartida = new FrmFinPartida(nuevaPartida);
            this.tokenSource = new CancellationTokenSource();
            this.Icon = (Icon)Properties.Resources.dado;
            this.token = this.tokenSource.Token;
        }
        /// <summary>
        ///  cargo los jugadores a la partida y comienza a jugarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPartida_Load(object sender, EventArgs e)
        {
            this.Text = "Partida n°" + nuevaPartida.Numero;
            this.nuevaPartida += bot1;
            this.nuevaPartida += bot2;
            this.banderaClosing = false;
            this.banderaBtnCancelar = false;
            foreach (Jugador item in nuevaPartida.Jugadores)
            {
                item.tirada += this.Tirada;
            }

            int turno=0;
            Task tarea = new Task(()=>{
                bool bandera = true;
                while(bandera)
                {
                    foreach (Jugador item in nuevaPartida.Jugadores)
                    {
                        item.JugarTurno(this.nuevaPartida);
                        item.Turnos++;
                        if (item.Turnos!= turno)
                        {
                            nuevaPartida.Rondas++;
                        }
                        turno = item.Turnos;
                        ActualizarLbl(item.Nombre,nuevaPartida.Rondas);
                        GenerarTablaPuntuaciones();
                        Thread.Sleep(1000);

                        if (item.Turnos == 11 || this.token.IsCancellationRequested)
                        {
                            bandera = false;
                            this.nuevaPartida.invocarEliminacion();
                            
                        }
                    }
                }
                if(this.banderaClosing==false)
                {
                    FinPartida();
                    VerificarArchivos_Serializador();
                }
            });
            tarea.Start();
        }

        /// <summary>
        /// Srerializa los jugadores al finalizar la partida
        /// </summary>
        /// <returns></returns>
       private bool VerificarArchivos_Serializador()
        {
            bool ok = false;
            List<Jugador> AUX = nuevaPartida.Jugadores;
            List<Jugador> jugadoresLlamadosMaxi = new List<Jugador>();
            List<Jugador> jugadoresJson;
            List<Jugador> jugadoresXml;
            SerializadorJson<List<Jugador>> serializadorJson = new SerializadorJson<List<Jugador>>("Jugadores.json");
            SerializadorXml<List<Jugador>> serializadorXml = new SerializadorXml<List<Jugador>>("Jugadores.xml");

            /// hago esto para no pisar los datos q ya tenia
            jugadoresJson = serializadorJson.Deserializar();
            if(jugadoresJson is null)
            {
                jugadoresJson = new List<Jugador>();
            }
            jugadoresXml = serializadorXml.Deserializar();
            if(jugadoresXml is null)
            {
                jugadoresXml = new List<Jugador>();
            }
            
            foreach (Jugador item in AUX)
            {
                if (item.Nombre == "Maxi")
                {
                    jugadoresLlamadosMaxi.Add(item);
                }
                for (int i = 0; i < 11; i++)
                {
                    item.Puntuacion += item.Puntuaciones[i];
                }
                if (item.Puntuacion > 100)
                {
                    jugadoresJson.Add(item);
                }
                if (item.Puntuacion < 101)
                {
                    jugadoresXml.Add(item);
                }              
            }

            if (jugadoresLlamadosMaxi.Count > 0)
            {
                if (ArchivosDeTexto.AgregarAlArchivo(jugadoresLlamadosMaxi))
                {
                    ok = true;
                }
            }
            if (jugadoresJson.Count > 0)
            {
                if (serializadorJson.Serializar(jugadoresJson))
                {
                    ok = true;
                }
            }
            if (jugadoresXml.Count > 0)
            {
                if (serializadorXml.Serializar(jugadoresXml))
                {
                    ok = true;
                }
            }
            return ok;
        }

        private void btn_cancelarPartida_Click(object sender, EventArgs e)
        {
            this.banderaBtnCancelar = true;
            this.tokenSource.Cancel();
        }
       /// <summary>
       /// cuando termina la partida instancio un nuevo form para mostrar los datos 
       /// </summary>
        private void FinPartida()
        {
            if (InvokeRequired)
            {
                Action fin = FinPartida;
                BeginInvoke(fin);
            }
            else
            {
                if (Jugador.VerificarGanador(bot1, bot2).Nombre != "empate")
                {
                    this.nuevaPartida.HayGanador = true;
                    this.nuevaPartida.Ganador = Jugador.VerificarGanador(bot1, bot2);
                    this.finPartida.Show();
                    this.banderaBtnCancelar = true;
                    this.Close();
                    
                }
                else
                {
                    this.nuevaPartida.HayGanador = false;
                    this.nuevaPartida.Ganador = Jugador.VerificarGanador(bot1, bot2);
                    this.finPartida.Show();
                    this.banderaBtnCancelar = true;
                    this.Close();
                }
                
            }
        }
        /// <summary>
        ///  actualiza el label del nombre por cada turno y la ronda
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="rondas"></param>
        private void ActualizarLbl(string nombre,int rondas)
        {
            if (InvokeRequired)
            {
                Action<string,int> actualizar = ActualizarLbl;
                object[] obj = new object[] { nombre,rondas };

                BeginInvoke(actualizar,obj);
            }
            else
            {
                this.label_turnoJugador.Text = nombre;
                this.label_rondas.Text = "Ronda n°" + rondas;
            }
        }
        
        /// <summary>
        ///  lanza los dados y actualiza las imagenes en el form
        /// </summary>
        /// <param name="nuevaPartida"></param>
        /// <returns></returns>
        private Dado[] Tirada(Partida nuevaPartida)
        {
            this.dados = nuevaPartida.Dados;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                this.dados[i].Lanzar(r);
            }
            nuevaPartida.Dados = this.dados;
            CargarImagen(this.dados); 
            return this.dados;
        }

       
        /// <summary>
        ///  carga las picture box
        /// </summary>
        /// <param name="dados"></param>
        private void CargarImagen(Dado[] dados)
        {
           this.pictureBox_dado1.Image = MostrarDado(dados[0]);
           this.pictureBox_dado2.Image = MostrarDado(dados[1]);
           this.pictureBox_dado3.Image = MostrarDado(dados[2]);
           this.pictureBox_dado4.Image = MostrarDado(dados[3]);
           this.pictureBox_dado5.Image = MostrarDado(dados[4]);
           this.pictureBox_gif.Image = (Image)Properties.Resources.gyphy;

        }
        /// <summary>
        ///  verifica q foto mostrar y la devuelve
        /// </summary>
        /// <param name="dado"></param>
        /// <returns></returns>
        private Image MostrarDado(Dado dado)
        {
            Image miImagen= (Image)Properties.Resources._1cara; 
            if (dado.Numero == 1)
            {
                miImagen = (Image)Properties.Resources._1cara;
            }
            if (dado.Numero == 2)
            {
                miImagen = (Image)Properties.Resources._2cara;
            }
            if (dado.Numero == 3)
            {
                miImagen = (Image)Properties.Resources._3cara;
            }
            if (dado.Numero == 4)
            {
                miImagen = (Image)Properties.Resources._4cara;
            }
            if (dado.Numero == 5)
            {
                miImagen = (Image)Properties.Resources._5cara;
            }
            if (dado.Numero == 6)
            {
                miImagen = (Image)Properties.Resources._6cara;
            }
            return miImagen;
        }

        /// <summary>
        /// carga las puntuaciones de los jugadores en el datagrid
        /// </summary>
        private void GenerarTablaPuntuaciones()
        {
            if (InvokeRequired)
            {
                Action generarTabla = GenerarTablaPuntuaciones;
                BeginInvoke(generarTabla);
            }
            else
            {
                DatatablePuntuaciones = new DataTable();
                DataViewPuntuaciones = DatatablePuntuaciones.DefaultView;
                DatatablePuntuaciones.Columns.Add("Jugador", typeof(string));
                DatatablePuntuaciones.Columns.Add("1", typeof(string));
                DatatablePuntuaciones.Columns.Add("2", typeof(string));
                DatatablePuntuaciones.Columns.Add("3", typeof(string));
                DatatablePuntuaciones.Columns.Add("4", typeof(string));
                DatatablePuntuaciones.Columns.Add("5", typeof(string));
                DatatablePuntuaciones.Columns.Add("6", typeof(string));
                DatatablePuntuaciones.Columns.Add("ESCALERA", typeof(string));
                DatatablePuntuaciones.Columns.Add("FULL", typeof(string));
                DatatablePuntuaciones.Columns.Add("POKER", typeof(string));
                DatatablePuntuaciones.Columns.Add("GENERALA", typeof(string));
                DatatablePuntuaciones.Columns.Add("GENERALA2", typeof(string));

                foreach (Jugador item in nuevaPartida.Jugadores)
                {
                    string nombre = item.Nombre;
                    string uno = item.Puntuaciones[0].ToString();
                    string dos = item.Puntuaciones[1].ToString();
                    string tres = item.Puntuaciones[2].ToString();
                    string cuatro = item.Puntuaciones[3].ToString();
                    string cinco = item.Puntuaciones[4].ToString();
                    string seis = item.Puntuaciones[5].ToString();
                    string escalera = item.Puntuaciones[6].ToString();
                    string full = item.Puntuaciones[7].ToString();
                    string poker = item.Puntuaciones[8].ToString();
                    string generala = item.Puntuaciones[9].ToString();
                    string generala2 = item.Puntuaciones[10].ToString();
                    DatatablePuntuaciones.Rows.Add(nombre, uno, dos, tres, cuatro, cinco, seis, escalera, full, poker, generala, generala2);
                }
                dataGridView1.DataSource = DatatablePuntuaciones;

            }
        }

        private void FrmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (banderaBtnCancelar==true)
            {
                this.nuevaPartida.invocarEliminacion(); 
            }
            else
            {
                if (MessageBox.Show("¿Esta seguro de salir la partida?? no podras volver..", "atencion!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.nuevaPartida.invocarEliminacion(); 
                    this.banderaClosing = true;
                }
            }
          
        }
    }
}
