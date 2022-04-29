namespace seg_trabajo.ayuda
{
    partial class respaldo_de_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(respaldo_de_DB));
            this.btn_respaldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_respaldo
            // 
            this.btn_respaldo.Location = new System.Drawing.Point(52, 31);
            this.btn_respaldo.Name = "btn_respaldo";
            this.btn_respaldo.Size = new System.Drawing.Size(113, 43);
            this.btn_respaldo.TabIndex = 0;
            this.btn_respaldo.Text = "Ejecutar";
            this.btn_respaldo.UseVisualStyleBackColor = true;
            this.btn_respaldo.Click += new System.EventHandler(this.btn_respaldo_Click);
            // 
            // respaldo_de_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 126);
            this.Controls.Add(this.btn_respaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "respaldo_de_DB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldo de Base de Datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_respaldo;
    }
}