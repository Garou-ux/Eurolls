using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Globalization;

namespace seg_trabajo
{

   
     public class Conexion
    {
        public SqlConnection MiConexion;
   
        public void Conectar()
        {
            //EUROLLSSVR\SQLEXPRESS
            MiConexion = new
                                //SqlConnection("Data Source=SERVER\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=daonsa2;Password=Francisco1");
                                //SqlConnection("Data Source=DESKTOP-H2GPA2O; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=p1234");
                                SqlConnection("Data Source=DESKTOP-07QM9LC\\SA; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=1234");

            //servidor
            //   SqlConnection("Data Source=EUROLLSSVR\\SQLEXPRESS; Initial Catalog=seg_trabajo;Persist Security Info=True;" + "MultipleActiveResultSets = True; User ID=sa;Password=Inicio001");
            MiConexion.Open();              
        }
        public void Desconectar()
        {
            MiConexion.Close();
        }
        public void EjecutarSql(String query)
        {
            this.Conectar();
            SqlCommand MiComando = new SqlCommand(query, MiConexion);
            int FilasAfectadas = MiComando.ExecuteNonQuery();//Ejecuta la consulta (Query)
            this.Desconectar();
        }
         //4:56 20 Octubre 3 reinicios 5:23 reinicio 
     
        public void ActualizarGrid(DataGridView dg, string query)
        {
            this.Conectar();//Conectar a la base de datos
            System.Data.DataSet MiDataSet = new System.Data.DataSet();//Crear DataSet
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(query, MiConexion);//Crear Adaptador de Datos
            MiDataAdapter.Fill(MiDataSet, "Conexion"); //Llenar el DataSet
            dg.DataSource = MiDataSet; //Asignar valores a las propiedades del DataGrid
            dg.DataMember = "Conexion";//Asignar valores a las propiedades del DataGrid
            this.Desconectar();//Desconectarnos de la base de datos
        }

        public void exportaexcel(DataGridView tabla)
        {
            
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Name nombre = new Microsoft. Office.Interop.Excel.Name(castillo);
            //excel.Name = "DaonsaExcel";

            Microsoft.Office.Interop.Excel.Workbook libroexcel = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet hojaexcel = (Microsoft.Office.Interop.Excel.Worksheet)libroexcel.Worksheets.get_Item(1);
            hojaexcel.Name = "DaonsaExcel";
            //libroexcel.Name = "DaExcel1";
            ////excel.Application.Workbooks.Add(true);
            //Microsoft.Office.Interop.Excel.Workbook castillo;
            //Microsoft.Office.Interop.Excel.Workbook DaonsaExcel = excel.Workbooks.Add();
            //excel.Application.Workbooks.Add("castillo");
            //excel.Name("castillo");
            //excel.file
            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }
            var saveFiledialoge = new SaveFileDialog();
            saveFiledialoge.FileName = "Daonsa2";
            saveFiledialoge.DefaultExt = ".xlsx";
            excel.Visible = true;
        }


        //// obtner un registro completo de una tabla
        public SqlDataReader obtenerRegistro22(string query1, string buscar, string variableCompara)
        {
            Conectar();
            string tabla1;
            tabla1 = query1 + " where " + variableCompara + " ='" + buscar + "' ";

            SqlCommand cmd = new SqlCommand(tabla1, MiConexion);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

   
        /////Sumar columna de grid
        public decimal sumargrid(DataGridView dg, int valos)
        {
            decimal importes = 0;

            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {

                decimal impor1 = decimal.Parse(dg.Rows[i].Cells[valos].Value.ToString());
                importes += impor1;
            }
            return importes;
        }
        public decimal sumargridpro(DataGridView dg, string valos)
        {
            decimal importes = 0;

            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {

                decimal impor1 = decimal.Parse(dg.Rows[i].Cells[valos].Value.ToString());
                importes += impor1;
            }
            return importes;
        }
        public decimal TotalCnDescuento(DataGridView dg, int valos, decimal descu)
        {
            decimal importes = 0;
            decimal subtotal = 0;
            decimal total = 0;
            decimal porciento = 0;
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {

                decimal impor1 = decimal.Parse(dg.Rows[i].Cells[valos].Value.ToString());
                importes += impor1;
            }
            porciento = descu / 100;
            subtotal = importes * porciento;
            total = importes - subtotal;
            return total;
        }

        public String Resultado(String query)
        {
            Conectar();
            SqlCommand sql = new SqlCommand(query, MiConexion);
            String Re = (String)sql.ExecuteScalar();
            Desconectar();
            return Re;

        }
        public int ResultadoInt(String query)
        {
            Conectar();
            SqlCommand sql = new SqlCommand(query, MiConexion);
            int Re1 = (int)sql.ExecuteScalar();
            Desconectar();
            return Re1;
        }

        public decimal ResultadoDeci(String query)
        {
            Conectar();
            SqlCommand sql = new SqlCommand(query, MiConexion);
            decimal Re2 = (decimal)sql.ExecuteScalar();
            Desconectar();
            return Re2;

        }

        public DateTime ResultadoFec(String query)
        {
            Conectar();
            SqlCommand sql = new SqlCommand(query, MiConexion);
            DateTime Re2 = (DateTime)sql.ExecuteScalar();
            Desconectar();
            return Re2;

        }


        public SqlDataReader obtenerRegistrocondicion(string query1)
        {
            Conectar();
            string tabla1;
            tabla1 = query1;
            //MessageBox.Show(tabla1);
            SqlCommand cmd = new SqlCommand(tabla1, MiConexion);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void LimpiarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)txt).Clear();
                }
                //else if (txt is ComboBox)
                //{
                //    ((ComboBox)txt).SelectedIndex = 0;
                //}GridPe.Rows.Clear();
                else if (txt is DataGridView)
                {
                    ((DataGridView)txt).Rows.Clear();
                }
            }
        }

        public SqlDataReader obtenerRegistro(string query1)
        {
            Conectar();
            string tabla1;
            tabla1 = query1;
            //MessageBox.Show(tabla1);
            SqlCommand cmd = new SqlCommand(tabla1, MiConexion);
            SqlDataReader dr = cmd.ExecuteReader();
            // Desconectar();
            return dr;
        }
        public String VacioLleno(string QUERY)
        {
            Conectar();
            string f = "";
            SqlCommand ex = new SqlCommand(QUERY, MiConexion);
            SqlDataReader et = ex.ExecuteReader();
            if (et.HasRows == true)
            {
                f = "s";//no tiene registros
            }
            else
            {
                f = "n";//si tiene registros
            }
            Desconectar();
            return f;
        }
        
        public void validarnumeros(KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void cargarcombo(ComboBox combo, string query, string valor, string display)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand(query, MiConexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            da.Fill(dt);
            Desconectar();
            combo.DisplayMember = display;
            combo.ValueMember = valor;
            combo.DataSource = dt;
        }

        public void cargarcomboGrid(DataGridViewComboBoxColumn combo, string query, string valor, string display)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand(query, MiConexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            da.Fill(dt);
            Desconectar();
            combo.DisplayMember = display;
            combo.ValueMember = valor;
            combo.DataSource = dt;
        }

        public bool validarEmail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else { return false; }
            }
            MessageBox.Show("Ingresa un correo valido");
            email = "";
            return false;
        }
        public void EnterTab(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

     

    }
}