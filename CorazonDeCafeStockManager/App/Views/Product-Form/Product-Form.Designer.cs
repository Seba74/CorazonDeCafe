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
            lblTitle = new Label();
            selectType = new ComboBox();
            selectCategory = new ComboBox();
            iName = new TextBox();
            iEstado = new TextBox();
            iPrice = new TextBox();
            iStock = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnSave = new ButtonCustom();
            btnCancel = new ButtonCustom();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 15);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Producto:";
            // 
            // selectType
            // 
            selectType.DisplayMember = "Soluble";
            selectType.FormattingEnabled = true;
            selectType.Location = new Point(279, 179);
            selectType.Name = "selectType";
            selectType.Size = new Size(121, 23);
            selectType.TabIndex = 13;
            selectType.Text = "Tipo";
            selectType.ValueMember = "1";
            // 
            // selectCategory
            // 
            selectCategory.DisplayMember = "Soluble";
            selectCategory.FormattingEnabled = true;
            selectCategory.Location = new Point(459, 179);
            selectCategory.Name = "selectCategory";
            selectCategory.Size = new Size(121, 23);
            selectCategory.TabIndex = 14;
            selectCategory.Text = "Categoría";
            selectCategory.ValueMember = "1";
            // 
            // iName
            // 
            iName.Location = new Point(24, 101);
            iName.Name = "iName";
            iName.PlaceholderText = "Nombre";
            iName.Size = new Size(100, 23);
            iName.TabIndex = 15;
            // 
            // iEstado
            // 
            iEstado.Location = new Point(152, 101);
            iEstado.Name = "iEstado";
            iEstado.PlaceholderText = "Estado";
            iEstado.Size = new Size(100, 23);
            iEstado.TabIndex = 16;
            // 
            // iPrice
            // 
            iPrice.Location = new Point(91, 243);
            iPrice.Name = "iPrice";
            iPrice.Size = new Size(100, 23);
            iPrice.TabIndex = 17;
            // 
            // iStock
            // 
            iStock.Location = new Point(300, 243);
            iStock.Name = "iStock";
            iStock.Size = new Size(100, 23);
            iStock.TabIndex = 18;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(216, 372);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 20;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(81, 372);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 21;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 219, 197);
            btnSave.BackgroundColor = Color.FromArgb(255, 219, 197);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(64, 0, 64);
            btnSave.Location = new Point(611, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 22;
            btnSave.Text = "Guardar";
            btnSave.TextColor = Color.FromArgb(64, 0, 64);
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 219, 197);
            btnCancel.BackgroundColor = Color.FromArgb(255, 219, 197);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(64, 0, 64);
            btnCancel.Location = new Point(322, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 40);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancelar";
            btnCancel.TextColor = Color.FromArgb(64, 0, 64);
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += buttonCustom1_Click;
            // 
            // Product_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(iStock);
            Controls.Add(iPrice);
            Controls.Add(iEstado);
            Controls.Add(iName);
            Controls.Add(selectCategory);
            Controls.Add(selectType);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private ComboBox selectType;
        private ComboBox selectCategory;
        private TextBox iName;
        private TextBox iEstado;
        private TextBox iPrice;
        private TextBox iStock;
        private Button button1;
        private Button button2;
        private ButtonCustom btnSave;
        private ButtonCustom btnCancel;
    }
}