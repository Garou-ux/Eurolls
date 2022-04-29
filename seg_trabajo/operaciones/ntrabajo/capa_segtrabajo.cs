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
    public partial class capa_segtrabajo : Form
    {
        Conexion ManipularDatos = new Conexion();
        public string inicial,nom;
        public capa_segtrabajo()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (txtorden.Text != string.Empty)
            {
                string validar = ManipularDatos.Resultado("validar_orden '" + txtorden.Text + "'");
                if (validar == "existe")
                {
                    segTrabajo st = new segTrabajo();

                    st.num = txtorden.Text;
                st.ini= inicial;
                st.nom = nom;
                    st.Show();
                    Close();
                }
                
                }
                else { MessageBox.Show("La orden no existe"); }
            }
        

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
