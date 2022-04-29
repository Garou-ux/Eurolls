namespace seg_trabajo.reportes.dimensionado
{
    partial class impdimen
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
            this.dataSetdimen = new seg_trabajo.datasets.DataSetdimen();
            this.dimensionadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dimensionadoTableAdapter = new seg_trabajo.datasets.DataSetdimenTableAdapters.DimensionadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdimen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dimensionadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "seg_trabajo.reportes.dimensionado.Reportdimen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(732, 298);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetdimen
            // 
            this.dataSetdimen.DataSetName = "DataSetdimen";
            this.dataSetdimen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dimensionadoBindingSource
            // 
            this.dimensionadoBindingSource.DataMember = "Dimensionado";
            this.dimensionadoBindingSource.DataSource = this.dataSetdimen;
            // 
            // dimensionadoTableAdapter
            // 
            this.dimensionadoTableAdapter.ClearBeforeFill = true;
            // 
            // impdimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 298);
            this.Controls.Add(this.reportViewer1);
            this.Name = "impdimen";
            this.Text = "Reporte dimensional";
            this.Load += new System.EventHandler(this.impdimen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdimen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dimensionadoBindingSource;
        private datasets.DataSetdimen dataSetdimen;
        private datasets.DataSetdimenTableAdapters.DimensionadoTableAdapter dimensionadoTableAdapter;
    }
}