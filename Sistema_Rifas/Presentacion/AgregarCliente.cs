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
    public partial class Cliente : Form
    {

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarComboDNI(ref cmbTipoDoc,"Descripcion","Id");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool cargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            string consulta = "SELECT Nombre, Apellido, DNI, TipoDoc, Direccion,Telefono,Barrio,Ciudad FROM Personas";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            grillaCliente.DataSource = tabla;

            return true;
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals("") || txtDNI.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Los campos: Nombre, Apellido y DNI, son obligatorios!");
            }
            else
            {
                    if (AccesoADatos.NuevoCliente.InsertarNuevoCliente(txtNombre.Text,txtApellido.Text,txtDNI.Text,cmbTipoDoc.Text,txtDireccion.Text,txtTelefono.Text,txtBarrio.Text,txtCiudad.Text))
                    {
                        MessageBox.Show("Cliente agregado.");
                        cargarGrilla();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar...");
                    }

            }
        }
        private bool buscarRifa(string NumeroRifa)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]);

            string consulta = "SELECT * FROM Personas WHERE NumeroRifa = @NumeroRifa";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NumeroRifa", NumeroRifa);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            if (tabla.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            cmbTipoDoc.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";

            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void cargarComboDNI(ref ComboBox combo, string descripcion, string pk)
        {
            combo.Items.Clear();
            combo.DataSource = AccesoADatos.NuevoCliente.ObtenerTiposDNI();
            combo.DisplayMember = descripcion;
            combo.ValueMember = pk;
        }
    }
}
