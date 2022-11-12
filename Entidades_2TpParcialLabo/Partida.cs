using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades_2TpParcialLabo
{
    public class Partida
    {
        public delegate void Action(int numero);
        public event Action Eliminar;

        private List<Jugador> jugadores;
        private bool hayGanador;
        private Jugador ganador;
        private int numero;
        private Dado[] dados;
        private int rondas;

        #region propiedades y  tostring()
        public int Rondas
        {
            get { return this.rondas; }
            set { this.rondas = value; }
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public bool HayGanador
        {
            get { return this.hayGanador; }
            set { this.hayGanador = value; }
        }
        public List<Jugador> Jugadores
        {
            get { return this.jugadores; }
        }
        public Jugador Ganador
        {
            get { return this.ganador; }
            set { this.ganador = value; }
        }
        public Dado[] Dados
        {
            get { return this.dados; }
            set { this.dados = value; }
        }
        public override string ToString()
        {
            return $"PARTIDA N° {this.numero}"; 
        }
        #endregion

        public Partida()
        {
            this.rondas = 0;
            this.jugadores = new List<Jugador>();
            this.hayGanador = false;
            this.dados = new Dado[5];
            for(int i = 0; i < 5 ; i++)
            {
                dados[i] = new Dado(); 
            }
        }

        /// <summary>
        /// es para elimar la partida del form principal una vez q finaliza
        /// </summary>
        public void invocarEliminacion()
        {
            if(this.Eliminar is not null)
            {
                this.Eliminar.Invoke(this.Numero);
            }  
        }
        /// <summary>
        /// para agregar jugadores a la partida
        /// </summary>
        /// <param name="partida"></param>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static Partida operator +(Partida partida, Jugador jugador)
        {
            if (partida is not null && jugador is not null)
            {
                partida.jugadores.Add(jugador);
            }
            
            return partida;
        }

    


    }
}
