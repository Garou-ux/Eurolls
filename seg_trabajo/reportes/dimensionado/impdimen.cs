using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seg_trabajo.reportes.dimensionado
{
    public partial class impdimen : Form
    {
        public impdimen()
        {
            InitializeComponent();
        }
        public string fol;
        private void impdimen_Load(object sender, EventArgs e)
        {
            dataSetdimen.EnforceConstraints = false;
            this.dimensionadoTableAdapter.Connection.ConnectionString = "Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001";
            this.dimensionadoTableAdapter.Fill(dataSetdimen.Dimensionado,fol);
            this.reportViewer1.RefreshReport();
        }
    }
}
