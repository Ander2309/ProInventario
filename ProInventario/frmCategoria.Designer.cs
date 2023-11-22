namespace ProInventario
{
    partial class frmCategoria
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
            TXTCategoria = new TextBox();
            label3 = new Label();
            TXTCod = new TextBox();
            label1 = new Label();
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            label8 = new Label();
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
            PanelIzq.Size = new Size(252, 348);
            PanelIzq.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 20);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 3;
            label2.Text = "Agregar Categorias";
            // 
            // TXTCategoria
            // 
            TXTCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTCategoria.Location = new Point(30, 152);
            TXTCategoria.Multiline = true;
            TXTCategoria.Name = "TXTCategoria";
            TXTCategoria.Size = new Size(199, 23);
            TXTCategoria.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre Categoria";
            // 
            // TXTCod
            // 
            TXTCod.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TXTCod.Location = new Point(30, 87);
            TXTCod.Multiline = true;
            TXTCod.Name = "TXTCod";
            TXTCod.Size = new Size(199, 23);
            TXTCod.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 64);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 6;
            label1.Text = "CodPCategoria";
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
            BTNEliminar.Location = new Point(30, 269);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(197, 23);
            BTNEliminar.TabIndex = 19;
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
            BTNEditar.Location = new Point(30, 240);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(197, 23);
            BTNEditar.TabIndex = 18;
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
            BTNGuardar.Location = new Point(30, 211);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(197, 23);
            BTNGuardar.TabIndex = 17;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.TextAlign = ContentAlignment.MiddleRight;
            BTNGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNGuardar.UseVisualStyleBackColor = false;
            BTNGuardar.Click += BTNGuardar_Click;
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
            dataGridView1.Location = new Point(258, 106);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(403, 186);
            dataGridView1.TabIndex = 20;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(258, 33);
            label8.Name = "label8";
            label8.Size = new Size(380, 33);
            label8.TabIndex = 21;
            label8.Text = "Lista de categorias";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 348);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(BTNEliminar);
            Controls.Add(BTNEditar);
            Controls.Add(BTNGuardar);
            Controls.Add(TXTCategoria);
            Controls.Add(label3);
            Controls.Add(TXTCod);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(PanelIzq);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PanelIzq;
        private Label label2;
        private TextBox TXTCategoria;
        private Label label3;
        private TextBox TXTCod;
        private Label label1;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private DataGridView dataGridView1;
        private Label label8;
    }
}