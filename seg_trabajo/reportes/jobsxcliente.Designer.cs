namespace seg_trabajo.reportes
{
    partial class jobsxcliente
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
            this.feci = new System.Windows.Forms.DateTimePicker();
            this.fecf = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboclis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnimp = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feci
            // 
            this.feci.CustomFormat = "yyyy/MM/dd";
            this.feci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.feci.Location = new System.Drawing.Point(12, 34);
            this.feci.Name = "feci";
            this.feci.Size = new System.Drawing.Size(113, 20);
            this.feci.TabIndex = 0;
            // 
            // fecf
            // 
            this.fecf.CustomFormat = "yyyy/MM/dd";
            this.fecf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecf.Location = new System.Drawing.Point(182, 34);
            this.fecf.Name = "fecf";
            this.fecf.Size = new System.Drawing.Size(113, 20);
            this.fecf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // comboclis
            // 
            this.comboclis.FormattingEnabled = true;
            this.comboclis.Location = new System.Drawing.Point(12, 83);
            this.comboclis.Name = "comboclis";
            this.comboclis.Size = new System.Drawing.Size(121, 21);
            this.comboclis.TabIndex = 4;
            this.comboclis.SelectionChangeCommitted += new System.EventHandler(this.comboclis_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // btnimp
            // 
            this.btnimp.Location = new System.Drawing.Point(50, 125);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(75, 23);
            this.btnimp.TabIndex = 6;
            this.btnimp.Text = "Imprimir";
            this.btnimp.UseVisualStyleBackColor = true;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(210, 125);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // jobsxcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(362, 177);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboclis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecf);
            this.Controls.Add(this.feci);
            this.MaximizeBox = false;
            this.Name = "jobsxcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Consultar";
            this.Load += new System.EventHandler(this.jobsxcliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker feci;
        private System.Windows.Forms.DateTimePicker fecf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboclis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.Button btnsalir;
    }
}