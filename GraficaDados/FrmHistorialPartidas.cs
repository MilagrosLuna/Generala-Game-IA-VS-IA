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
    /// <summary>
    ///  este form es para todo lo que tiene que ver con la base de datos, llama a mostrar, modificar y eliminar
    /// </summary>
    public partial class FrmHistorialPartidas : Form
    {
        private AccesoDatos ado;
        private List<Partida> partidasJugadas;
        private FrmPartidasHistoricas partidas;
        private FrmSeleccionarPartidaModificar frmModificar;
        private FrmSeleccionarPartidasEliminar frmEliminar;
        public FrmHistorialPartidas()
        {
            InitializeComponent();
            this.ado = new AccesoDatos();
            this.partidasJugadas = new List<Partida>();
            this.partidas = new FrmPartidasHistoricas(ado.ObtenerListaDato());
            this.frmModificar = new FrmSeleccionarPartidaModificar(ado.ObtenerListaDato());
            this.frmEliminar = new FrmSeleccionarPartidasEliminar(ado.ObtenerListaDato());
            this.Icon = (Icon)Properties.Resources.dado;
        }

        private void btn_probarConexion_Click(object sender, EventArgs e)
        {
            if(ado.ProbarConexion())
            {
                MessageBox.Show("Conexion EXITOSA", "Conexion");
            }
            else
            {
                MessageBox.Show("Conexion FALLO", "Conexion");
            }
        }

        private void btn_verPartidas_Click(object sender, EventArgs e)
        {
            this.partidas.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.frmModificar.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.frmEliminar.ShowDialog();
        }
    }
}
