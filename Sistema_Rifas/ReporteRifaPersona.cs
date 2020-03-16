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
    public partial class ReporteRifaPersona : Form
    {
        public ReporteRifaPersona()
        {
            InitializeComponent();
        }

        private void ReporteRifaPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetRifaPersona.ObtenerPersonaRifa' Puede moverla o quitarla según sea necesario.
            //this.ObtenerPersonaRifaTableAdapter.Fill(this.DataSetRifaPersona.ObtenerPersonaRifa);

            this.reportViewer1.RefreshReport();
        }
    }
}
