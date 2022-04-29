using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class consultar_activos : Form
    {
        seg_trabajo.Conexion datos = new Conexion();
        public consultar_activos()
        {
            InitializeComponent();
           // consulta();
            //datos.cargarcombo(comboClientes,"select cve,nom from clientes","cve","nom");
        }
        private void consulta()
        {
           datos.ActualizarGrid(gridConsulta, "exec Status_deOrden "+rbactivo.Checked+","+rbcompletado.Checked+"");

         //   for (int i = 0; i < gridConsulta.Rows.Count - 1; i++) {
              //  gridConsulta.Rows[i].Cells["Status"].Style.BackColor = Color.ForestGreen;
                // gridSeg.Rows[i].Cells["col_des3"].Style.BackColor = Color.ForestGreen;
           // }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
         //   datos.ActualizarGrid(gridConsulta, "exec Status_deOrden 1,0,'" + feci.Text + "','" + fecf.Text + "','" + comboClientes.SelectedValue.ToString() + "'");  
        }

        private void rbactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbactivo.Checked == true) {
                consulta();
            }
        }

        private void rbcompletado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcompletado.Checked == true) {
                consulta();
            }
        }

        private void consultar_activos_Load(object sender, EventArgs e)
        {

        }
    }
    
}
