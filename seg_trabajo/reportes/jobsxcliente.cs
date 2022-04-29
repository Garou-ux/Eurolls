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
namespace seg_trabajo.reportes
{
    public partial class jobsxcliente : Form
    {
        Conexion datos = new Conexion();
        bool clis=false;
        public jobsxcliente()
        {
            InitializeComponent();
        }

        private void jobsxcliente_Load(object sender, EventArgs e)
        {
            datos.cargarcombo(comboclis, "select cve,nom from clientes","cve","nom");
        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            imprep imp = new imprep();
            imp.feci = feci.Value;
            imp.fecf = fecf.Value;
            imp.cli = comboclis.SelectedValue.ToString();
            imp.filtroxcli = clis;
            imp.Show();
        }

        private void comboclis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clis = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
