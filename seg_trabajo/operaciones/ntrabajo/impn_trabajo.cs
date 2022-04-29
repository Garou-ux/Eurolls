using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class impn_trabajo : Form
    {
        public impn_trabajo()
        {
            InitializeComponent();
        }
        public string folio;
        private void impn_trabajo_Load(object sender, EventArgs e)
        {
            this.dataSetorden.EnforceConstraints = false;
      // this.reporteordenTableAdapter.Connection.ConnectionString = "Data Source=SERVER\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=daonsa2;Password=Francisco1";
            this.reporteordenTableAdapter.Connection.ConnectionString = "Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001";
          this.reporteordenTableAdapter.Fill(this.dataSetorden.Reporteorden,folio);

            this.reportViewer1.RefreshReport();
        }
    }
}
