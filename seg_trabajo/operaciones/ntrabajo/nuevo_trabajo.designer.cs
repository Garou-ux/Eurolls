
namespace seg_trabajo.operaciones.ntrabajo
{
    partial class nuevo_trabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevo_trabajo));
            this.txtfol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combocli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomcli = new System.Windows.Forms.TextBox();
            this.gridjob = new System.Windows.Forms.DataGridView();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espcorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.fec = new System.Windows.Forms.DateTimePicker();
            this.Fecha = new System.Windows.Forms.Label();
            this.btnimportar = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridjob)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfol
            // 
            this.txtfol.Location = new System.Drawing.Point(10, 26);
            this.txtfol.MaxLength = 50;
            this.txtfol.Name = "txtfol";
            this.txtfol.Size = new System.Drawing.Size(87, 20);
            this.txtfol.TabIndex = 0;
            this.txtfol.Leave += new System.EventHandler(this.txtfol_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de orden";
            // 
            // combocli
            // 
            this.combocli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocli.DropDownWidth = 250;
            this.combocli.FormattingEnabled = true;
            this.combocli.Location = new System.Drawing.Point(249, 26);
            this.combocli.Name = "combocli";
            this.combocli.Size = new System.Drawing.Size(89, 21);
            this.combocli.TabIndex = 1;
            this.combocli.SelectionChangeCommitted += new System.EventHandler(this.combocli_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(342, 26);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.ReadOnly = true;
            this.txtnomcli.Size = new System.Drawing.Size(325, 20);
            this.txtnomcli.TabIndex = 2;
            // 
            // gridjob
            // 
            this.gridjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridjob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.job,
            this.pos,
            this.med,
            this.esp,
            this.diam,
            this.espcorte,
            this.ac});
            this.gridjob.Location = new System.Drawing.Point(673, 29);
            this.gridjob.Name = "gridjob";
            this.gridjob.RowTemplate.Height = 25;
            this.gridjob.Size = new System.Drawing.Size(39, 17);
            this.gridjob.TabIndex = 3;
            this.gridjob.Visible = false;
            this.gridjob.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridjob_CellEndEdit);
            this.gridjob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridjob_KeyPress);
            // 
            // job
            // 
            this.job.HeaderText = "#JOB";
            this.job.Name = "job";
            this.job.Width = 140;
            // 
            // pos
            // 
            this.pos.HeaderText = "Posición";
            this.pos.Name = "pos";
            // 
            // med
            // 
            this.med.HeaderText = "Medida";
            this.med.Name = "med";
            // 
            // esp
            // 
            this.esp.HeaderText = "Espesor";
            this.esp.Name = "esp";
            // 
            // diam
            // 
            this.diam.HeaderText = "Diametro exterior(mm)";
            this.diam.Name = "diam";
            // 
            // espcorte
            // 
            this.espcorte.HeaderText = "Espesor corte";
            this.espcorte.Name = "espcorte";
            // 
            // ac
            // 
            this.ac.HeaderText = "Acero";
            this.ac.Name = "ac";
            this.ac.Width = 85;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(10, 83);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(72, 20);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnimp
            // 
            this.btnimp.Location = new System.Drawing.Point(276, 83);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(72, 20);
            this.btnimp.TabIndex = 5;
            this.btnimp.Text = "Imprimir";
            this.btnimp.UseVisualStyleBackColor = true;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // fec
            // 
            this.fec.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.fec.Enabled = false;
            this.fec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fec.Location = new System.Drawing.Point(102, 26);
            this.fec.Name = "fec";
            this.fec.Size = new System.Drawing.Size(133, 20);
            this.fec.TabIndex = 7;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(102, 8);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(65, 13);
            this.Fecha.TabIndex = 8;
            this.Fecha.Text = "Fecha/Hora";
            // 
            // btnimportar
            // 
            this.btnimportar.Enabled = false;
            this.btnimportar.Location = new System.Drawing.Point(95, 83);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(72, 20);
            this.btnimportar.TabIndex = 9;
            this.btnimportar.Text = "Importar";
            this.btnimportar.UseVisualStyleBackColor = true;
            this.btnimportar.Click += new System.EventHandler(this.btnimportar_Click);
            // 
            // btnmodi
            // 
            this.btnmodi.Location = new System.Drawing.Point(185, 83);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(75, 20);
            this.btnmodi.TabIndex = 10;
            this.btnmodi.Text = "Eliminar";
            this.btnmodi.UseVisualStyleBackColor = true;
            this.btnmodi.Visible = false;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // nuevo_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 117);
            this.Controls.Add(this.btnmodi);
            this.Controls.Add(this.btnimportar);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.fec);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.gridjob);
            this.Controls.Add(this.combocli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomcli);
            this.Controls.Add(this.txtfol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "nuevo_trabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nuevo_trabajo";
            this.Load += new System.EventHandler(this.nuevo_trabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridjob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combocli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomcli;
        private System.Windows.Forms.DataGridView gridjob;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn med;
        private System.Windows.Forms.DataGridViewTextBoxColumn esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn diam;
        private System.Windows.Forms.DataGridViewTextBoxColumn espcorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac;
        private System.Windows.Forms.DateTimePicker fec;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Button btnimportar;
        private System.Windows.Forms.Button btnmodi;
    }
}