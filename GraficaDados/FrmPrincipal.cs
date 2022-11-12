using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_2TpParcialLabo;
namespace GraficaDados
{
    public partial class FrmPrincipal : Form
    {
        private AccesoDatos ado;
        private int contadorPartidas;
        private FrmHistorialPartidas frmHistorial;
        private FrmArchivos frmArchivos;
        
        public FrmPrincipal()
        {
            InitializeComponent();
            this.ado = new AccesoDatos();
            contadorPartidas = ObtenerUltimoNum();
            frmHistorial = new FrmHistorialPartidas();
            frmArchivos = new FrmArchivos();
            this.Icon = (Icon)Properties.Resources.dado;
        }
        /// <summary>
        /// obtiene el ultimo numero de partida de la base de datos  y lo devuelve 
        /// </summary>
        /// <returns></returns>
        private int ObtenerUltimoNum()
        {
            List<Partida> partidasHistoricas = ado.ObtenerListaDato(); ;

            int id=0;
            for (int i = 0; i < partidasHistoricas.Count; i++)
            {
                id = partidasHistoricas[i].Numero;
            }
            return id;
        }
        /// <summary>
        ///  genera la partida 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GenerarPartida_Click(object sender, EventArgs e)
        {
            int numero;
            AgregarBtnPartida(GenerarPartida(out numero),numero);
        }
        /// <summary>
        /// se instancia la partida en el form
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private FrmPartida GenerarPartida(out int numero)
        {
            contadorPartidas++;
            numero = contadorPartidas;
            Partida partida = new Partida();
            partida.Eliminar += EliminarBtnPartida;
            FrmPartida frm_partida = new FrmPartida(contadorPartidas,partida);
            return frm_partida;
        }
        /// <summary>
        /// se agrega la partida a un panel de controles para poder acceder a ella
        /// </summary>
        /// <param name="partida"></param>
        /// <param name="numero"></param>
        private void AgregarBtnPartida(FrmPartida partida,int numero)
        {
            Button boton = new Button
            {
                Size = new Size(75, 75),
                Text = $"PARTIDA N°{numero}"
            };
            boton.BackgroundImage = (Image)Properties.Resources.fondo_jpg;
            boton.ForeColor = Color.White;
            this.flowLayoutPanelPartidas.Controls.Add(boton);
            

            partida.Show();
            partida.Visible = false;
            boton.Click += (sender, e) =>
            {
                partida.Visible = true;
            };

        }
        /// <summary>
        /// cuando se termine quita la partida del panel de controles
        /// </summary>
        /// <param name="numero"></param>
        private void EliminarBtnPartida(int numero)
        {
            if(InvokeRequired)
            {
                Action<int> fin = EliminarBtnPartida;
                BeginInvoke(fin,numero);
            }
            else
            {
                int elementos = this.flowLayoutPanelPartidas.Controls.Count;
                for (int i = elementos-1; i > -1 ; i--)
                {
                    if(flowLayoutPanelPartidas.Controls[i] is Button boton)
                    {
                        if(boton.Text == $"PARTIDA N°{numero}")
                        {
                            this.flowLayoutPanelPartidas.Controls.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void btn_historialPartidas_Click(object sender, EventArgs e)
        {
            frmHistorial.ShowDialog();
        }

        private void btn_archivos_Click(object sender, EventArgs e)
        {
            frmArchivos.ShowDialog();
        }
    }
}
