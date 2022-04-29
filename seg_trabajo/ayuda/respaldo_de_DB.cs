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
namespace seg_trabajo.ayuda
{
    public partial class respaldo_de_DB : Form
    {
        Conexion datos = new Conexion();
        public respaldo_de_DB()
        {
            InitializeComponent();
        }

        private void btn_respaldo_Click(object sender, EventArgs e)
        {
            datos.EjecutarSql("exec copiaBD");
            MessageBox.Show("Proceso completado correctamente");
        }
    }
}
