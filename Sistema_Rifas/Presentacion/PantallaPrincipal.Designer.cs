namespace WindowsFormsApplication1
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaRifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarSorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPremiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoSorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConRifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loteriasOrdenadasPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInicio = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.consultarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1370, 36);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(122, 32);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaRifaToolStripMenuItem,
            this.realizarSorteoToolStripMenuItem,
            this.cargarPremiosToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.loteriaToolStripMenuItem,
            this.nuevoSorteoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 32);
            this.toolStripMenuItem1.Text = "Nuevo";
            // 
            // nuevaRifaToolStripMenuItem
            // 
            this.nuevaRifaToolStripMenuItem.Name = "nuevaRifaToolStripMenuItem";
            this.nuevaRifaToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.nuevaRifaToolStripMenuItem.Text = "Cliente";
            this.nuevaRifaToolStripMenuItem.Click += new System.EventHandler(this.nuevaRifaToolStripMenuItem_Click);
            // 
            // realizarSorteoToolStripMenuItem
            // 
            this.realizarSorteoToolStripMenuItem.Name = "realizarSorteoToolStripMenuItem";
            this.realizarSorteoToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.realizarSorteoToolStripMenuItem.Text = "Premio";
            this.realizarSorteoToolStripMenuItem.Click += new System.EventHandler(this.realizarSorteoToolStripMenuItem_Click);
            // 
            // cargarPremiosToolStripMenuItem
            // 
            this.cargarPremiosToolStripMenuItem.Name = "cargarPremiosToolStripMenuItem";
            this.cargarPremiosToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.cargarPremiosToolStripMenuItem.Text = "Rifa";
            this.cargarPremiosToolStripMenuItem.Click += new System.EventHandler(this.cargarPremiosToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // loteriaToolStripMenuItem
            // 
            this.loteriaToolStripMenuItem.Name = "loteriaToolStripMenuItem";
            this.loteriaToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.loteriaToolStripMenuItem.Text = "Loteria";
            this.loteriaToolStripMenuItem.Click += new System.EventHandler(this.loteriaToolStripMenuItem_Click);
            // 
            // nuevoSorteoToolStripMenuItem
            // 
            this.nuevoSorteoToolStripMenuItem.Name = "nuevoSorteoToolStripMenuItem";
            this.nuevoSorteoToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.nuevoSorteoToolStripMenuItem.Text = "Usuario";
            this.nuevoSorteoToolStripMenuItem.Click += new System.EventHandler(this.nuevoSorteoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesConRifasToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.ganadoresToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.consultarToolStripMenuItem.Text = "Consultas";
            // 
            // clientesConRifasToolStripMenuItem
            // 
            this.clientesConRifasToolStripMenuItem.Name = "clientesConRifasToolStripMenuItem";
            this.clientesConRifasToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.clientesConRifasToolStripMenuItem.Text = "Clientes";
            this.clientesConRifasToolStripMenuItem.Click += new System.EventHandler(this.clientesConRifasToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // ganadoresToolStripMenuItem
            // 
            this.ganadoresToolStripMenuItem.Name = "ganadoresToolStripMenuItem";
            this.ganadoresToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.ganadoresToolStripMenuItem.Text = "Ganadores";
            this.ganadoresToolStripMenuItem.Click += new System.EventHandler(this.ganadoresToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rifaToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.estadisticaVendedoresToolStripMenuItem,
            this.loteriasOrdenadasPorNombreToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.reportesToolStripMenuItem.Text = "Reportes y Estadisticas";
            // 
            // rifaToolStripMenuItem
            // 
            this.rifaToolStripMenuItem.Name = "rifaToolStripMenuItem";
            this.rifaToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.rifaToolStripMenuItem.Text = "Rifas Vendidas";
            this.rifaToolStripMenuItem.Click += new System.EventHandler(this.rifaToolStripMenuItem_Click_1);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.resultadosToolStripMenuItem.Text = "Ganadores";
            this.resultadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // estadisticaVendedoresToolStripMenuItem
            // 
            this.estadisticaVendedoresToolStripMenuItem.Name = "estadisticaVendedoresToolStripMenuItem";
            this.estadisticaVendedoresToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.estadisticaVendedoresToolStripMenuItem.Text = "Vendedores";
            this.estadisticaVendedoresToolStripMenuItem.Click += new System.EventHandler(this.estadisticaVendedoresToolStripMenuItem_Click);
            // 
            // loteriasOrdenadasPorNombreToolStripMenuItem
            // 
            this.loteriasOrdenadasPorNombreToolStripMenuItem.Name = "loteriasOrdenadasPorNombreToolStripMenuItem";
            this.loteriasOrdenadasPorNombreToolStripMenuItem.Size = new System.Drawing.Size(359, 32);
            this.loteriasOrdenadasPorNombreToolStripMenuItem.Text = "Loterias ordenadas por nombre";
            this.loteriasOrdenadasPorNombreToolStripMenuItem.Click += new System.EventHandler(this.loteriasOrdenadasPorNombreToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTecnicoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteTecnicoToolStripMenuItem
            // 
            this.soporteTecnicoToolStripMenuItem.Name = "soporteTecnicoToolStripMenuItem";
            this.soporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.soporteTecnicoToolStripMenuItem.Text = "Soporte tecnico";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(12, 50);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(0, 13);
            this.lblInicio.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(789, 48);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(569, 34);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "BIENVENIDO AL SISTEMA DE GESTION DE VENTAS DE RIFAS.\r\nEn este programa usted podr" +
    "a gestionar y administrar de forma sencilla la venta de rifas.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de rifas - Menú principal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

/*        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;*/
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarSorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoSorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPremiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesConRifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaRifaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rifaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loteriasOrdenadasPorNombreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label Titulo;
    }
}