namespace WindowsFormsApplication1
{
    partial class ReporteVend
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
            this.VendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteVendedores = new WindowsFormsApplication1.ReporteVendedores();
            this.VendedoresTableAdapter = new WindowsFormsApplication1.ReporteVendedoresTableAdapters.VendedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VendedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.ReporteVendedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VendedoresBindingSource
            // 
            this.VendedoresBindingSource.DataMember = "Vendedores";
            this.VendedoresBindingSource.DataSource = this.ReporteVendedores;
            // 
            // ReporteVendedores
            // 
            this.ReporteVendedores.DataSetName = "ReporteVendedores";
            this.ReporteVendedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VendedoresTableAdapter
            // 
            this.VendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVend";
            this.Load += new System.EventHandler(this.ReporteVend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendedoresBindingSource;
        private ReporteVendedores ReporteVendedores;
        private ReporteVendedoresTableAdapters.VendedoresTableAdapter VendedoresTableAdapter;
    }
}