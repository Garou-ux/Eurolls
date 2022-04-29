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
using Microsoft.VisualBasic;
namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class segTrabajo : Form
    {
        Conexion datos = new Conexion();
        public string num,ini;
        public string nom;
        public segTrabajo()
        {
            InitializeComponent();
            if (nom == "David" || nom == "admin") { label5.Visible = true; } else { label5.Visible = false; }
        }

       public void cargar_grid() {
            string query = "exec consultar_seg '" + num + "'";
            SqlDataReader dr = datos.obtenerRegistro(query);
            //  MessageBox.Show(query);
            gridSeg.Rows.Clear();
            if (dr.HasRows)
            {

                int i = 0;
                while (dr.Read())
                {
                    gridSeg.Rows.Add();
                    gridSeg.Rows[i].Cells["col_job"].Value = dr["job"].ToString();
                    gridSeg.Rows[i].Cells["col_pos"].Value = dr["posicion"].ToString();
                    gridSeg.Rows[i].Cells["col_med"].Value = dr["medida"].ToString();
                 //   gridSeg.Rows[i].Cells["col_esp"].Value = dr["espesor"].ToString();
                   // gridSeg.Rows[i].Cells["col_dext"].Value = dr["diametroext"].ToString();
                    //gridSeg.Rows[i].Cells["col_espcorte"].Value = dr["espesorcorte"].ToString();
                    gridSeg.Rows[i].Cells["col_acero"].Value = dr["acero"].ToString();
                    gridSeg.Rows[i].Cells["col_acces"].Value = dr["acces"].ToString();
                    gridSeg.Rows[i].Cells["col_corte"].Value = dr["corte"].ToString();
                    gridSeg.Rows[i].Cells["col_des"].Value = dr["desbaste"].ToString();
                    gridSeg.Rows[i].Cells["col_des2"].Value = dr["desb2"].ToString();
                    gridSeg.Rows[i].Cells["col_des3"].Value = dr["desb3"].ToString();
                    gridSeg.Rows[i].Cells["col_marc"].Value = dr["marcado"].ToString();
                    gridSeg.Rows[i].Cells["col_temp"].Value = dr["templado"].ToString();
                    gridSeg.Rows[i].Cells["col_temp2"].Value = dr["temp2"].ToString();
                    gridSeg.Rows[i].Cells["col_temp3"].Value = dr["temp3"].ToString();
                    gridSeg.Rows[i].Cells["col_espes"].Value = dr["esp"].ToString();
                    gridSeg.Rows[i].Cells["col_inter"].Value = dr["dmfin"].ToString();
                    gridSeg.Rows[i].Cells["col_inter2"].Value = dr["dlfin"].ToString();
                    gridSeg.Rows[i].Cells["col_acab"].Value = dr["acabado"].ToString();
                    gridSeg.Rows[i].Cells["col_cuñ"].Value = dr["cu"].ToString();
                    gridSeg.Rows[i].Cells["col_pul"].Value = dr["pulido"].ToString();
                    gridSeg.Rows[i].Cells["col_aguj"].Value = dr["aguj"].ToString();
                    gridSeg.Rows[i].Cells["col_revi"].Value = dr["revision"].ToString();
                    gridSeg.Rows[i].Cells["col_id"].Value = dr["id"].ToString();
                    gridSeg.Rows[i].Cells["col_fol"].Value = dr["folio"].ToString();
                    gridSeg.Rows[i].Cells["col_revi"].Value = dr["revision"].ToString();
                    if (gridSeg.Rows[i].Cells["col_acces"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_acces"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_acces"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_acces"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_acces"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_corte"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_corte"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_corte"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_corte"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_corte"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_des"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_des"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_des"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_des"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_des"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_des2"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_des2"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_des2"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_des2"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_des2"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_des3"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_des3"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_des3"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_des3"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_des3"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_marc"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_marc"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_marc"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_marc"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_marc"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_aguj"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_aguj"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_aguj"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_aguj"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_aguj"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_temp"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_temp"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_temp"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_temp"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_temp"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_temp2"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_temp2"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_temp2"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_temp2"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_temp2"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_temp3"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_temp3"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_temp3"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_temp3"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_temp3"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_espes"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_espes"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_espes"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_espes"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_espes"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_inter"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_inter"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_inter"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_inter"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_inter"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_inter2"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_inter2"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_inter2"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_inter2"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_inter2"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_acab"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_acab"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_acab"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_acab"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_acab"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_cuñ"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_cuñ"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_cuñ"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_cuñ"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_cuñ"].Style.BackColor = Color.LightGray; }
                    if (gridSeg.Rows[i].Cells["col_pul"].Value.ToString() != "" && gridSeg.Rows[i].Cells["col_pul"].Value.ToString() != "N/A") { gridSeg.Rows[i].Cells["col_pul"].Style.BackColor = Color.ForestGreen; } else if (gridSeg.Rows[i].Cells["col_pul"].Value.ToString() == "N/A") { gridSeg.Rows[i].Cells["col_pul"].Style.BackColor = Color.LightGray; }
                    i += 1;
                }
            }
            else { MessageBox.Show("No hay datos por mostrar"); }
        
        }

        private void btnej_Click(object sender, EventArgs e)
        {
          
        }

     

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void gridSeg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSeg.Columns[e.ColumnIndex].Name=="col_act" && e.RowIndex>=0) {
                // MessageBox.Show("hola");
                //#region inserta en seg
                //for (int f = 0; f < gridSeg.Rows.Count - 1; f++)
                //{
                //    string j = gridSeg.Rows[f].Cells["col_job"].Value.ToString(); // this.gridSeg.CurrentRow.Cells["col_job"].Value.ToString();
                //    string idox = gridSeg.Rows[f].Cells["col_id"].Value.ToString();
                //    string seg = "exec act_seg'" + txtfol.Text + "','"+j+"','"+idox+"'";
                //    datos.EjecutarSql(seg);
                //}
                //#endregion
                string pr = "exec obtener_proceso '" + this.gridSeg.CurrentRow.Cells["col_id"].Value.ToString() + "'";
                operaciones.ntrabajo.act_orden act = new act_orden();
                act.job =this.gridSeg.CurrentRow.Cells["col_job"].Value.ToString();
                act.proc = datos.Resultado(pr);
               // act.fec = dtfec.Value.ToString("yyyy/MM/dd H:m:s");
                act.foli = Convert.ToInt32( this.gridSeg.CurrentRow.Cells["col_id"].Value);
                act.usu = nom;
                act.i = ini;
                act.n = num;
                //MessageBox.Show(dtfec.Value.ToString("yyyy/MM/dd H:m:s"));
                act.ShowDialog();
                Close();
            //}
            //if (gridSeg.Columns[e.ColumnIndex].Name == "col_dim" && e.RowIndex >= 0)
            //{
            //    dimensiones dim = new dimensiones();
            //    dim.ShowDialog();
            //   // Close();
            }
        }
        void cargarimagen() {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image im = Properties.Resources.actualizar;
            img.Image = im;
            gridSeg.Columns.Add(img);
            img.HeaderText = "Actualizar";
            img.Name = "col_actualizar";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            img.Width = 60;
        }
        private void segTrabajo_Load(object sender, EventArgs e)
        {
            //cargarimagen();
            txtfol.Text = num;
            this.Text = "Consultar Proceso"+ num;
            txtcli.Text = datos.Resultado("select c.nom from clientes c  inner join orden_aux o on o.cli=c.cve where o.folio='"+num+"' group by c.nom");
            cargar_grid();
            #region inserta en seg
            for (int f = 0; f < gridSeg.Rows.Count - 1; f++)
            {
                string j = gridSeg.Rows[f].Cells["col_job"].Value.ToString(); // this.gridSeg.CurrentRow.Cells["col_job"].Value.ToString();
                string idox = gridSeg.Rows[f].Cells["col_id"].Value.ToString();
                string seg = "exec act_seg'" + txtfol.Text + "','" + j + "','" + idox + "'";
                datos.EjecutarSql(seg);
            }
            #endregion
        }
        #region obtener valores seleccionados
        private void Filas_seleccionadas(object sender, System.EventArgs e, string inici)
        {
            //Int32 selectedCellCount =
            //    gridSeg.GetCellCount(DataGridViewElementStates.Selected);               
                string id = "";
                int col = gridSeg.CurrentCell.ColumnIndex;
                DateTime fe = DateTime.Now;
                fe.ToLongDateString();
                /*
                 @fol int,
	@idox varchar(20),
	@fec varchar(200),
	@usu varchar(200),
	@num varchar(100)
                 */
             
                //for (int i = 0; i < selectedCellCount; i++){
                //    if (selectedCellCount ==1)
                //    {
                //        id = gridSeg.CurrentRow.Cells["col_id"].Value.ToString();
                //    }
                //    else if(selectedCellCount > 1)
                //    {
                //        id = gridSeg.Rows[i].Cells["col_id"].Value.ToString();
                //    }
                //      string actualizar = "exec Actualizar_proc '" + col + "','" + id + "','" + fe + "','" +inici + "','"+num+"'";
                //      MessageBox.Show(actualizar);
                //      datos.EjecutarSql(actualizar);
                //    }
                //MessageBox.Show("Proceso completado"); 
                Int32 selectedCellCount =
            gridSeg.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    if (gridSeg.AreAllCellsSelected(true))
                    {
                        //MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        System.Text.StringBuilder sb =
                            new System.Text.StringBuilder();

                        for (int i = 0;
                            i < selectedCellCount; i++)
                        {
                            //sb.Append("Row: ");
                            //sb.Append(gridSeg.SelectedCells[i].RowIndex
                            //    .ToString());
                            //sb.Append(", Column: ");
                            //sb.Append(gridSeg.SelectedCells[i].ColumnIndex
                            //    .ToString());
                            //sb.Append(Environment.NewLine);
                            int filas = gridSeg.SelectedCells[i].RowIndex;

                            int columnas = gridSeg.SelectedCells[i].ColumnIndex;

                            //MessageBox.Show(filas.ToString());
                            //MessageBox.Show(columnas.ToString());
                            id= gridSeg.Rows[filas].Cells["col_id"].Value.ToString();
                            //MessageBox.Show(id);
                            string actualizar = "exec Actualizar_proc '" + col + "','" + id + "','" + fe + "','" + inici + "','" + num + "'";
                            //MessageBox.Show(actualizar);
                            string res = datos.Resultado(actualizar);

                            if (res == "no prro") { MessageBox.Show("primero hay que actualizar el proceso anterior"); }
                            else
                            {
                                string inserta = "exec porcentaje_usus '" + num + "','" + inici + "'";
                                datos.EjecutarSql(inserta);
                            }
                        }

                        //sb.Append("Total: " + selectedCellCount.ToString());
                        //MessageBox.Show(sb.ToString(), "Selected Cells");
                        MessageBox.Show("Proceso completado");
                    }
                }
            
           
        }
        #endregion
        #region omitir/actualizar proceso
        private void gridSeg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int col = gridSeg.CurrentCell.ColumnIndex;

                int idox = Convert.ToInt32(gridSeg.CurrentRow.Cells["col_id"].Value);
                var usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese sus iniciales", ini);
                var contraseña = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su contraseña",ini);
                string validar = datos.Resultado("exec autoriza '" + usuario + "','" + contraseña + "'");

                if (validar == "pasa")
                {
                    DialogResult result = MessageBox.Show("Deseas actualizar este proceso", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Filas_seleccionadas(sender, e,usuario);
                        gridSeg.Rows.Clear();
                        cargar_grid();
                    }

                }
                else { MessageBox.Show("Iniciales o contraseña invalidos"); }

            }
        }

        #endregion


        private void gridSeg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nom == "David" || nom == "admin")
            {
                int col = gridSeg.CurrentCell.ColumnIndex;

                int idox = Convert.ToInt32(gridSeg.CurrentRow.Cells["col_id"].Value);
                DialogResult result = MessageBox.Show("Deseas omitir este proceso", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string act = "exec omitir_proceso2 " + col + ",'" + idox + "'";
                    //  MessageBox.Show(act);
                    datos.EjecutarSql(act);
                    gridSeg.Rows.Clear();
                    cargar_grid();
                }
            }
        }

        private void txtbusqueda_Leave(object sender, EventArgs e)
        {
            string searchValue = txtbusqueda.Text;

             //gridSeg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             try
             {
            foreach (DataGridViewRow row in gridSeg.Rows)
            {
                if ((row.Cells[2].Value.ToString().StartsWith(searchValue) == true || row.Cells[2].Value.ToString().Equals(searchValue)) || (row.Cells[0].Value.ToString().StartsWith(searchValue) == true || row.Cells[0].Value.ToString().Equals(searchValue)))
                {
                   // gridSeg.Rows[2].Selected = true;
                    row.Selected = true;
                     break;
                }
            }
            }
               catch (Exception exc)
             {
                 MessageBox.Show(exc.Message);
             }
        }

        private void gridSeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nom == "David" || nom == "admin")
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    int idox = Convert.ToInt32(gridSeg.CurrentRow.Cells["col_id"].Value);
                    int col = gridSeg.CurrentCell.ColumnIndex;
                     DialogResult result = MessageBox.Show("¿Deseas borrar el proceso?", "", MessageBoxButtons.YesNo);
                     if (result == DialogResult.Yes)
                     {
                         string act = "exec Revivir_proc " + col + ",'" + idox + "'";
                         //  MessageBox.Show(act);
                         datos.EjecutarSql(act);
                         gridSeg.Rows.Clear();
                         cargar_grid();
                     }
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            datos.exportaexcel(gridSeg);

            Cursor.Current = Cursors.Default;
        }
    }
}
