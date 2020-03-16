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
    class NuevoVendedor
    {

        public static bool agregarVendedor(string nombre, string comision)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "INSERT INTO Vendedores (Nombre,Comision) VALUES (@Nombre,@Comision)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Comision", comision);

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

        public static bool ModificarVendedores(string nombre, string comision)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            try
            {
                string consulta = "UPDATE Vendedores SET [Nombre] = @Nombre , [Comision] = @Comision WHERE [Nombre] = @Nombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Comision", comision);
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

        public static bool EliminarVendedor(string nombre)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            try
            {
                string consulta = "DELETE FROM Vendedores WHERE [Nombre] = @Nombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
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

        public static DataTable ObtenerVendedorPorCodigo(int Id)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            SqlCommand cmd = new SqlCommand();

            try
            {
                string consulta = "SELECT * FROM Vendedores WHERE Id = @Id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", Id);

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
    }
}
