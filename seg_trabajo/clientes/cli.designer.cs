
namespace seg_trabajo.clientes
{
    partial class cli
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
            this.txtcli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomcli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gridclientes = new System.Windows.Forms.DataGridView();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtciu = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupeclli = new System.Windows.Forms.GroupBox();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbsi = new System.Windows.Forms.RadioButton();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gridclientes)).BeginInit();
            this.groupeclli.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcli
            // 
            this.txtcli.Location = new System.Drawing.Point(10, 155);
            this.txtcli.MaxLength = 10;
            this.txtcli.Name = "txtcli";
            this.txtcli.Size = new System.Drawing.Size(120, 20);
            this.txtcli.TabIndex = 0;
            this.txtcli.Leave += new System.EventHandler(this.txtcli_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id. Cliente(maximo 10 digitos)";
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(165, 154);
            this.txtnomcli.MaxLength = 200;
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.Size = new System.Drawing.Size(295, 20);
            this.txtnomcli.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // Gridclientes
            // 
            this.Gridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridclientes.Location = new System.Drawing.Point(10, 10);
            this.Gridclientes.Name = "Gridclientes";
            this.Gridclientes.RowTemplate.Height = 25;
            this.Gridclientes.Size = new System.Drawing.Size(665, 118);
            this.Gridclientes.TabIndex = 2;
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(10, 198);
            this.txtdir.MaxLength = 200;
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(283, 20);
            this.txtdir.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ciudad";
            // 
            // txtciu
            // 
            this.txtciu.Location = new System.Drawing.Point(297, 198);
            this.txtciu.MaxLength = 100;
            this.txtciu.Name = "txtciu";
            this.txtciu.Size = new System.Drawing.Size(143, 20);
            this.txtciu.TabIndex = 3;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(539, 198);
            this.txtrfc.MaxLength = 20;
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(72, 20);
            this.txtrfc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RFC";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(7, 250);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(167, 20);
            this.txtemail.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Correo electronicio";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(192, 250);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(143, 20);
            this.txtTel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefono";
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(454, 198);
            this.txtcp.MaxLength = 15;
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(70, 20);
            this.txtcp.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Codigo postal";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(13, 305);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(64, 20);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(97, 305);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(94, 20);
            this.btnexcel.TabIndex = 7;
            this.btnexcel.Text = "Exportar a excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupeclli
            // 
            this.groupeclli.Controls.Add(this.rbno);
            this.groupeclli.Controls.Add(this.rbsi);
            this.groupeclli.Location = new System.Drawing.Point(307, 279);
            this.groupeclli.Name = "groupeclli";
            this.groupeclli.Size = new System.Drawing.Size(61, 62);
            this.groupeclli.TabIndex = 9;
            this.groupeclli.TabStop = false;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Location = new System.Drawing.Point(5, 33);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(39, 17);
            this.rbno.TabIndex = 0;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbsi
            // 
            this.rbsi.AutoSize = true;
            this.rbsi.Location = new System.Drawing.Point(5, 11);
            this.rbsi.Name = "rbsi";
            this.rbsi.Size = new System.Drawing.Size(34, 17);
            this.rbsi.TabIndex = 0;
            this.rbsi.TabStop = true;
            this.rbsi.Text = "Si";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(207, 305);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 20);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar cliente";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 354);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupeclli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtciu);
            this.Controls.Add(this.Gridclientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnomcli);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.txtcli);
            this.MaximizeBox = false;
            this.Name = "cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar clientes";
            this.Load += new System.EventHandler(this.cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridclientes)).EndInit();
            this.groupeclli.ResumeLayout(false);
            this.groupeclli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomcli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Gridclientes;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtciu;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupeclli;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbsi;
        private System.Windows.Forms.Button btneliminar;
    }
}