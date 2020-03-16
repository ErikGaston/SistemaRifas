namespace WindowsFormsApplication1
{
    partial class ReporteDeGanadores
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
            this.DataSetGanadores = new WindowsFormsApplication1.DataSetGanadores();
            this.GanadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GanadoresTableAdapter = new WindowsFormsApplication1.DataSetGanadoresTableAdapters.GanadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GanadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GanadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.ReporteGanadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetGanadores
            // 
            this.DataSetGanadores.DataSetName = "DataSetGanadores";
            this.DataSetGanadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GanadoresBindingSource
            // 
            this.GanadoresBindingSource.DataMember = "Ganadores";
            this.GanadoresBindingSource.DataSource = this.DataSetGanadores;
            // 
            // GanadoresTableAdapter
            // 
            this.GanadoresTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDeGanadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDeGanadores";
            this.Text = "ReporteDeGanadores";
            this.Load += new System.EventHandler(this.ReporteDeGanadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GanadoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GanadoresBindingSource;
        private DataSetGanadores DataSetGanadores;
        private DataSetGanadoresTableAdapters.GanadoresTableAdapter GanadoresTableAdapter;
    }
}