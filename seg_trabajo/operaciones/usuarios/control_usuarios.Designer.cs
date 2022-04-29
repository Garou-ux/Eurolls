namespace seg_trabajo.operaciones.usuarios
{
    partial class control_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control_usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txteml = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpwd2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbsi = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbusu1 = new System.Windows.Forms.RadioButton();
            this.rbusu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nombre";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(122, 22);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(176, 20);
            this.txtnom.TabIndex = 0;
            this.txtnom.Leave += new System.EventHandler(this.txtnom_Leave);
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(122, 64);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(176, 20);
            this.txtusu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Usuario";
            // 
            // txteml
            // 
            this.txteml.Location = new System.Drawing.Point(122, 103);
            this.txteml.Name = "txteml";
            this.txteml.Size = new System.Drawing.Size(176, 20);
            this.txteml.TabIndex = 3;
            this.txteml.Leave += new System.EventHandler(this.txteml_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Iniciales";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(119, 192);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(99, 20);
            this.txtpwd.TabIndex = 4;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Contraseña";
            // 
            // txtpwd2
            // 
            this.txtpwd2.Location = new System.Drawing.Point(119, 230);
            this.txtpwd2.Name = "txtpwd2";
            this.txtpwd2.Size = new System.Drawing.Size(99, 20);
            this.txtpwd2.TabIndex = 5;
            this.txtpwd2.UseSystemPasswordChar = true;
            this.txtpwd2.Leave += new System.EventHandler(this.txtpwd2_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Confirme contraseña";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 269);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(103, 269);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(203, 269);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Para consultar usuario escriba el nombre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(224, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 96;
            this.checkBox1.Text = "Ocultar/Mostrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(224, 229);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 17);
            this.checkBox2.TabIndex = 97;
            this.checkBox2.Text = "Ocultar/Mostrar";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbno);
            this.groupBox1.Controls.Add(this.rbsi);
            this.groupBox1.Location = new System.Drawing.Point(155, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 38);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver clientes";
            // 
            // rbsi
            // 
            this.rbsi.AutoSize = true;
            this.rbsi.Location = new System.Drawing.Point(6, 15);
            this.rbsi.Name = "rbsi";
            this.rbsi.Size = new System.Drawing.Size(34, 17);
            this.rbsi.TabIndex = 99;
            this.rbsi.Text = "Si";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Checked = true;
            this.rbno.Location = new System.Drawing.Point(65, 15);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(39, 17);
            this.rbno.TabIndex = 100;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbusu1);
            this.groupBox2.Controls.Add(this.rbusu);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 38);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver usuarios";
            // 
            // rbusu1
            // 
            this.rbusu1.AutoSize = true;
            this.rbusu1.Checked = true;
            this.rbusu1.Location = new System.Drawing.Point(65, 15);
            this.rbusu1.Name = "rbusu1";
            this.rbusu1.Size = new System.Drawing.Size(39, 17);
            this.rbusu1.TabIndex = 100;
            this.rbusu1.TabStop = true;
            this.rbusu1.Text = "No";
            this.rbusu1.UseVisualStyleBackColor = true;
            // 
            // rbusu
            // 
            this.rbusu.AutoSize = true;
            this.rbusu.Location = new System.Drawing.Point(6, 15);
            this.rbusu.Name = "rbusu";
            this.rbusu.Size = new System.Drawing.Size(34, 17);
            this.rbusu.TabIndex = 99;
            this.rbusu.Text = "Si";
            this.rbusu.UseVisualStyleBackColor = true;
            // 
            // control_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtpwd2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txteml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "control_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control_usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txteml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpwd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbsi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbusu1;
        private System.Windows.Forms.RadioButton rbusu;
    }
}