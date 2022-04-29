using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace seg_trabajo.clientes
{
    public partial class cli : Form
    {
        Conexion ManipularDatos = new Conexion();
        public cli()
        {
            InitializeComponent();
        }

        private void cli_Load(object sender, EventArgs e)
        {
           
            string datoscli = "select cve 'No.cliente', nom Nombre, dir Direccón, ciu Ciudad, codpos 'Codigo postal', rfc, edo Estado, mun Municipio, email Correo, tel Telefono from clientes";

            ManipularDatos.ActualizarGrid(Gridclientes, datoscli);
        }


        #region muestra los municipiosal seleccionar el estados
        private void comboedo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ManipularDatos.cargarcombo(combomun, "select cast(cvemun as varchar) as cvemun, cvemundes from municipios  as m inner join estados as e on  substring(m.cvemun,1,2)=e.cveedo where e.cveedo='" + comboedo.SelectedValue + "'", "cvemun", "cvemundes");
        }
        #endregion

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ManipularDatos.exportaexcel(Gridclientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region limpia los campos
        private void limpiar()
        {
            txtcli.Clear();
            txtnomcli.Clear();
            txtdir.Clear();
            txtciu.Clear();
            txtcp.Clear();
            txtrfc.Clear();
            txtemail.Clear();
            txtTel.Clear();
        }
        #endregion

        #region guardardatos
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string guardar = "exec guardarCliente '"+txtcli.Text+"','"+txtnomcli.Text+"','"+txtdir.Text+"','"+txtciu.Text+"','"+txtcp.Text+"','"+txtrfc.Text+"','"+txtemail.Text+"','"+txtTel.Text+"'";
            ManipularDatos.EjecutarSql(guardar);
            MessageBox.Show("Datos guardados correctamente");
            limpiar();
            string datoscli = "select cve 'No.cliente', nom Nombre, dir Direccón, ciu Ciudad, codpos 'Codigo postal', rfc, edo Estado, mun Municipio, email Correo, tel Telefono from clientes";

            ManipularDatos.ActualizarGrid(Gridclientes, datoscli);
        }
        #endregion
        #region mostrar datos del cliente
        private void txtcli_Leave(object sender, EventArgs e)
        {
            //string datos_cliente = "select cve , nom, dir, ciu, codpos, rfc, edo , mun, email, tel from clientes where cve='"+txtcli.Text+"'";
            //SqlDataReader dr= ManipularDatos.obtenerRegistro(datos_cliente);
            //if (dr.HasRows){
            //    while (dr.Read()) {
            //        txtnomcli.Text = dr["nom"].ToString();
            //        txtdir.Text = dr["dir"].ToString();
            //        txtciu.Text = dr["ciu"].ToString();
            //        txtcp.Text = dr["codpos"].ToString();
            //        txtrfc.Text = dr["rfc"].ToString();
            //        string edo = dr["edo"].ToString();
            //        //ManipularDatos.cargarcombo(comboedo, "select cveedo,cveedodes from estados where cveedo='"+edo+"'", "cveedo","cveedodes");
            //        string mun = dr["mun"].ToString();
            //       // ManipularDatos.cargarcombo(combomun, "select cvemun,cvemundes from municipios where cvemun='"+mun+"'", "cvemun","cvemundes");
            //        txtemail.Text = dr["email"].ToString();
            //        txtTel.Text = dr["tel"].ToString();

            //    }
            //}
            //else { MessageBox.Show(" Numero de cliente inexistente"); }
        }
#endregion

        #region eliminar cliente
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (rbsi.Checked == true) { 
                 var resultado = MessageBox.Show("¿Desear realmente eliminar este registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//2.Confirmacion del usuario
                if (resultado == DialogResult.Yes)
                {
                    String Clave = this.Gridclientes.CurrentRow.Cells[0].Value.ToString();
                    ManipularDatos.Conectar();
                    String baja = "delete from clientes where cve='" + Clave + "' or cve = '"+txtcli.Text+"'";
                    ManipularDatos.EjecutarSql(baja);
                 //   ManipularDatos.ActualizarGrid(GridCli, Grid);
                    ManipularDatos.Desconectar();
                    limpiar();
                    string datoscli = "select cve 'No.cliente', nom Nombre, dir Direccón, ciu Ciudad, codpos 'Codigo postal', rfc, edo Estado, mun Municipio, email Correo, tel Telefono from clientes";

                    ManipularDatos.ActualizarGrid(Gridclientes, datoscli);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se puede dar de baja");
            }

            }
        #endregion
    }
}

