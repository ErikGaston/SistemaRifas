namespace WindowsFormsApplication1
{
    partial class NuevaRifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaRifa));
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRifa = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCodLoteria = new System.Windows.Forms.Label();
            this.txtCodLoteria = new System.Windows.Forms.TextBox();
            this.btnBuscarLoteria = new System.Windows.Forms.Button();
            this.txtLoteria = new System.Windows.Forms.TextBox();
            this.lblLoteria = new System.Windows.Forms.Label();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grillaRifa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinaliarRifa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroRifa = new System.Windows.Forms.TextBox();
            this.txtAgergarRifa = new System.Windows.Forms.Button();
            this.lblIdRifa = new System.Windows.Forms.Label();
            this.txtIdRifa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRifa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVA RIFA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(19, 168);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 22);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(101, 168);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(76, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dni:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(100, 80);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(76, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(182, 75);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(76, 28);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 22);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(100, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblRifa
            // 
            this.lblRifa.AutoSize = true;
            this.lblRifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRifa.Location = new System.Drawing.Point(19, 140);
            this.lblRifa.Name = "lblRifa";
            this.lblRifa.Size = new System.Drawing.Size(79, 22);
            this.lblRifa.TabIndex = 9;
            this.lblRifa.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(101, 140);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // lblCodLoteria
            // 
            this.lblCodLoteria.AutoSize = true;
            this.lblCodLoteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodLoteria.Location = new System.Drawing.Point(301, 78);
            this.lblCodLoteria.Name = "lblCodLoteria";
            this.lblCodLoteria.Size = new System.Drawing.Size(132, 22);
            this.lblCodLoteria.TabIndex = 11;
            this.lblCodLoteria.Text = "Codigo Loteria:";
            // 
            // txtCodLoteria
            // 
            this.txtCodLoteria.Location = new System.Drawing.Point(439, 80);
            this.txtCodLoteria.Name = "txtCodLoteria";
            this.txtCodLoteria.Size = new System.Drawing.Size(62, 20);
            this.txtCodLoteria.TabIndex = 12;
            // 
            // btnBuscarLoteria
            // 
            this.btnBuscarLoteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLoteria.Location = new System.Drawing.Point(506, 75);
            this.btnBuscarLoteria.Name = "btnBuscarLoteria";
            this.btnBuscarLoteria.Size = new System.Drawing.Size(75, 28);
            this.btnBuscarLoteria.TabIndex = 13;
            this.btnBuscarLoteria.Text = "Buscar";
            this.btnBuscarLoteria.UseVisualStyleBackColor = true;
            this.btnBuscarLoteria.Click += new System.EventHandler(this.btnBuscarLoteria_Click);
            // 
            // txtLoteria
            // 
            this.txtLoteria.Enabled = false;
            this.txtLoteria.Location = new System.Drawing.Point(397, 107);
            this.txtLoteria.Name = "txtLoteria";
            this.txtLoteria.Size = new System.Drawing.Size(184, 20);
            this.txtLoteria.TabIndex = 15;
            // 
            // lblLoteria
            // 
            this.lblLoteria.AutoSize = true;
            this.lblLoteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteria.Location = new System.Drawing.Point(301, 105);
            this.lblLoteria.Name = "lblLoteria";
            this.lblLoteria.Size = new System.Drawing.Size(70, 22);
            this.lblLoteria.TabIndex = 14;
            this.lblLoteria.Text = "Loteria:";
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVendedor.Location = new System.Drawing.Point(301, 168);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(155, 22);
            this.lblCodigoVendedor.TabIndex = 16;
            this.lblCodigoVendedor.Text = "Codigo Vendedor:";
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(453, 170);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.Size = new System.Drawing.Size(48, 20);
            this.txtCodVendedor.TabIndex = 17;
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVendedor.Location = new System.Drawing.Point(507, 160);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarVendedor.TabIndex = 18;
            this.btnBuscarVendedor.Text = "Buscar";
            this.btnBuscarVendedor.UseVisualStyleBackColor = true;
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            // 
            // txtNombreV
            // 
            this.txtNombreV.Enabled = false;
            this.txtNombreV.Location = new System.Drawing.Point(406, 198);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(176, 20);
            this.txtNombreV.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre:";
            // 
            // grillaRifa
            // 
            this.grillaRifa.AllowUserToAddRows = false;
            this.grillaRifa.AllowUserToDeleteRows = false;
            this.grillaRifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Dni,
            this.Rifa,
            this.Vendedor,
            this.Loteria});
            this.grillaRifa.Location = new System.Drawing.Point(23, 267);
            this.grillaRifa.Name = "grillaRifa";
            this.grillaRifa.ReadOnly = true;
            this.grillaRifa.Size = new System.Drawing.Size(559, 124);
            this.grillaRifa.TabIndex = 21;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Rifa
            // 
            this.Rifa.DataPropertyName = "NumeroRifa";
            this.Rifa.HeaderText = "Rifa";
            this.Rifa.Name = "Rifa";
            this.Rifa.ReadOnly = true;
            // 
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "CodigoVendedor";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // Loteria
            // 
            this.Loteria.DataPropertyName = "CodLoteria";
            this.Loteria.HeaderText = "Loteria";
            this.Loteria.Name = "Loteria";
            this.Loteria.ReadOnly = true;
            // 
            // btnFinaliarRifa
            // 
            this.btnFinaliarRifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinaliarRifa.Location = new System.Drawing.Point(236, 397);
            this.btnFinaliarRifa.Name = "btnFinaliarRifa";
            this.btnFinaliarRifa.Size = new System.Drawing.Size(139, 38);
            this.btnFinaliarRifa.TabIndex = 22;
            this.btnFinaliarRifa.Text = "Finalizar Alta";
            this.btnFinaliarRifa.UseVisualStyleBackColor = true;
            this.btnFinaliarRifa.Click += new System.EventHandler(this.btnFinaliarRifa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 44);
            this.label4.TabIndex = 24;
            this.label4.Text = "Numero\r\nRifa:";
            // 
            // txtNroRifa
            // 
            this.txtNroRifa.Location = new System.Drawing.Point(101, 200);
            this.txtNroRifa.Name = "txtNroRifa";
            this.txtNroRifa.Size = new System.Drawing.Size(43, 20);
            this.txtNroRifa.TabIndex = 25;
            // 
            // txtAgergarRifa
            // 
            this.txtAgergarRifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgergarRifa.Location = new System.Drawing.Point(174, 198);
            this.txtAgergarRifa.Name = "txtAgergarRifa";
            this.txtAgergarRifa.Size = new System.Drawing.Size(84, 31);
            this.txtAgergarRifa.TabIndex = 26;
            this.txtAgergarRifa.Text = "Agregar Rifa";
            this.txtAgergarRifa.UseVisualStyleBackColor = true;
            this.txtAgergarRifa.Click += new System.EventHandler(this.txtAgergarRifa_Click);
            // 
            // lblIdRifa
            // 
            this.lblIdRifa.AutoSize = true;
            this.lblIdRifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRifa.Location = new System.Drawing.Point(183, 168);
            this.lblIdRifa.Name = "lblIdRifa";
            this.lblIdRifa.Size = new System.Drawing.Size(29, 22);
            this.lblIdRifa.TabIndex = 27;
            this.lblIdRifa.Text = "Id:";
            // 
            // txtIdRifa
            // 
            this.txtIdRifa.Enabled = false;
            this.txtIdRifa.Location = new System.Drawing.Point(218, 168);
            this.txtIdRifa.Name = "txtIdRifa";
            this.txtIdRifa.Size = new System.Drawing.Size(39, 20);
            this.txtIdRifa.TabIndex = 28;
            // 
            // NuevaRifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 439);
            this.Controls.Add(this.txtIdRifa);
            this.Controls.Add(this.lblIdRifa);
            this.Controls.Add(this.txtAgergarRifa);
            this.Controls.Add(this.txtNroRifa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinaliarRifa);
            this.Controls.Add(this.grillaRifa);
            this.Controls.Add(this.txtNombreV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarVendedor);
            this.Controls.Add(this.txtCodVendedor);
            this.Controls.Add(this.lblCodigoVendedor);
            this.Controls.Add(this.txtLoteria);
            this.Controls.Add(this.lblLoteria);
            this.Controls.Add(this.btnBuscarLoteria);
            this.Controls.Add(this.txtCodLoteria);
            this.Controls.Add(this.lblCodLoteria);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblRifa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaRifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rifa";
            this.Load += new System.EventHandler(this.NuevaRifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaRifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRifa;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCodLoteria;
        private System.Windows.Forms.TextBox txtCodLoteria;
        private System.Windows.Forms.Button btnBuscarLoteria;
        private System.Windows.Forms.TextBox txtLoteria;
        private System.Windows.Forms.Label lblLoteria;
        private System.Windows.Forms.Label lblCodigoVendedor;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grillaRifa;
        private System.Windows.Forms.Button btnFinaliarRifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroRifa;
        private System.Windows.Forms.Button txtAgergarRifa;
        private System.Windows.Forms.Label lblIdRifa;
        private System.Windows.Forms.TextBox txtIdRifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loteria;
    }
}