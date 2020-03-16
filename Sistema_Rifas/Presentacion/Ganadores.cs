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
    public partial class Ganadores : Form
    {
        public Ganadores()
        {
            InitializeComponent();
        }


        private void CargarComboPosicion(ref ComboBox cmbPosicion, string descripcion, string pk)
        {
            cmbPosicion.Items.Clear();
            cmbPosicion.DataSource = AccesoADatos.Ganadores.ObtenerTablaPremios();

            cmbPosicion.DisplayMember = descripcion;
            cmbPosicion.ValueMember = pk;
        }

        private void Ganadores_Load(object sender, EventArgs e)
        {
            CargarComboPosicion(ref cmbPosicion, "Descripcion", "Posicion");

        }

        private void txtVerGanador_Click(object sender, EventArgs e)
        {
            DataTable resultado = AccesoADatos.Ganadores.ObtenerDatosGanador(int.Parse(txtNumero.Text));
            DataTable resultado1 = AccesoADatos.Ganadores.ObtenerDatoPremios(int.Parse(cmbPosicion.Text));

            if (resultado.Rows.Count > 0 &  resultado1.Rows.Count>0)
            {
                grillaGanadores.Rows.Add(resultado.Rows[0][1], resultado.Rows[0][3], resultado.Rows[0][5], resultado.Rows[0][2]);
                grillPermios.Rows.Add(resultado1.Rows[0][1], resultado1.Rows[0][2]);

                txtFecha.Text = resultado.Rows[0][1].ToString();
                txtNroGanador.Text = resultado.Rows[0][3].ToString();
                txtDni.Text = resultado.Rows[0][5].ToString();
                txtLoteria.Text = resultado.Rows[0][2].ToString();
                txtPosocion.Text = resultado1.Rows[0][1].ToString();
                txtPremio.Text = resultado1.Rows[0][2].ToString();

                lblInforme.Text = "FELICIDADES AL GANADOR DNI "+txtDni.Text+"!!\n POR SU PREMIO "+txtPremio.Text+" !!";
            }
            else
            {
                MessageBox.Show("No se encontraron los datos solicitados!");
                limpiarCampos();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            try
            {
                AccesoADatos.Ganadores.AgregarGanador(DateTime.Parse(txtFecha.Text), int.Parse(txtNroGanador.Text), int.Parse(txtPosocion.Text), int.Parse(txtDni.Text), int.Parse(txtLoteria.Text));
                MessageBox.Show("Ganador agregago exitosamente!");
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                throw;
            }

        }

        private void limpiarCampos()
        {
            cmbPosicion.Text = "";
            txtNumero.Text = "";

            txtNumero.Focus();
        }
    }

    
}
