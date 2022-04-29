
namespace seg_trabajo.operaciones.ntrabajo
{
    partial class impn_trabajo
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
            this.dataSetorden = new seg_trabajo.datasets.DataSetorden();
            this.reporteordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteordenTableAdapter = new seg_trabajo.datasets.DataSetordenTableAdapters.ReporteordenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteordenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteordenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "seg_trabajo.reportes.Reportorden.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(547, 196);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetorden
            // 
            this.dataSetorden.DataSetName = "DataSetorden";
            this.dataSetorden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteordenBindingSource
            // 
            this.reporteordenBindingSource.DataMember = "Reporteorden";
            this.reporteordenBindingSource.DataSource = this.dataSetorden;
            // 
            // reporteordenTableAdapter
            // 
            this.reporteordenTableAdapter.ClearBeforeFill = true;
            // 
            // impn_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 196);
            this.Controls.Add(this.reportViewer1);
            this.Name = "impn_trabajo";
            this.Text = "impn_trabajo";
            this.Load += new System.EventHandler(this.impn_trabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteordenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteordenBindingSource;
        private datasets.DataSetorden dataSetorden;
        private datasets.DataSetordenTableAdapters.ReporteordenTableAdapter reporteordenTableAdapter;
    }
}