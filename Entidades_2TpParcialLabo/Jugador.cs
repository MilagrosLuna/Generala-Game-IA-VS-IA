using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2TpParcialLabo
{
    public class Jugador
    {
        public delegate Dado[] delegadoTirada(Partida nuevaPartida);
        public event delegadoTirada tirada;
        private string nombre;
        private int puntuacionTotal;
        private int turnos;
        private int[] puntuaciones;
        private Dado[] dadosLanzados;
       
        public Jugador()
        {
            this.nombre = "";
            this.puntuacionTotal = 0;
            this.puntuaciones = new int[11];
        }
        public Jugador(string nombre) : this()
        {
            if (nombre is not null)
            {
                this.nombre = nombre;
            }
        }
        public Jugador(string nombre,int puntuacion,int turnos) : this(nombre)
        {
            this.puntuacionTotal = puntuacion;
            this.turnos = turnos;
        }

        #region propiedades y tostring()
        public int Turnos
        {
            get { return this.turnos; }
            set { this.turnos = value; }
        }
        public int[] Puntuaciones
        {
            get { return this.puntuaciones; }
            set { this.puntuaciones = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Puntuacion
        {
            get { return this.puntuacionTotal; }
            set { this.puntuacionTotal = value; }
        }
        /// <summary>
        /// sobrecarga utilizada para la escritura en archivos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre + " - " + this.puntuacionTotal + " - " + this.turnos;
        }
        #endregion

        /// <summary>
        /// metodo que se encarga de jugar el turno, tirar dados y guardar la puntuacion
        /// </summary>
        /// <param name="partida"></param>
        public void JugarTurno(Partida partida)
        {
            Dado[] aux = new Dado[5];
            
            if (this.tirada is not null)
            {
                this.dadosLanzados = this.tirada.Invoke(partida);
            }
           
            int[] puntuacion = new int[11];
            puntuacion = ContarPuntuacion(dadosLanzados);
            CompararPuntuaciones(puntuacion, this.puntuaciones);
        }

        /// <summary>
        /// este metodo compara entre todas las puntuaciones de la jugada reciente y las q tiene el jugador
        /// osea si el jugador tiene guardado 20 puntos a escalera, y en la jugada receinte lo mas grande que
        /// podria guardar es una escalera, el metodo dice q no q busque la proxima puntuacion, porq el jugador ya 
        /// tiene guardada una puntuacion en el lugar de escalera
        /// </summary>
        /// <param name="puntuacionTiradaReciente"></param>
        /// <param name="puntuacionDelJugador"></param>
        private void CompararPuntuaciones(int[] puntuacionTiradaReciente, int[] puntuacionDelJugador)
        {
            int indexMayorPuntuacion = -1;
            int puntuacion = 0;
            bool tienePuntos = true;

            while(tienePuntos)
            {
                indexMayorPuntuacion = CalcularPuntuacionMaxima(puntuacionTiradaReciente, out puntuacion);
                // este if es solo para cuando la jugada es generala y verifica para ver si tiene o no doble generala
                if (indexMayorPuntuacion == 9)
                {
                    if (puntuacionDelJugador[indexMayorPuntuacion] > 0)
                    {
                        puntuacionDelJugador[10] = 100;
                    }
                }
                // if q compara lo que el jugador tiene guardado con lo q recibio para
                // ver si puee guardar esa jugada
                // si no puede guardarla, la elimina y vuelve a buscar la mejor jugada
                if (puntuacionDelJugador[indexMayorPuntuacion] == 0)
                {
                    puntuacionDelJugador[indexMayorPuntuacion] = puntuacion;
                    tienePuntos = false;
                }
                else
                {
                    if (puntuacion == 0)
                    {
                        break;
                    }
                    tienePuntos = true;
                    puntuacionTiradaReciente[indexMayorPuntuacion] = 0;
                }                
            }
        }

        /// <summary>
        /// Metodo que recibe todas las puntuaciones de alguna jugada, y compara cual es la mayor, retorna el indice de la jugada (para saber cual fue)
        /// y tambien devuelve la puntuacion
        /// </summary>
        /// <param name="puntuacionTiradaReciente"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        private int CalcularPuntuacionMaxima(int[] puntuacionTiradaReciente, out int numero)
        {
            int indexMayorPuntuacion = -1;
            int puntuacion = 0;
            
            for (int i = 0; i < 10; i++)
            {
                if(i==0)
                {
                    indexMayorPuntuacion = i;
                    puntuacion = puntuacionTiradaReciente[i];
                }
                if (puntuacionTiradaReciente[i] >puntuacion)
                {
                    indexMayorPuntuacion = i;
                    puntuacion = puntuacionTiradaReciente[i];
                }
            }
            numero = puntuacion;
            return indexMayorPuntuacion;
        }

        /// <summary>
        ///  Verifica Todas las puntuaciones posibles en base a la jugada que se realizo
        ///  y retorna todas las puntuaciones
        /// </summary>
        /// <param name="dadosJugados"></param>
        /// <returns></returns>
        private int[] ContarPuntuacion(Dado[] dadosJugados)
        {
            int[] puntuacion = new int[11];
            int numero;
            if(Dado.Generala(dadosJugados))
            {
                puntuacion[9] = 50;
            }
            if(Dado.Escalera(dadosJugados))
            {
                puntuacion[6] = 20;
            }
            if (Dado.Poker(dadosJugados))
            {
                puntuacion[8] = 40;
            }
            if (Dado.Full(dadosJugados))
            {
                puntuacion[7] = 30;
            }
           
            for(int i=1;i<7;i++)
            {
                numero=Dado.VerificarPuntuacionNumero(dadosJugados, i);
                puntuacion[i-1] = numero * i;
            }
            
            return puntuacion;
        }

        /// <summary>
        ///  metodo que calcula las puntuaciones y verifica quien fue el que obtuvo mayor
        ///  puntuacion, sino retorna un empate
        /// </summary>
        /// <param name="jugador1"></param>
        /// <param name="jugador2"></param>
        /// <returns></returns>
        public static Jugador VerificarGanador(Jugador jugador1, Jugador jugador2)
        {
            Jugador ganador = new Jugador("fue empate");
            jugador1.puntuacionTotal =0;
            jugador2.puntuacionTotal =0;
            for (int i=0;i<11;i++)
            {
                jugador1.puntuacionTotal += jugador1.puntuaciones[i];
                jugador2.puntuacionTotal += jugador2.puntuaciones[i];
            }
            if(jugador1.puntuacionTotal > jugador2.puntuacionTotal)
            {
                ganador = jugador1;
            }
            else if(jugador2.puntuacionTotal > jugador1.puntuacionTotal)
            {
                ganador = jugador2;
            }
            return ganador;
        }


    }
}
