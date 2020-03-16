using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace WindowsFormsApplication1.AccesoADatos
{
    class NuevoCliente
    {

        public static bool InsertarNuevoCliente(string nombre, string apellido, string dni, string TipoDoc, string direccion, string telefono, string barrio, string ciudad)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "INSERT INTO Personas  (Nombre,Apellido,DNI,TipoDoc,Direccion,Telefono,Barrio,Ciudad) VALUES (@nombre,@Apellido,@DNI,@TipoDoc,@direccion,@telefono,@barrio,@ciudad)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@TipoDoc", TipoDoc);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@barrio", barrio);
                cmd.Parameters.AddWithValue("@ciudad", ciudad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                cn.Close();

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

        public static DataTable ObtenerClientePorDNI(int dni)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT DNI,Nombre,Apellido FROM Personas WHERE dni=@dni";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

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

        public static DataTable ConsultarClienteDNI(int dni)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT * FROM Personas WHERE dni=@dni";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

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

        public static DataTable ObtenerTiposDNI()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "SELECT * FROM TiposDocumentos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

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
        public static bool EliminarCliente(int dni)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "DELETE FROM Personas WHERE [DNI] = @dni";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
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
