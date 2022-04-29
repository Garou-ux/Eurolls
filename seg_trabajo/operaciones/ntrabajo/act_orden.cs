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
namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class act_orden : Form
    {
        Conexion datos = new Conexion();
        seg_trabajo.inicio.menu m = new inicio.menu();
        public string job,proc,fec,i, n,fol,usu;
        public int foli;
        bool ejec;
        public act_orden()
        {
            InitializeComponent();
        }

        private void act_orden_Load(object sender, EventArgs e)
        {
            txtjob.Text = job;
            txtproc.Text = proc;
            txtusu.Text = i;
           // MessageBox.Show(foli.ToString());
        }

      
        private void btnact_Click(object sender, EventArgs e)
        {
            /*
             * 	@fol varchar(50),
	@job varchar(200),
	@fec varchar(100),
	@usu varchar(200),
	@cor bit,
	@des bit,
	@des2 bit,
	@des3 bit,
	@marc bit,
	@aguj bit,
	@temp bit,
	@temp2 bit,
	@temp3 bit,
	@esp bit,
	@diam_int bit,
	@diam_int2 bit,
	@cu bit,
	@aca bit,
	@pul bit
             * */
            if (txtusu.Text != string.Empty && txtcon.Text != string.Empty)
            {
                DateTime fe = DateTime.Now;

                fe.ToLongDateString();
                //MessageBox.Show(foli.ToString());
                string actualizar = "exec actualizar_proceso " + foli + ", '" + txtjob.Text + "','" + fe + "','" + txtusu.Text + "'," + rbcorte.Checked + "," + rbdes.Checked + "," + rddes2.Checked + "," + rddes3.Checked + "," + rbmarc.Checked + "," + rdaguj.Checked + "," + rbtemp.Checked + "," + rbtemp2.Checked + "," + rbtemp3.Checked + "," + rbesp.Checked + "," + rdint1.Checked + "," + rdint2.Checked + "," + rbcu.Checked + "," + rbacab.Checked + "," + rbpul.Checked + ","+rbRevision.Checked+",'"+n+"',"+rbacces.Checked+" ";
                //  string sts;            
                datos.EjecutarSql(actualizar);
                MessageBox.Show("Proceso completado");
                btnact.Enabled = false;
                txtcon.Text = "";
            }
            else { MessageBox.Show("Captura las iniciales y tu contraseña"); }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            segTrabajo st = new segTrabajo();
         
            //st.Close();
          
            st.num = n;
            st.cargar_grid();
            st.Show();
            Close();
        }

        private void txtcon_Leave(object sender, EventArgs e)
        {
            string validar = datos.Resultado("exec autoriza '"+txtusu.Text+"','"+txtcon.Text+"'");

            if (validar == "pasa") {
                btnact.Enabled = true;
            }
        }

        private void btnproces_Click(object sender, EventArgs e)
        {
            if (txtusu.Text != string.Empty && txtcon.Text != string.Empty)
            {
                DateTime fe = DateTime.Now;

                fe.ToLongDateString();
                string actualizar = "exec Omitir_proceso " + foli + ", '" + txtjob.Text + "','" + fe + "','" + txtusu.Text + "'," + rbcorte.Checked + "," + rbdes.Checked + "," + rddes2.Checked + "," + rddes3.Checked + "," + rbmarc.Checked + "," + rdaguj.Checked + "," + rbtemp.Checked + "," + rbtemp2.Checked + "," + rbtemp3.Checked + "," + rbesp.Checked + "," + rdint1.Checked + "," + rdint2.Checked + "," + rbcu.Checked + "," + rbacab.Checked + "," + rbpul.Checked + " ";
                //  string sts;            
                datos.EjecutarSql(actualizar);
                MessageBox.Show("Proceso completado");
                btnact.Enabled = false;
                txtcon.Text = "";
            }
            else { MessageBox.Show("Captura las iniciales y tu contraseña"); }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            segTrabajo st = new segTrabajo();

            //st.Close();

            st.num = n;
            st.nom = usu;
            st.cargar_grid();
            st.Show();
            Close();
        }
    }
}
