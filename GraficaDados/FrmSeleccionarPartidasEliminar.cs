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
    public partial class FrmSeleccionarPartidasEliminar : Form
    {
        private List<Partida> partidasJugadas;
        private DataTable partidasDatosDataTable;
        private DataView partidasDataView;
        private AccesoDatos ado;
        public FrmSeleccionarPartidasEliminar(List<Partida> partidas)
        {
            InitializeComponent();
            this.ado = new AccesoDatos();
            this.partidasJugadas = partidas;
            this.Icon = (Icon)Properties.Resources.dado;
        }

        private void FrmSeleccionarPartidasEliminar_Load(object sender, EventArgs e)
        {
            this.comboBox_partida.DataSource = this.partidasJugadas;
            GenerarTabla();
        }
        /// <summary>
        /// carga los datos en el datagrid
        /// </summary>
        private void GenerarTabla()
        {

            partidasDatosDataTable = new DataTable();
            partidasDataView = partidasDatosDataTable.DefaultView;
            partidasDatosDataTable.Columns.Add("Id", typeof(string));
            partidasDatosDataTable.Columns.Add("Rondas", typeof(string));
            partidasDatosDataTable.Columns.Add("Ganador", typeof(string));
            partidasDatosDataTable.Columns.Add("Puntuacion", typeof(string));
            foreach (Partida item in this.partidasJugadas)
            {
                string id = item.Numero.ToString();
                string rondas = item.Rondas.ToString();
                string ganador = item.Ganador.Nombre;
                string puntuacion = item.Ganador.Puntuacion.ToString();
                partidasDatosDataTable.Rows.Add(id, rondas, ganador, puntuacion);
            }
            dataGridView1.DataSource = partidasDatosDataTable;
        }
        /// <summary>
        /// elimina de la base de datos la partida seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            Partida Nueva = (Partida)comboBox_partida.SelectedItem;
            //MessageBox.Show(Nueva.Numero.ToString());
            if (this.ado.EliminarDato(Nueva.Numero))
            {
                MessageBox.Show("Eliminada");
                this.Close();
            }
            else
            {
                MessageBox.Show("no se elimino");
            }
        }
    }
}
