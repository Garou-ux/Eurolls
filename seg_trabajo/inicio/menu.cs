using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace seg_trabajo.inicio
{
    public partial class menu : Form
    {
        Conexion Manipulardatos = new Conexion();
       // login lo = new login();
        public String alm;
        public String TipoAgente;
        int LX, LY, SW, SH;
        
        public menu()
        {
            InitializeComponent();
            //label1.Text = alm;
            //label2.Text = TipoAgente;
        //MessageBox.Show(alm,TipoAgente);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menu_Load(object sender, EventArgs e)
        {
            Manipulardatos.Conectar();
            lblin.Visible = false;
            lblusu.Visible = false;
            if (lblusu.Text == "si") { vcontrolusu.Visible = true; } else { vcontrolusu.Visible = false; }

            if (lblres.Text == "si") { vClientes.Visible = true; } else { vClientes.Visible = false; }
        }

        private void toolSalir_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuMini_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            //iconmaximizar.Visible = true;
            MenuMax.Visible = true;
            //iconrestaurar.Visible = false;
            MenuMini.Visible = false;
        }

        private void MenuMax_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //iconmaximizar.Visible = false;
            MenuMax.Visible = false;
            //iconrestaurar.Visible = true;
            MenuMini.Visible = true;
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void vClientes_Click(object sender, EventArgs e)
        {
            clientes.cli cl = new clientes.cli();
            cl.Show();
        }

        private void vorden_Click(object sender, EventArgs e)
        {
            operaciones.ntrabajo.nuevo_trabajo nt = new operaciones.ntrabajo.nuevo_trabajo();
            nt.nom = lblnom.Text;
            nt.Show();

            //operaciones.ntrabajo.Importar_excel impor = new operaciones.ntrabajo.Importar_excel();
            //impor.Show();
        }

        private void vcontrolusu_Click(object sender, EventArgs e)
        {
            operaciones.usuarios.control_usuarios cu = new operaciones.usuarios.control_usuarios();
            cu.Show();
        }

        private void rjobs_Click(object sender, EventArgs e)
        {
            //seg_trabajo.reportes.jobsxcliente jc = new reportes.jobsxcliente();
            //jc.Show();
            reportes.rep_historico rp = new reportes.rep_historico();
            rp.ShowDialog();
        }

        private void vproce_Click(object sender, EventArgs e)
        {
            //seg_trabajo.operaciones.ntrabajo.segTrabajo st = new operaciones.ntrabajo.segTrabajo();
            //st.Show();
            operaciones.ntrabajo.capa_segtrabajo cp = new operaciones.ntrabajo.capa_segtrabajo();
            cp.inicial = lblin.Text;
            cp.nom  = lblnom.Text;
            cp.Show();
        }

        private void vconsulta_Click(object sender, EventArgs e)
        {
            operaciones.ntrabajo.consultar_activos ca = new operaciones.ntrabajo.consultar_activos();
            ca.Show();
        }

        private void Vdimensiones_Click(object sender, EventArgs e)
        {
            operaciones.ntrabajo.dimensiones dim = new operaciones.ntrabajo.dimensiones();
            dim.Show();
        }

        private void Vcontrol_Click(object sender, EventArgs e)
        {
            operaciones.Control_salidas.control_sal cs = new operaciones.Control_salidas.control_sal();
            cs.Show();
        }

        private void Vproveedores_Click(object sender, EventArgs e)
        {
            operaciones.Proveedores.prov pv = new operaciones.Proveedores.prov();
            pv.ShowDialog();
        }

        private void Vayuda_Click(object sender, EventArgs e)
        {
            ayuda.ayuda_seg_trabajo ay = new ayuda.ayuda_seg_trabajo();
            ay.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            operaciones.ntrabajo.participacion_usu par = new operaciones.ntrabajo.participacion_usu();
            par.Show();
        }

        
       
    }
}
