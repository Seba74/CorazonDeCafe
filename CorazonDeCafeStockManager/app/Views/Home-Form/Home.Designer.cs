namespace CorazonDeCafeStockManager
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            btnProducts = new ButtonCustom();
            panel2 = new Panel();
            btnMin = new PictureBox();
            btnNormal = new PictureBox();
            btnClose = new PictureBox();
            btnMax = new PictureBox();
            viewPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProducts);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 614);
            panel1.TabIndex = 0;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MediumSlateBlue;
            btnProducts.BackgroundColor = Color.MediumSlateBlue;
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 8;
            btnProducts.BorderSize = 0;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(12, 89);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(129, 45);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextColor = Color.White;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(btnNormal);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnMax);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(154, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 50);
            panel2.TabIndex = 17;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Zoom;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Location = new Point(872, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(18, 18);
            btnMin.TabIndex = 21;
            btnMin.TabStop = false;
            btnMin.Click += BtnMin_Click;
            // 
            // btnNormal
            // 
            btnNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNormal.BackColor = Color.Transparent;
            btnNormal.BackgroundImage = (Image)resources.GetObject("btnNormal.BackgroundImage");
            btnNormal.BackgroundImageLayout = ImageLayout.Zoom;
            btnNormal.Cursor = Cursors.Hand;
            btnNormal.Location = new Point(911, 13);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(18, 18);
            btnNormal.TabIndex = 20;
            btnNormal.TabStop = false;
            btnNormal.Visible = false;
            btnNormal.Click += BtnNormal_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.close_m;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(947, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 23);
            btnClose.TabIndex = 18;
            btnClose.TabStop = false;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundImage = Properties.Resources.max;
            btnMax.BackgroundImageLayout = ImageLayout.Zoom;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Location = new Point(911, 12);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(18, 18);
            btnMax.TabIndex = 19;
            btnMax.TabStop = false;
            btnMax.Click += BtnMax_Click;
            // 
            // viewPanel
            // 
            viewPanel.Dock = DockStyle.Fill;
            viewPanel.Location = new Point(154, 50);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(980, 564);
            viewPanel.TabIndex = 19;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1134, 614);
            ControlBox = false;
            Controls.Add(viewPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Corazón De Café";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ButtonCustom btnProducts;
        private PictureBox btnMin;
        private PictureBox btnNormal;
        private PictureBox btnMax;
        private PictureBox btnClose;
        private Panel panel2;
        private Panel viewPanel;
    }
}