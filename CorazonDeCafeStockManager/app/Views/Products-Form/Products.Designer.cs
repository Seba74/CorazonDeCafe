﻿namespace CorazonDeCafeStockManager
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            productList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            IcSearch = new PictureBox();
            ipSearch = new utils.Custom.TextBox.TextBoxCustom();
            selectCategory = new ComboBoxCustom();
            ((System.ComponentModel.ISupportInitialize)productList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IcSearch).BeginInit();
            SuspendLayout();
            // 
            // productList
            // 
            productList.AllowUserToAddRows = false;
            productList.AllowUserToDeleteRows = false;
            productList.AllowUserToResizeColumns = false;
            productList.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            productList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            productList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productList.BackgroundColor = SystemColors.MenuBar;
            productList.BorderStyle = BorderStyle.None;
            productList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productList.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Stock, Tipo, Categoria, Estado });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            productList.DefaultCellStyle = dataGridViewCellStyle12;
            productList.GridColor = SystemColors.WindowText;
            productList.Location = new Point(12, 132);
            productList.MultiSelect = false;
            productList.Name = "productList";
            productList.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.IndianRed;
            dataGridViewCellStyle13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            productList.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            productList.RowHeadersVisible = false;
            productList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            productList.RowsDefaultCellStyle = dataGridViewCellStyle14;
            productList.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            productList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            productList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 219, 197);
            productList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            productList.RowTemplate.Height = 35;
            productList.RowTemplate.Resizable = DataGridViewTriState.False;
            productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productList.Size = new Size(773, 519);
            productList.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            Id.DefaultCellStyle = dataGridViewCellStyle10;
            Id.FillWeight = 50F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.FillWeight = 200F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle11;
            Precio.FillWeight = 80F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.FillWeight = 50F;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // IcSearch
            // 
            IcSearch.BackColor = Color.FromArgb(255, 219, 197);
            IcSearch.Image = (Image)resources.GetObject("IcSearch.Image");
            IcSearch.Location = new Point(217, 72);
            IcSearch.Name = "IcSearch";
            IcSearch.Size = new Size(25, 24);
            IcSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            IcSearch.TabIndex = 2;
            IcSearch.TabStop = false;
            // 
            // ipSearch
            // 
            ipSearch.BackColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipSearch.BorderRadius = 5;
            ipSearch.BorderSize = 2;
            ipSearch.Cursor = Cursors.Hand;
            ipSearch.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ipSearch.Location = new Point(12, 65);
            ipSearch.Multiline = false;
            ipSearch.Name = "ipSearch";
            ipSearch.Padding = new Padding(8, 6, 4, 4);
            ipSearch.PasswordChar = false;
            ipSearch.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSearch.PlaceholderText = "Buscar...";
            ipSearch.Size = new Size(243, 37);
            ipSearch.TabIndex = 12;
            ipSearch.Texts = "";
            ipSearch.UnderlinedStyle = false;
            // 
            // selectCategory
            // 
            selectCategory.BackColor = Color.FromArgb(255, 219, 197);
            selectCategory.BorderColor = Color.FromArgb(145, 90, 57);
            selectCategory.BorderRadius = 5;
            selectCategory.BorderSize = 0;
            selectCategory.DropDownStyle = ComboBoxStyle.DropDown;
            selectCategory.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectCategory.ForeColor = Color.FromArgb(145, 90, 57);
            selectCategory.IconColor = Color.FromArgb(145, 90, 57);
            selectCategory.ListBackColor = Color.FromArgb(230, 228, 245);
            selectCategory.ListTextColor = Color.FromArgb(145, 90, 57);
            selectCategory.Location = new Point(276, 65);
            selectCategory.MinimumSize = new Size(200, 30);
            selectCategory.Name = "selectCategory";
            selectCategory.Size = new Size(200, 37);
            selectCategory.TabIndex = 13;
            selectCategory.Texts = "Categorias";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 663);
            Controls.Add(selectCategory);
            Controls.Add(IcSearch);
            Controls.Add(ipSearch);
            Controls.Add(productList);
            Cursor = Cursors.Hand;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)productList).EndInit();
            ((System.ComponentModel.ISupportInitialize)IcSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productList;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridViewButtonColumn Accion;
        private utils.Custom.TextBox.TextBoxCustom ipSearch;
        private PictureBox IcSearch;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Estado;
        private ComboBoxCustom selectCategory;
    }
}