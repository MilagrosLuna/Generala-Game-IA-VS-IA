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
    public partial class FrmArchivos : Form
    {
        private List<Jugador> jugadores;
        private FrmMostrarArchivo frmMostrar;
        private SerializadorJson<List<Jugador>> serializadorJson = new SerializadorJson<List<Jugador>>("Jugadores.json");
        private SerializadorXml<List<Jugador>> serializadorXml = new SerializadorXml<List<Jugador>>("Jugadores.xml");

        public FrmArchivos()
        {
            InitializeComponent();
            this.Icon = (Icon)Properties.Resources.dado;
            jugadores = new List<Jugador>();
        }

        /// <summary>
        ///  genera el form para mostrar los jugadores que deserializo en xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xml_Click(object sender, EventArgs e)
        {
            if (jugadores is not null)
            {
                jugadores.Clear();
            }
            jugadores = serializadorXml.Deserializar();
            if (jugadores is not null)
            {
                if (jugadores.Count > 0)
                {
                    //   MessageBox.Show("si");
                    frmMostrar = new FrmMostrarArchivo(jugadores);
                    frmMostrar.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("no hay jugadores");
            }
        }
        /// <summary>
        ///  genera el form para mostrar los jugadores que deserializo en json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_json_Click(object sender, EventArgs e)
        {
            if(jugadores is not null)
            {
                jugadores.Clear();
            }
            
            jugadores = serializadorJson.Deserializar();
            if (jugadores is not null)
            {
                if (jugadores.Count > 0)
                {
                    //   MessageBox.Show("si");
                    frmMostrar = new FrmMostrarArchivo(jugadores);
                    frmMostrar.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("no hay jugadores");
            }
        }
        /// <summary>
        ///  genera el form para mostrar los jugadores que obtuvo en la lectura del archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_archivoTexto_Click(object sender, EventArgs e)
        {
            if (jugadores is not null)
            {
                jugadores.Clear();
            }
            jugadores = ArchivosDeTexto.LeerArchivoLineaALinea();
            if(jugadores.Count>0)
            {
                //   MessageBox.Show("si");
                frmMostrar = new FrmMostrarArchivo(jugadores);
                frmMostrar.ShowDialog();
            }
            
        }

      
    }
}
