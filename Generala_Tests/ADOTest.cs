using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_2TpParcialLabo;

namespace Generala_Tests
{
    [TestClass]
    public class ADOTest
    {
        private AccesoDatos ados = new AccesoDatos();

        [TestMethod]
        public void AgregarPartida_ok()
        {
            Partida nueva = new Partida();
            nueva.Ganador = new Jugador("juan");
            nueva.Ganador.Puntuacion = 123;
            nueva.Rondas = 10;
            //Assert
            Assert.IsTrue(this.ados.AgregarDato(nueva));
        }

        [TestMethod]
        public void AgregarPartida_falla()
        {
            Partida nueva = new Partida();
            nueva.Rondas = 2;
            //Assert
            Assert.IsFalse(this.ados.AgregarDato(nueva));
        }

        [TestMethod]
        public void ObtenerListaDato_Ok()
        {
            //Assert
            Assert.IsNotNull(this.ados.ObtenerListaDato());
        }

        [TestMethod]
        public void ObtenerListaDato_Falla()
        {
            //Assert
            Assert.IsNull(this.ados.ObtenerListaDato());
        }

    }
}
