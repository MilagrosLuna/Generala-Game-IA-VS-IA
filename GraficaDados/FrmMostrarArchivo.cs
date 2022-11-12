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
    public partial class FrmMostrarArchivo : Form
    {
        private List<Jugador> jugadores;
        private DataTable DatatablePuntuaciones;
        private DataView DataViewPuntuaciones;
        public FrmMostrarArchivo(List<Jugador>jugadores)
        {
            this.jugadores = jugadores;
            InitializeComponent();
            GenerarTablaPuntuaciones();
            this.Icon = (Icon)Properties.Resources.dado;
        }
       
        /// <summary>
        /// carga los datos en el data grid, de la lista de jugadores q recibe
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
                DatatablePuntuaciones.Columns.Add("Nombre", typeof(string));
                DatatablePuntuaciones.Columns.Add("Puntuacion", typeof(string));
                DatatablePuntuaciones.Columns.Add("Turnos", typeof(string));

                foreach (Jugador item in this.jugadores)
                {
                    string nombre = item.Nombre;
                    string uno = item.Puntuacion.ToString();
                    string dos = item.Turnos.ToString();
                    DatatablePuntuaciones.Rows.Add(nombre, uno, dos);
                }
                dataGridView1.DataSource = DatatablePuntuaciones;

            }
        }
    }
}
