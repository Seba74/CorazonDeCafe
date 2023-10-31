namespace CorazonDeCafeStockManager.App.Views.PrintedBillingForm
{
    partial class PrintedBillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintedBillingForm));
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            barHPanel = new Panel();
            closeBtn = new PictureBox();
            panel1 = new Panel();
            panel14 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            panel11 = new Panel();
            label1 = new Label();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            orderSubtotal = new Label();
            label5 = new Label();
            label8 = new Label();
            orderIVA = new Label();
            orderTotal = new Label();
            label7 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            cartGrid = new DataGridView();
            Description = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            panel7 = new Panel();
            lblCoffeeLocation = new Label();
            lblCoffeeAddress = new Label();
            lblCoffeePhone = new Label();
            lblCoffeeName = new Label();
            lblCustomerCUIT = new Label();
            lblCustomerLocation = new Label();
            lblCustomerAddress = new Label();
            lblCustomerPhone = new Label();
            lblCustomerName = new Label();
            label4 = new Label();
            label3 = new Label();
            panel13 = new Panel();
            panel12 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            lblPaymentMethod = new Label();
            lblPm = new Label();
            lblBillingDate = new Label();
            label6 = new Label();
            lblBillingCode = new Label();
            lblBCode = new Label();
            barHPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            panel1.SuspendLayout();
            panel14.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // barHPanel
            // 
            barHPanel.BackColor = Color.FromArgb(255, 219, 197);
            barHPanel.Controls.Add(closeBtn);
            barHPanel.Dock = DockStyle.Top;
            barHPanel.Location = new Point(0, 0);
            barHPanel.MaximumSize = new Size(3400, 22);
            barHPanel.Name = "barHPanel";
            barHPanel.Size = new Size(595, 22);
            barHPanel.TabIndex = 27;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundImage = (Image)resources.GetObject("closeBtn.BackgroundImage");
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.ErrorImage = null;
            closeBtn.Location = new Point(566, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(22, 18);
            closeBtn.TabIndex = 34;
            closeBtn.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 197);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 636);
            panel1.MaximumSize = new Size(3400, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 99);
            panel1.TabIndex = 28;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel14.Controls.Add(label11);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(label9);
            panel14.Location = new Point(320, 22);
            panel14.Name = "panel14";
            panel14.Size = new Size(273, 69);
            panel14.TabIndex = 34;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Poppins Light", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(146, 90, 57);
            label11.Location = new Point(10, 40);
            label11.Name = "label11";
            label11.Size = new Size(146, 17);
            label11.TabIndex = 43;
            label11.Text = "corazondecafe@coffee.com";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Poppins Light", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(146, 90, 57);
            label10.Location = new Point(9, 26);
            label10.Name = "label10";
            label10.Size = new Size(242, 17);
            label10.TabIndex = 42;
            label10.Text = "referente a su factura puede contactarnos en :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Poppins Light", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(146, 90, 57);
            label9.Location = new Point(9, 12);
            label9.Name = "label9";
            label9.Size = new Size(236, 17);
            label9.TabIndex = 41;
            label9.Text = "Para mayor infomación o por alguna consulta";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(28, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 69);
            panel2.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(label1);
            panel11.Controls.Add(lblName);
            panel11.Location = new Point(61, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(189, 63);
            panel11.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(146, 90, 57);
            label1.Location = new Point(7, 36);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 41;
            label1.Text = "www.corazondecafe.com";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(146, 90, 57);
            lblName.Location = new Point(4, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(145, 28);
            lblName.TabIndex = 40;
            lblName.Text = "Corazón de Café";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(orderSubtotal);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(orderIVA);
            panel3.Controls.Add(orderTotal);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(352, 547);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 85);
            panel3.TabIndex = 1;
            // 
            // orderSubtotal
            // 
            orderSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderSubtotal.AutoSize = true;
            orderSubtotal.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderSubtotal.ForeColor = Color.Black;
            orderSubtotal.Location = new Point(143, 2);
            orderSubtotal.Name = "orderSubtotal";
            orderSubtotal.RightToLeft = RightToLeft.Yes;
            orderSubtotal.Size = new Size(51, 26);
            orderSubtotal.TabIndex = 65;
            orderSubtotal.Text = "00.00";
            orderSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(13, 51);
            label5.Name = "label5";
            label5.Size = new Size(74, 34);
            label5.TabIndex = 62;
            label5.Text = "TOTAL:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 2);
            label8.Name = "label8";
            label8.Size = new Size(87, 26);
            label8.TabIndex = 60;
            label8.Text = "SUBTOTAL:";
            // 
            // orderIVA
            // 
            orderIVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderIVA.AutoSize = true;
            orderIVA.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            orderIVA.ForeColor = Color.Black;
            orderIVA.Location = new Point(143, 28);
            orderIVA.Name = "orderIVA";
            orderIVA.RightToLeft = RightToLeft.Yes;
            orderIVA.Size = new Size(51, 26);
            orderIVA.TabIndex = 64;
            orderIVA.Text = "00.00";
            orderIVA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderTotal
            // 
            orderTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderTotal.AutoSize = true;
            orderTotal.Font = new Font("Poppins Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            orderTotal.ForeColor = Color.Red;
            orderTotal.Location = new Point(120, 51);
            orderTotal.Name = "orderTotal";
            orderTotal.RightToLeft = RightToLeft.Yes;
            orderTotal.Size = new Size(78, 34);
            orderTotal.TabIndex = 63;
            orderTotal.Text = "000.00";
            orderTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 28);
            label7.Name = "label7";
            label7.Size = new Size(66, 26);
            label7.TabIndex = 61;
            label7.Text = "IVA 19%:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 290);
            panel4.Name = "panel4";
            panel4.Size = new Size(595, 256);
            panel4.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(cartGrid);
            panel5.Location = new Point(28, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(539, 247);
            panel5.TabIndex = 2;
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.AllowUserToDeleteRows = false;
            cartGrid.AllowUserToResizeColumns = false;
            cartGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            cartGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            cartGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartGrid.BackgroundColor = SystemColors.Menu;
            cartGrid.BorderStyle = BorderStyle.None;
            cartGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            cartGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            cartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Columns.AddRange(new DataGridViewColumn[] { Description, Precio, amount });
            cartGrid.Cursor = Cursors.Hand;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            cartGrid.DefaultCellStyle = dataGridViewCellStyle12;
            cartGrid.Enabled = false;
            cartGrid.GridColor = SystemColors.WindowText;
            cartGrid.Location = new Point(6, 3);
            cartGrid.MultiSelect = false;
            cartGrid.Name = "cartGrid";
            cartGrid.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.IndianRed;
            dataGridViewCellStyle13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            cartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            cartGrid.RowHeadersVisible = false;
            cartGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            cartGrid.RowsDefaultCellStyle = dataGridViewCellStyle14;
            cartGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            cartGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            cartGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 219, 197);
            cartGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            cartGrid.RowTemplate.Height = 35;
            cartGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            cartGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cartGrid.Size = new Size(528, 241);
            cartGrid.TabIndex = 45;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.FillWeight = 160F;
            Description.HeaderText = "Descripción";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle10;
            Precio.FillWeight = 72F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // amount
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            amount.DefaultCellStyle = dataGridViewCellStyle11;
            amount.FillWeight = 60F;
            amount.HeaderText = "Cantidad";
            amount.MaxInputLength = 2;
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(145, 90, 57);
            panel6.Location = new Point(27, 287);
            panel6.MaximumSize = new Size(3400, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(540, 2);
            panel6.TabIndex = 30;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblCoffeeLocation);
            panel7.Controls.Add(lblCoffeeAddress);
            panel7.Controls.Add(lblCoffeePhone);
            panel7.Controls.Add(lblCoffeeName);
            panel7.Controls.Add(lblCustomerCUIT);
            panel7.Controls.Add(lblCustomerLocation);
            panel7.Controls.Add(lblCustomerAddress);
            panel7.Controls.Add(lblCustomerPhone);
            panel7.Controls.Add(lblCustomerName);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(panel13);
            panel7.Controls.Add(panel12);
            panel7.Location = new Point(28, 79);
            panel7.Name = "panel7";
            panel7.Size = new Size(539, 145);
            panel7.TabIndex = 31;
            // 
            // lblCoffeeLocation
            // 
            lblCoffeeLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCoffeeLocation.AutoSize = true;
            lblCoffeeLocation.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoffeeLocation.ForeColor = Color.Black;
            lblCoffeeLocation.Location = new Point(312, 94);
            lblCoffeeLocation.Name = "lblCoffeeLocation";
            lblCoffeeLocation.Size = new Size(109, 22);
            lblCoffeeLocation.TabIndex = 51;
            lblCoffeeLocation.Text = "Corazón de Café";
            // 
            // lblCoffeeAddress
            // 
            lblCoffeeAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCoffeeAddress.AutoSize = true;
            lblCoffeeAddress.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoffeeAddress.ForeColor = Color.Black;
            lblCoffeeAddress.Location = new Point(312, 72);
            lblCoffeeAddress.Name = "lblCoffeeAddress";
            lblCoffeeAddress.Size = new Size(109, 22);
            lblCoffeeAddress.TabIndex = 50;
            lblCoffeeAddress.Text = "Corazón de Café";
            // 
            // lblCoffeePhone
            // 
            lblCoffeePhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCoffeePhone.AutoSize = true;
            lblCoffeePhone.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoffeePhone.ForeColor = Color.Black;
            lblCoffeePhone.Location = new Point(312, 50);
            lblCoffeePhone.Name = "lblCoffeePhone";
            lblCoffeePhone.Size = new Size(109, 22);
            lblCoffeePhone.TabIndex = 49;
            lblCoffeePhone.Text = "Corazón de Café";
            // 
            // lblCoffeeName
            // 
            lblCoffeeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCoffeeName.AutoSize = true;
            lblCoffeeName.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoffeeName.ForeColor = Color.Black;
            lblCoffeeName.Location = new Point(312, 28);
            lblCoffeeName.Name = "lblCoffeeName";
            lblCoffeeName.Size = new Size(109, 22);
            lblCoffeeName.TabIndex = 48;
            lblCoffeeName.Text = "Corazón de Café";
            // 
            // lblCustomerCUIT
            // 
            lblCustomerCUIT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerCUIT.AutoSize = true;
            lblCustomerCUIT.Enabled = false;
            lblCustomerCUIT.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerCUIT.ForeColor = Color.Black;
            lblCustomerCUIT.Location = new Point(14, 116);
            lblCustomerCUIT.Name = "lblCustomerCUIT";
            lblCustomerCUIT.Size = new Size(109, 22);
            lblCustomerCUIT.TabIndex = 47;
            lblCustomerCUIT.Text = "Corazón de Café";
            // 
            // lblCustomerLocation
            // 
            lblCustomerLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerLocation.AutoSize = true;
            lblCustomerLocation.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerLocation.ForeColor = Color.Black;
            lblCustomerLocation.Location = new Point(14, 94);
            lblCustomerLocation.Name = "lblCustomerLocation";
            lblCustomerLocation.Size = new Size(109, 22);
            lblCustomerLocation.TabIndex = 46;
            lblCustomerLocation.Text = "Corazón de Café";
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerAddress.ForeColor = Color.Black;
            lblCustomerAddress.Location = new Point(14, 72);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(109, 22);
            lblCustomerAddress.TabIndex = 45;
            lblCustomerAddress.Text = "Corazón de Café";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerPhone.ForeColor = Color.Black;
            lblCustomerPhone.Location = new Point(14, 50);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(109, 22);
            lblCustomerPhone.TabIndex = 44;
            lblCustomerPhone.Text = "Corazón de Café";
            // 
            // lblCustomerName
            // 
            lblCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(14, 28);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(109, 22);
            lblCustomerName.TabIndex = 42;
            lblCustomerName.Text = "Corazón de Café";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(146, 90, 57);
            label4.Location = new Point(309, 2);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 43;
            label4.Text = "Corazón de Café";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(146, 90, 57);
            label3.Location = new Point(10, 2);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 42;
            label3.Text = "Datos del cliente";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.None;
            panel13.BackColor = Color.FromArgb(145, 90, 57);
            panel13.Location = new Point(301, 7);
            panel13.Name = "panel13";
            panel13.Size = new Size(2, 120);
            panel13.TabIndex = 33;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.FromArgb(145, 90, 57);
            panel12.Location = new Point(2, 7);
            panel12.Name = "panel12";
            panel12.Size = new Size(2, 120);
            panel12.TabIndex = 32;
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Location = new Point(13, 26);
            panel8.Name = "panel8";
            panel8.Size = new Size(138, 51);
            panel8.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(146, 90, 57);
            label2.Location = new Point(7, 4);
            label2.Name = "label2";
            label2.Size = new Size(123, 42);
            label2.TabIndex = 42;
            label2.Text = "FACTURA";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.FromArgb(145, 90, 57);
            panel9.Location = new Point(27, 224);
            panel9.MaximumSize = new Size(3400, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(540, 2);
            panel9.TabIndex = 31;
            // 
            // panel10
            // 
            panel10.Controls.Add(lblPaymentMethod);
            panel10.Controls.Add(lblPm);
            panel10.Controls.Add(lblBillingDate);
            panel10.Controls.Add(label6);
            panel10.Controls.Add(lblBillingCode);
            panel10.Controls.Add(lblBCode);
            panel10.Location = new Point(28, 230);
            panel10.Name = "panel10";
            panel10.Size = new Size(539, 58);
            panel10.TabIndex = 33;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentMethod.ForeColor = Color.Black;
            lblPaymentMethod.Location = new Point(394, 33);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(113, 25);
            lblPaymentMethod.TabIndex = 57;
            lblPaymentMethod.Text = "Mercado Pago";
            // 
            // lblPm
            // 
            lblPm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPm.AutoSize = true;
            lblPm.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPm.ForeColor = Color.Black;
            lblPm.Location = new Point(380, 3);
            lblPm.Name = "lblPm";
            lblPm.Size = new Size(142, 28);
            lblPm.TabIndex = 56;
            lblPm.Text = "Método de Pago";
            // 
            // lblBillingDate
            // 
            lblBillingDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBillingDate.AutoSize = true;
            lblBillingDate.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBillingDate.ForeColor = Color.Black;
            lblBillingDate.Location = new Point(197, 33);
            lblBillingDate.Name = "lblBillingDate";
            lblBillingDate.Size = new Size(134, 25);
            lblBillingDate.TabIndex = 55;
            lblBillingDate.Text = "Fecha de Factura";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(194, 3);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 54;
            label6.Text = "Fecha de Compra";
            // 
            // lblBillingCode
            // 
            lblBillingCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBillingCode.AutoSize = true;
            lblBillingCode.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBillingCode.ForeColor = Color.Black;
            lblBillingCode.Location = new Point(53, 32);
            lblBillingCode.Name = "lblBillingCode";
            lblBillingCode.Size = new Size(55, 25);
            lblBillingCode.TabIndex = 53;
            lblBillingCode.Text = "000121";
            // 
            // lblBCode
            // 
            lblBCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBCode.AutoSize = true;
            lblBCode.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBCode.ForeColor = Color.Black;
            lblBCode.Location = new Point(6, 3);
            lblBCode.Name = "lblBCode";
            lblBCode.Size = new Size(161, 28);
            lblBCode.TabIndex = 52;
            lblBCode.Text = "Código de Factura";
            // 
            // PrintedBillingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(595, 735);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(barHPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrintedBillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            barHPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            panel1.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel barHPanel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox1;
        private Panel panel11;
        private Label lblName;
        private Label label1;
        private Label label2;
        private Panel panel12;
        private Panel panel13;
        private Label lblCustomerAddress;
        private Label lblCustomerPhone;
        private Label lblCustomerName;
        private Label label4;
        private Label label3;
        private Label lblCustomerLocation;
        private Label lblCoffeeName;
        private Label lblCustomerCUIT;
        private Label lblCoffeeLocation;
        private Label lblCoffeeAddress;
        private Label lblCoffeePhone;
        private Label lblBCode;
        private Label lblPaymentMethod;
        private Label lblPm;
        private Label lblBillingDate;
        private Label label6;
        private Label lblBillingCode;
        private DataGridView cartGrid;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn amount;
        private Label orderSubtotal;
        private Label label5;
        private Label label8;
        private Label orderIVA;
        private Label orderTotal;
        private Label label7;
        private Panel panel14;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox closeBtn;
    }
}