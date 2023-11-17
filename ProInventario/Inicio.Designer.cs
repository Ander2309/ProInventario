namespace ProInventario
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            MenuInventario = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            Contenedor = new Panel();
            menu.SuspendLayout();
            menuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { MenuInventario, MenuReportes, MenuUsuarios });
            menu.Location = new Point(0, 48);
            menu.Name = "menu";
            menu.Size = new Size(984, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // MenuInventario
            // 
            MenuInventario.AutoSize = false;
            MenuInventario.IconChar = FontAwesome.Sharp.IconChar.Box;
            MenuInventario.IconColor = Color.Black;
            MenuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuInventario.IconSize = 50;
            MenuInventario.ImageScaling = ToolStripItemImageScaling.None;
            MenuInventario.Name = "MenuInventario";
            MenuInventario.Size = new Size(122, 69);
            MenuInventario.Text = "Inventario";
            MenuInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuInventario.Click += MenuInventario_Click;
            // 
            // MenuReportes
            // 
            MenuReportes.AutoSize = false;
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.IconSize = 50;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(122, 69);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.AutoSize = false;
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            MenuUsuarios.IconColor = Color.Black;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.IconSize = 50;
            MenuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(80, 69);
            MenuUsuarios.Text = "Usuarios";
            MenuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.SteelBlue;
            menuTitulo.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem });
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.Yes;
            menuTitulo.Size = new Size(984, 48);
            menuTitulo.TabIndex = 1;
            menuTitulo.Text = "menuStrip1";
            menuTitulo.ItemClicked += menuTitulo_ItemClicked;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inventarioToolStripMenuItem.ForeColor = SystemColors.Control;
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(151, 44);
            inventarioToolStripMenuItem.Text = "Inventario ";
            // 
            // Contenedor
            // 
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 121);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(984, 583);
            Contenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 704);
            Controls.Add(Contenedor);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menuTitulo.ResumeLayout(false);
            menuTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuInventario;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private Panel Contenedor;
    }
}