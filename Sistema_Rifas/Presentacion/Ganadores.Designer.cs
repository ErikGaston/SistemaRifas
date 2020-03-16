namespace WindowsFormsApplication1
{
    partial class Ganadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ganadores));
            this.lblPosicion = new System.Windows.Forms.Label();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.lblNroGanador = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaGanadores = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RIFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTERIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grillPermios = new System.Windows.Forms.DataGridView();
            this.POSICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREMIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtVerGanador = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNroGanador = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtLoteria = new System.Windows.Forms.TextBox();
            this.txtPosocion = new System.Windows.Forms.TextBox();
            this.txtPremio = new System.Windows.Forms.TextBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGanadores)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillPermios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(12, 63);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(83, 22);
            this.lblPosicion.TabIndex = 0;
            this.lblPosicion.Text = "Posicion:";
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(130, 63);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(88, 21);
            this.cmbPosicion.TabIndex = 1;
            // 
            // lblNroGanador
            // 
            this.lblNroGanador.AutoSize = true;
            this.lblNroGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroGanador.Location = new System.Drawing.Point(12, 97);
            this.lblNroGanador.Name = "lblNroGanador";
            this.lblNroGanador.Size = new System.Drawing.Size(153, 22);
            this.lblNroGanador.TabIndex = 2;
            this.lblNroGanador.Text = "Numero Ganador:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(171, 99);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(118, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "GANADORES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grillaGanadores);
            this.panel1.Location = new System.Drawing.Point(15, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 133);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATOS DEL GANADOR";
            // 
            // grillaGanadores
            // 
            this.grillaGanadores.AllowUserToAddRows = false;
            this.grillaGanadores.AllowUserToDeleteRows = false;
            this.grillaGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.RIFA,
            this.DNI,
            this.LOTERIA});
            this.grillaGanadores.Location = new System.Drawing.Point(0, 32);
            this.grillaGanadores.Name = "grillaGanadores";
            this.grillaGanadores.ReadOnly = true;
            this.grillaGanadores.Size = new System.Drawing.Size(346, 98);
            this.grillaGanadores.TabIndex = 0;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // RIFA
            // 
            this.RIFA.HeaderText = "RIFA";
            this.RIFA.Name = "RIFA";
            this.RIFA.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // LOTERIA
            // 
            this.LOTERIA.DataPropertyName = "CodLoteria";
            this.LOTERIA.HeaderText = "LOTERIA";
            this.LOTERIA.Name = "LOTERIA";
            this.LOTERIA.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.grillPermios);
            this.panel2.Location = new System.Drawing.Point(18, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 133);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "DATOS DEL PREMIO";
            // 
            // grillPermios
            // 
            this.grillPermios.AllowUserToAddRows = false;
            this.grillPermios.AllowUserToDeleteRows = false;
            this.grillPermios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillPermios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.POSICION,
            this.PREMIO});
            this.grillPermios.Location = new System.Drawing.Point(0, 30);
            this.grillPermios.Name = "grillPermios";
            this.grillPermios.ReadOnly = true;
            this.grillPermios.Size = new System.Drawing.Size(245, 100);
            this.grillPermios.TabIndex = 0;
            // 
            // POSICION
            // 
            this.POSICION.HeaderText = "POSICION";
            this.POSICION.Name = "POSICION";
            this.POSICION.ReadOnly = true;
            // 
            // PREMIO
            // 
            this.PREMIO.HeaderText = "PREMIO";
            this.PREMIO.Name = "PREMIO";
            this.PREMIO.ReadOnly = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(272, 304);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(89, 40);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtVerGanador
            // 
            this.txtVerGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerGanador.Location = new System.Drawing.Point(257, 63);
            this.txtVerGanador.Name = "txtVerGanador";
            this.txtVerGanador.Size = new System.Drawing.Size(104, 56);
            this.txtVerGanador.TabIndex = 12;
            this.txtVerGanador.Text = "Ver Ganador";
            this.txtVerGanador.UseVisualStyleBackColor = true;
            this.txtVerGanador.Click += new System.EventHandler(this.txtVerGanador_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(21, 413);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(64, 20);
            this.txtFecha.TabIndex = 13;
            this.txtFecha.Visible = false;
            // 
            // txtNroGanador
            // 
            this.txtNroGanador.Location = new System.Drawing.Point(91, 413);
            this.txtNroGanador.Name = "txtNroGanador";
            this.txtNroGanador.Size = new System.Drawing.Size(64, 20);
            this.txtNroGanador.TabIndex = 14;
            this.txtNroGanador.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(161, 413);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(64, 20);
            this.txtDni.TabIndex = 15;
            this.txtDni.Visible = false;
            // 
            // txtLoteria
            // 
            this.txtLoteria.Location = new System.Drawing.Point(231, 413);
            this.txtLoteria.Name = "txtLoteria";
            this.txtLoteria.Size = new System.Drawing.Size(64, 20);
            this.txtLoteria.TabIndex = 16;
            this.txtLoteria.Visible = false;
            // 
            // txtPosocion
            // 
            this.txtPosocion.Location = new System.Drawing.Point(300, 413);
            this.txtPosocion.Name = "txtPosocion";
            this.txtPosocion.Size = new System.Drawing.Size(64, 20);
            this.txtPosocion.TabIndex = 17;
            this.txtPosocion.Visible = false;
            // 
            // txtPremio
            // 
            this.txtPremio.Location = new System.Drawing.Point(272, 384);
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.Size = new System.Drawing.Size(64, 20);
            this.txtPremio.TabIndex = 18;
            this.txtPremio.Visible = false;
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(18, 436);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(0, 18);
            this.lblInforme.TabIndex = 19;
            // 
            // Ganadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 512);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.txtPremio);
            this.Controls.Add(this.txtPosocion);
            this.Controls.Add(this.txtLoteria);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNroGanador);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtVerGanador);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNroGanador);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.lblPosicion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ganadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganadores";
            this.Load += new System.EventHandler(this.Ganadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGanadores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillPermios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.Label lblNroGanador;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaGanadores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillPermios;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSICION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREMIO;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button txtVerGanador;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RIFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTERIA;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNroGanador;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtLoteria;
        private System.Windows.Forms.TextBox txtPosocion;
        private System.Windows.Forms.TextBox txtPremio;
        private System.Windows.Forms.Label lblInforme;
    }
}