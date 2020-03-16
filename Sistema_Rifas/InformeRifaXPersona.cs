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
    public partial class InformeRifaXPersona : Form
    {
        public InformeRifaXPersona()
        {
            InitializeComponent();
        }

        private void InformeRifaXPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'RifaPersona.RifaPorPersona' Puede moverla o quitarla según sea necesario.
            this.RifaPorPersonaTableAdapter.Fill(this.RifaPersona.RifaPorPersona);

            this.reportViewer1.RefreshReport();
        }
    }
}
