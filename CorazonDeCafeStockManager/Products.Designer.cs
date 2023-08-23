namespace CorazonDeCafeStockManager
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            productList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)productList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // productList
            // 
            productList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            productList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productList.BackgroundColor = SystemColors.Menu;
            productList.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productList.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Stock, Tipo, Categoria, Estado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Menu;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productList.DefaultCellStyle = dataGridViewCellStyle3;
            productList.GridColor = SystemColors.WindowText;
            productList.Location = new Point(12, 126);
            productList.MultiSelect = false;
            productList.Name = "productList";
            productList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            productList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            productList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.BackColor = SystemColors.Menu;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.InfoText;
            productList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            productList.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            productList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            productList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.PeachPuff;
            productList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            productList.RowTemplate.Height = 25;
            productList.RowTemplate.Resizable = DataGridViewTriState.True;
            productList.Size = new Size(1188, 525);
            productList.TabIndex = 0;
            productList.CellContentClick += productList_CellContentClick;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 200F;
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 280;
            // 
            // Precio
            // 
            Precio.Frozen = true;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 150;
            // 
            // Stock
            // 
            Stock.Frozen = true;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.Frozen = true;
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 200;
            // 
            // Categoria
            // 
            Categoria.Frozen = true;
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 200;
            // 
            // Estado
            // 
            Estado.Frozen = true;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(43, 45);
            textBox1.MaximumSize = new Size(220, 35);
            textBox1.MinimumSize = new Size(220, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por Id o Nombre";
            textBox1.Size = new Size(220, 35);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Menu;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos", "Grano", "Molido", "Soluble" });
            comboBox1.Location = new Point(281, 43);
            comboBox1.MaximumSize = new Size(163, 0);
            comboBox1.MinimumSize = new Size(163, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 3;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 663);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(productList);
            Cursor = Cursors.Hand;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)productList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productList;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Estado;
        private ComboBox comboBox1;
    }
}