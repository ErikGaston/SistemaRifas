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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }


        private void nuevoSorteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.ShowDialog();
        }

        private void nuevaRifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.ShowDialog();
        }

        private void realizarSorteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Premios p = new Premios();
            p.ShowDialog();
        }

        private void cargarPremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaRifa ventana = new NuevaRifa();
            ventana.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesConRifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente cc = new ConsultarCliente();
            cc.ShowDialog();
        }

        private void loteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loteria ventana = new Loteria();
            ventana.ShowDialog();
        }


        private void rifaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InformeRifaXPersona reporte = new InformeRifaXPersona();
            reporte.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteClientes ventana = new ReporteClientes();
            ventana.ShowDialog();
        }

        private void ganadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ganadores g = new Ganadores();
            g.ShowDialog();
        }

        private void estadisticaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVend ventana = new ReporteVend();
            ventana.ShowDialog();
        }

        private void loteriasOrdenadasPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoLoteriasPorNombre ventana = new ListadoLoteriasPorNombre();
            ventana.ShowDialog();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteDeGanadores r = new ReporteDeGanadores();
            r.ShowDialog();
        }

    }
}

