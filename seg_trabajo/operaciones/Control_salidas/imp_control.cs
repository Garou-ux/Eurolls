using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seg_trabajo.operaciones.Control_salidas
{
    public partial class imp_control : Form
    {
        public imp_control()
        {
            InitializeComponent();
        }
        public string folio;
        private void imp_control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetControl.Reporte_control' table. You can move, or remove it, as needed.
            this.DataSetControl.EnforceConstraints = false;
            this.dataSetpzas.EnforceConstraints = false;
            this.Reporte_controlTableAdapter.Connection.ConnectionString = "Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001";
            this.rep_totalesTableAdapter.Connection.ConnectionString = "Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001";
            this.Reporte_controlTableAdapter.Fill(this.DataSetControl.Reporte_control,folio);
            this.rep_totalesTableAdapter.Fill(dataSetpzas.Rep_totales,folio);
            this.reportViewer1.RefreshReport();
        }
    }
}
