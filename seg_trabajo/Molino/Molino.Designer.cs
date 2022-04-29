
namespace seg_trabajo.Molino
{
    partial class Molino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Molino));
            this.GridRodillos = new System.Windows.Forms.DataGridView();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txMolino = new System.Windows.Forms.TextBox();
            this.txJOB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txRodillos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txClienteNombre = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataSetCategorias = new seg_trabajo.Molino.DataSetCategorias();
            this.tblCategoriaRodillosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoriaRodillosTableAdapter = new seg_trabajo.Molino.DataSetCategoriasTableAdapters.TblCategoriaRodillosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridRodillos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriaRodillosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridRodillos
            // 
            this.GridRodillos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridRodillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRodillos.Location = new System.Drawing.Point(1, 89);
            this.GridRodillos.Name = "GridRodillos";
            this.GridRodillos.Size = new System.Drawing.Size(1058, 343);
            this.GridRodillos.TabIndex = 0;
            this.GridRodillos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRodillos_CellEndEdit);
            this.GridRodillos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GridRodillos_EditingControlShowing);
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownWidth = 250;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(53, 12);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(131, 21);
            this.comboClientes.TabIndex = 1;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Molino";
            // 
            // txMolino
            // 
            this.txMolino.Location = new System.Drawing.Point(53, 50);
            this.txMolino.MaxLength = 25;
            this.txMolino.Name = "txMolino";
            this.txMolino.Size = new System.Drawing.Size(131, 20);
            this.txMolino.TabIndex = 4;
            // 
            // txJOB
            // 
            this.txJOB.Location = new System.Drawing.Point(262, 50);
            this.txJOB.MaxLength = 20;
            this.txJOB.Name = "txJOB";
            this.txJOB.Size = new System.Drawing.Size(131, 20);
            this.txJOB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "JOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // txRodillos
            // 
            this.txRodillos.Enabled = false;
            this.txRodillos.Location = new System.Drawing.Point(731, 50);
            this.txRodillos.Name = "txRodillos";
            this.txRodillos.Size = new System.Drawing.Size(68, 20);
            this.txRodillos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad de Rodillos";
            // 
            // txClienteNombre
            // 
            this.txClienteNombre.Enabled = false;
            this.txClienteNombre.Location = new System.Drawing.Point(208, 12);
            this.txClienteNombre.Name = "txClienteNombre";
            this.txClienteNombre.ReadOnly = true;
            this.txClienteNombre.Size = new System.Drawing.Size(382, 20);
            this.txClienteNombre.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Fig1.PNG");
            this.imageList1.Images.SetKeyName(1, "Fig2.PNG");
            this.imageList1.Images.SetKeyName(2, "Fig3.PNG");
            this.imageList1.Images.SetKeyName(3, "Fig4.PNG");
            this.imageList1.Images.SetKeyName(4, "Fig5.PNG");
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(926, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Visible = false;
            this.comboBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox2_DrawItem);
            this.comboBox2.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox2_MeasureItem);
            // 
            // dataSetCategorias
            // 
            this.dataSetCategorias.DataSetName = "DataSetCategorias";
            this.dataSetCategorias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCategoriaRodillosBindingSource
            // 
            this.tblCategoriaRodillosBindingSource.DataMember = "TblCategoriaRodillos";
            this.tblCategoriaRodillosBindingSource.DataSource = this.dataSetCategorias;
            // 
            // tblCategoriaRodillosTableAdapter
            // 
            this.tblCategoriaRodillosTableAdapter.ClearBeforeFill = true;
            // 
            // Molino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 432);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txClienteNombre);
            this.Controls.Add(this.txRodillos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txJOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txMolino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.GridRodillos);
            this.Name = "Molino";
            this.Text = "Molino";
            this.Load += new System.EventHandler(this.Molino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridRodillos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriaRodillosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridRodillos;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txMolino;
        private System.Windows.Forms.TextBox txJOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txRodillos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txClienteNombre;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox2;
        private DataSetCategorias dataSetCategorias;
        private System.Windows.Forms.BindingSource tblCategoriaRodillosBindingSource;
        private DataSetCategoriasTableAdapters.TblCategoriaRodillosTableAdapter tblCategoriaRodillosTableAdapter;
    }
}