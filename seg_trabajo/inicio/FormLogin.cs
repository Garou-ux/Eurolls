using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace seg_trabajo.inicio
{
    public partial class FormLogin : Form
    {
        Conexion ManipularDatos = new Conexion();
        string rol = "";
        public bool ortpedia;
        public bool implantes;
        public bool distribuidora;
        public bool medhome;
        string almc;
        string Tagente;

        public FormLogin()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             ManipularDatos.Conectar();
            string query1 = "select id , nombre, pwd,usu,iniciales,eml,us from usuarios where usu= '" + txtuser.Text + "' and pwd = '" + txtpass.Text + "' ";
            //string query1 = "exec validarlogin '" + txtuser.Text + "','" + txtpass.Text + "' ";
            SqlCommand cmd = new SqlCommand(query1, ManipularDatos.MiConexion);
            SqlDataReader dc = cmd.ExecuteReader();
            menu m = new menu();
            //Pedidos p = new Pedidos();
           // m.lblpass.Text = txtpass.Text;
           //m.lblusu.Text = txtuser.Text;

            if (dc.HasRows)
            {
                while (dc.Read())
                {
                    //MessageBox.Show("distribuidora");
                    //m.lblage.Text = dc["u_agente"].ToString();
                    //m.lblalm.Text = dc["alm"].ToString();
                    m.lblusu.Text = dc["us"].ToString();
                    m.lblin.Text = dc["iniciales"].ToString();
                    m.lblres.Text = dc["eml"].ToString();
                    m.lblnom.Text = dc["usu"].ToString();
                    //m.lblpass.Text = dc["con"].ToString();
                    //m.lblalm.Text = almc;
                    //m.lblage.Text = Tagente;
                    m.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos");
                txtuser.Focus();
            }
        
        }
    }
}
