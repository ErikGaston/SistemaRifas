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
    class NuevoUsuario
    {
        public static bool InsertarNuevoUsuario(string usuario, string contraseña)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "INSERT INTO Login(Usuario,Contraseña) VALUES (@usuario,@contraseña)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

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

        public static bool compararContraseña(string contraseña, string repetircontraseña)
        {
            if (contraseña.Trim().Equals(repetircontraseña.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
