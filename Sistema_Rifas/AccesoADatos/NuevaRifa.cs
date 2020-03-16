using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1.AccesoADatos
{
    class NuevaRifa
    {

        public static bool Rifa(DateTime fecha, int NroRifa, int dni,string nombre,string apellido, int CodLoteria,int CodVendedor,List<int>listaRifa)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            SqlTransaction objTransacion = null;

            try
            {
                SqlCommand cmdRifa = new SqlCommand();
                SqlCommand cmdRifaPersona = new SqlCommand();
                

                string consulta = "INSERT INTO Rifa VALUES (@NroRifa,@fecha,@dni,@nombre,@apellido)";

                cmdRifa.Parameters.Clear();
                cmdRifa.Parameters.AddWithValue("@fecha", fecha);
                cmdRifa.Parameters.AddWithValue("@NroRifa", NroRifa);
                cmdRifa.Parameters.AddWithValue("@dni", dni);
                cmdRifa.Parameters.AddWithValue("@nombre", nombre);
                cmdRifa.Parameters.AddWithValue("@apellido", apellido);

                cn.Open();
                objTransacion = cn.BeginTransaction("Alta de Rifa");

                cmdRifa.CommandType = CommandType.Text;
                cmdRifa.CommandText = consulta;

                cmdRifa.Transaction = objTransacion;

                cmdRifa.Connection = cn;

                cmdRifa.ExecuteNonQuery();

                foreach (var Id in listaRifa)
                {
                    string consultaRifaxPersona = "INSERT INTO RifaPorPersona VALUES (@Fecha,@CodLoteria,@NroRifa,@CodVendedor,@dni)";

                    cmdRifaPersona.Transaction = objTransacion;

                    cmdRifaPersona.Parameters.Clear();
                    cmdRifaPersona.Parameters.AddWithValue("@Fecha", fecha);
                    cmdRifaPersona.Parameters.AddWithValue("@NroRifa", NroRifa);
                    cmdRifaPersona.Parameters.AddWithValue("@dni", dni);
                    cmdRifaPersona.Parameters.AddWithValue("@CodLoteria", CodLoteria);
                    cmdRifaPersona.Parameters.AddWithValue("@CodVendedor", CodVendedor);

                    cmdRifaPersona.CommandType = CommandType.Text;
                    cmdRifaPersona.CommandText = consultaRifaxPersona;

                    
                    cmdRifaPersona.Connection = cn;
                    cmdRifaPersona.ExecuteNonQuery();

                }

                objTransacion.Commit();
                return true;

            }
            catch (Exception)
            {

                objTransacion.Rollback();
                return false;

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

       

        public static DataTable ObtenerTodasLasRifas()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                SqlCommand cmd = new SqlCommand();

                //string consulta = "SELECT * FROM Rifa";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerTodasLasRifas";

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            
        }

        public static int obtenerIdRifa()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT MAX(Id) FROM Rifa";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            

        }

        public static bool ValidarNroRifa(int NumeroRifa)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "SELECT * FROM RifaPorPersona WHERE NumeroRifa=@NumeroRifa";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumeroRifa", NumeroRifa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                cn.Close();
            }
            
        }
    }
}
