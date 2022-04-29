namespace seg_trabajo.reportes
{
    partial class rep_historico
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
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbpza = new System.Windows.Forms.RadioButton();
            this.rbord = new System.Windows.Forms.RadioButton();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.feci = new System.Windows.Forms.DateTimePicker();
            this.fecf = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownHeight = 200;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.IntegralHeight = false;
            this.comboClientes.Location = new System.Drawing.Point(56, 35);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(168, 21);
            this.comboClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbpza);
            this.groupBox1.Controls.Add(this.rbord);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el tipo de filtro";
            // 
            // rbpza
            // 
            this.rbpza.AutoSize = true;
            this.rbpza.Location = new System.Drawing.Point(144, 24);
            this.rbpza.Name = "rbpza";
            this.rbpza.Size = new System.Drawing.Size(105, 17);
            this.rbpza.TabIndex = 4;
            this.rbpza.TabStop = true;
            this.rbpza.Text = "Por Ord. y piezas";
            this.rbpza.UseVisualStyleBackColor = true;
            // 
            // rbord
            // 
            this.rbord.AutoSize = true;
            this.rbord.Checked = true;
            this.rbord.Location = new System.Drawing.Point(6, 24);
            this.rbord.Name = "rbord";
            this.rbord.Size = new System.Drawing.Size(121, 17);
            this.rbord.TabIndex = 3;
            this.rbord.TabStop = true;
            this.rbord.Text = "Por orden de trabajo";
            this.rbord.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(109, 115);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(115, 21);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // feci
            // 
            this.feci.CustomFormat = "yyy/MM/dd";
            this.feci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.feci.Location = new System.Drawing.Point(59, 9);
            this.feci.Name = "feci";
            this.feci.Size = new System.Drawing.Size(99, 20);
            this.feci.TabIndex = 5;
            // 
            // fecf
            // 
            this.fecf.CustomFormat = "yyy/MM/dd";
            this.fecf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecf.Location = new System.Drawing.Point(226, 9);
            this.fecf.Name = "fecf";
            this.fecf.Size = new System.Drawing.Size(99, 20);
            this.fecf.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // rep_historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 143);
            this.Controls.Add(this.fecf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboClientes);
            this.MaximizeBox = false;
            this.Name = "rep_historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbpza;
        private System.Windows.Forms.RadioButton rbord;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker feci;
        private System.Windows.Forms.DateTimePicker fecf;
        private System.Windows.Forms.Label label3;
    }
}