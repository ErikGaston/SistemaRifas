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
    public partial class ConsultarCliente : Form
    {

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private bool cargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);
            try
            {
                //string consulta = "SELECT * FROM Personas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerClientes";

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaCliente.DataSource = tabla;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool resultado = AccesoADatos.NuevoCliente.EliminarCliente(int.Parse(txtDNI.Text));
            if (resultado)
            {
                MessageBox.Show("El cliente se elimino con exito");
                cargarGrilla();
                txtDNI.Text = "";
                
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable resultado = AccesoADatos.NuevoCliente.ConsultarClienteDNI(int.Parse(txtDNI.Text));
                if (resultado.Rows.Count > 0)
                {
                    grillaCliente.DataSource = resultado;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
