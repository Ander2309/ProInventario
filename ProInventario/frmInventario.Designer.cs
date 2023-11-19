namespace ProInventario
{
    partial class frmInventario
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
            label1 = new Label();
            label2 = new Label();
            TXTCodProducto = new TextBox();
            TXTDescripcion = new TextBox();
            label4 = new Label();
            TXTPrecio = new TextBox();
            label5 = new Label();
            TxtStock = new TextBox();
            label6 = new Label();
            TXTNombreProducto = new TextBox();
            PanelIzq = new Label();
            label3 = new Label();
            label7 = new Label();
            COMBXCategoria = new ComboBox();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "CodProducto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 2;
            label2.Text = "Detalle Productos\r\n";
            // 
            // TXTCodProducto
            // 
            TXTCodProducto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTCodProducto.Location = new Point(23, 66);
            TXTCodProducto.Multiline = true;
            TXTCodProducto.Name = "TXTCodProducto";
            TXTCodProducto.Size = new Size(199, 23);
            TXTCodProducto.TabIndex = 3;
            // 
            // TXTDescripcion
            // 
            TXTDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTDescripcion.Location = new Point(23, 190);
            TXTDescripcion.Multiline = true;
            TXTDescripcion.Name = "TXTDescripcion";
            TXTDescripcion.Size = new Size(199, 23);
            TXTDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 167);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // TXTPrecio
            // 
            TXTPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTPrecio.Location = new Point(23, 248);
            TXTPrecio.Multiline = true;
            TXTPrecio.Name = "TXTPrecio";
            TXTPrecio.Size = new Size(199, 23);
            TXTPrecio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 225);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Precio";
            // 
            // TxtStock
            // 
            TxtStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStock.Location = new Point(23, 308);
            TxtStock.Multiline = true;
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(199, 23);
            TxtStock.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 285);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "Stock";
            // 
            // TXTNombreProducto
            // 
            TXTNombreProducto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTNombreProducto.Location = new Point(23, 131);
            TXTNombreProducto.Multiline = true;
            TXTNombreProducto.Name = "TXTNombreProducto";
            TXTNombreProducto.Size = new Size(199, 23);
            TXTNombreProducto.TabIndex = 5;
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
            PanelIzq.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 108);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre Producto";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(23, 346);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 12;
            label7.Text = "Cantegoria";
            // 
            // COMBXCategoria
            // 
            COMBXCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            COMBXCategoria.FormattingEnabled = true;
            COMBXCategoria.Location = new Point(23, 369);
            COMBXCategoria.Name = "COMBXCategoria";
            COMBXCategoria.Size = new Size(199, 23);
            COMBXCategoria.TabIndex = 13;
            COMBXCategoria.SelectedIndexChanged += COMBXCategoria_SelectedIndexChanged;
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
            BTNGuardar.Location = new Point(23, 413);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(197, 23);
            BTNGuardar.TabIndex = 14;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.TextAlign = ContentAlignment.MiddleRight;
            BTNGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNGuardar.UseVisualStyleBackColor = false;
            BTNGuardar.Click += iconButton1_Click;
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
            BTNEditar.Location = new Point(23, 442);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(197, 23);
            BTNEditar.TabIndex = 15;
            BTNEditar.Text = "Editar";
            BTNEditar.TextAlign = ContentAlignment.MiddleRight;
            BTNEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEditar.UseVisualStyleBackColor = false;
            BTNEditar.Click += iconButton2_Click;
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
            BTNEliminar.Location = new Point(23, 471);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(197, 23);
            BTNEliminar.TabIndex = 16;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.TextAlign = ContentAlignment.MiddleRight;
            BTNEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEliminar.UseVisualStyleBackColor = false;
            BTNEliminar.Click += iconButton3_Click;
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
            dataGridView1.Location = new Point(282, 131);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(727, 351);
            dataGridView1.TabIndex = 17;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(282, 32);
            label8.Name = "label8";
            label8.Size = new Size(653, 31);
            label8.TabIndex = 18;
            label8.Text = "Lista de productos";
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1021, 523);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(BTNEliminar);
            Controls.Add(BTNEditar);
            Controls.Add(BTNGuardar);
            Controls.Add(COMBXCategoria);
            Controls.Add(label7);
            Controls.Add(TxtStock);
            Controls.Add(label6);
            Controls.Add(TXTPrecio);
            Controls.Add(label5);
            Controls.Add(TXTDescripcion);
            Controls.Add(label4);
            Controls.Add(TXTNombreProducto);
            Controls.Add(label3);
            Controls.Add(TXTCodProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PanelIzq);
            Name = "frmInventario";
            Text = "frmInventario";
            Load += frmInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox TXTCodProducto;
        private TextBox TXTDescripcion;
        private Label label4;
        private TextBox TXTPrecio;
        private Label label5;
        private TextBox TxtStock;
        private Label label6;
        private TextBox TXTNombreProducto;
        private Label PanelIzq;
        private Label label3;
        private Label label7;
        private ComboBox COMBXCategoria;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private DataGridView dataGridView1;
        private Label label8;
    }
}