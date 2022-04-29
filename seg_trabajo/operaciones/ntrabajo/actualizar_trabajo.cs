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
namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class actualizar_trabajo : Form
    {
        Conexion datos = new Conexion();
        public string orden;

        public actualizar_trabajo()
        {
            InitializeComponent();
        }

        private void actualizar_trabajo_Load(object sender, EventArgs e)
        {
           datos.cargarcombo(combocli, "select cve, cve + '| ' + nom nom  from clientes", "cve", "nom");
           txtfol.Text = orden;
           datos_orden();
        }
        private void datos_orden() {
            SqlDataReader dr = datos.obtenerRegistro("exec datos_orden '" + txtfol.Text + "'");
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    gridjob.Rows.Add();
                    gridjob.Rows[i].Cells["col_item"].Value = dr["id"].ToString();
                    gridjob.Rows[i].Cells["col_codigoa"].Value = dr["codacero"].ToString();
                    gridjob.Rows[i].Cells["col_largoi"].Value = dr["largoi"].ToString();
                    gridjob.Rows[i].Cells["col_largof"].Value = dr["largof"].ToString();
                    gridjob.Rows[i].Cells["pos"].Value = dr["posicion"].ToString();
                    gridjob.Rows[i].Cells["med"].Value = dr["medida"].ToString();
                    gridjob.Rows[i].Cells["job"].Value = dr["job"].ToString();
                    gridjob.Rows[i].Cells["esp"].Value = dr["espesor"].ToString();
                    gridjob.Rows[i].Cells["diam"].Value = dr["diametroext"].ToString();
                    gridjob.Rows[i].Cells["col_diammen"].Value = dr["diametromen"].ToString();
                    gridjob.Rows[i].Cells["espcorte"].Value = dr["espesorcorte"].ToString();
                    gridjob.Rows[i].Cells["ac"].Value = dr["acero"].ToString();
                    gridjob.Rows[i].Cells["col_hrc"].Value = dr["hrc"].ToString();

                    i += 1;

                }

            }
        
        }
        private void txtfol_Leave(object sender, EventArgs e)
        {
            datos_orden();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < gridjob.Rows.Count - 1; k++) {
          int id=    Convert.ToInt32 ( gridjob.Rows[k].Cells["col_item"].Value.ToString());
           string codigo =    gridjob.Rows[k].Cells["col_codigoa"].Value.ToString();
           string largoi  =   gridjob.Rows[k].Cells["col_largoi"].Value.ToString();
               string largof= gridjob.Rows[k].Cells["col_largof"].Value.ToString();
             string pos =   gridjob.Rows[k].Cells["pos"].Value.ToString();
            string med=    gridjob.Rows[k].Cells["med"].Value.ToString();
            string job =    gridjob.Rows[k].Cells["job"].Value.ToString();
            string esp =    gridjob.Rows[k].Cells["esp"].Value.ToString();
            string diam=    gridjob.Rows[k].Cells["diam"].Value.ToString();
               string diammen  = gridjob.Rows[k].Cells["col_diammen"].Value.ToString();
               string espcorte= gridjob.Rows[k].Cells["espcorte"].Value.ToString();
              string ac =  gridjob.Rows[k].Cells["ac"].Value.ToString();
                string hrc= gridjob.Rows[k].Cells["col_hrc"].Value.ToString();
                if(id>0){

                    string modi = "UPDATE orden_aux SET codacero ='"+codigo+"',largoi = '"+largoi+"',largof = '"+largof+"',job = '"+job+"',posicion = '"+pos+"',medida = '"+med+"',espesor = '"+esp+"',diametroext = '"+diam+"',diametromen = '"+diammen+"',espesorcorte = '"+espcorte+"',acero = '"+ac+"',hrc = '"+hrc+"',cli = '"+combocli.SelectedValue.ToString()+"'  WHERE id='" + id + "'";
                    datos.EjecutarSql(modi);
                }
            }
            MessageBox.Show("Proceso completado");
            datos.LimpiarCampos(this);
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Deseas eliminar esta orden de trabajo", "", MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
             {
                 datos.EjecutarSql("delete from orden_aux where folio='"+txtfol.Text+"'");
                 datos.EjecutarSql("delete from seg where fol='"+txtfol.Text+"'");
                 datos.EjecutarSql("delete from sts_ordenes where folio='"+txtfol.Text+"'");
             }
        }

       
    }
}
