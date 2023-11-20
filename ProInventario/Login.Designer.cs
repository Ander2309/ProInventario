namespace ProInventario
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TXTNombre = new TextBox();
            TXTClave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            BTNIngresar = new FontAwesome.Sharp.IconButton();
            BTNCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 272);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(190, 67);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE INVENTARIO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Box;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 124;
            iconPictureBox1.Location = new Point(41, 49);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(141, 124);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // TXTNombre
            // 
            TXTNombre.Location = new Point(294, 49);
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(361, 23);
            TXTNombre.TabIndex = 3;
            // 
            // TXTClave
            // 
            TXTClave.Location = new Point(294, 110);
            TXTClave.Name = "TXTClave";
            TXTClave.PasswordChar = '*';
            TXTClave.Size = new Size(361, 23);
            TXTClave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 21);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 92);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // BTNIngresar
            // 
            BTNIngresar.BackColor = Color.RoyalBlue;
            BTNIngresar.Cursor = Cursors.Hand;
            BTNIngresar.FlatAppearance.BorderColor = Color.Black;
            BTNIngresar.FlatStyle = FlatStyle.Flat;
            BTNIngresar.ForeColor = Color.White;
            BTNIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BTNIngresar.IconColor = Color.White;
            BTNIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNIngresar.IconSize = 21;
            BTNIngresar.Location = new Point(326, 178);
            BTNIngresar.Name = "BTNIngresar";
            BTNIngresar.Size = new Size(107, 31);
            BTNIngresar.TabIndex = 7;
            BTNIngresar.Text = "Ingresar";
            BTNIngresar.TextAlign = ContentAlignment.MiddleRight;
            BTNIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNIngresar.UseVisualStyleBackColor = false;
            BTNIngresar.Click += BTNIngresar_Click;
            // 
            // BTNCancelar
            // 
            BTNCancelar.BackColor = Color.Red;
            BTNCancelar.Cursor = Cursors.Hand;
            BTNCancelar.FlatAppearance.BorderColor = Color.Black;
            BTNCancelar.FlatStyle = FlatStyle.Flat;
            BTNCancelar.ForeColor = Color.White;
            BTNCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            BTNCancelar.IconColor = Color.White;
            BTNCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNCancelar.IconSize = 21;
            BTNCancelar.Location = new Point(526, 178);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(107, 31);
            BTNCancelar.TabIndex = 8;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.TextAlign = ContentAlignment.MiddleRight;
            BTNCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNCancelar.UseVisualStyleBackColor = false;
            BTNCancelar.Click += BTNCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 272);
            Controls.Add(BTNCancelar);
            Controls.Add(BTNIngresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TXTClave);
            Controls.Add(TXTNombre);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox TXTNombre;
        private TextBox TXTClave;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton BTNIngresar;
        private FontAwesome.Sharp.IconButton BTNCancelar;
    }
}