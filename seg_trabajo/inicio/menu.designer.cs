namespace seg_trabajo.inicio
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMax = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMini = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vCat = new System.Windows.Forms.ToolStripMenuItem();
            this.vClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Vproveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.vOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.vorden = new System.Windows.Forms.ToolStripMenuItem();
            this.vproce = new System.Windows.Forms.ToolStripMenuItem();
            this.vconsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.Vdimensiones = new System.Windows.Forms.ToolStripMenuItem();
            this.Vcontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.vReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.rjobs = new System.Windows.Forms.ToolStripMenuItem();
            this.vcontrolusu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusu = new System.Windows.Forms.Label();
            this.lblini = new System.Windows.Forms.Label();
            this.lblin = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMax,
            this.MenuMini,
            this.toolStripMenuItem2,
            this.toolSalir,
            this.toolStripMenuItem3,
            this.vCat,
            this.vOperaciones,
            this.vReportes,
            this.vcontrolusu,
            this.Vayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuMax
            // 
            this.MenuMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuMax.ForeColor = System.Drawing.Color.White;
            this.MenuMax.Image = ((System.Drawing.Image)(resources.GetObject("MenuMax.Image")));
            this.MenuMax.Name = "MenuMax";
            this.MenuMax.Size = new System.Drawing.Size(28, 20);
            this.MenuMax.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.MenuMax.Click += new System.EventHandler(this.MenuMax_Click);
            // 
            // MenuMini
            // 
            this.MenuMini.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuMini.ForeColor = System.Drawing.Color.White;
            this.MenuMini.Image = ((System.Drawing.Image)(resources.GetObject("MenuMini.Image")));
            this.MenuMini.Name = "MenuMini";
            this.MenuMini.Size = new System.Drawing.Size(28, 20);
            this.MenuMini.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.MenuMini.Visible = false;
            this.MenuMini.Click += new System.EventHandler(this.MenuMini_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolSalir
            // 
            this.toolSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSalir.ForeColor = System.Drawing.Color.White;
            this.toolSalir.Name = "toolSalir";
            this.toolSalir.Size = new System.Drawing.Size(41, 20);
            this.toolSalir.Text = "Salir";
            this.toolSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolSalir.Click += new System.EventHandler(this.toolSalir_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuItem3.Text = "Cerrar Sesion";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // vCat
            // 
            this.vCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vClientes,
            this.Vproveedores});
            this.vCat.ForeColor = System.Drawing.Color.White;
            this.vCat.Image = ((System.Drawing.Image)(resources.GetObject("vCat.Image")));
            this.vCat.Name = "vCat";
            this.vCat.Size = new System.Drawing.Size(88, 20);
            this.vCat.Text = "Catálogos";
            // 
            // vClientes
            // 
            this.vClientes.Image = ((System.Drawing.Image)(resources.GetObject("vClientes.Image")));
            this.vClientes.Name = "vClientes";
            this.vClientes.Size = new System.Drawing.Size(139, 22);
            this.vClientes.Text = "Clientes";
            this.vClientes.Visible = false;
            this.vClientes.Click += new System.EventHandler(this.vClientes_Click);
            // 
            // Vproveedores
            // 
            this.Vproveedores.Image = ((System.Drawing.Image)(resources.GetObject("Vproveedores.Image")));
            this.Vproveedores.Name = "Vproveedores";
            this.Vproveedores.Size = new System.Drawing.Size(139, 22);
            this.Vproveedores.Text = "Proveedores";
            this.Vproveedores.Click += new System.EventHandler(this.Vproveedores_Click);
            // 
            // vOperaciones
            // 
            this.vOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorden,
            this.vproce,
            this.vconsulta,
            this.Vdimensiones,
            this.Vcontrol});
            this.vOperaciones.ForeColor = System.Drawing.Color.White;
            this.vOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("vOperaciones.Image")));
            this.vOperaciones.Name = "vOperaciones";
            this.vOperaciones.Size = new System.Drawing.Size(101, 20);
            this.vOperaciones.Text = "Operaciones";
            // 
            // vorden
            // 
            this.vorden.Image = ((System.Drawing.Image)(resources.GetObject("vorden.Image")));
            this.vorden.Name = "vorden";
            this.vorden.Size = new System.Drawing.Size(226, 22);
            this.vorden.Text = "Generar orden";
            this.vorden.Click += new System.EventHandler(this.vorden_Click);
            // 
            // vproce
            // 
            this.vproce.Image = ((System.Drawing.Image)(resources.GetObject("vproce.Image")));
            this.vproce.Name = "vproce";
            this.vproce.Size = new System.Drawing.Size(226, 22);
            this.vproce.Text = "Actualizar procesos de orden";
            this.vproce.Click += new System.EventHandler(this.vproce_Click);
            // 
            // vconsulta
            // 
            this.vconsulta.Image = ((System.Drawing.Image)(resources.GetObject("vconsulta.Image")));
            this.vconsulta.Name = "vconsulta";
            this.vconsulta.Size = new System.Drawing.Size(226, 22);
            this.vconsulta.Text = "Consultar ordenes activas";
            this.vconsulta.Click += new System.EventHandler(this.vconsulta_Click);
            // 
            // Vdimensiones
            // 
            this.Vdimensiones.Image = ((System.Drawing.Image)(resources.GetObject("Vdimensiones.Image")));
            this.Vdimensiones.Name = "Vdimensiones";
            this.Vdimensiones.Size = new System.Drawing.Size(226, 22);
            this.Vdimensiones.Text = "Dimensionado";
            this.Vdimensiones.Click += new System.EventHandler(this.Vdimensiones_Click);
            // 
            // Vcontrol
            // 
            this.Vcontrol.Image = ((System.Drawing.Image)(resources.GetObject("Vcontrol.Image")));
            this.Vcontrol.Name = "Vcontrol";
            this.Vcontrol.Size = new System.Drawing.Size(226, 22);
            this.Vcontrol.Text = "Control de salidas";
            this.Vcontrol.Click += new System.EventHandler(this.Vcontrol_Click);
            // 
            // vReportes
            // 
            this.vReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rjobs,
            this.toolStripMenuItem1});
            this.vReportes.ForeColor = System.Drawing.Color.White;
            this.vReportes.Image = ((System.Drawing.Image)(resources.GetObject("vReportes.Image")));
            this.vReportes.Name = "vReportes";
            this.vReportes.Size = new System.Drawing.Size(81, 20);
            this.vReportes.Text = "Reportes";
            // 
            // rjobs
            // 
            this.rjobs.Name = "rjobs";
            this.rjobs.Size = new System.Drawing.Size(309, 22);
            this.rjobs.Text = "Historico de ordenes entregadas a clientes";
            this.rjobs.Click += new System.EventHandler(this.rjobs_Click);
            // 
            // vcontrolusu
            // 
            this.vcontrolusu.ForeColor = System.Drawing.Color.White;
            this.vcontrolusu.Image = ((System.Drawing.Image)(resources.GetObject("vcontrolusu.Image")));
            this.vcontrolusu.Name = "vcontrolusu";
            this.vcontrolusu.Size = new System.Drawing.Size(80, 20);
            this.vcontrolusu.Text = "Usuarios";
            this.vcontrolusu.Click += new System.EventHandler(this.vcontrolusu_Click);
            // 
            // Vayuda
            // 
            this.Vayuda.Name = "Vayuda";
            this.Vayuda.Size = new System.Drawing.Size(53, 20);
            this.Vayuda.Text = "Ayuda";
            this.Vayuda.Click += new System.EventHandler(this.Vayuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido:";
            this.label1.Visible = false;
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblusu.Location = new System.Drawing.Point(120, 35);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(0, 20);
            this.lblusu.TabIndex = 3;
            // 
            // lblini
            // 
            this.lblini.AutoSize = true;
            this.lblini.Location = new System.Drawing.Point(13, 64);
            this.lblini.Name = "lblini";
            this.lblini.Size = new System.Drawing.Size(0, 13);
            this.lblini.TabIndex = 4;
            this.lblini.Visible = false;
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.Location = new System.Drawing.Point(12, 86);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(0, 13);
            this.lblin.TabIndex = 5;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(345, 64);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(35, 13);
            this.lblres.TabIndex = 6;
            this.lblres.Text = "label2";
            this.lblres.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(772, 109);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(35, 13);
            this.lblnom.TabIndex = 8;
            this.lblnom.Text = "label3";
            this.lblnom.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(309, 22);
            this.toolStripMenuItem1.Text = "Participacion de operador x orden de trabajo";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 435);
            this.ControlBox = false;
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblin);
            this.Controls.Add(this.lblini);
            this.Controls.Add(this.lblusu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dapa";
            this.Load += new System.EventHandler(this.menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMini;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuMax;
        private System.Windows.Forms.ToolStripMenuItem vCat;
        private System.Windows.Forms.ToolStripMenuItem vOperaciones;
        private System.Windows.Forms.ToolStripMenuItem vReportes;
        private System.Windows.Forms.ToolStripMenuItem vClientes;
        private System.Windows.Forms.ToolStripMenuItem vorden;
        private System.Windows.Forms.ToolStripMenuItem rjobs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.ToolStripMenuItem vcontrolusu;
        private System.Windows.Forms.ToolStripMenuItem vproce;
        private System.Windows.Forms.Label lblini;
        public System.Windows.Forms.Label lblin;
        public System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem vconsulta;
        public System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.ToolStripMenuItem Vdimensiones;
        private System.Windows.Forms.ToolStripMenuItem Vcontrol;
        private System.Windows.Forms.ToolStripMenuItem Vproveedores;
        private System.Windows.Forms.ToolStripMenuItem Vayuda;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}