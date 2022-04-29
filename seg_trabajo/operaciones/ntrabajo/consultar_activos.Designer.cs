namespace seg_trabajo.operaciones.ntrabajo
{
    partial class consultar_activos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultar_activos));
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.rbcompletado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsulta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.gridConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConsulta.BackgroundColor = System.Drawing.Color.Silver;
            this.gridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridConsulta.GridColor = System.Drawing.Color.LightGray;
            this.gridConsulta.Location = new System.Drawing.Point(2, 38);
            this.gridConsulta.Name = "gridConsulta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridConsulta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridConsulta.Size = new System.Drawing.Size(333, 443);
            this.gridConsulta.TabIndex = 1;
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Location = new System.Drawing.Point(29, 12);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(60, 17);
            this.rbactivo.TabIndex = 2;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activas";
            this.rbactivo.UseVisualStyleBackColor = true;
            this.rbactivo.CheckedChanged += new System.EventHandler(this.rbactivo_CheckedChanged);
            // 
            // rbcompletado
            // 
            this.rbcompletado.AutoSize = true;
            this.rbcompletado.Location = new System.Drawing.Point(152, 12);
            this.rbcompletado.Name = "rbcompletado";
            this.rbcompletado.Size = new System.Drawing.Size(86, 17);
            this.rbcompletado.TabIndex = 3;
            this.rbcompletado.TabStop = true;
            this.rbcompletado.Text = "Completadas";
            this.rbcompletado.UseVisualStyleBackColor = true;
            this.rbcompletado.CheckedChanged += new System.EventHandler(this.rbcompletado_CheckedChanged);
            // 
            // consultar_activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 480);
            this.Controls.Add(this.rbcompletado);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.gridConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultar_activos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar ordenes activas";
            this.Load += new System.EventHandler(this.consultar_activos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConsulta;
        private System.Windows.Forms.RadioButton rbactivo;
        private System.Windows.Forms.RadioButton rbcompletado;
    }
}