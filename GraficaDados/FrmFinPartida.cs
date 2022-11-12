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
    public partial class FrmFinPartida : Form
    {
        private Partida partida;
        private AccesoDatos ado;
        public FrmFinPartida(Partida partidaFinalizada)
        {
            InitializeComponent();
            this.partida = partidaFinalizada;
            this.ado = new AccesoDatos();
            this.Icon = (Icon)Properties.Resources.dado;
        }
        /// <summary>
        ///  en el load se cambian los labels depende de la info de la partida q recibe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFinPartida_Load(object sender, EventArgs e)
        {
            if(partida.HayGanador==true)
            {
                this.lbl_ganador.Text = "El ganador es: " + this.partida.Ganador.Nombre;
                this.lbl_puntuacion.Text = "Con una puntuacion de: " + this.partida.Ganador.Puntuacion;
                this.lbl_partida.Text = "Es la partida N° " + this.partida.Numero.ToString();
            }
            else
            {
                this.lbl_ganador.Text = "No hubo ganador";
                this.lbl_puntuacion.Text = "Fue empate";
                this.lbl_partida.Text = "Es la partida N° " + this.partida.Numero.ToString();
            }

            if (this.ado.AgregarDato(this.partida))
            {
              //  MessageBox.Show("agregada a la base de datos");
            }

        }

    }
}
