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
    public partial class FrmPartidasHistoricas : Form
    {
        private List<Partida> partidasJugadas;
        private DataTable partidasDatosDataTable;
        private DataView partidasDataView;
        public FrmPartidasHistoricas(List<Partida> partidas)
        {
            InitializeComponent();
            this.partidasJugadas = partidas;
            partidasDatosDataTable = new DataTable();
            partidasDataView = partidasDatosDataTable.DefaultView;
            this.Text = "";
            this.Icon = (Icon)Properties.Resources.dado;
            GenerarTabla();
        }
        /// <summary>
        /// carga la info en el datagrid
        /// </summary>
        private void GenerarTabla()
        {
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
    }
}
