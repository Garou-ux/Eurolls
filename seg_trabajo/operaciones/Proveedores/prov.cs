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
namespace seg_trabajo.operaciones.Proveedores
{
    public partial class prov : Form
    {
        Conexion datos = new Conexion();
        public prov()
        {
            InitializeComponent();
        }

        #region actualiza/guardaelproveedor
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcve.Text != String.Empty)
            {
                
                datos.EjecutarSql(" if exists (select cve from Proveedores where cve='"+txtcve.Text+"') "
                    + " begin update Proveedores set nom='"+txtnom.Text+"' where cve='"+txtcve.Text+"' end else "
                + " begin  insert into Proveedores(cve,nom) values('"+txtcve.Text+"','"+txtnom.Text+"') end ");
                MessageBox.Show("Proceso completado");
                datos.LimpiarCampos(this);
            }
        }
        #endregion
        #region elimina
        private void btneliminar_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Deseas eliminar este proveedor", "", MessageBoxButtons.YesNo);
              if (result == DialogResult.Yes)
              {
                  datos.EjecutarSql("delete from Proveedores where cve='"+txtcve.Text+"'");
                  MessageBox.Show("Proceso comppletado");
                  datos.LimpiarCampos(this);
              }
        }
        #endregion
    }
}
