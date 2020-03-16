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

namespace WindowsFormsApplication1
{
    public partial class Usuario : Form
    {

        public Usuario()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre de usuario");
            }
            else
            {
                bool resultado = AccesoADatos.NuevoUsuario.compararContraseña(txtContraseña.Text, txtRepetirContraseña.Text);
                if (resultado)
                {
                    AccesoADatos.NuevoUsuario.InsertarNuevoUsuario(txtUsuario.Text, txtContraseña.Text);
                    MessageBox.Show("El usuario se agrego con exito");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtContraseña.Text = "";
            txtRepetirContraseña.Text = "";
            txtUsuario.Text = "";

            txtUsuario.Focus();
        }

    }
}
