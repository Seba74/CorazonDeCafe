namespace CorazonDeCafeStockManager
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            productList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ipSearch = new utils.Custom.TextBox.TextBoxCustom();
            panel1 = new Panel();
            reload = new ButtonCustom();
            btnEdit = new ButtonCustom();
            IcSearch = new PictureBox();
            selectType = new ComboBoxCustom();
            btnAdd = new ButtonCustom();
            selectCategory = new ComboBoxCustom();
            ((System.ComponentModel.ISupportInitialize)productList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IcSearch).BeginInit();
            SuspendLayout();
            // 
            // productList
            // 
            productList.AllowUserToAddRows = false;
            productList.AllowUserToDeleteRows = false;
            productList.AllowUserToResizeColumns = false;
            productList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            productList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productList.BackgroundColor = SystemColors.MenuBar;
            productList.BorderStyle = BorderStyle.None;
            productList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productList.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Stock, Tipo, Categoria, Estado });
            productList.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            productList.DefaultCellStyle = dataGridViewCellStyle5;
            productList.GridColor = SystemColors.WindowText;
            productList.Location = new Point(12, 153);
            productList.MultiSelect = false;
            productList.Name = "productList";
            productList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.IndianRed;
            dataGridViewCellStyle6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            productList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            productList.RowHeadersVisible = false;
            productList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            productList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            productList.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            productList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            productList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 219, 197);
            productList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            productList.RowTemplate.Height = 35;
            productList.RowTemplate.Resizable = DataGridViewTriState.False;
            productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productList.Size = new Size(918, 498);
            productList.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Id.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle4;
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
            // ipSearch
            // 
            ipSearch.BackColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipSearch.BorderRadius = 5;
            ipSearch.BorderSize = 2;
            ipSearch.Cursor = Cursors.IBeam;
            ipSearch.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ipSearch.Location = new Point(0, 14);
            ipSearch.MaximumSize = new Size(650, 38);
            ipSearch.Multiline = false;
            ipSearch.Name = "ipSearch";
            ipSearch.Padding = new Padding(8, 8, 4, 6);
            ipSearch.PasswordChar = false;
            ipSearch.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSearch.PlaceholderText = "Buscar...";
            ipSearch.Size = new Size(257, 38);
            ipSearch.TabIndex = 12;
            ipSearch.Texts = "";
            ipSearch.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(reload);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(IcSearch);
            panel1.Controls.Add(selectType);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(ipSearch);
            panel1.Controls.Add(selectCategory);
            panel1.Location = new Point(12, 77);
            panel1.MaximumSize = new Size(1800, 65);
            panel1.MinimumSize = new Size(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 65);
            panel1.TabIndex = 17;
            // 
            // reload
            // 
            reload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            reload.BackColor = Color.Transparent;
            reload.BackgroundColor = Color.Transparent;
            reload.BackgroundImageLayout = ImageLayout.Zoom;
            reload.BorderColor = Color.FromArgb(145, 90, 57);
            reload.BorderRadius = 5;
            reload.BorderSize = 2;
            reload.Cursor = Cursors.Hand;
            reload.FlatAppearance.BorderSize = 0;
            reload.FlatStyle = FlatStyle.Flat;
            reload.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            reload.ForeColor = Color.FromArgb(145, 90, 57);
            reload.Image = Properties.Resources.reload;
            reload.Location = new Point(847, 15);
            reload.MaximumSize = new Size(80, 38);
            reload.Name = "reload";
            reload.Padding = new Padding(6, 0, 6, 0);
            reload.Size = new Size(50, 38);
            reload.TabIndex = 19;
            reload.TextAlign = ContentAlignment.MiddleLeft;
            reload.TextColor = Color.FromArgb(145, 90, 57);
            reload.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(145, 90, 57);
            btnEdit.BorderRadius = 5;
            btnEdit.BorderSize = 2;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(145, 90, 57);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(734, 15);
            btnEdit.MaximumSize = new Size(160, 38);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(6, 0, 6, 0);
            btnEdit.Size = new Size(107, 38);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Editar";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextColor = Color.FromArgb(145, 90, 57);
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // IcSearch
            // 
            IcSearch.BackColor = Color.FromArgb(255, 219, 197);
            IcSearch.Image = (Image)resources.GetObject("IcSearch.Image");
            IcSearch.Location = new Point(227, 21);
            IcSearch.Name = "IcSearch";
            IcSearch.Size = new Size(25, 24);
            IcSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            IcSearch.TabIndex = 2;
            IcSearch.TabStop = false;
            // 
            // selectType
            // 
            selectType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectType.BackColor = Color.FromArgb(255, 219, 197);
            selectType.BorderColor = Color.FromArgb(145, 90, 57);
            selectType.BorderRadius = 5;
            selectType.BorderSize = 0;
            selectType.DropDownStyle = ComboBoxStyle.DropDown;
            selectType.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectType.ForeColor = Color.FromArgb(145, 90, 57);
            selectType.IconColor = Color.FromArgb(145, 90, 57);
            selectType.Items.AddRange(new object[] { "Origen", "Sostenible", "Premium" });
            selectType.ListBackColor = Color.FromArgb(230, 228, 245);
            selectType.ListTextColor = Color.FromArgb(145, 90, 57);
            selectType.Location = new Point(268, 13);
            selectType.MaximumSize = new Size(200, 38);
            selectType.MinimumSize = new Size(110, 37);
            selectType.Name = "selectType";
            selectType.Padding = new Padding(0, 0, 0, 2);
            selectType.Size = new Size(110, 38);
            selectType.TabIndex = 14;
            selectType.Texts = "Tipo";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundColor = Color.Transparent;
            btnAdd.BorderColor = Color.FromArgb(145, 90, 57);
            btnAdd.BorderRadius = 5;
            btnAdd.BorderSize = 2;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(145, 90, 57);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(605, 14);
            btnAdd.MaximumSize = new Size(160, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(6, 0, 6, 0);
            btnAdd.Size = new Size(123, 38);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextColor = Color.FromArgb(145, 90, 57);
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // selectCategory
            // 
            selectCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectCategory.BackColor = Color.FromArgb(255, 219, 197);
            selectCategory.BorderColor = Color.FromArgb(145, 90, 57);
            selectCategory.BorderRadius = 5;
            selectCategory.BorderSize = 0;
            selectCategory.DropDownStyle = ComboBoxStyle.DropDown;
            selectCategory.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectCategory.ForeColor = Color.FromArgb(145, 90, 57);
            selectCategory.IconColor = Color.FromArgb(145, 90, 57);
            selectCategory.Items.AddRange(new object[] { "Soluble", "Molido", "Grano" });
            selectCategory.ListBackColor = Color.FromArgb(230, 228, 245);
            selectCategory.ListTextColor = Color.FromArgb(145, 90, 57);
            selectCategory.Location = new Point(392, 13);
            selectCategory.MaximumSize = new Size(200, 38);
            selectCategory.MinimumSize = new Size(110, 30);
            selectCategory.Name = "selectCategory";
            selectCategory.Padding = new Padding(0, 0, 0, 2);
            selectCategory.Size = new Size(110, 38);
            selectCategory.TabIndex = 13;
            selectCategory.Texts = "Categoría";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 663);
            Controls.Add(panel1);
            Controls.Add(productList);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)productList).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IcSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productList;
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
        private ComboBoxCustom selectType;
        private Panel panel1;
        private ButtonCustom btnAdd;
        private ButtonCustom btnEdit;
        private ButtonCustom reload;
    }
}