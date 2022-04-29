namespace seg_trabajo.reportes
{
    partial class imp_hist
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
            this.dataSetclijobs = new seg_trabajo.datasets.DataSetclijobs();
            this.reportehistpzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_hist_pzasTableAdapter = new seg_trabajo.datasets.DataSetclijobsTableAdapters.Reporte_hist_pzasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetclijobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportehistpzasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportehistpzasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "seg_trabajo.reportes.Report_hist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(628, 298);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetclijobs
            // 
            this.dataSetclijobs.DataSetName = "DataSetclijobs";
            this.dataSetclijobs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportehistpzasBindingSource
            // 
            this.reportehistpzasBindingSource.DataMember = "Reporte_hist_pzas";
            this.reportehistpzasBindingSource.DataSource = this.dataSetclijobs;
            // 
            // reporte_hist_pzasTableAdapter
            // 
            this.reporte_hist_pzasTableAdapter.ClearBeforeFill = true;
            // 
            // imp_hist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 298);
            this.Controls.Add(this.reportViewer1);
            this.Name = "imp_hist";
            this.Text = "imp_hist";
            this.Load += new System.EventHandler(this.imp_hist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetclijobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportehistpzasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportehistpzasBindingSource;
        private datasets.DataSetclijobs dataSetclijobs;
        private datasets.DataSetclijobsTableAdapters.Reporte_hist_pzasTableAdapter reporte_hist_pzasTableAdapter;
    }
}