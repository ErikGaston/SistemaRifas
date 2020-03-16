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
    class NuevoPremio
    {
        public static bool AgregarPremios(string posicion, string premio)
        {
            
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "INSERT INTO Premios (Posicion,Descripcion) VALUES (@Posicion,@Descripcion);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Posicion", posicion);
                cmd.Parameters.AddWithValue("@Descripcion", premio);
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

        public static DataTable BuscarPosicion(int posicion)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "SELECT * FROM Premios WHERE Posicion = @Posicion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Posicion", posicion);

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
