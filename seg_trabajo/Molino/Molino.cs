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
using Microsoft.VisualBasic;

namespace seg_trabajo.Molino
{
    public partial class Molino : Form
    {
        Conexion datos = new Conexion();
        public Molino()
        {
            InitializeComponent();
            GridRodillos.Enabled = true;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.Items.AddRange(
             Enumerable.Repeat<string>("", imageList1.Images.Count).ToArray());
        }

        private void Molino_Load(object sender, EventArgs e)
        {

            //se carga el combo de clientes
            datos.cargarcombo(comboClientes, "select id,nom from clientes", "id","nom");

            DataGridViewComboBoxColumn cboColumn;
            cboColumn = new DataGridViewComboBoxColumn();
            {
                var withBlock = cboColumn;
                withBlock.Name = "DatosFiguras";
                withBlock.HeaderText = "";
                withBlock.Items.Add("1");
                withBlock.Items.Add("2");
                withBlock.Items.Add("3");
                withBlock.Items.Add("4");
                withBlock.Items.Add("5");
                
            }
            //Columna categorias
            DataGridViewComboBoxColumn Categorias;
            Categorias = new DataGridViewComboBoxColumn();
            Categorias.Name = "DatosCategorias";
            Categorias.HeaderText = "Categoria";

            datos.cargarcomboGrid(Categorias, "select CategoriaRodilloId,Nombre from TblCategoriaRodillos", "CategoriaRodilloId", "Nombre");
            //GridRodillos.Rows[0].Cells[0]
            //Columna posicion
            DataGridViewTextBoxColumn Posicion;
            Posicion = new DataGridViewTextBoxColumn();
            Posicion.Name = "DatosPosicion";
            Posicion.HeaderText = "Posición";

            //Columna Enviado
            DataGridViewTextBoxColumn Enviado;
            Enviado = new DataGridViewTextBoxColumn();
            Enviado.Name = "DatosEnviado";
            Enviado.HeaderText = "Enviado";

            //Columna Contra Dibujo
            DataGridViewTextBoxColumn ContraDibujo;
            ContraDibujo = new DataGridViewTextBoxColumn();
            ContraDibujo.Name = "DatosContraDibujo";
            ContraDibujo.HeaderText = "Contra Dibujo";

            //Columna Contra Recibido
            DataGridViewTextBoxColumn ContraRecibido;
            ContraRecibido = new DataGridViewTextBoxColumn();
            ContraRecibido.Name = "DatosContraContraRecibido";
            ContraRecibido.HeaderText = "Contra Recibido";

            //Columna Laina
            DataGridViewTextBoxColumn Laina;
            Laina = new DataGridViewTextBoxColumn();
            Laina.Name = "DatosLaina";
            Laina.HeaderText = "Laina";

            //Columna Recibido
            DataGridViewTextBoxColumn Recibido;
            Recibido = new DataGridViewTextBoxColumn();
            Recibido.Name = "DatosRecibido";
            Recibido.HeaderText = "Recibido";

            //Columna EnviadoGarganta
            DataGridViewTextBoxColumn EnviadoGarganta;
            EnviadoGarganta = new DataGridViewTextBoxColumn();
            EnviadoGarganta.Name = "DatosEnviadoGarganta";
            EnviadoGarganta.HeaderText = "Enviado";

            //Columna Operador
            DataGridViewTextBoxColumn Operador;
            Operador = new DataGridViewTextBoxColumn();
            Operador.Name = "DatosOperador";
            Operador.HeaderText = "Operador";

            //Aquo se agregan las columnas del grid
            this.GridRodillos.Columns.Add(Categorias);
            this.GridRodillos.Columns.Add(cboColumn);       
            this.GridRodillos.Columns.Add(Posicion);
            this.GridRodillos.Columns.Add(Enviado);
            this.GridRodillos.Columns.Add(ContraDibujo);
            this.GridRodillos.Columns.Add(ContraRecibido);
            this.GridRodillos.Columns.Add(Laina);
            this.GridRodillos.Columns.Add(Recibido);
            this.GridRodillos.Columns.Add(EnviadoGarganta);
            this.GridRodillos.Columns.Add(Operador);


        }

  
        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
           
            e.DrawBackground();
            e.DrawFocusRectangle();
           
            bool bSelected = Convert.ToBoolean(e.State & DrawItemState.Selected);
            bool bValue = Convert.ToBoolean(e.State & DrawItemState.ComboBoxEdit);
            int colIndex = this.GridRodillos.CurrentCell.ColumnIndex;
            //MessageBox.Show(e.Index.ToString());
            if (e.Index >= 0 && colIndex == 1)
            {
                
                    if (e.Index < imageList1.Images.Count)
                    {
                        Image img = new Bitmap(imageList1.Images[e.Index], new Size(20, 20));
                        e.Graphics.DrawImage(img, new PointF(e.Bounds.Left, e.Bounds.Top));
                    }
                    e.Graphics.DrawString(string.Format("Figura {0}", e.Index + 1)
                     , e.Font, new SolidBrush(e.ForeColor)
                     , e.Bounds.Left + 32, e.Bounds.Top);
                
            }
        }

        private void comboBox2_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 300;
            e.ItemWidth = 300;
        }
    
        private void GridRodillos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
            int colIndex = this.GridRodillos.CurrentCell.ColumnIndex;
            //MessageBox.Show(colIndex.ToString());
            if (e.Control is ComboBox && colIndex == 1)
            {
                if (colIndex == 1) { 
                ComboBox theCB = (ComboBox)e.Control;

                theCB.DrawMode = DrawMode.OwnerDrawFixed;
                try
                {
                    theCB.DrawItem -= comboBox2_DrawItem;
                }
                catch { }

                theCB.DrawItem += comboBox2_DrawItem;

            }

            }

        }

        //Evento que detecta la seleccion del combo de clientes y muestra el nombre en el input
        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ClienteId = comboClientes.SelectedValue.ToString();

            txClienteNombre.Text = datos.Resultado("select nom from clientes where id = '"+ClienteId+"'");
        }


        private void GridRodillos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Validacion cuando se edita la columna de posicion
            if (GridRodillos.Columns[e.ColumnIndex].Name == "DatosPosicion")
            {
                int colIndex = this.GridRodillos.CurrentCell.ColumnIndex;
                int RowIndex = this.GridRodillos.CurrentRow.Index;
                var ValorFila = GridRodillos.CurrentRow.Cells["DatosPosicion"].Value.ToString();
                var TotalFilas = "";
                if (ValorFila != "")
                {
                     TotalFilas = GridRodillos.Rows.Count.ToString();
                }

                var CantidadRodillos = GridRodillos.Rows.Cast<DataGridViewRow>()
       .Where(row => !(row.Cells[2].Value == null || row.Cells[2].Value == DBNull.Value))
       .Count();


                txRodillos.Text = CantidadRodillos.ToString();
            }

            //validacion cuando se edita la columna de enviado(diametro)
            if (GridRodillos.Columns[e.ColumnIndex].Name == "DatosEnviado")
            {
                int colIndex = this.GridRodillos.CurrentCell.ColumnIndex;
                int RowIndex = this.GridRodillos.CurrentRow.Index;
                var ValorFila = GridRodillos.CurrentRow.Cells["DatosEnviado"].Value.ToString();


                this.GridRodillos.Rows[RowIndex].Cells["DatosDibujo"].Value = ValorFila;

                
            }

        }
    }
}
