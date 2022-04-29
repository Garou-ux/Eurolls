namespace seg_trabajo.operaciones.Control_salidas
{
    partial class imp_control
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportecontrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetControl = new seg_trabajo.operaciones.Control_salidas.DataSetControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_controlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_controlTableAdapter = new seg_trabajo.operaciones.Control_salidas.DataSetControlTableAdapters.Reporte_controlTableAdapter();
            this.dataSetpzas = new seg_trabajo.operaciones.Control_salidas.DataSetpzas();
            this.reptotalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rep_totalesTableAdapter = new seg_trabajo.operaciones.Control_salidas.DataSetpzasTableAdapters.Rep_totalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportecontrolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_controlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetpzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptotalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportecontrolBindingSource
            // 
            this.reportecontrolBindingSource.DataMember = "Reporte_control";
            this.reportecontrolBindingSource.DataSource = this.DataSetControl;
            // 
            // DataSetControl
            // 
            this.DataSetControl.DataSetName = "DataSetControl";
            this.DataSetControl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportecontrolBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.reptotalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "seg_trabajo.operaciones.Control_salidas.Report_control.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 270);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_controlBindingSource
            // 
            this.Reporte_controlBindingSource.DataMember = "Reporte_control";
            this.Reporte_controlBindingSource.DataSource = this.DataSetControl;
            // 
            // Reporte_controlTableAdapter
            // 
            this.Reporte_controlTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetpzas
            // 
            this.dataSetpzas.DataSetName = "DataSetpzas";
            this.dataSetpzas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reptotalesBindingSource
            // 
            this.reptotalesBindingSource.DataMember = "Rep_totales";
            this.reptotalesBindingSource.DataSource = this.dataSetpzas;
            // 
            // rep_totalesTableAdapter
            // 
            this.rep_totalesTableAdapter.ClearBeforeFill = true;
            // 
            // imp_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 270);
            this.Controls.Add(this.reportViewer1);
            this.Name = "imp_control";
            this.Text = "imp_control";
            this.Load += new System.EventHandler(this.imp_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportecontrolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_controlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetpzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptotalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_controlBindingSource;
        private DataSetControl DataSetControl;
        private DataSetControlTableAdapters.Reporte_controlTableAdapter Reporte_controlTableAdapter;
        private System.Windows.Forms.BindingSource reportecontrolBindingSource;
        private System.Windows.Forms.BindingSource reptotalesBindingSource;
        private DataSetpzas dataSetpzas;
        private DataSetpzasTableAdapters.Rep_totalesTableAdapter rep_totalesTableAdapter;
    }
}