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
    public partial class Login : Form
    {
        InventarioContext _Contexto = new InventarioContext();
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {

            Usuario openUsuario = _Contexto.Usuarios.FirstOrDefault(u => u.Nombre == TXTNombre.Text
            && u.Contraseña == TXTClave.Text);


            if(openUsuario != null)
            {
                Inicio form = new Inicio();

                form.Show();
                this.Hide();

                form.FormClosing += frmClosing;
            }
            else
            {
                MessageBox.Show("Nose encontro el usuario","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            TXTNombre.Text = "";
            TXTClave.Text = "";
            this.Show();
        }
    }
}
