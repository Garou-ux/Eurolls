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
    public partial class imprep : Form
    {
        public imprep()
        {
            InitializeComponent();
        }
        /*
         * @feci date,
	@fecf date,
	@cli varchar(50),
	@filtroxcli bit
         * */
        public DateTime feci, fecf;
        public string cli;
        public bool filtroxcli;

        private void imprep_Load(object sender, EventArgs e)
        {
            this.dataSetclijobs.EnforceConstraints = false;
            this.reporteclijobsTableAdapter.Fill(this.dataSetclijobs.Reporteclijobs,feci,fecf,cli,filtroxcli);
            this.reportViewer1.RefreshReport();
        }
    }
}
