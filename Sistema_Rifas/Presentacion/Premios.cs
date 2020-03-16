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
    public partial class Premios : Form

    {
       
        public Premios()
        {
            InitializeComponent();
        }


        private void Premios_Load(object sender, EventArgs e)
        {
            cargarPremios();
        }

        private bool cargarPremios()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            //string consulta = "SELECT Posicion, Descripcion FROM Premios";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerPremios";

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            grillaPremios.DataSource = tabla;

            return true;
        }

        private void btnAgregarPremio_Click(object sender, EventArgs e)
        {

            if (txtPosicionPremio.Text.Equals("") || txtPremio.Text.Equals("") )
            {
                MessageBox.Show("Debe ingresar un premio");
            }
            else
            {
               DataTable res = AccesoADatos.NuevoPremio.BuscarPosicion(int.Parse(txtPosicionPremio.Text));
                if (res.Rows.Count>0)
                {
                    MessageBox.Show("La posicion ingresada, ya existe!");
                    LimpiarCampos();
                }
                else
                {
                    bool resultado = AccesoADatos.NuevoPremio.AgregarPremios(txtPosicionPremio.Text, txtPremio.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Premio agregado!");
                        cargarPremios();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar premio!");
                    }
                }
            }   
        }

        private void LimpiarCampos()
        {
            txtPremio.Text = "";
            txtPosicionPremio.Text = "";

            txtPosicionPremio.Focus();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private bool ModificarPremios()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "UPDATE Premios SET [Posicion] = @pos , [Descripcion] = @des WHERE [Posicion] = @pos";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pos", txtPosicionPremio.Text);
                cmd.Parameters.AddWithValue("@des", txtPremio.Text);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtPosicionPremio.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la posicion");
            }
            else
            {
                ModificarPremios();
                cargarPremios();
                LimpiarCampos();
                MessageBox.Show("El premio se modifico con exito");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPosicionPremio.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la posicion");
            }
            else
            {
                EliminarPremios();
                cargarPremios();
                LimpiarCampos();
                MessageBox.Show("El premio se elimino con exito");
            }
        }
        private bool EliminarPremios()
        {
            
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                string consulta = "DELETE FROM Premios WHERE [Posicion] = @pos";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pos", txtPosicionPremio.Text);
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
    }
}
