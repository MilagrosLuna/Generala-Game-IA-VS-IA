using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Entidades_2TpParcialLabo
{
    public class AccesoDatos
    {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
               
        // CAMBIAR CADENA DE CONEXION, el backup de la base se encuentra en el git
        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=base_datos_parcial;Data Source=DESKTOP-23PB1ME";
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public List<Partida> ObtenerListaDato()
        {
            List<Partida> lista = new List<Partida>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.CommandText = "SELECT * FROM dbo.tablaPartida";


                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Partida item = new Partida();

                    item.Numero = (int)lector["Id"];
                    item.Rondas = int.Parse(lector["Rondas"].ToString());
                    item.Ganador = new Jugador(lector["Ganador"].ToString());
                    item.Ganador.Puntuacion = int.Parse(lector["Puntuacion"].ToString());
                   
                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        public bool AgregarDato(Partida param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.tablaPartida (Rondas,Ganador,Puntuacion) VALUES(";
                sql = sql + param.Rondas.ToString() + ",'" + param.Ganador.Nombre + "'," + param.Ganador.Puntuacion.ToString() + ")";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarDato(Partida param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Id", param.Numero);
                this.comando.Parameters.AddWithValue("@Rondas", param.Rondas);
                this.comando.Parameters.AddWithValue("@Ganador", param.Ganador.Nombre);
                this.comando.Parameters.AddWithValue("@Puntuacion", param.Ganador.Puntuacion);
                

                string sql = "UPDATE dbo.tablaPartida ";
                sql += "SET Rondas = @Rondas, Ganador = @Ganador, Puntuacion =  @Puntuacion ";
                sql += "WHERE Id = @Id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.tablaPartida ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }
    }
}
