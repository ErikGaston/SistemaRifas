using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {


            bool resultado = false;

            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un usuario y contraseña...");
            }
            else
            {
             
                resultado = ValidarUsuario(txtContraseña.Text.Trim(), txtContraseña.Text.Trim());

                if (resultado)
                {
                    PantallaPrincipal pantalla = new PantallaPrincipal();
                    this.Hide();
                    pantalla.Show();

                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");
                }

            }

        }
        private bool ValidarUsuario(string nombreUsuario, string password)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "SELECT * FROM Login WHERE Usuario = @NomUsu AND Contraseña = @Pass ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NomUsu", nombreUsuario);
                cmd.Parameters.AddWithValue("@Pass", password);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable Tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Tabla);

                if (Tabla.Rows.Count == 1)
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
                
                throw;
            }
            finally
            {
                cn.Close();
            }
           

        }
        private void Login_Load(object sender, EventArgs e)
        {
            ActualizarUsuarios();
        }

        private bool ActualizarUsuarios()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                //string consulta = "SELECT * FROM Login";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerUsuarios";

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return true;
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkNomUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidaUsuario os = new OlvidaUsuario();
            os.ShowDialog();
        }

        private void linkContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidaContraseña oc = new OlvidaContraseña();
            oc.ShowDialog();
        }

        private void linkCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario u = new Usuario();
            u.ShowDialog();
        }
    }
}
