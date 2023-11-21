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
            if (_Contexto.SaveChanges() == 1)
            {
                MessageBox.Show(this, "Editado con exitoo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(this, "Error", "Prueba otra ves", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (_Contexto.SaveChanges() == 1)
            {
                MessageBox.Show(this, "Editado con exitoo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(this, "Error", "Prueba otra ves", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Limpiar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _Contexto.Productos.ToList();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Seguro que quieres eliminar este reggistro??", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int Codigo = int.Parse(TXTCodProducto.Text);
                var proModificar = _Contexto.Productos.FirstOrDefault(p => p.ProductoId == Codigo);

                _Contexto.Productos.Remove(proModificar);
                _Contexto.SaveChanges();
                MessageBox.Show(this, "Borrado con exitoo", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _Contexto.Productos.ToList();

            }
            else
            {
                MessageBox.Show(this, "Error", "Prueba otra ves", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            var filtro = TXTBuscar.Text;
            var resultado = _Contexto.Productos.Where(B => B.ProductoId.ToString() == filtro || B.Nombre.ToLower().Contains(filtro)).ToList();

            dataGridView1.DataSource = resultado;
        }

        private void BTNReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Contexto.Productos.ToList();
            TXTBuscar.Text = "";
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmInventario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.TXTCodProducto.Text = dataGridView1.SelectedCells[0].Value.ToString();
            this.TXTNombreProducto.Text = dataGridView1.SelectedCells[1].Value.ToString();
            this.TXTDescripcion.Text = dataGridView1.SelectedCells[2].Value.ToString();
            this.TXTPrecio.Text = dataGridView1.SelectedCells[3].Value.ToString();
            this.TxtStock.Text = dataGridView1.SelectedCells[4].Value.ToString();
            this.COMBXCategoria.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
    }
}
