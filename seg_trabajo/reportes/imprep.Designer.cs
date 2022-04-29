namespace seg_trabajo.reportes
{
    partial class imprep
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
            this.reporteclijobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteclijobsTableAdapter = new seg_trabajo.datasets.DataSetclijobsTableAdapters.ReporteclijobsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetclijobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteclijobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteclijobsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "seg_trabajo.reportes.Reportclijobs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(642, 284);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetclijobs
            // 
            this.dataSetclijobs.DataSetName = "DataSetclijobs";
            this.dataSetclijobs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteclijobsBindingSource
            // 
            this.reporteclijobsBindingSource.DataMember = "Reporteclijobs";
            this.reporteclijobsBindingSource.DataSource = this.dataSetclijobs;
            // 
            // reporteclijobsTableAdapter
            // 
            this.reporteclijobsTableAdapter.ClearBeforeFill = true;
            // 
            // imprep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 284);
            this.Controls.Add(this.reportViewer1);
            this.Name = "imprep";
            this.Text = "imprep";
            this.Load += new System.EventHandler(this.imprep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetclijobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteclijobsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteclijobsBindingSource;
        private datasets.DataSetclijobs dataSetclijobs;
        private datasets.DataSetclijobsTableAdapters.ReporteclijobsTableAdapter reporteclijobsTableAdapter;
    }
}