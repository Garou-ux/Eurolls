namespace seg_trabajo.operaciones.Control_salidas
{
    partial class control_sal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control_sal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.GridControl = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPrv = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.brnImp = new System.Windows.Forms.Button();
            this.txtPzas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sts_sal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_posi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_acero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Orden";
            // 
            // txtorden
            // 
            this.txtorden.Location = new System.Drawing.Point(109, 12);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(119, 20);
            this.txtorden.TabIndex = 1;
            this.txtorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtorden_KeyPress);
            this.txtorden.Leave += new System.EventHandler(this.txtorden_Leave);
            // 
            // GridControl
            // 
            this.GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_sts_sal,
            this.col_job,
            this.col_posi,
            this.col_fec,
            this.col_kg,
            this.col_acero,
            this.col_hrc,
            this.col_obs});
            this.GridControl.Location = new System.Drawing.Point(-1, 136);
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(1036, 256);
            this.GridControl.TabIndex = 2;
            this.GridControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridControl_CellClick);
            this.GridControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridControl_CellContentClick);
            this.GridControl.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridControl_CellEndEdit);
            this.GridControl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridControl_CellValueChanged);
            this.GridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // comboPrv
            // 
            this.comboPrv.DropDownHeight = 108;
            this.comboPrv.DropDownWidth = 300;
            this.comboPrv.FormattingEnabled = true;
            this.comboPrv.IntegralHeight = false;
            this.comboPrv.Location = new System.Drawing.Point(109, 67);
            this.comboPrv.Name = "comboPrv";
            this.comboPrv.Size = new System.Drawing.Size(119, 21);
            this.comboPrv.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(521, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // brnImp
            // 
            this.brnImp.Location = new System.Drawing.Point(626, 5);
            this.brnImp.Name = "brnImp";
            this.brnImp.Size = new System.Drawing.Size(75, 23);
            this.brnImp.TabIndex = 6;
            this.brnImp.Text = "Imprimir";
            this.brnImp.UseVisualStyleBackColor = true;
            this.brnImp.Click += new System.EventHandler(this.brnImp_Click);
            // 
            // txtPzas
            // 
            this.txtPzas.Location = new System.Drawing.Point(869, 72);
            this.txtPzas.Name = "txtPzas";
            this.txtPzas.ReadOnly = true;
            this.txtPzas.Size = new System.Drawing.Size(119, 20);
            this.txtPzas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de piezas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente";
            // 
            // txtCli
            // 
            this.txtCli.Location = new System.Drawing.Point(109, 41);
            this.txtCli.Name = "txtCli";
            this.txtCli.ReadOnly = true;
            this.txtCli.Size = new System.Drawing.Size(215, 20);
            this.txtCli.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total de KG";
            // 
            // txtkg
            // 
            this.txtkg.Enabled = false;
            this.txtkg.Location = new System.Drawing.Point(535, 72);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(110, 20);
            this.txtkg.TabIndex = 12;
            this.txtkg.Leave += new System.EventHandler(this.txtkg_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(575, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seleccionar las partidas para poder visualizarlas en el reporte de impresion";
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Visible = false;
            // 
            // col_sts_sal
            // 
            this.col_sts_sal.HeaderText = "Enviar";
            this.col_sts_sal.Name = "col_sts_sal";
            // 
            // col_job
            // 
            this.col_job.HeaderText = "JOB";
            this.col_job.Name = "col_job";
            this.col_job.ReadOnly = true;
            this.col_job.Width = 130;
            // 
            // col_posi
            // 
            this.col_posi.HeaderText = "Posición";
            this.col_posi.Name = "col_posi";
            this.col_posi.ReadOnly = true;
            // 
            // col_fec
            // 
            this.col_fec.HeaderText = "Fecha de salida";
            this.col_fec.Name = "col_fec";
            // 
            // col_kg
            // 
            this.col_kg.HeaderText = "KG";
            this.col_kg.Name = "col_kg";
            this.col_kg.Visible = false;
            // 
            // col_acero
            // 
            this.col_acero.HeaderText = "Acero";
            this.col_acero.Name = "col_acero";
            this.col_acero.ReadOnly = true;
            // 
            // col_hrc
            // 
            this.col_hrc.HeaderText = "HRC";
            this.col_hrc.Name = "col_hrc";
            this.col_hrc.ReadOnly = true;
            // 
            // col_obs
            // 
            this.col_obs.HeaderText = "Observaciones";
            this.col_obs.Name = "col_obs";
            this.col_obs.Width = 250;
            // 
            // control_sal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1032, 392);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPzas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brnImp);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboPrv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridControl);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "control_sal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de salidas";
            this.Load += new System.EventHandler(this.control_sal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.DataGridView GridControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPrv;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button brnImp;
        private System.Windows.Forms.TextBox txtPzas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_sts_sal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_job;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_posi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_acero;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_obs;
    }
}