using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.AccesoADatos
{
    class Ganadores
    {
        public static DataTable ObtenerTablaPremios()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Posicion FROM Premios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerDatosGanador(int Numero)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM RifaPorPersona WHERE NumeroRifa = @NumeroRifa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumeroRifa", Numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerDatoPremios(int Posicion)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Premios WHERE Posicion = @Posicion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Posicion", Posicion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AgregarGanador(DateTime Fecha, int NroPremiado, int Posicion, int Dni, int Codloteria)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {


                string consulta = "INSERT INTO Ganadores (Fecha,NroPremiado,Posicion,Dni,CodLoteria) VALUES (@Fecha,@NroPremiado,@Posicion,@Dni,@Codloteria)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@NroPremiado", NroPremiado);
                cmd.Parameters.AddWithValue("@Posicion", Posicion);
                cmd.Parameters.AddWithValue("@Dni", Dni);
                cmd.Parameters.AddWithValue("@CodLoteria", Codloteria);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception )
            {
                return false;
                throw;
            }
            finally
            {
                cn.Close(); 
            }
            

        }

        //Prueba
    }
}
