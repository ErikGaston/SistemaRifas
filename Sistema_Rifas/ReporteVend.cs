using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReporteVend : Form
    {
        public ReporteVend()
        {
            InitializeComponent();
        }

        private void ReporteVend_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteVendedores.Vendedores' Puede moverla o quitarla según sea necesario.
            this.VendedoresTableAdapter.Fill(this.ReporteVendedores.Vendedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
