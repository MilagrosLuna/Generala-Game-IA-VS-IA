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
    public partial class FrmModificar : Form
    {
        private AccesoDatos ado;
        private int id;
        public FrmModificar(int id)
        {
            InitializeComponent();
            this.ado = new AccesoDatos();
            this.Icon = (Icon)Properties.Resources.dado;
            this.id = id;
        }

        /// <summary>
        /// modifica la partida en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Validar() == true)
            {
                Partida nuevaPartida = new Partida();
                nuevaPartida.Numero = this.id;
                nuevaPartida.Rondas = int.Parse(this.textBox_rondas.Text);
                nuevaPartida.Ganador = new Jugador(this.textBox_Ganador.Text);
                nuevaPartida.Ganador.Puntuacion = int.Parse(this.textBox_puntuacion.Text);

                if (this.ado.ModificarDato(nuevaPartida))
                {
                    MessageBox.Show("modificada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("no se modifico.");
                }
            }
           
        }

        /// <summary>
        ///  verifica que todos los datos de la partida se completen
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(textBox_Ganador.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("ganador");
            }

            if (string.IsNullOrWhiteSpace(textBox_puntuacion.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("puntuacion");
            }

            if (string.IsNullOrWhiteSpace(textBox_rondas.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("rondas");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

    }
}
