using System;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades_2TpParcialLabo
{
    public class Dado
    {
        private int numero;

        public Dado()
        {
            this.numero = 0;
        }

        public int Numero // para devolver el numero
        {
            get { return this.numero; }
            set { this.numero=value; }
        }
        /// <summary>
        /// Metodo que simula la tirada del dado, asigna un valor random entre 1 y 6 incluidos
        /// </summary>
        /// <param name="R"></param>
        public void Lanzar(Random R)
        {
            this.numero = R.Next(1,7);
        }

        #region Generala
        /// <summary>
        /// Verifica si En la jugada de dados que recibe esta la jugada generala
        /// es decir, que hayan salido 5 dados iguales
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public static bool Generala(Dado[] dados)
        {
            bool esGenerala = false;
            int contador = 1;
            for (int i = 1; i < 5; i++)   
            {
                if ((dados[i]).Numero == (dados[0]).Numero)
                {
                    contador++;
                }
            }
            if (contador == 5)
            {
                esGenerala = true;
            }
            return esGenerala;
        }
        #endregion
        #region escalera
        /// <summary>
        ///  Verifica si En la jugada de dados que recibe esta la jugada escalera
        /// es decir, que hayan salido todos los dados distintos
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public static bool Escalera(Dado[] dados)
        {
            bool esEscalera = false;
            if (dados[0].Numero != dados[1].Numero &&
                 dados[0].Numero != dados[2].Numero &&
                 dados[0].Numero != dados[3].Numero &&
                 dados[0].Numero != dados[4].Numero )
            {
                if (dados[1].Numero != dados[2].Numero &&
                    dados[1].Numero != dados[3].Numero &&
                    dados[1].Numero != dados[4].Numero )
                {
                    if (dados[2].Numero != dados[3].Numero &&
                        dados[2].Numero != dados[4].Numero )
                    {
                        if (dados[3].Numero != dados[4].Numero )
                        {
                            
                                esEscalera = true;
                            
                        }
                    }
                }

            }
            return esEscalera;
        }
        #endregion
        #region poker
        /// <summary>
        ///  Verifica si En la jugada de dados que recibe esta la jugada poker
        /// es decir, que hayan salido al menos 4 dados iguales
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public static bool Poker(Dado[] dados)
        {
            bool esPoker = false;
            int[] numeros = new int[7];
            int i = 0;
            int poker = 0;
            int numero4 = 0;
            int posicion = 0;
            for (i = 0; i < dados.Length; i++)
            {
                if (dados[i].Numero == 1)
                {
                    numeros[1]++;
                }
                if (dados[i].Numero == 2)
                {
                    numeros[2]++;
                }
                if (dados[i].Numero == 3)
                {
                    numeros[3]++;
                }
                if (dados[i].Numero == 4)
                {
                    numeros[4]++;
                }
                if (dados[i].Numero == 5)
                {
                    numeros[5]++;
                }
                if (dados[i].Numero == 6)
                {
                    numeros[6]++;
                }
            }
            for (i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 4)
                {
                    poker++;
                    numero4 = i;
                }
            }
            for (i = 0; i < dados.Length; i++)
            {
                if (dados[i].Numero != numero4)
                {
                    posicion = i;
                }
            }
            if (poker == 1)
            {
                esPoker = true;
            }
            return esPoker;
        }
        #endregion
        #region full
        /// <summary>
        ///  Verifica si En la jugada de dados que recibe esta la jugada full
        /// es decir, que hayan salido 3 dados iguales y 2 iguales distintos al anterior
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public static bool Full(Dado[] dados)
        {
            bool esFull = false;
            int[] numeros = new int[7];
            int i = 0;
            int numerocon3 = 0;
            int numerocon2 = 0;
            for (i = 0; i < dados.Length ; i++)
            {
                if (dados[i].Numero == 1)
                {
                    numeros[1]++;
                }
                if (dados[i].Numero == 2)
                {
                    numeros[2]++;
                }
                if (dados[i].Numero == 3)
                {
                    numeros[3]++;
                }
                if (dados[i].Numero == 4)
                {
                    numeros[4]++;
                }
                if (dados[i].Numero == 5)
                {
                    numeros[5]++;
                }
                if (dados[i].Numero == 6)
                {
                    numeros[6]++;
                }
            }
            for (i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 3)
                {
                    numerocon3 = i;
                }
            }
            if (numerocon3 > 0)
            {
                for (i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 2)
                    {
                        numerocon2 = i;
                    }
                }
            }
            if (numerocon3 >0 && numerocon2 >0)
            {
                esFull = true;
            }
            return esFull;
        }
        #endregion

        /// <summary>
        /// metodo que verifica  la cantidad de veces que salio un numero en una tirada de dados 
        /// es decir si salieron 3-3-4-5-1 , me devuelve que el 3 salio 2 veces, el 4,5 y1 solo una vez
        /// para despues poder ver cual me conviene guardar, si el q mas salio o el q no. no es lo mismo 
        /// guardar uno al 1, que guardar seis al 3
        /// </summary>
        /// <param name="dados"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static int VerificarPuntuacionNumero(Dado[] dados,int numero)
        {
            int contador = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i].Numero == numero)
                {
                    contador++;
                }
            }
            return contador;
        }

      

    }
}
