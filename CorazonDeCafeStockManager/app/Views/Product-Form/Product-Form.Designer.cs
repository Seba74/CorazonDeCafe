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
            btnMin = new PictureBox();
            btnNormal = new PictureBox();
            btnMax = new PictureBox();
            btnClose = new PictureBox();
            lblTitle = new Label();
            selectType = new ComboBox();
            selectCategory = new ComboBox();
            iName = new TextBox();
            iEstado = new TextBox();
            iPrice = new TextBox();
            iStock = new TextBox();
            btnSend = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Zoom;
            btnMin.Location = new Point(690, 14);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(18, 18);
            btnMin.TabIndex = 11;
            btnMin.TabStop = false;
            // 
            // btnNormal
            // 
            btnNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNormal.BackColor = Color.Transparent;
            btnNormal.BackgroundImage = (Image)resources.GetObject("btnNormal.BackgroundImage");
            btnNormal.BackgroundImageLayout = ImageLayout.Zoom;
            btnNormal.Location = new Point(729, 14);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(18, 18);
            btnNormal.TabIndex = 10;
            btnNormal.TabStop = false;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundImage = Properties.Resources.max;
            btnMax.BackgroundImageLayout = ImageLayout.Zoom;
            btnMax.Location = new Point(729, 14);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(18, 18);
            btnMax.TabIndex = 9;
            btnMax.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.close_m;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(765, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 23);
            btnClose.TabIndex = 8;
            btnClose.TabStop = false;
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
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.None;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Location = new Point(586, 372);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 39);
            btnSend.TabIndex = 19;
            btnSend.Text = "Guardar";
            btnSend.UseVisualStyleBackColor = true;
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
            // Product_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSend);
            Controls.Add(iStock);
            Controls.Add(iPrice);
            Controls.Add(iEstado);
            Controls.Add(iName);
            Controls.Add(selectCategory);
            Controls.Add(selectType);
            Controls.Add(lblTitle);
            Controls.Add(btnMin);
            Controls.Add(btnNormal);
            Controls.Add(btnMax);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_Form";
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnMin;
        private PictureBox btnNormal;
        private PictureBox btnMax;
        private PictureBox btnClose;
        private Label lblTitle;
        private ComboBox selectType;
        private ComboBox selectCategory;
        private TextBox iName;
        private TextBox iEstado;
        private TextBox iPrice;
        private TextBox iStock;
        private Button btnSend;
        private Button button1;
        private Button button2;
    }
}