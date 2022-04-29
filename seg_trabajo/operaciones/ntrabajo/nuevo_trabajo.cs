using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class nuevo_trabajo : Form
    {
        Conexion ManipularDatos = new Conexion();
        bool impor;
        public string nom;
        public nuevo_trabajo()
        {
            InitializeComponent();
        }

        private void nuevo_trabajo_Load(object sender, EventArgs e)
        {
            //txtfol.Text = ManipularDatos.ResultadoInt("select folio+1 folio from contaorden").ToString();
            //ManipularDatos.EjecutarSql("update contaorden set folio='"+txtfol.Text+"'");
            ManipularDatos.cargarcombo(combocli, "select cve, cve + '| ' + nom nom  from clientes","cve","nom");
            if (nom == "David" || nom == "admin") { btnmodi.Visible = true; } else { btnmodi.Visible = false; }
        }

        private void combocli_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtnomcli.Text = ManipularDatos.Resultado("select nom from clientes where cve='"+combocli.SelectedValue+"'");
        }

        #region guardalosManipularDatos
        private void btnguardar_Click(object sender, EventArgs e)
        {
            //DateTime fecha
            string foliorep = ManipularDatos.Resultado("if exists(select folio from orden where folio='"+txtfol.Text+"')begin select 'si' end else begin select 'no' end");
            if (foliorep == "no") {
                string guardarord = "exec guardarOrden '" + txtfol.Text + "','" + combocli.SelectedValue + "','" + txtnomcli.Text + "','1','"+fec.Text+"'";
                ManipularDatos.EjecutarSql(guardarord);

                for(int i = 0; i < gridjob.Rows.Count - 1; i++) {

                    string job = gridjob.Rows[i].Cells["job"].Value.ToString();
                    string pos = gridjob.Rows[i].Cells["pos"].Value.ToString();
                    string medida =gridjob.Rows[i].Cells["med"].Value.ToString();
                    decimal espesor = Convert.ToDecimal(gridjob.Rows[i].Cells["esp"].Value.ToString());
                    decimal diametroext = Convert.ToDecimal(gridjob.Rows[i].Cells["diam"].Value.ToString());
                    decimal espesorcorte = Convert.ToDecimal(gridjob.Rows[i].Cells["espcorte"].Value.ToString());
                    string acero = gridjob.Rows[i].Cells["ac"].Value.ToString();

                    string guardarordx = "exec guadarord_aux '"+txtfol.Text+"','"+job+"','"+pos+"','"+medida+"','"+espesor+"','"+diametroext+"','"+espesorcorte+"','"+acero+"','1','"+combocli.SelectedValue+"','"+fec.Text+"'";
                    ManipularDatos.EjecutarSql(guardarordx);
                }
                ManipularDatos.EjecutarSql("update contaorden set folio='" + txtfol.Text + "'");
                MessageBox.Show("Datos guardados correctamente");
                ManipularDatos.LimpiarCampos(this);             
                txtfol.Text = ManipularDatos.ResultadoInt("select folio+1 folio from contaorden").ToString();
               
            }
            else { MessageBox.Show(" No se permiten folios repetidos");  ManipularDatos.LimpiarCampos(this); txtfol.Text = ManipularDatos.ResultadoInt("select folio+1 folio from contaorden").ToString(); }
            

        }
        #endregion

        private void btnimp_Click(object sender, EventArgs e)
        {
            operaciones.ntrabajo.imp imp = new imp();
            imp.Show();
        }

      

        private void gridjob_KeyPress(object sender, KeyPressEventArgs e)
        {

             
           
           
        }

        private void gridjob_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridjob.Columns[e.ColumnIndex].Name == "esp" || gridjob.Columns[e.ColumnIndex].Name == "diam" || gridjob.Columns[e.ColumnIndex].Name == "espcorte")//condicion que me indica si le di clic a cve_art
            {
               
              
            }
        }

        private void btnimportar_Click(object sender, EventArgs e)
        {

            if (txtfol.Text != String.Empty && impor==true)
            {
                Importar_excel im = new Importar_excel();
                im.num_orden = txtfol.Text;
                string cli = "";
                if (combocli.SelectedValue.ToString() != String.Empty) { cli = combocli.SelectedValue.ToString(); } else { cli = ""; }
                im.cliente = cli;
                im.Show();
            }
            else {
                MessageBox.Show("Captura el número de orden y selecciona el cliente");
            }
        }

        private void txtfol_Leave(object sender, EventArgs e)
        {
            #region valida que exista el folio
            string validar = ManipularDatos.Resultado("validar_orden '"+txtfol.Text+"'");
            if (validar == "existe")
            {
                impor = false;
               MessageBox.Show("El numero de orden ya existe");
               
            }
            else { impor = true; btnimportar.Enabled = true; }
            #endregion
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            //operaciones.ntrabajo.actualizar_trabajo act = new actualizar_trabajo();
            //act.orden = txtfol.Text;
            //act.ShowDialog();
            if (txtfol.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Deseas eliminar esta orden de trabajo", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ManipularDatos.EjecutarSql("delete from orden_aux where folio='" + txtfol.Text + "'");
                    ManipularDatos.EjecutarSql("delete from seg where fol='" + txtfol.Text + "'");
                    ManipularDatos.EjecutarSql("delete from dimensionales where folio='" + txtfol.Text + "'");
                    ManipularDatos.EjecutarSql("delete from sts_ordenes where folio='" + txtfol.Text + "'");
                    MessageBox.Show("Proceso completado");
                }
            }
            else { MessageBox.Show("Capture el numero de orden a eliminar"); }
        }
    }
}
