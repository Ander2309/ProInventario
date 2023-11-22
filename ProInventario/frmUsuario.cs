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
    public partial class frmUsuario : Form
    {
        InventarioContext _Contexto = new InventarioContext();
        public frmUsuario()
        {
            InitializeComponent();


        }


        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            Usuario a = new Usuario();
            a.UserId = int.Parse(TXTCodUsuario.Text);
            a.Nombre = TXTNombre.Text;
            a.CorreoElectronico = TXTCorreo.Text;
            a.Contraseña = TXTContraseña.Text;
            a.Rol = TXTRol.Text;

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
            dataGridView1.DataSource = _Contexto.Usuarios.ToList();

            Limpiar();
        }

        private void Limpiar()
        {
            TXTCodUsuario.Text = "";
            TXTNombre.Text = "";
            TXTCorreo.Text = "";
            TXTContraseña.Text = "";
            TXTRol.Text = "";
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Contexto.Usuarios.ToList();
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(TXTCodUsuario.Text);

            var a = _Contexto.Usuarios.FirstOrDefault(p => p.UserId == codigo);

            a.Nombre = TXTNombre.Text;
            a.CorreoElectronico = TXTCorreo.Text;
            a.Contraseña = TXTContraseña.Text;
            a.Rol = TXTRol.Text;

            _Contexto.Usuarios.Update(a);
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
            dataGridView1.DataSource = _Contexto.Usuarios.ToList();

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Seguro que quieres eliminar este reggistro??", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int Codigo = int.Parse(TXTCodUsuario.Text);
                var proModificar = _Contexto.Usuarios.FirstOrDefault(p => p.UserId == Codigo);

                _Contexto.Usuarios.Remove(proModificar);
                _Contexto.SaveChanges();
                MessageBox.Show(this, "Borrado con exitoo", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _Contexto.Usuarios.ToList();

            }
            else
            {
                MessageBox.Show(this, "Error", "Prueba otra ves", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.TXTCodUsuario.Text = dataGridView1.SelectedCells[0].Value.ToString();
            this.TXTNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            this.TXTCorreo.Text = dataGridView1.SelectedCells[2].Value.ToString();
            this.TXTRol.Text = dataGridView1.SelectedCells[3].Value.ToString();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Contexto.Usuarios.ToList();
            TXTBuscar.Text = "";
            Limpiar();
        }

        private void TXTBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var filtro = TXTBuscar.Text;
            var resultado = _Contexto.Usuarios.Where(n => n.UserId.ToString() == filtro || n.Nombre.ToLower().Contains(filtro) || n.CorreoElectronico.ToLower().Contains(filtro)).ToList();

            dataGridView1.DataSource = resultado;
        }
    }
}
