using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace seg_trabajo.clases_funciones
{
    class Importar
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;
        // new Importar().importarExcel(dgExcel, "Hoja1");

        public void importarExcel(DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
          //  try
           // {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }
                // Set cursor as hourglass
                Cursor.Current = Cursors.WaitCursor;

                // Execute your time-intensive hashing code here...
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
             //   string hoja = "select codigo_acero,	largo_i,	largo_f,	posicion,	,medida,	job,	espesor,	tmax_esp,	tmin_esp,	diam_ext,	tmax_dext,	tmin_dext,	diam_men,	tmax_dmint,	tmin_dmint,	CUÑERO,	tmax_cu,	tmin_cu,	prof_caja,	tmax_prof,	tmin_prof,	espesor_corte,	acero,	hrc from [" + nombreHoja + "$] ";
            //    MyDataAdapter = new OleDbDataAdapter("Select codigo_acero,largo_i,largo_f,posicion,medida,job,espesor,diam_ext,diam_men,espesor_corte,acero,hrc,DIAM_EXT_DIBUJO,li_diamext,DIAM_INT_DIBUJO,li_diamint,ESPESOR_DIBUJO,li_esp,CUÑERO,li_cu,PROF_CUÑERO,li_profcu,DUREZA,li_dur from [" + nombreHoja + "$] ", conn);
                MyDataAdapter = new OleDbDataAdapter("Select codigo_acero,largo_i,largo_f,posicion,medida,job,espesor,tmax_esp,	tmin_esp,	diam_ext,	tmax_dext,	tmin_dext,	diam_men,	tmax_dmint,	tmin_dmint,diam_im,	tmax_dim, tmin_dim,CUÑERO,	tmax_cu,	tmin_cu,	prof_caja,	tmax_prof,	tmin_prof, prof_caja_m,	tmax_profm,	tmin_profm	, espesor_corte,	acero,	hrc from [" + nombreHoja + "$] ", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;
                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.ToString());
           // }
        }
    }
}
