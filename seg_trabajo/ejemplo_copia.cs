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
namespace seg_trabajo
{
    public partial class ejemplo_copia : Form
    {
        Conexion datos = new Conexion();
        public ejemplo_copia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string s = Clipboard.GetText();

            //string[] lines = s.Replace("\n", "").Split('\r');

            //dataGridView1.Rows.Add(lines.Length - 1);
            //string[] fields;
            //int row = 0;
            //int col = 0;

            //foreach (string item in lines)
            //{
            //    fields = item.Split('\t');
            //    foreach (string f in fields)
            //    {
            //        Console.WriteLine(f);
            //        dataGridView1[col, row].Value = f;
            //        col++;
            //    }
            //    row++;
            //    col = 0;
            //}

            datos.ActualizarGrid(dataGridView1,"select * from dimen");
        }
    }
}
