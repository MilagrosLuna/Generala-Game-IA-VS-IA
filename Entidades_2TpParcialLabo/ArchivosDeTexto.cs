using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades_2TpParcialLabo
{
    public static class ArchivosDeTexto
    {
        public static StreamWriter sw;
        public static StreamReader sr;
        public static string path;

        /// <summary>
        /// Genera el directorio para guardar el archivo
        /// </summary>
        static ArchivosDeTexto()
        {
            if (!Directory.Exists("..\\Archivos"))
            {
                Directory.CreateDirectory("..\\Archivos");
            }

            ArchivosDeTexto.path = "..\\Archivos\\jugadores.txt";
        }
        /// <summary>
        /// Guarda los jugadores de la lista que recibe en el archivo 
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool AgregarAlArchivo(List<Jugador> lista)
        {
            bool agrego = false;

            try
            {
                ArchivosDeTexto.sw = new StreamWriter(ArchivosDeTexto.path, true);
                foreach (Jugador item in lista)
                {
                    ArchivosDeTexto.sw.WriteLine(item.ToString());
                }
                agrego = true;
            }
            catch
            {
                agrego = false;
            }
            finally
            {
                if (ArchivosDeTexto.sw != null)
                    ArchivosDeTexto.sw.Close();
            }

            return agrego;
        }
        /// <summary>
        /// Devuelve una lista con los jugadores guardados en el archivo
        /// </summary>
        /// <returns></returns>
        public static List<Jugador> LeerArchivoLineaALinea()
        {
            string retorno = "";
            List<Jugador> lista = new List<Jugador>();
            try
            {
                using (ArchivosDeTexto.sr = new StreamReader(ArchivosDeTexto.path))
                {
                    while ((retorno = ArchivosDeTexto.sr.ReadLine()) != null)
                    {
                        string[] datosJugador = retorno.Split(" - ");

                        Jugador p = new Jugador(datosJugador[0], int.Parse(datosJugador[1]), int.Parse(datosJugador[2]));

                        lista.Add(p);
                    }
                }
            }
            catch 
            {
                lista = null;
            }

            return lista;
        }

    }
}
