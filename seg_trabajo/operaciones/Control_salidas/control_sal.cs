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
namespace seg_trabajo.operaciones.Control_salidas
{
    public partial class control_sal : Form
    {
        Conexion datos = new Conexion();
        bool kg = false;
        string folio,idkg = "";
        string valor_copia = "";
        public control_sal()
        {
            InitializeComponent();
        }
        #region guarda kg y obs
        private void GridControl_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string id, kg, obs= "";
            //if (GridControl.Columns[e.ColumnIndex].Name == "col_kg") { 
            //id=GridControl.CurrentRow.Cells["col_id"].Value.ToString();
            //kg = GridControl.CurrentRow.Cells["col_kg"].Value.ToString();
            //obs = GridControl.CurrentRow.Cells["col_obs"].Value.ToString();
            //datos.EjecutarSql("update orden_aux set kg='"+kg+"',obs='"+obs+"' where id='"+id+"'");
            //decimal kil = datos.sumargridpro(GridControl, "col_kg");
            //txtkg.Text = kil.ToString();
            //}
            if (GridControl.Columns[e.ColumnIndex].Name == "col_obs")
            {
                id = GridControl.CurrentRow.Cells["col_id"].Value.ToString();
                kg = GridControl.CurrentRow.Cells["col_kg"].Value.ToString();
                obs = GridControl.CurrentRow.Cells["col_obs"].Value.ToString();
                datos.EjecutarSql("update orden_aux set obs='" + obs + "' where id='" + id + "'");

            }
        }
        #endregion
        #region muestralos datos
        private void cargar() {
            folio = txtorden.Text;
            SqlDataReader ken = datos.obtenerRegistro("exec consultar_Control '" + txtorden.Text + "'");
            string sts_Sal = "";
            bool check;
            int i = 0;
            if (ken.HasRows)
            {
                GridControl.Rows.Clear();
                while (ken.Read())
                {

                    GridControl.Rows.Add();
                    txtPzas.Text = ken["piezas"].ToString();
                    //txtkg.Text = ken["kilos"].ToString();
                    txtCli.Text = ken["nombrec"].ToString();
                    sts_Sal = ken["sts_Sal"].ToString();
                    if (sts_Sal == "2") { check = true; } else { check = false; }
                    // GridControl.Rows[i].Cells["col_sts_sal"].Value = sts_Sal;
                    if (check == true)
                    {
                        GridControl.Rows[i].ReadOnly = true; GridControl.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    // comboPrv.SelectedValue = ken["nombrep"];
                    GridControl.Rows[i].Cells["col_id"].Value = ken["id"].ToString();
                    GridControl.Rows[i].Cells["col_posi"].Value = ken["posicion"].ToString();
                    GridControl.Rows[i].Cells["col_fec"].Value = ken["fec_salida"].ToString();
                    GridControl.Rows[i].Cells["col_job"].Value = ken["job"].ToString();
                    GridControl.Rows[i].Cells["col_kg"].Value = ken["kg"].ToString();
                    GridControl.Rows[i].Cells["col_acero"].Value = ken["acero"].ToString();
                    GridControl.Rows[i].Cells["col_hrc"].Value = ken["hrc"].ToString();
                    GridControl.Rows[i].Cells["col_obs"].Value = ken["obs"].ToString();
                    i += 1;
                }
            }
        }
#endregion
        
        private void txtorden_Leave(object sender, EventArgs e)
        {
            folio = txtorden.Text;
            cargar();
        }
      
        private void txtorden_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.EnterTab(e);
        }

