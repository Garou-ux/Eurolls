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
    public partial class dimensiones : Form
    {
        Conexion datos = new Conexion();
        public dimensiones()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void gridDimensiones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            #region calculo de diferenciales
            string dif = "";
            string id,real = "";
            SqlDataReader dr;
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_realdext") {
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["col_realdext"].Value.ToString();
                dif = "exec diferenciales '"+id+"','"+real+"',1,0,0,0,0,0,0,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows) {
                    while (dr.Read()) {
                        gridDimensiones.CurrentRow.Cells["col_difdext"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde") {
                            gridDimensiones.CurrentRow.Cells["col_difdext"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["col_difdext"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_realdint")
            {
                //MessageBox.Show("realdint");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["col_realdint"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,1,0,0,0,0,0,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gridDimensiones.CurrentRow.Cells["coldif_dint"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde")
                        {
                            gridDimensiones.CurrentRow.Cells["coldif_dint"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["coldif_dint"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_realesp")
            {
                //MessageBox.Show("realesp");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["col_realesp"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,0,1,0,0,0,0,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gridDimensiones.CurrentRow.Cells["coldif_esp"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde")
                        {
                            gridDimensiones.CurrentRow.Cells["coldif_esp"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["coldif_esp"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_realcu")
            {
                //MessageBox.Show("realcu");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["col_realcu"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,0,0,1,0,0,0,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gridDimensiones.CurrentRow.Cells["coldif_cu"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde")
                        {
                            gridDimensiones.CurrentRow.Cells["coldif_cu"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["coldif_cu"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_realprof")
            {
                //MessageBox.Show("realprof");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["col_realprof"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,0,0,0,1,0,0,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gridDimensiones.CurrentRow.Cells["coldif_prof"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde")
                        {
                            gridDimensiones.CurrentRow.Cells["coldif_prof"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["coldif_prof"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }


            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_dur") {
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                string dure = gridDimensiones.CurrentRow.Cells["col_dur"].Value.ToString();
                datos.EjecutarSql("update dimensionales set dureza='"+dure+"' where id='"+id+"'");

            }
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "col_realdur")
            {
                //MessageBox.Show("realdur");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["col_realdur"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,0,0,0,0,1,0,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                      //  gridDimensiones.CurrentRow.Cells["col_realdur"].Value = dr["diferencia"].ToString();
                       
                    }
                }
            }

            if (gridDimensiones.Columns[e.ColumnIndex].Name == "real_profcum")
            {
                //MessageBox.Show("prof_cum");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["real_profcum"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,0,0,0,0,0,1,0";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gridDimensiones.CurrentRow.Cells["dif_profcum"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde")
                        {
                            gridDimensiones.CurrentRow.Cells["dif_profcum"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["dif_profcum"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }
            if (gridDimensiones.Columns[e.ColumnIndex].Name == "real_dm")
            {
                //MessageBox.Show("diam_m");
                id = gridDimensiones.CurrentRow.Cells["col_id"].Value.ToString();
                real = gridDimensiones.CurrentRow.Cells["real_dm"].Value.ToString();
                dif = "exec diferenciales '" + id + "','" + real + "',0,0,0,0,0,0,0,1";
                dr = datos.obtenerRegistro(dif);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        gridDimensiones.CurrentRow.Cells["dif_dm"].Value = dr["diferencia"].ToString();
                        if (dr["Color"].ToString() == "Verde")
                        {
                            gridDimensiones.CurrentRow.Cells["dif_dm"].Style.BackColor = Color.ForestGreen;
                        }
                        else { gridDimensiones.CurrentRow.Cells["dif_dm"].Style.BackColor = Color.Firebrick; }
                    }
                }
            }
            #endregion
        }

        private void txtfol_Leave(object sender, EventArgs e)
        {
            #region muestra las dimensiones
            if (txtfol.Text != String.Empty)
            {
                int i = 0;
                SqlDataReader k = datos.obtenerRegistro("exec Dimensionado '" + txtfol.Text + "'");
                if (k.HasRows)
                {
                    gridDimensiones.Rows.Clear();
                    while (k.Read())
                    {
                        txtmol.Text = k["molino"].ToString();
                        txtinsp.Text = k["insp"].ToString();
                        txtprod.Text = k["prod"].ToString();
                        if (k["prod"].ToString() == "Vernier") { rbverni.Checked = true; }
                        else if (k["prod"].ToString() == "Micrometro") { rbmic.Checked = true; }
                        else if (k["prod"].ToString() == "Bore Gage") { rbgag.Checked = true; }
                        gridDimensiones.Rows.Add();
                        gridDimensiones.Rows[i].Cells["col_job"].Value = k["job"].ToString();
                        gridDimensiones.Rows[i].Cells["col_pos"].Value = k["pos"].ToString();
                        gridDimensiones.Rows[i].Cells["col_diamext"].Value = k["diam_ext"].ToString();
                        gridDimensiones.Rows[i].Cells["li_diamext"].Value = k["li_diamext"].ToString();
                        gridDimensiones.Rows[i].Cells["lf_diamext"].Value = k["lf_diamext"].ToString();
                        gridDimensiones.Rows[i].Cells["col_realdext"].Value = k["real_dext"].ToString();
                        gridDimensiones.Rows[i].Cells["col_difdext"].Value = k["dif_dext"].ToString();
                        gridDimensiones.Rows[i].Cells["col_dint"].Value = k["diam_int"].ToString();
                        gridDimensiones.Rows[i].Cells["li_diamint"].Value = k["li_diamint"].ToString();
                        gridDimensiones.Rows[i].Cells["lf_diamint"].Value = k["lf_diamint"].ToString();
                        gridDimensiones.Rows[i].Cells["col_realdint"].Value = k["real_dint"].ToString();
                        gridDimensiones.Rows[i].Cells["coldif_dint"].Value = k["dif_dint"].ToString();
                        gridDimensiones.Rows[i].Cells["col_esp"].Value = k["esp_dibujo"].ToString();
                        gridDimensiones.Rows[i].Cells["li_esp"].Value = k["li_esp"].ToString();
                        gridDimensiones.Rows[i].Cells["lf_esp"].Value = k["lf_esp"].ToString();
                        gridDimensiones.Rows[i].Cells["col_realesp"].Value = k["real_esp"].ToString();
                        gridDimensiones.Rows[i].Cells["coldif_esp"].Value = k["dif_esp"].ToString();
                        gridDimensiones.Rows[i].Cells["col_cu"].Value = k["cunero"].ToString();
                        gridDimensiones.Rows[i].Cells["li_cu"].Value = k["li_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["lf_cu"].Value = k["lf_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["col_realcu"].Value = k["real_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["coldif_cu"].Value = k["dif_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["col_profcu"].Value = k["prof_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["li_profcu"].Value = k["li_profcu"].ToString();
                        gridDimensiones.Rows[i].Cells["lf_profcu"].Value = k["lf_profcu"].ToString();
                        gridDimensiones.Rows[i].Cells["col_realprof"].Value = k["real_prof_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["coldif_prof"].Value = k["dif_prof_cu"].ToString();
                        gridDimensiones.Rows[i].Cells["col_dur"].Value = k["dureza"].ToString();
                        gridDimensiones.Rows[i].Cells["col_realdur"].Value = k["real_dur"].ToString();
                        gridDimensiones.Rows[i].Cells["diam_m"].Value = k["diam_int_m"].ToString();
                        gridDimensiones.Rows[i].Cells["tmax_men"].Value = k["li_diam_int_m"].ToString();
                        gridDimensiones.Rows[i].Cells["tmin_m"].Value = k["li_diam_int_m"].ToString();
                        gridDimensiones.Rows[i].Cells["real_dm"].Value = k["real_dm"].ToString();
                        gridDimensiones.Rows[i].Cells["dif_dm"].Value = k["dif_dm"].ToString();


                        gridDimensiones.Rows[i].Cells["prof_cum"].Value = k["prof_m"].ToString();
                        gridDimensiones.Rows[i].Cells["tmax_prof_cum"].Value = k["li_profm"].ToString();
                        gridDimensiones.Rows[i].Cells["tmin_prof_cum"].Value = k["lf_profm"].ToString();
                        gridDimensiones.Rows[i].Cells["real_profcum"].Value = k["real_profm"].ToString();
                        gridDimensiones.Rows[i].Cells["dif_profcum"].Value = k["dif_profm"].ToString();
                        gridDimensiones.Rows[i].Cells["col_id"].Value = k["id"].ToString();


                        i++;

                    }
                }
            }
            #endregion
        }

        private void txtfol_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.EnterTab(e);
        }

        private void btnguar_Click(object sender, EventArgs e)
        {
            #region guarda el enc
            if (txtfol.Text != String.Empty) {
                /*
                 * @folio varchar(200),
	@molino varchar(200),
	@prod varchar(200),
	@equip varchar(200)
                 * */
                string equipo = "";
                if (rbverni.Checked == true && rbgag.Checked == false && rbmic.Checked == false) { equipo = "Vernier"; }
                else if (rbmic.Checked == true && rbverni.Checked == false && rbgag.Checked == false) { equipo = "Micrometro"; }
                else if (rbgag.Checked == true && rbverni.Checked == false && rbmic.Checked == false) { equipo = "Bore Gage"; }
                else if (rbmic.Checked == true && rbverni.Checked == true && rbgag.Checked == false) { equipo = "Micrometro/Vernier"; }
                else if (rbgag.Checked == true && rbverni.Checked == true && rbmic.Checked == true) { equipo = "Bore Gage/Vernier/Micrometro"; }
                else if (rbgag.Checked == true && rbverni.Checked == true && rbmic.Checked == false) { equipo = "Bore Gage/Vernier"; }
                else if (rbgag.Checked == true && rbmic.Checked == true && rbverni.Checked == false) { equipo = "Bore Gage/Micrometro"; }
                string guarda = "exec guardar_Enc '"+txtfol.Text+"','"+txtmol.Text+"','"+txtprod.Text+"','"+equipo+"','"+txtinsp.Text+"' ";
                datos.EjecutarSql(guarda);
                MessageBox.Show("Proceso completado");
            }
            #endregion
        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            if (txtfol.Text != String.Empty) {
                reportes.dimensionado.impdimen impdi = new reportes.dimensionado.impdimen();
                impdi.fol = txtfol.Text;
                impdi.Show();
            }
        }

        private void gridDimensiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfol.Text != String.Empty) {
                datos.exportaexcel(gridDimensiones);
            }
        }
    }
}
