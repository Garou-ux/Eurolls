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
    public partial class imp_hist : Form
    {
        public imp_hist()
        {
            InitializeComponent();
        }
        public DateTime feci, fecf;
        public string cliente;
        public bool pza, ord;
        private void imp_hist_Load(object sender, EventArgs e)
        {
            this.dataSetclijobs.EnforceConstraints = false;
            //this.reporteordenTableAdapter.Connection.ConnectionString = "Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001";
            this.reporte_hist_pzasTableAdapter.Connection.ConnectionString = "Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001";
            reporte_hist_pzasTableAdapter.Fill(dataSetclijobs.Reporte_hist_pzas,feci,fecf, cliente,pza,ord);
            this.reportViewer1.RefreshReport();
        }
    }
}