        private void control_sal_Load(object sender, EventArgs e)
        {
            datos.cargarcombo(comboPrv,"select cve,nom from Proveedores","cve","nom");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCli.Text != String.Empty)
            {
                datos.EjecutarSql("update orden_aux set prv='" + comboPrv.SelectedValue.ToString() + "',fec_salida=cast(GETDATE() as date) where folio='" + txtorden.Text + "'");
                for (int s = 0; s < GridControl.Rows.Count - 1; s++) {
                    if (Convert.ToBoolean(GridControl.Rows[s].Cells["col_sts_sal"].Value) == true){
                    string id = GridControl.Rows[s].Cells["col_id"].Value.ToString();

                    datos.EjecutarSql("update orden_aux set sts_Sal='2', fec_salida=cast(GETDATE() as date) where id='" + id + "'");

                        }

                }
                    MessageBox.Show("Proceso completado");
                    cargar();
            }
            else { MessageBox.Show("Capture el numero de orden"); }
        }

        private void brnImp_Click(object sender, EventArgs e)
        {
            if (txtorden.Text != String.Empty)
            {
                imp_control imp = new imp_control();
                imp.folio = txtorden.Text;
                imp.ShowDialog();
            }
            else { MessageBox.Show("Capture el numero de orden"); }
        }

       

        private void GridControl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (GridControl.Columns[e.ColumnIndex].Name == "col_sts_sal" && GridControl.CurrentRow.Cells["col_sts_sal"].ReadOnly != true)
            {
                string id = GridControl.CurrentRow.Cells["col_id"].Value.ToString();
                idkg = GridControl.CurrentRow.Cells["col_id"].Value.ToString();
                if (Convert.ToBoolean(GridControl.CurrentRow.Cells["col_sts_sal"].Value) == true)
                {
                    datos.EjecutarSql("update orden_aux set imp='1',fec_salida=cast(GETDATE() as date) where id='" + id + "'");
                    //MessageBox.Show("checado");
                    kg = true;
                    txtkg.Enabled = true;
                }
                else if (Convert.ToBoolean(GridControl.CurrentRow.Cells["col_sts_sal"].Value) == false)
                {

                    datos.EjecutarSql("update orden_aux set imp='0' where id='" + id + "'");
                   // MessageBox.Show(" no checado");
                    kg = false;
                }
            }
          
        }

        private void GridControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridControl.Columns[e.ColumnIndex].Name == "col_sts_sal" && GridControl.CurrentRow.Cells["col_sts_sal"].ReadOnly == true)
            {
                DialogResult result = MessageBox.Show("Este Job ya ah sido enviado, desea modificarlo", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // GridControl.Rows[i].ReadOnly = true;
                    GridControl.CurrentRow.ReadOnly = false;
                    GridControl.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                }
            }
           
        }

        private void GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode ==Keys.V){

                
                string id = "";
                int col = GridControl.CurrentCell.ColumnIndex;
                DateTime fe = DateTime.Now;
                fe.ToLongDateString();
               
                Int32 selectedCellCount =
                GridControl.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {                                         
                       for (int i = 0;
                            i < selectedCellCount; i++)
                        {
                            
                            
                            int filas = GridControl.SelectedCells[i].RowIndex;

                            int columnas = GridControl.SelectedCells[i].ColumnIndex;

                            //MessageBox.Show(filas.ToString());
                            //MessageBox.Show(columnas.ToString());

                            id = GridControl.Rows[filas].Cells["col_id"].Value.ToString();
                            //if (GridControl.Rows[filas].Cells["col_kg"].Value.ToString() != "0" || GridControl.Rows[filas].Cells["col_kg"].Value.ToString() != "")
                            //{
                            //     valor_copia = GridControl.Rows[filas].Cells["col_kg"].Value.ToString();
                            //    MessageBox.Show(valor_copia);
                            //}
                            GridControl.Rows[filas].Cells["col_kg"].Value = valor_copia;
                            datos.EjecutarSql("update orden_aux set kg='" + valor_copia + "' where id='" + id + "'");
                          

                       
                    }
                }
            }
        }

        private void GridControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridControl.Columns[e.ColumnIndex].Name == "col_kg") {
                valor_copia = GridControl.CurrentRow.Cells["col_kg"].Value.ToString();
            
            }
        }

        private void txtkg_Leave(object sender, EventArgs e)
        {

            if (txtkg.Text != String.Empty && txtorden.Text!=String.Empty) {
                datos.EjecutarSql("update orden_aux set kg='"+txtkg.Text+"' where imp='1' and folio='"+txtorden.Text+"' ");
            }
        }
    }
}
