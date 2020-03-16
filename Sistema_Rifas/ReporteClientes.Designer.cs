namespace WindowsFormsApplication1
{
    partial class ReporteClientes
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
            this.PersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClientes = new WindowsFormsApplication1.DataSetClientes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonasTableAdapter = new WindowsFormsApplication1.DataSetClientesTableAdapters.PersonasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonasBindingSource
            // 
            this.PersonasBindingSource.DataMember = "Personas";
            this.PersonasBindingSource.DataSource = this.DataSetClientes;
            // 
            // DataSetClientes
            // 
            this.DataSetClientes.DataSetName = "DataSetClientes";
            this.DataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClientes";
            reportDataSource1.Value = this.PersonasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonasTableAdapter
            // 
            this.PersonasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteClientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonasBindingSource;
        private DataSetClientes DataSetClientes;
        private DataSetClientesTableAdapters.PersonasTableAdapter PersonasTableAdapter;
    }
}