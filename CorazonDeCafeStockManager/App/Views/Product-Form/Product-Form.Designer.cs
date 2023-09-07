namespace CorazonDeCafeStockManager
{
    partial class Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Form));
            lblTitle = new Label();
            btnGoBack = new PictureBox();
            btnSave = new ButtonCustom();
            btnCancel = new ButtonCustom();
            btnDelete = new ButtonCustom();
            barHPanel = new Panel();
            ipName = new utils.Custom.TextBox.TextBoxCustom();
            ipStock = new utils.Custom.TextBox.TextBoxCustom();
            ipPrice = new utils.Custom.TextBox.TextBoxCustom();
            ipCategory = new ComboBoxCustom();
            ipType = new ComboBoxCustom();
            btnAddImage = new ButtonCustom();
            bgImagen = new PictureBox();
            showImage = new PictureBox();
            lblName = new Label();
            lblState = new Label();
            ipState = new ComboBoxCustom();
            lblPrice = new Label();
            lblCategory = new Label();
            lblType = new Label();
            lblStock = new Label();
            lblSelectImage = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnGoBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bgImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 15);
            lblTitle.TabIndex = 12;
            // 
            // btnGoBack
            // 
            btnGoBack.AccessibleDescription = "Volver Atrás";
            btnGoBack.AccessibleName = "Volver atrás";
            btnGoBack.BackgroundImage = (Image)resources.GetObject("btnGoBack.BackgroundImage");
            btnGoBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoBack.Location = new Point(12, 55);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(24, 28);
            btnGoBack.TabIndex = 24;
            btnGoBack.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundColor = Color.Transparent;
            btnSave.BorderColor = Color.FromArgb(79, 167, 135);
            btnSave.BorderRadius = 5;
            btnSave.BorderSize = 2;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 200, 164);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 197, 180);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(79, 167, 135);
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(765, 587);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6, 0, 5, 0);
            btnSave.Size = new Size(120, 45);
            btnSave.TabIndex = 22;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextColor = Color.FromArgb(79, 167, 135);
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(96, 96, 96);
            btnCancel.BorderRadius = 5;
            btnCancel.BorderSize = 2;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(164, 164, 164);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(204, 204, 204);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(96, 96, 96);
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(611, 587);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6, 0, 2, 0);
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.FromArgb(96, 96, 96);
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundColor = Color.Transparent;
            btnDelete.BorderColor = Color.FromArgb(255, 95, 95);
            btnDelete.BorderRadius = 5;
            btnDelete.BorderSize = 2;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 164, 164);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 204);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(255, 95, 95);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(46, 587);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(8, 0, 0, 0);
            btnDelete.Size = new Size(115, 45);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextColor = Color.FromArgb(255, 95, 95);
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // barHPanel
            // 
            barHPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            barHPanel.BackColor = Color.FromArgb(145, 90, 57);
            barHPanel.Location = new Point(0, 556);
            barHPanel.Name = "barHPanel";
            barHPanel.Size = new Size(942, 5);
            barHPanel.TabIndex = 26;
            // 
            // ipName
            // 
            ipName.BackColor = Color.FromArgb(255, 219, 197);
            ipName.BorderColor = Color.FromArgb(255, 219, 197);
            ipName.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipName.BorderRadius = 5;
            ipName.BorderSize = 2;
            ipName.Cursor = Cursors.Hand;
            ipName.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipName.Location = new Point(100, 166);
            ipName.MaximumSize = new Size(650, 37);
            ipName.MinimumSize = new Size(250, 34);
            ipName.Multiline = false;
            ipName.Name = "ipName";
            ipName.Padding = new Padding(8, 6, 4, 2);
            ipName.PasswordChar = false;
            ipName.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipName.PlaceholderText = "Corazón de Café";
            ipName.Size = new Size(354, 34);
            ipName.TabIndex = 27;
            ipName.Texts = "";
            ipName.UnderlinedStyle = false;
            // 
            // ipStock
            // 
            ipStock.BackColor = Color.FromArgb(255, 219, 197);
            ipStock.BorderColor = Color.FromArgb(255, 219, 197);
            ipStock.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipStock.BorderRadius = 5;
            ipStock.BorderSize = 2;
            ipStock.Cursor = Cursors.Hand;
            ipStock.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipStock.Location = new Point(101, 422);
            ipStock.MaximumSize = new Size(650, 37);
            ipStock.MinimumSize = new Size(100, 34);
            ipStock.Multiline = false;
            ipStock.Name = "ipStock";
            ipStock.Padding = new Padding(10, 6, 4, 2);
            ipStock.PasswordChar = false;
            ipStock.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipStock.PlaceholderText = "5";
            ipStock.Size = new Size(121, 34);
            ipStock.TabIndex = 28;
            ipStock.Texts = "";
            ipStock.UnderlinedStyle = false;
            // 
            // ipPrice
            // 
            ipPrice.BackColor = Color.FromArgb(255, 219, 197);
            ipPrice.BorderColor = Color.FromArgb(255, 219, 197);
            ipPrice.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipPrice.BorderRadius = 5;
            ipPrice.BorderSize = 2;
            ipPrice.Cursor = Cursors.Hand;
            ipPrice.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipPrice.Location = new Point(294, 248);
            ipPrice.MaximumSize = new Size(650, 37);
            ipPrice.MinimumSize = new Size(100, 34);
            ipPrice.Multiline = false;
            ipPrice.Name = "ipPrice";
            ipPrice.Padding = new Padding(10, 6, 4, 2);
            ipPrice.PasswordChar = false;
            ipPrice.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPrice.PlaceholderText = "3333.33";
            ipPrice.Size = new Size(160, 34);
            ipPrice.TabIndex = 33;
            ipPrice.Texts = "";
            ipPrice.UnderlinedStyle = false;
            // 
            // ipCategory
            // 
            ipCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ipCategory.BackColor = Color.FromArgb(255, 219, 197);
            ipCategory.BorderColor = Color.FromArgb(145, 90, 57);
            ipCategory.BorderRadius = 5;
            ipCategory.BorderSize = 0;
            ipCategory.DropDownStyle = ComboBoxStyle.DropDown;
            ipCategory.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipCategory.ForeColor = Color.FromArgb(145, 90, 57);
            ipCategory.IconColor = Color.FromArgb(145, 90, 57);
            ipCategory.Items.AddRange(new object[] { "Grano", "Molido", "Soluble" });
            ipCategory.ListBackColor = Color.FromArgb(230, 228, 245);
            ipCategory.ListTextColor = Color.Black;
            ipCategory.Location = new Point(100, 341);
            ipCategory.MaximumSize = new Size(200, 37);
            ipCategory.MinimumSize = new Size(110, 32);
            ipCategory.Name = "ipCategory";
            ipCategory.Size = new Size(160, 32);
            ipCategory.TabIndex = 34;
            ipCategory.Texts = "Categoría";
            // 
            // ipType
            // 
            ipType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ipType.BackColor = Color.FromArgb(255, 219, 197);
            ipType.BorderColor = Color.FromArgb(145, 90, 57);
            ipType.BorderRadius = 5;
            ipType.BorderSize = 0;
            ipType.DropDownStyle = ComboBoxStyle.DropDown;
            ipType.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipType.ForeColor = Color.FromArgb(145, 90, 57);
            ipType.IconColor = Color.FromArgb(145, 90, 57);
            ipType.Items.AddRange(new object[] { "Origen", "Sostenible", "Premium" });
            ipType.ListBackColor = Color.FromArgb(230, 228, 245);
            ipType.ListTextColor = Color.Black;
            ipType.Location = new Point(294, 341);
            ipType.MaximumSize = new Size(200, 37);
            ipType.MinimumSize = new Size(110, 32);
            ipType.Name = "ipType";
            ipType.Size = new Size(160, 32);
            ipType.TabIndex = 35;
            ipType.Texts = "Tipo";
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.FromArgb(255, 219, 197);
            btnAddImage.BackgroundColor = Color.FromArgb(255, 219, 197);
            btnAddImage.BorderColor = Color.PaleVioletRed;
            btnAddImage.BorderRadius = 5;
            btnAddImage.BorderSize = 0;
            btnAddImage.Cursor = Cursors.Hand;
            btnAddImage.FlatAppearance.BorderSize = 0;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddImage.ForeColor = Color.FromArgb(146, 90, 57);
            btnAddImage.Location = new Point(239, 422);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Padding = new Padding(8, 0, 0, 0);
            btnAddImage.Size = new Size(215, 34);
            btnAddImage.TabIndex = 36;
            btnAddImage.Text = "Seleccione una imagen";
            btnAddImage.TextAlign = ContentAlignment.MiddleLeft;
            btnAddImage.TextColor = Color.FromArgb(146, 90, 57);
            btnAddImage.UseVisualStyleBackColor = false;
            // 
            // bgImagen
            // 
            bgImagen.BackColor = Color.Transparent;
            bgImagen.Image = (Image)resources.GetObject("bgImagen.Image");
            bgImagen.Location = new Point(564, 157);
            bgImagen.Name = "bgImagen";
            bgImagen.Size = new Size(239, 327);
            bgImagen.TabIndex = 38;
            bgImagen.TabStop = false;
            bgImagen.Visible = false;
            // 
            // showImage
            // 
            showImage.BackColor = Color.Transparent;
            showImage.BackgroundImageLayout = ImageLayout.Zoom;
            showImage.Location = new Point(564, 157);
            showImage.Name = "showImage";
            showImage.Size = new Size(239, 304);
            showImage.SizeMode = PictureBoxSizeMode.Zoom;
            showImage.TabIndex = 37;
            showImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(146, 90, 57);
            lblName.Location = new Point(101, 137);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 26);
            lblName.TabIndex = 39;
            lblName.Text = "Nombre";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.ForeColor = Color.FromArgb(146, 90, 57);
            lblState.Location = new Point(101, 219);
            lblState.Name = "lblState";
            lblState.Size = new Size(63, 26);
            lblState.TabIndex = 40;
            lblState.Text = "Estado";
            // 
            // ipState
            // 
            ipState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ipState.BackColor = Color.FromArgb(255, 219, 197);
            ipState.BorderColor = Color.FromArgb(145, 90, 57);
            ipState.BorderRadius = 5;
            ipState.BorderSize = 0;
            ipState.DropDownStyle = ComboBoxStyle.DropDown;
            ipState.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipState.ForeColor = Color.Black;
            ipState.IconColor = Color.FromArgb(145, 90, 57);
            ipState.Items.AddRange(new object[] { "Activo", "Inactivo" });
            ipState.ListBackColor = Color.FromArgb(230, 228, 245);
            ipState.ListTextColor = Color.Black;
            ipState.Location = new Point(101, 250);
            ipState.MaximumSize = new Size(200, 37);
            ipState.MinimumSize = new Size(110, 32);
            ipState.Name = "ipState";
            ipState.Size = new Size(160, 32);
            ipState.TabIndex = 41;
            ipState.Texts = "Activo";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(146, 90, 57);
            lblPrice.Location = new Point(294, 219);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 26);
            lblPrice.TabIndex = 42;
            lblPrice.Text = "Precio";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.FromArgb(146, 90, 57);
            lblCategory.Location = new Point(101, 312);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(86, 26);
            lblCategory.TabIndex = 43;
            lblCategory.Text = "Categoría";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.ForeColor = Color.FromArgb(146, 90, 57);
            lblType.Location = new Point(294, 312);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 26);
            lblType.TabIndex = 44;
            lblType.Text = "Tipo";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.ForeColor = Color.FromArgb(146, 90, 57);
            lblStock.Location = new Point(101, 393);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 26);
            lblStock.TabIndex = 45;
            lblStock.Text = "Stock";
            // 
            // lblSelectImage
            // 
            lblSelectImage.AutoSize = true;
            lblSelectImage.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectImage.ForeColor = Color.FromArgb(146, 90, 57);
            lblSelectImage.Location = new Point(239, 393);
            lblSelectImage.Name = "lblSelectImage";
            lblSelectImage.Size = new Size(68, 26);
            lblSelectImage.TabIndex = 46;
            lblSelectImage.Text = "Imagen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(146, 90, 57);
            label8.Location = new Point(92, 52);
            label8.Name = "label8";
            label8.Size = new Size(180, 37);
            label8.TabIndex = 47;
            label8.Text = "Nuevo Producto";
            // 
            // Product_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 663);
            Controls.Add(label8);
            Controls.Add(lblSelectImage);
            Controls.Add(lblStock);
            Controls.Add(lblType);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(ipState);
            Controls.Add(lblState);
            Controls.Add(lblName);
            Controls.Add(showImage);
            Controls.Add(bgImagen);
            Controls.Add(btnAddImage);
            Controls.Add(ipType);
            Controls.Add(ipCategory);
            Controls.Add(ipPrice);
            Controls.Add(ipStock);
            Controls.Add(ipName);
            Controls.Add(barHPanel);
            Controls.Add(btnDelete);
            Controls.Add(btnGoBack);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_Form";
            ((System.ComponentModel.ISupportInitialize)btnGoBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)bgImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)showImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private PictureBox btnGoBack;
        private ButtonCustom btnSave;
        private ButtonCustom btnCancel;
        private ButtonCustom btnDelete;
        private Panel barHPanel;
        private utils.Custom.TextBox.TextBoxCustom ipName;
        private utils.Custom.TextBox.TextBoxCustom ipStock;
        private utils.Custom.TextBox.TextBoxCustom ipPrice;
        private ComboBoxCustom ipCategory;
        private ComboBoxCustom ipType;
        private ButtonCustom btnAddImage;
        private PictureBox bgImagen;
        private PictureBox showImage;
        private Label lblName;
        private Label lblState;
        private ComboBoxCustom ipState;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblType;
        private Label lblStock;
        private Label lblSelectImage;
        private Label label8;
    }
}