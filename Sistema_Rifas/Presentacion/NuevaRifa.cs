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
    public partial class NuevaRifa : Form
    {
        public NuevaRifa()
        {
            InitializeComponent();
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaresultado = AccesoADatos.NuevoCliente.ObtenerClientePorDNI(int.Parse(txtDNI.Text.Trim()));

                if (tablaresultado.Rows.Count > 0)
                {
                    txtDNI.Text = tablaresultado.Rows[0][0].ToString();
                    txtNombre.Text = tablaresultado.Rows[0][1].ToString();
                    txtApellido.Text = tablaresultado.Rows[0][2].ToString();
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Cliente no encontrado!", "Desea cargar un cliente nuevo?", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    { 
                        Cliente c = new Cliente();
                        c.ShowDialog();
                    }
                    else
                    {
                        txtDNI.Text = "";
                        txtDNI.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar cliente.");
                throw;
            }
        }

        private void btnBuscarLoteria_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable resultado = AccesoADatos.NuevaLoteria.ObtenerLoteriaPorID(int.Parse(txtCodLoteria.Text));
                if (resultado.Rows.Count > 0)
                {
                    txtLoteria.Text = resultado.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("Loteria no encontrada!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar");

                throw;
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable resultado = AccesoADatos.NuevoVendedor.ObtenerVendedorPorCodigo(int.Parse(txtCodVendedor.Text));
                if (resultado.Rows.Count > 0)
                {
                    txtNombreV.Text = resultado.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Vendedor no encontrado!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar!");

                throw;
            }
        }

        private void limpiarCampos()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCodLoteria.Text = "";
            txtCodVendedor.Text = "";
            txtNombreV.Text = "";
            txtNroRifa.Text = "";
            txtLoteria.Text = "";

            txtDNI.Focus();                 
        }

        private void NuevaRifa_Load(object sender, EventArgs e)
        {
            cargarIdRifa();

        }
        private void cargarIdRifa()
        {
            txtIdRifa.Text = (AccesoADatos.NuevaRifa.obtenerIdRifa() + 1).ToString();
        }

        private void txtAgergarRifa_Click(object sender, EventArgs e)
        {
            bool resultado = AccesoADatos.NuevaRifa.ValidarNroRifa(int.Parse(txtNroRifa.Text));
            if (resultado)
            {
                MessageBox.Show("El numero de rifa, ya existe!");
            }
            else
            {
                grillaRifa.Rows.Add(int.Parse(txtIdRifa.Text), txtFecha.Text, txtDNI.Text, txtNroRifa.Text, txtCodVendedor.Text, txtCodLoteria.Text);
            }
            
        }

        private void btnFinaliarRifa_Click(object sender, EventArgs e)
        {
            List<int> listaRifa = new List<int>();

            for (int i = 0; i < grillaRifa.Rows.Count; i++)
            {
                listaRifa.Add(int.Parse(grillaRifa.Rows[i].Cells[0].Value.ToString()));
            }

            bool resultado = AccesoADatos.NuevaRifa.Rifa(DateTime.Parse(txtFecha.Text), int.Parse(txtNroRifa.Text), int.Parse(txtDNI.Text),txtNombre.Text,txtApellido.Text,int.Parse(txtCodLoteria.Text),int.Parse(txtCodVendedor.Text),listaRifa);

            if (resultado)
            {
                MessageBox.Show("Rifa dada de alta exitosamente!");
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al dar de alta!");
            }
        }

    }
}
