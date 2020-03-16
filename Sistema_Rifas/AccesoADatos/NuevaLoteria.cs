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
    class NuevaLoteria
    {
        public static bool agregarLoteria(string codigo, string descripcion)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            try
            {
                string consulta = "INSERT INTO Loteria(Codigo,Descripcion) VALUES (@Codigo,@Descripcion)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmd.ExecuteNonQuery();
                cn.Close();

                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public static DataTable ObtenerLoteriaPorID(int Codigo)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "SELECT * FROM Loteria WHERE Codigo=@Codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Codigo", Codigo);

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
