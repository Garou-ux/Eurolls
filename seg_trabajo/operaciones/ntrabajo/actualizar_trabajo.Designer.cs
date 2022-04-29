namespace seg_trabajo.operaciones.ntrabajo
{
    partial class actualizar_trabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualizar_trabajo));
            this.btnimportar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Label();
            this.fec = new System.Windows.Forms.DateTimePicker();
            this.btnimp = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.gridjob = new System.Windows.Forms.DataGridView();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_codigoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_largoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_largof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_diammen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espcorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combocli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomcli = new System.Windows.Forms.TextBox();
            this.txtfol = new System.Windows.Forms.TextBox();
            this.btnelim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridjob)).BeginInit();
            this.SuspendLayout();
            // 
            // btnimportar
            // 
            this.btnimportar.Enabled = false;
            this.btnimportar.Location = new System.Drawing.Point(1124, 372);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(72, 20);
            this.btnimportar.TabIndex = 21;
            this.btnimportar.Text = "Importar";
            this.btnimportar.UseVisualStyleBackColor = true;
            this.btnimportar.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(104, 9);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(65, 13);
            this.Fecha.TabIndex = 20;
            this.Fecha.Text = "Fecha/Hora";
            // 
            // fec
            // 
            this.fec.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.fec.Enabled = false;
            this.fec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fec.Location = new System.Drawing.Point(104, 27);
            this.fec.Name = "fec";
            this.fec.Size = new System.Drawing.Size(133, 20);
            this.fec.TabIndex = 19;
            // 
            // btnimp
            // 
            this.btnimp.Location = new System.Drawing.Point(218, 372);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(72, 20);
            this.btnimp.TabIndex = 17;
            this.btnimp.Text = "Imprimir";
            this.btnimp.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 372);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(72, 20);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Modificar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // gridjob
            // 
            this.gridjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridjob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_item,
            this.col_codigoa,
            this.col_largoi,
            this.col_largof,
            this.pos,
            this.med,
            this.job,
            this.esp,
            this.diam,
            this.col_diammen,
            this.espcorte,
            this.ac,
            this.col_hrc});
            this.gridjob.Location = new System.Drawing.Point(12, 66);
            this.gridjob.Name = "gridjob";
            this.gridjob.RowTemplate.Height = 25;
            this.gridjob.Size = new System.Drawing.Size(1184, 300);
            this.gridjob.TabIndex = 15;
            // 
            // col_item
            // 
            this.col_item.Frozen = true;
            this.col_item.HeaderText = "Item";
            this.col_item.Name = "col_item";
            this.col_item.Visible = false;
            // 
            // col_codigoa
            // 
            this.col_codigoa.Frozen = true;
            this.col_codigoa.HeaderText = "Codigo Acero";
            this.col_codigoa.Name = "col_codigoa";
            // 
            // col_largoi
            // 
            this.col_largoi.Frozen = true;
            this.col_largoi.HeaderText = "Largo Inicial";
            this.col_largoi.Name = "col_largoi";
            // 
            // col_largof
            // 
            this.col_largof.Frozen = true;
            this.col_largof.HeaderText = "Largo final";
            this.col_largof.Name = "col_largof";
            // 
            // pos
            // 
            this.pos.Frozen = true;
            this.pos.HeaderText = "Posición";
            this.pos.Name = "pos";
            // 
            // med
            // 
            this.med.Frozen = true;
            this.med.HeaderText = "Medida";
            this.med.Name = "med";
            // 
            // job
            // 
            this.job.Frozen = true;
            this.job.HeaderText = "#JOB";
            this.job.Name = "job";
            this.job.Width = 140;
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
            // col_diammen
            // 
            this.col_diammen.HeaderText = "Diametro menor";
            this.col_diammen.Name = "col_diammen";
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
            // col_hrc
            // 
            this.col_hrc.HeaderText = "HRC";
            this.col_hrc.Name = "col_hrc";
            // 
            // combocli
            // 
            this.combocli.FormattingEnabled = true;
            this.combocli.Location = new System.Drawing.Point(251, 27);
            this.combocli.Name = "combocli";
            this.combocli.Size = new System.Drawing.Size(89, 21);
            this.combocli.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero de orden";
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(344, 27);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.ReadOnly = true;
            this.txtnomcli.Size = new System.Drawing.Size(325, 20);
            this.txtnomcli.TabIndex = 14;
            // 
            // txtfol
            // 
            this.txtfol.Location = new System.Drawing.Point(12, 27);
            this.txtfol.MaxLength = 50;
            this.txtfol.Name = "txtfol";
            this.txtfol.Size = new System.Drawing.Size(87, 20);
            this.txtfol.TabIndex = 10;
            this.txtfol.Leave += new System.EventHandler(this.txtfol_Leave);
            // 
            // btnelim
            // 
            this.btnelim.Location = new System.Drawing.Point(107, 372);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(75, 20);
            this.btnelim.TabIndex = 22;
            this.btnelim.Text = "Eliminar";
            this.btnelim.UseVisualStyleBackColor = true;
            this.btnelim.Click += new System.EventHandler(this.btnelim_Click);
            // 
            // actualizar_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1220, 398);
            this.Controls.Add(this.btnelim);
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
            this.Name = "actualizar_trabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de orden";
            this.Load += new System.EventHandler(this.actualizar_trabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridjob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimportar;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker fec;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView gridjob;
        private System.Windows.Forms.ComboBox combocli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomcli;
        private System.Windows.Forms.TextBox txtfol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_largoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_largof;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn med;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn diam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_diammen;
        private System.Windows.Forms.DataGridViewTextBoxColumn espcorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hrc;
        private System.Windows.Forms.Button btnelim;
    }
}