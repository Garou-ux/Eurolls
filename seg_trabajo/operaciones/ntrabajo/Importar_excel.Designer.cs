namespace seg_trabajo.operaciones.ntrabajo
{
    partial class Importar_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importar_excel));
            this.dgExcel = new System.Windows.Forms.DataGridView();
            this.btnimpor = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgExcel
            // 
            this.dgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcel.Location = new System.Drawing.Point(12, 12);
            this.dgExcel.Name = "dgExcel";
            this.dgExcel.Size = new System.Drawing.Size(1100, 318);
            this.dgExcel.TabIndex = 0;
            // 
            // btnimpor
            // 
            this.btnimpor.Location = new System.Drawing.Point(849, 335);
            this.btnimpor.Name = "btnimpor";
            this.btnimpor.Size = new System.Drawing.Size(75, 23);
            this.btnimpor.TabIndex = 1;
            this.btnimpor.Text = "Importar";
            this.btnimpor.UseVisualStyleBackColor = true;
            this.btnimpor.Click += new System.EventHandler(this.btnimpor_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(1037, 335);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(941, 335);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Importar_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1116, 370);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnimpor);
            this.Controls.Add(this.dgExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Importar_excel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar_excel";
            this.Load += new System.EventHandler(this.Importar_excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgExcel;
        private System.Windows.Forms.Button btnimpor;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnguardar;
    }
}