namespace ProInventario
{
    partial class frmUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PanelIzq = new Label();
            label2 = new Label();
            TXTRol = new TextBox();
            label6 = new Label();
            TXTContraseña = new TextBox();
            label5 = new Label();
            TXTCorreo = new TextBox();
            label4 = new Label();
            TXTNombre = new TextBox();
            label3 = new Label();
            TXTCodUsuario = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            TXTBuscar = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelIzq
            // 
            PanelIzq.BackColor = Color.White;
            PanelIzq.BorderStyle = BorderStyle.FixedSingle;
            PanelIzq.Cursor = Cursors.No;
            PanelIzq.Dock = DockStyle.Left;
            PanelIzq.Location = new Point(0, 0);
            PanelIzq.Name = "PanelIzq";
            PanelIzq.Size = new Size(252, 523);
            PanelIzq.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 3;
            label2.Text = "Crear Usuarios";
            // 
            // TXTRol
            // 
            TXTRol.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTRol.Location = new Point(24, 309);
            TXTRol.Multiline = true;
            TXTRol.Name = "TXTRol";
            TXTRol.Size = new Size(199, 23);
            TXTRol.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(24, 286);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 20;
            label6.Text = "Rol";
            // 
            // TXTContraseña
            // 
            TXTContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTContraseña.Location = new Point(24, 249);
            TXTContraseña.Multiline = true;
            TXTContraseña.Name = "TXTContraseña";
            TXTContraseña.Size = new Size(199, 23);
            TXTContraseña.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 226);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 18;
            label5.Text = "Contraseña";
            // 
            // TXTCorreo
            // 
            TXTCorreo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTCorreo.Location = new Point(24, 191);
            TXTCorreo.Multiline = true;
            TXTCorreo.Name = "TXTCorreo";
            TXTCorreo.Size = new Size(199, 23);
            TXTCorreo.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 168);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 16;
            label4.Text = "Correo";
            // 
            // TXTNombre
            // 
            TXTNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTNombre.Location = new Point(24, 132);
            TXTNombre.Multiline = true;
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(199, 23);
            TXTNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 109);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 14;
            label3.Text = "Nombre";
            // 
            // TXTCodUsuario
            // 
            TXTCodUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTCodUsuario.Location = new Point(24, 67);
            TXTCodUsuario.Multiline = true;
            TXTCodUsuario.Name = "TXTCodUsuario";
            TXTCodUsuario.Size = new Size(199, 23);
            TXTCodUsuario.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 12;
            label1.Text = "Codigo de usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(282, 132);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(727, 351);
            dataGridView1.TabIndex = 22;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // BTNEliminar
            // 
            BTNEliminar.BackColor = Color.Red;
            BTNEliminar.Cursor = Cursors.Hand;
            BTNEliminar.FlatAppearance.BorderColor = Color.Black;
            BTNEliminar.FlatStyle = FlatStyle.Flat;
            BTNEliminar.ForeColor = Color.White;
            BTNEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BTNEliminar.IconColor = Color.White;
            BTNEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEliminar.IconSize = 18;
            BTNEliminar.Location = new Point(26, 430);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(197, 23);
            BTNEliminar.TabIndex = 25;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.TextAlign = ContentAlignment.MiddleRight;
            BTNEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEliminar.UseVisualStyleBackColor = false;
            BTNEliminar.Click += BTNEliminar_Click;
            // 
            // BTNEditar
            // 
            BTNEditar.BackColor = Color.RoyalBlue;
            BTNEditar.Cursor = Cursors.Hand;
            BTNEditar.FlatAppearance.BorderColor = Color.Black;
            BTNEditar.FlatStyle = FlatStyle.Flat;
            BTNEditar.ForeColor = Color.White;
            BTNEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            BTNEditar.IconColor = Color.White;
            BTNEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEditar.IconSize = 18;
            BTNEditar.Location = new Point(26, 401);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(197, 23);
            BTNEditar.TabIndex = 24;
            BTNEditar.Text = "Editar";
            BTNEditar.TextAlign = ContentAlignment.MiddleRight;
            BTNEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEditar.UseVisualStyleBackColor = false;
            BTNEditar.Click += BTNEditar_Click;
            // 
            // BTNGuardar
            // 
            BTNGuardar.BackColor = Color.ForestGreen;
            BTNGuardar.Cursor = Cursors.Hand;
            BTNGuardar.FlatAppearance.BorderColor = Color.Black;
            BTNGuardar.FlatStyle = FlatStyle.Flat;
            BTNGuardar.ForeColor = Color.White;
            BTNGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BTNGuardar.IconColor = Color.White;
            BTNGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNGuardar.IconSize = 18;
            BTNGuardar.Location = new Point(26, 372);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(197, 23);
            BTNGuardar.TabIndex = 23;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.TextAlign = ContentAlignment.MiddleRight;
            BTNGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNGuardar.UseVisualStyleBackColor = false;
            BTNGuardar.Click += BTNGuardar_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(282, 20);
            label7.Name = "label7";
            label7.Size = new Size(713, 44);
            label7.TabIndex = 22;
            label7.Text = "Lista de usuarios";
            // 
            // TXTBuscar
            // 
            TXTBuscar.Location = new Point(719, 27);
            TXTBuscar.Multiline = true;
            TXTBuscar.Name = "TXTBuscar";
            TXTBuscar.Size = new Size(146, 26);
            TXTBuscar.TabIndex = 26;
            TXTBuscar.TextChanged += TXTBuscar_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.SteelBlue;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(930, 27);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(38, 26);
            iconButton1.TabIndex = 23;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.SteelBlue;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(886, 27);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(38, 26);
            iconButton2.TabIndex = 22;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1021, 523);
            Controls.Add(iconButton1);
            Controls.Add(iconButton2);
            Controls.Add(TXTBuscar);
            Controls.Add(label7);
            Controls.Add(BTNEliminar);
            Controls.Add(BTNEditar);
            Controls.Add(BTNGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(TXTRol);
            Controls.Add(label6);
            Controls.Add(TXTContraseña);
            Controls.Add(label5);
            Controls.Add(TXTCorreo);
            Controls.Add(label4);
            Controls.Add(TXTNombre);
            Controls.Add(label3);
            Controls.Add(TXTCodUsuario);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(PanelIzq);
            Name = "frmUsuario";
            Text = "Usuario";
            Load += Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PanelIzq;
        private Label label2;
        private TextBox TXTRol;
        private Label label6;
        private TextBox TXTContraseña;
        private Label label5;
        private TextBox TXTCorreo;
        private Label label4;
        private TextBox TXTNombre;
        private Label label3;
        private TextBox TXTCodUsuario;
        private Label label1;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private Label label7;
        private TextBox TXTBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}