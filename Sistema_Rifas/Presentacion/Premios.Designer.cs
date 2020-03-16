namespace WindowsFormsApplication1
{
    partial class Premios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Premios));
            this.lblIdPremio = new System.Windows.Forms.Label();
            this.lblPremio = new System.Windows.Forms.Label();
            this.txtPosicionPremio = new System.Windows.Forms.TextBox();
            this.txtPremio = new System.Windows.Forms.TextBox();
            this.btnAgregarPremio = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grillaPremios = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPremios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPremio
            // 
            this.lblIdPremio.AutoSize = true;
            this.lblIdPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPremio.Location = new System.Drawing.Point(12, 45);
            this.lblIdPremio.Name = "lblIdPremio";
            this.lblIdPremio.Size = new System.Drawing.Size(78, 22);
            this.lblIdPremio.TabIndex = 0;
            this.lblIdPremio.Text = "Posicion";
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio.Location = new System.Drawing.Point(12, 84);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(104, 22);
            this.lblPremio.TabIndex = 1;
            this.lblPremio.Text = "Descripcion";
            // 
            // txtPosicionPremio
            // 
            this.txtPosicionPremio.Location = new System.Drawing.Point(96, 47);
            this.txtPosicionPremio.Name = "txtPosicionPremio";
            this.txtPosicionPremio.Size = new System.Drawing.Size(43, 20);
            this.txtPosicionPremio.TabIndex = 1;
            // 
            // txtPremio
            // 
            this.txtPremio.Location = new System.Drawing.Point(16, 120);
            this.txtPremio.Multiline = true;
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.Size = new System.Drawing.Size(177, 79);
            this.txtPremio.TabIndex = 2;
            // 
            // btnAgregarPremio
            // 
            this.btnAgregarPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPremio.Location = new System.Drawing.Point(16, 214);
            this.btnAgregarPremio.Name = "btnAgregarPremio";
            this.btnAgregarPremio.Size = new System.Drawing.Size(121, 28);
            this.btnAgregarPremio.TabIndex = 3;
            this.btnAgregarPremio.Text = "Agregar Premio";
            this.btnAgregarPremio.UseVisualStyleBackColor = true;
            this.btnAgregarPremio.Click += new System.EventHandler(this.btnAgregarPremio_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(385, 214);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(115, 28);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Salir";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grillaPremios
            // 
            this.grillaPremios.AllowUserToAddRows = false;
            this.grillaPremios.AllowUserToDeleteRows = false;
            this.grillaPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPremios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Premio});
            this.grillaPremios.Location = new System.Drawing.Point(199, 47);
            this.grillaPremios.Name = "grillaPremios";
            this.grillaPremios.ReadOnly = true;
            this.grillaPremios.Size = new System.Drawing.Size(301, 152);
            this.grillaPremios.TabIndex = 6;
            // 
            // Posicion
            // 
            this.Posicion.DataPropertyName = "Posicion";
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            // 
            // Premio
            // 
            this.Premio.DataPropertyName = "Descripcion";
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            this.Premio.ReadOnly = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(143, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 28);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(264, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(194, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 25);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "PREMIOS";
            // 
            // Premios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grillaPremios);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregarPremio);
            this.Controls.Add(this.txtPremio);
            this.Controls.Add(this.txtPosicionPremio);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.lblIdPremio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Premios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premios";
            this.Load += new System.EventHandler(this.Premios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPremios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPremio;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.TextBox txtPosicionPremio;
        private System.Windows.Forms.TextBox txtPremio;
        private System.Windows.Forms.Button btnAgregarPremio;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView grillaPremios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
    }
}