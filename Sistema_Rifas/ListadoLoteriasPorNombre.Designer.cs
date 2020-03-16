namespace WindowsFormsApplication1
{
    partial class ListadoLoteriasPorNombre
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LoteriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteLoteriaXNombre = new WindowsFormsApplication1.ReporteLoteriaXNombre();
            this.LoteriaTableAdapter = new WindowsFormsApplication1.ReporteLoteriaXNombreTableAdapters.LoteriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LoteriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteLoteriaXNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LoteriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.ReporteLoteriasXNombre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // LoteriaBindingSource
            // 
            this.LoteriaBindingSource.DataMember = "Loteria";
            this.LoteriaBindingSource.DataSource = this.ReporteLoteriaXNombre;
            // 
            // ReporteLoteriaXNombre
            // 
            this.ReporteLoteriaXNombre.DataSetName = "ReporteLoteriaXNombre";
            this.ReporteLoteriaXNombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoteriaTableAdapter
            // 
            this.LoteriaTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoLoteriasPorNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoLoteriasPorNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoLoteriasPorNombre";
            this.Load += new System.EventHandler(this.ListadoLoteriasPorNombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoteriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteLoteriaXNombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoteriaBindingSource;
        private ReporteLoteriaXNombre ReporteLoteriaXNombre;
        private ReporteLoteriaXNombreTableAdapters.LoteriaTableAdapter LoteriaTableAdapter;
    }
}