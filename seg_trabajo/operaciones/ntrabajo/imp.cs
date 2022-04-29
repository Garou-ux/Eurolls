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
    public partial class imp : Form
    {
        public imp()
        {
            InitializeComponent();
        }

        private void btniimp_Click(object sender, EventArgs e)
        {
            operaciones.ntrabajo.impn_trabajo im = new impn_trabajo();

            im.folio = txtfol.Text;
            im.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
