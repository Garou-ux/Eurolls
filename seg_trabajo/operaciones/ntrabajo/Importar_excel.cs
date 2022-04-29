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
using System.Text.RegularExpressions;
namespace seg_trabajo.operaciones.ntrabajo
{
    public partial class Importar_excel : Form
    {
        seg_trabajo.clases_funciones.Importar imp = new clases_funciones.Importar();
        Conexion datos = new Conexion();
        public string num_orden, cliente;


        public Importar_excel()
        {
            InitializeComponent();
        }

        private void btnimpor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            imp.importarExcel(dgExcel, "ACERO");

            Cursor.Current = Cursors.Default;
            btnguardar.Enabled = true;
        }

        private void Importar_excel_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Estimado usuario, para evitar errores al momento de importar el archivo de excel, asegurese de los siguientes requisitos: "
         + " -La Hoja siempre se tiene que llamar ACERO "
         + " -No deje espacios entre filas para darle nombre a las columnas ya que tendran nombre de (A1, F1, etc..) "
         + " -Las columnas tienen que seguir el siguiente orden y tener los siguientes nombres: "
         + " -Item,codigo_acero,largo_inicial,largo_final,posicion,medida,job,espesor,diam_exterior,diam_menor,espesor_corte,acero,hrc");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            //se elimina la tabla dimen
            datos.EjecutarSql("delete from dimen");
            string id = "";
            int cont = 0;
            int filas = dgExcel.Rows.Count - 1;
            #region arrays de dimensiones
            string[] pos = new string[filas];
            string[] di = new string[filas];
            string[] di_aint = new string[filas];
            string[] esp = new string[filas];
            string[] cuñ = new string[filas];
            string[] profcu = new string[filas];
            string[] dur = new string[filas];
            #endregion

            for (int i = 0; i < dgExcel.Rows.Count - 1; i++)
            {

                #region igualar las variables a las columnas del grid
                string codigo_acero = dgExcel.Rows[i].Cells[0].Value.ToString();
                string largoi = dgExcel.Rows[i].Cells[1].Value.ToString();
                string largof = dgExcel.Rows[i].Cells[2].Value.ToString();
                string posicion = dgExcel.Rows[i].Cells[3].Value.ToString();
                string medida = dgExcel.Rows[i].Cells[4].Value.ToString();
                string job = dgExcel.Rows[i].Cells[5].Value.ToString();
                string espesor = dgExcel.Rows[i].Cells[6].Value.ToString();
                string li_esp = dgExcel.Rows[i].Cells[7].Value.ToString();
                string lf_esp = dgExcel.Rows[i].Cells[8].Value.ToString();
                string diametroext = dgExcel.Rows[i].Cells[9].Value.ToString();
                string li_diamext = dgExcel.Rows[i].Cells[10].Value.ToString();
                string lf_diamext = dgExcel.Rows[i].Cells[11].Value.ToString();
                string diametromen = dgExcel.Rows[i].Cells[12].Value.ToString();
                string li_diamint = dgExcel.Rows[i].Cells[13].Value.ToString();
                string lf_diamint = dgExcel.Rows[i].Cells[14].Value.ToString();
                string diam_int_m = dgExcel.Rows[i].Cells[15].Value.ToString();
                string tmax_diamint_m = dgExcel.Rows[i].Cells[16].Value.ToString();
                string tmin_diamint_m = dgExcel.Rows[i].Cells[17].Value.ToString();
                string cunero = dgExcel.Rows[i].Cells[18].Value.ToString();
                string li_cu = dgExcel.Rows[i].Cells[19].Value.ToString();
                string lf_cu = dgExcel.Rows[i].Cells[20].Value.ToString();
                string prof_cu = dgExcel.Rows[i].Cells[21].Value.ToString();
                string li_profcu = dgExcel.Rows[i].Cells[22].Value.ToString();
                string lf_profcu = dgExcel.Rows[i].Cells[23].Value.ToString();
                string prof_cu_m = dgExcel.Rows[i].Cells[24].Value.ToString();
                string li_profcum = dgExcel.Rows[i].Cells[25].Value.ToString();
                string lf_profcum = dgExcel.Rows[i].Cells[26].Value.ToString();
                //string dureza = dgExcel.Rows[i].Cells[27].Value.ToString();
                //string tmax_dur = dgExcel.Rows[i].Cells[28].Value.ToString();
                //string tmin_dur = dgExcel.Rows[i].Cells[29].Value.ToString();
                string espesor_corte = dgExcel.Rows[i].Cells[27].Value.ToString();
                string acero = dgExcel.Rows[i].Cells[28].Value.ToString();
                string hrc = dgExcel.Rows[i].Cells[29].Value.ToString();
                #endregion


                #region asignar valor a filas vacias
                if (espesor == "N/A") { espesor = "0.00"; }
                if (diametroext == "N/A") { diametroext = "0.00"; }
                if (diametromen == "N/A") { diametromen = "0.00"; }
                if (espesor_corte == "N/A") { espesor_corte = "0.00"; }
                // if (diamext == "N/A") { diamext = "1"; }
                if (li_diamext == "N/A") { li_diamext = "0.00"; }
                if (lf_diamext == "N/A") { lf_diamext = "0.00"; }
                // if (diam_int == "N/A") { diam_int = "0.00"; }
                if (li_diamint == "N/A") { li_diamint = "0.00"; }
                if (lf_diamint == "N/A") { lf_diamint = "0.00"; }
                //if (esp_dibujo == "N/A") { esp_dibujo = "0.00"; }
                if (li_esp == "N/A") { li_esp = "0.00"; }
                if (lf_esp == "N/A") { lf_esp = "0.00"; }
                if (cunero == "N/A") { cunero = "0.00"; }
                if (li_cu == "N/A") { li_cu = "0.00"; }
                if (lf_cu == "N/A") { lf_cu = "0.00"; }
                if (prof_cu == "N/A") { prof_cu = "0.00"; }
                if (li_profcu == "N/A") { li_profcu = "0.00"; }
                if (lf_profcu == "N/A") { lf_profcu = "0.00"; }
                if (prof_cu_m == "N/A" || prof_cu_m == "") { prof_cu_m = "0.00"; }
                if (li_profcum == "N/A" || li_profcum == "") { li_profcum = "0.00"; }
                if (lf_profcum == "N/A" || lf_profcum == "") { lf_profcum = "0.00"; }
                if (diam_int_m == "N/A") { diam_int_m = "0.00"; }
                if (tmax_diamint_m == "N/A" || tmax_diamint_m == "") { tmax_diamint_m = "0.00"; }
                if (tmin_diamint_m == "N/A" || tmin_diamint_m == "") { tmin_diamint_m = "0.00"; }
                //if (dureza == "N/A" || dureza == "") { dureza = "0.00"; }
                //if (tmax_dur == "N/A" || tmax_dur == "") { tmax_dur = "0.00"; }
                //if (tmin_dur == "N/A" || tmin_dur == "") { tmin_dur = "0.00"; }
                #endregion
                if (job != "")
                {
                    string guardar = "exec guadarord_aux '" + num_orden + "','" + codigo_acero + "','" + largoi + "','" + largof + "','" + job + "','" + posicion + "','" + medida + "','" + espesor + "', "
                    + " '" + diametroext + "','" + diametromen + "','" + espesor_corte + "','" + acero + "','" + hrc + "','" + cliente + "'   ";
                    datos.EjecutarSql(guardar);


                    string dimensionales = "exec guardar_dimensiones '" + num_orden + "','" + job + "', '" + posicion + "','" + Convert.ToDecimal(diametroext) + "','" + Convert.ToDecimal(li_diamext) + "','" + Convert.ToDecimal(lf_diamext) + "','" + Convert.ToDecimal(diametromen) + "', "
                 + " '" + Convert.ToDecimal(li_diamint) + "','" + Convert.ToDecimal(lf_diamint) + "','" + Convert.ToDecimal(espesor) + "','" + Convert.ToDecimal(li_esp) + "','" + Convert.ToDecimal(lf_esp) + "','" + Convert.ToDecimal(cunero) + "','" + Convert.ToDecimal(li_cu) + "','" + Convert.ToDecimal(lf_cu) + "','" + Convert.ToDecimal(prof_cu) + "','" + Convert.ToDecimal(li_profcu) + "','" + Convert.ToDecimal(lf_profcu) + "','" + cliente + "','" + Convert.ToDecimal(prof_cu_m) + "','" + Convert.ToDecimal(li_profcum) + "','" + Convert.ToDecimal(lf_profcum) + "','" + Convert.ToDecimal(diam_int_m) + "','" + Convert.ToDecimal(tmax_diamint_m) + "','" + Convert.ToDecimal(tmin_diamint_m) + "' ";
                    datos.EjecutarSql(dimensionales);
                }



            }


            datos.EjecutarSql("In_sts_orden '" + num_orden + "'");
            MessageBox.Show("Proceso completado correctamente");
            dgExcel.DataSource = "";
            btnimpor.Enabled = false;
            btnguardar.Enabled = false;
            datos.ActualizarGrid(dgExcel, "select * from orden_aux where folio='" + num_orden + "'");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
