using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seg_trabajo.reportes
{
    public partial class rep_historico : Form
    {
        Conexion datos = new Conexion();
        public rep_historico()
        {
            InitializeComponent();
            datos.cargarcombo(comboClientes,"select cve,nom from clientes","cve","nom");
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            imp_hist ih = new imp_hist();
            ih.feci = feci.Value;
            ih.fecf = fecf.Value;
            ih.cliente = comboClientes.SelectedValue.ToString();
            ih.ord = rbord.Checked;
            ih.pza = rbpza.Checked;
            ih.Show();
        }
    }
}
