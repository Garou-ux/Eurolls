using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace seg_trabajo.operaciones.usuarios
{
    public partial class control_usuarios : Form
    {
        Conexion datos = new Conexion();
        bool guard;
        public control_usuarios()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtpwd2.Text == txtpwd.Text)
            {
                string res = "";
                string us = "";
                if (rbsi.Checked == true) { res = "si"; } else { res = "no"; }
                if (rbusu.Checked == true) { us = "si"; } else { us = "no"; }
            string guardar = "exec guardar_usuarios '"+txtnom.Text+"','"+txtusu.Text+"','"+txtpwd.Text+"','"+txteml.Text+"','"+res+"','"+us+"'";
            datos.EjecutarSql(guardar);
            datos.LimpiarCampos(this);
            MessageBox.Show("Proceso completado correctamente");
                }
        }

        private void txtpwd2_Leave(object sender, EventArgs e)
        {
            if (txtpwd2.Text == txtpwd.Text) { guard = true; }
            else{
                MessageBox.Show("Verifique que ambas contraseñas sean iguales");
                txtpwd2.Focus(); guard = false;
                }
        }

        private void txteml_Leave(object sender, EventArgs e)
        {
            //datos.validarEmail(txteml.Text);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas darlo de Baja", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                datos.EjecutarSql("delete from usuarios where usu='" + txtusu.Text + "' ");
                MessageBox.Show("Proceso completado correctamente");
                datos.LimpiarCampos(this);
            }
            
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            string datos_usu = "select usu,nombre,pwd,eml,iniciales from usuarios where nombre='"+txtnom.Text+"'";
            SqlDataReader dr = datos.obtenerRegistro(datos_usu);
            if (dr.HasRows) {
                while (dr.Read()) {

                    txtusu.Text = dr["usu"].ToString();
                    txteml.Text = dr["iniciales"].ToString();
                    txtpwd.Text = dr["pwd"].ToString();
                    txtpwd2.Text = dr["pwd"].ToString();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            txtpwd.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtpwd2.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
