using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_2TpParcialLabo;
using System;

namespace Generala_Tests
{
    [TestClass]
    public class DadoTest
    {
        [TestMethod]
        public void LanzarOk()
        {
            bool lanzados = false;
            Dado[] dados = new Dado[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
                dados[i].Lanzar(r);
                if(dados[i].Numero>0&& dados[i].Numero<7)
                {
                    lanzados = true;
                }
                else
                {
                    lanzados = false;
                    break;
                }
            }
           
            //Assert
            Assert.IsTrue(lanzados);

        }

        #region Generala
        [TestMethod]
        public void EsGenerala_Ok()// q sea generala y me devuelva true  Q si es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 5;
            dados[1].Numero = 5;
            dados[2].Numero = 5;
            dados[3].Numero = 5;
            dados[4].Numero = 5;
            bool esGenerala = Dado.Generala(dados);
            //Assert
            Assert.IsTrue(esGenerala);

        }
        [TestMethod]
        public void EsGenerala_Falla() // q no sea generala y me devuelva false Q NO ES 
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 5;
            dados[1].Numero = 5;
            dados[2].Numero = 2;
            dados[3].Numero = 5;
            dados[4].Numero = 5;
            bool esGenerala = Dado.Generala(dados);
            //Assert
            Assert.IsFalse(esGenerala);
        }
        #endregion

        #region escalera
        [TestMethod]
        public void EsEscalera_Ok()// q sea escalera y me devuelva true  Q si es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 5;
            dados[1].Numero = 6;
            dados[2].Numero = 2;
            dados[3].Numero = 3;
            dados[4].Numero = 4;
            bool esEscalera = Dado.Escalera(dados);
            //Assert
            Assert.IsTrue(esEscalera);
        }
        [TestMethod]
        public void EsEscalera_Falla()// q no sea escalera y me devuelva true  Q no es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 6;
            dados[1].Numero = 1;
            dados[2].Numero = 2;
            dados[3].Numero = 2;
            dados[4].Numero = 4;
            bool esEscalera = Dado.Escalera(dados);
            //Assert
            Assert.IsFalse(esEscalera);
        }

        #endregion

        #region poker
        [TestMethod]
        public void EsPoker_Ok()// q sea poker y me devuelva true  Q si es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 5;
            dados[1].Numero = 5;
            dados[2].Numero = 5;
            dados[3].Numero = 5;
            dados[4].Numero = 4;
            bool esPoker = Dado.Poker(dados);
            //Assert
            Assert.IsTrue(esPoker);
        }
        [TestMethod]
        public void EsPoker_Falla()// q no sea poker y me devuelva true  Q no es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 6;
            dados[1].Numero = 3;
            dados[2].Numero = 2;
            dados[3].Numero = 3;
            dados[4].Numero = 4;
            bool esPoker = Dado.Poker(dados);
            //Assert
            Assert.IsFalse(esPoker);
        }
        #endregion

        #region full
        [TestMethod]
        public void EsFull_Ok()// q sea full y me devuelva true  Q si es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 5;
            dados[1].Numero = 5;
            dados[2].Numero = 5;
            dados[3].Numero = 4;
            dados[4].Numero = 4;
            bool esFull = Dado.Full(dados);
            //Assert
            Assert.IsTrue(esFull);
        }
        [TestMethod]
        public void EsFull_Falla()// q no sea Full y me devuelva true  Q no es
        {
            Dado[] dados = new Dado[5];
            for (int i = 0; i < 5; i++)
            {
                dados[i] = new Dado();
            }
            dados[0].Numero = 6;
            dados[1].Numero = 3;
            dados[2].Numero = 2;
            dados[3].Numero = 3;
            dados[4].Numero = 4;
            bool esFull = Dado.Full(dados);
            //Assert
            Assert.IsFalse(esFull);
        }
        #endregion

    }
}
