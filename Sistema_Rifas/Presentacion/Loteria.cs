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
    public partial class Loteria : Form
    {
        public Loteria()
        {
            InitializeComponent();
        }

        private void Loteria_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerLoterias";

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            grillaLoteria.DataSource = tabla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtCodigo.Text.Equals("")||txtLoteria.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos!");
                }
                else
                {
                    bool resultado = AccesoADatos.NuevaLoteria.agregarLoteria(txtCodigo.Text, txtLoteria.Text);
                    MessageBox.Show("Loteria agregada");
                    cargarGrilla();
                    limpiarCampos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar loteria");
                throw;
            }
        }
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtLoteria.Text = "";
            txtCodigo.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
