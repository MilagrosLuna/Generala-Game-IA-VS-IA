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
    public class JugadorTest
    {
        [TestMethod]
        public void JugadorHayGanador()
        {
            Jugador bot1=new Jugador("pedro");
            Jugador bot2=new Jugador("juan");
            Jugador ganador;
            bot1.Puntuaciones = new int[]{4,2,6,3,5,2,12,20,30,10,50};
            bot2.Puntuaciones = new int[]{4,2,6,3,5,2,12,20,0,0,0};
            ganador = Jugador.VerificarGanador(bot1, bot2);
            Assert.AreEqual(bot1, ganador);
        }

        [TestMethod]
        public void JugadorHayEmpate()
        {
            Jugador bot1 = new Jugador("pedro");
            Jugador bot2 = new Jugador("juan");
            Jugador ganador;
            Jugador empate = new Jugador("fue empate");
            bot1.Puntuaciones = new int[] { 4, 2, 6, 3, 5, 2, 12, 20, 30, 10, 50 };
            bot2.Puntuaciones = new int[] { 4, 2, 6, 3, 5, 2, 12, 20, 30, 10, 50 };
            ganador = Jugador.VerificarGanador(bot1, bot2);
            Assert.AreEqual(empate.Nombre, ganador.Nombre);
        }

      

    }
}
