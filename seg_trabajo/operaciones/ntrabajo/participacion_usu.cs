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
using System.Windows.Forms.DataVisualization.Charting;
namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class participacion_usu : Form
    {
        Conexion datos = new Conexion();
        //DataTable dt;
        //SqlDataAdapter da;
        //DataRow dr;
        string consulta_grafica;
        public participacion_usu()
        {
            InitializeComponent();
        }

        private void participacion_usu_Load(object sender, EventArgs e)
        {
            string parti = "exec participacion ''";
            datos.ActualizarGrid(gridpar,parti);
            //gridpar.Rows[0].ReadOnly = true; 
            //gridpar.Rows[1].ReadOnly = true;
            //gridpar.Rows[2].ReadOnly = true;
            //gridpar.Columns[1].Width=300;
            
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            datos.exportaexcel(gridpar);
        }
        #region busqueda de ordenes
        private void txtbusqueda_Leave(object sender, EventArgs e)
        {
            string searchValue = txtbusqueda.Text;

            //gridSeg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in gridpar.Rows)
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
        #endregion

       // comienza la pagina de graficos
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                int i = 0;
                consulta_grafica = "exec participacion '" + textBox1.Text + "'";
                SqlDataReader dr = datos.obtenerRegistro(consulta_grafica);
                    Title title = new Title();
                    title.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        title.Text = "Participación de operadores para la Orden " + textBox1.Text;
        textBox1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                this.grafi_parti.Titles.Add(title);
                
                while (dr.Read())
                {

                    Series series = this.grafi_parti.Series.Add(dr["Operador"].ToString());
                    series.Points.Add(Convert.ToDouble(dr["Participación"].ToString()));
                    i += 1;
                }
            }
          
        }


        //termina pagina de graficos

    }
}
