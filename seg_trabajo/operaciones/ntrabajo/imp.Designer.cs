namespace seg_trabajo.operaciones.ntrabajo
{
    partial class imp
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
            this.txtfol = new System.Windows.Forms.TextBox();
            this.btniimp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfol
            // 
            this.txtfol.Location = new System.Drawing.Point(21, 37);
            this.txtfol.Name = "txtfol";
            this.txtfol.Size = new System.Drawing.Size(100, 20);
            this.txtfol.TabIndex = 0;
            // 
            // btniimp
            // 
            this.btniimp.Location = new System.Drawing.Point(127, 34);
            this.btniimp.Name = "btniimp";
            this.btniimp.Size = new System.Drawing.Size(112, 23);
            this.btniimp.TabIndex = 1;
            this.btniimp.Text = "Imprimir";
            this.btniimp.UseVisualStyleBackColor = true;
            this.btniimp.Click += new System.EventHandler(this.btniimp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No.Orden";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniimp);
            this.Controls.Add(this.txtfol);
            this.MaximizeBox = false;
            this.Name = "imp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresion de orden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfol;
        private System.Windows.Forms.Button btniimp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}