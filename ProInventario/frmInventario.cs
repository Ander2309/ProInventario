using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProInventario.Contexto;

namespace ProInventario
{
    public partial class frmInventario : Form
    {
        InventarioContext _Contexto = new InventarioContext();
        public frmInventario()
        {
            InitializeComponent();

            LLenarComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Producto a = new Producto();

            a.ProductoId = int.Parse(TXTCodProducto.Text);
            a.Nombre = TXTNombreProducto.Text;
            a.Descripcion = TXTDescripcion.Text;
            a.Precio = decimal.Parse(TXTPrecio.Text);
            a.Stock = int.Parse(TxtStock.Text);
            a.CategoriaId = Convert.ToInt32(COMBXCategoria.SelectedValue);

            _Contexto.Add(a);
            _Contexto.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _Contexto.Productos.ToList();

            Limpiar();
        }

         private void Limpiar()
        {
            TXTCodProducto.Text = "";
            TXTNombreProducto.Text = "";
            TXTDescripcion.Text = "";
            TXTPrecio.Text = "";
            TxtStock.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(TXTCodProducto.Text);

            var proModificar = _Contexto.Productos.FirstOrDefault(p => p.ProductoId == Codigo);

            proModificar.Nombre = TXTNombreProducto.Text;
            proModificar.Descripcion = TXTDescripcion.Text;
            proModificar.Precio = decimal.Parse(TXTPrecio.Text);
            proModificar.Stock = int.Parse(TxtStock.Text);
            proModificar.CategoriaId = Convert.ToInt32(COMBXCategoria.SelectedValue);

            _Contexto.Productos.Update(proModificar);
            _Contexto.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _Contexto.Productos.ToList();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(TXTCodProducto.Text);

            var proModificar = _Contexto.Productos.FirstOrDefault(p => p.ProductoId == Codigo);

            _Contexto.Productos.Remove(proModificar);
            _Contexto.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _Contexto.Productos.ToList();
        }

        private void COMBXCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void LLenarComboBox()
        {
            var datosCategoria = from Categoria in _Contexto.Categorias
                                 select new
                                 {
                                     Categoria.CategoriaId,
                                     Categoria.Nombre
                                 };
            COMBXCategoria.DataSource = datosCategoria.ToList();
            COMBXCategoria.DisplayMember = "Nombre";
            COMBXCategoria.ValueMember = "CategoriaId";
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Contexto.Productos.ToList();
        }
    }
}
