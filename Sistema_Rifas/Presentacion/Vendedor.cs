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
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtComision.Text.Equals(""))
            {
                MessageBox.Show("Campos vacios!");
            }
            else
            {
                bool resultado = AccesoADatos.NuevoVendedor.agregarVendedor(txtNombre.Text, txtComision.Text);
                if (resultado)
                {
                    MessageBox.Show("Vendedor agregado exitosamente!");
                    cargarGrilla();
                    limpiarCampos();
                }
            }
        }

        private void cargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            //string consulta = "SELECT Nombre,Comision FROM Vendedores";
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerVendedores";

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            grillaVendedores.DataSource = tabla;
  
        }

        private void Vendedor_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void limpiarCampos()
        {
            txtComision.Text = "";
            txtNombre.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool resultado = AccesoADatos.NuevoVendedor.ModificarVendedores(txtNombre.Text,txtComision.Text);
            if (resultado)
            {
                MessageBox.Show("Vendedor modificado exitosamente!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool resultado = AccesoADatos.NuevoVendedor.EliminarVendedor(txtNombre.Text);
            if (resultado)
            {
                MessageBox.Show("Vendedor Eliminado!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
