using ProInventario.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProInventario
{
    public partial class frmCategoria : Form
    {
        InventarioContext _Contexto = new InventarioContext();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            Categoria a = new Categoria();


            a.CategoriaId = int.Parse(TXTCod.Text);
            a.Nombre = TXTCategoria.Text;

            _Contexto.Add(a);
            if (_Contexto.SaveChanges() == 1)
            {
                MessageBox.Show(this, "Guardado con exitoo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(this, "Error", "Prueba otra ves", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _Contexto.Categorias.ToList();

            Limpiar();
        }

        private void Limpiar()
        {
            TXTCategoria.Text = "";
            TXTCod.Text = "";

        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {

            int Codigo = int.Parse(TXTCod.Text);

            var modi = _Contexto.Categorias.FirstOrDefault(p => p.CategoriaId == Codigo);

            modi.CategoriaId = int.Parse(TXTCod.Text);
            modi.Nombre = TXTCategoria.Text;

            _Contexto.Categorias.Update(modi);

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
            dataGridView1.DataSource = _Contexto.Categorias.ToList();
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Seguro que quieres eliminar este reggistro??", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int Codigo = int.Parse(TXTCod.Text);
                var proModificar = _Contexto.Categorias.FirstOrDefault(p => p.CategoriaId == Codigo);

                _Contexto.Categorias.Remove(proModificar);
                _Contexto.SaveChanges();
                MessageBox.Show(this, "Borrado con exitoo", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _Contexto.Categorias.ToList();

            }
            else
            {
                MessageBox.Show(this, "Error", "Prueba otra ves", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Contexto.Categorias.ToList();
        }
    }


}
