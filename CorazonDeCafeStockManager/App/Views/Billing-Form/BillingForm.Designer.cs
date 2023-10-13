namespace CorazonDeCafeStockManager
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCustomer = new ButtonCustom();
            lblName = new Label();
            IcSearch = new PictureBox();
            ipSearch = new utils.Custom.TextBox.TextBoxCustom();
            ipName = new utils.Custom.TextBox.TextBoxCustom();
            ipPhone = new utils.Custom.TextBox.TextBoxCustom();
            ipAddress = new utils.Custom.TextBox.TextBoxCustom();
            productsView = new Panel();
            cartGrid = new DataGridView();
            productId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            panel5 = new Panel();
            panel6 = new Panel();
            btnSave = new ButtonCustom();
            btnCancel = new ButtonCustom();
            panel3 = new Panel();
            ipPaymentMethod = new ComboBoxCustom();
            ipOrderType = new ComboBoxCustom();
            ipCUIT = new utils.Custom.TextBox.TextBoxCustom();
            orderSubtotal = new Label();
            orderIVA = new Label();
            orderTotal = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSubtotal = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IcSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ipName);
            panel1.Controls.Add(ipPhone);
            panel1.Controls.Add(ipAddress);
            panel1.Location = new Point(3, 38);
            panel1.MaximumSize = new Size(1800, 465);
            panel1.MinimumSize = new Size(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 174);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCustomer);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(IcSearch);
            panel2.Controls.Add(ipSearch);
            panel2.Location = new Point(9, 14);
            panel2.MaximumSize = new Size(1200, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 44);
            panel2.TabIndex = 44;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.BackgroundColor = Color.Transparent;
            btnCustomer.BackgroundImageLayout = ImageLayout.Center;
            btnCustomer.BorderColor = Color.FromArgb(145, 90, 57);
            btnCustomer.BorderRadius = 5;
            btnCustomer.BorderSize = 2;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.FromArgb(145, 90, 57);
            btnCustomer.Image = Properties.Resources.user_search;
            btnCustomer.Location = new Point(422, 6);
            btnCustomer.MaximumSize = new Size(36, 34);
            btnCustomer.MinimumSize = new Size(36, 34);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(7, 0, 6, 0);
            btnCustomer.Size = new Size(36, 34);
            btnCustomer.TabIndex = 81;
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextColor = Color.FromArgb(145, 90, 57);
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(146, 90, 57);
            lblName.Location = new Point(4, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 26);
            lblName.TabIndex = 41;
            lblName.Text = "Cliente";
            // 
            // IcSearch
            // 
            IcSearch.BackColor = Color.FromArgb(255, 219, 197);
            IcSearch.Image = (Image)resources.GetObject("IcSearch.Image");
            IcSearch.Location = new Point(386, 12);
            IcSearch.Name = "IcSearch";
            IcSearch.Size = new Size(25, 24);
            IcSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            IcSearch.TabIndex = 2;
            IcSearch.TabStop = false;
            // 
            // ipSearch
            // 
            ipSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipSearch.BackColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipSearch.BorderRadius = 5;
            ipSearch.BorderSize = 2;
            ipSearch.Cursor = Cursors.IBeam;
            ipSearch.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipSearch.Location = new Point(72, 7);
            ipSearch.MaximumSize = new Size(1200, 32);
            ipSearch.MinimumSize = new Size(255, 32);
            ipSearch.Multiline = false;
            ipSearch.Name = "ipSearch";
            ipSearch.Padding = new Padding(8, 5, 4, 0);
            ipSearch.PasswordChar = false;
            ipSearch.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSearch.PlaceholderText = "Buscar por DNI...";
            ipSearch.Size = new Size(343, 32);
            ipSearch.TabIndex = 82;
            ipSearch.Texts = "";
            ipSearch.UnderlinedStyle = false;
            // 
            // ipName
            // 
            ipName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipName.BackColor = Color.FromArgb(255, 219, 197);
            ipName.BorderColor = Color.FromArgb(255, 219, 197);
            ipName.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipName.BorderRadius = 5;
            ipName.BorderSize = 2;
            ipName.Cursor = Cursors.IBeam;
            ipName.Enabled = false;
            ipName.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipName.Location = new Point(14, 73);
            ipName.MaximumSize = new Size(1200, 32);
            ipName.MinimumSize = new Size(377, 32);
            ipName.Multiline = false;
            ipName.Name = "ipName";
            ipName.Padding = new Padding(8, 5, 4, 0);
            ipName.PasswordChar = false;
            ipName.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipName.PlaceholderText = "Nombre";
            ipName.Size = new Size(451, 32);
            ipName.TabIndex = 40;
            ipName.Texts = "";
            ipName.UnderlinedStyle = false;
            // 
            // ipPhone
            // 
            ipPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipPhone.BackColor = Color.FromArgb(255, 219, 197);
            ipPhone.BorderColor = Color.FromArgb(255, 219, 197);
            ipPhone.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipPhone.BorderRadius = 5;
            ipPhone.BorderSize = 2;
            ipPhone.Cursor = Cursors.IBeam;
            ipPhone.Enabled = false;
            ipPhone.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipPhone.Location = new Point(307, 122);
            ipPhone.MaximumSize = new Size(1200, 32);
            ipPhone.MinimumSize = new Size(0, 32);
            ipPhone.Multiline = false;
            ipPhone.Name = "ipPhone";
            ipPhone.Padding = new Padding(8, 6, 4, 2);
            ipPhone.PasswordChar = false;
            ipPhone.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPhone.PlaceholderText = "Teléfono";
            ipPhone.Size = new Size(158, 32);
            ipPhone.TabIndex = 43;
            ipPhone.Texts = "";
            ipPhone.UnderlinedStyle = false;
            // 
            // ipAddress
            // 
            ipAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipAddress.BackColor = Color.FromArgb(255, 219, 197);
            ipAddress.BorderColor = Color.FromArgb(255, 219, 197);
            ipAddress.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipAddress.BorderRadius = 5;
            ipAddress.BorderSize = 2;
            ipAddress.Cursor = Cursors.IBeam;
            ipAddress.Enabled = false;
            ipAddress.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipAddress.Location = new Point(14, 122);
            ipAddress.MaximumSize = new Size(1200, 32);
            ipAddress.MinimumSize = new Size(0, 32);
            ipAddress.Multiline = false;
            ipAddress.Name = "ipAddress";
            ipAddress.Padding = new Padding(8, 6, 4, 2);
            ipAddress.PasswordChar = false;
            ipAddress.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipAddress.PlaceholderText = "Dirección";
            ipAddress.Size = new Size(267, 32);
            ipAddress.TabIndex = 42;
            ipAddress.Texts = "";
            ipAddress.UnderlinedStyle = false;
            // 
            // productsView
            // 
            productsView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsView.Location = new Point(0, 184);
            productsView.MaximumSize = new Size(1200, 1200);
            productsView.Name = "productsView";
            productsView.Size = new Size(566, 467);
            productsView.TabIndex = 42;
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.AllowUserToDeleteRows = false;
            cartGrid.AllowUserToResizeColumns = false;
            cartGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            cartGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            cartGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartGrid.BackgroundColor = SystemColors.MenuBar;
            cartGrid.BorderStyle = BorderStyle.None;
            cartGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            cartGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle20.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = SystemColors.Window;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            cartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Columns.AddRange(new DataGridViewColumn[] { productId, Nombre, Precio, amount, Action });
            cartGrid.Cursor = Cursors.Hand;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle25.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle25.SelectionForeColor = Color.White;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.False;
            cartGrid.DefaultCellStyle = dataGridViewCellStyle25;
            cartGrid.GridColor = SystemColors.WindowText;
            cartGrid.Location = new Point(1, 0);
            cartGrid.MultiSelect = false;
            cartGrid.Name = "cartGrid";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.IndianRed;
            dataGridViewCellStyle26.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle26.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            cartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            cartGrid.RowHeadersVisible = false;
            cartGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle27.ForeColor = Color.White;
            dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle27.SelectionForeColor = Color.White;
            cartGrid.RowsDefaultCellStyle = dataGridViewCellStyle27;
            cartGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            cartGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            cartGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 219, 197);
            cartGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            cartGrid.RowTemplate.Height = 35;
            cartGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            cartGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cartGrid.Size = new Size(446, 251);
            cartGrid.TabIndex = 44;
            // 
            // productId
            // 
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productId.DefaultCellStyle = dataGridViewCellStyle21;
            productId.FillWeight = 30F;
            productId.HeaderText = "Id";
            productId.MaxInputLength = 4;
            productId.Name = "productId";
            productId.ReadOnly = true;
            productId.Visible = false;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.FillWeight = 160F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Format = "C2";
            dataGridViewCellStyle22.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle22;
            Precio.FillWeight = 72F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // amount
            // 
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            amount.DefaultCellStyle = dataGridViewCellStyle23;
            amount.FillWeight = 60F;
            amount.HeaderText = "Cantidad";
            amount.MaxInputLength = 2;
            amount.Name = "amount";
            // 
            // Action
            // 
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(145, 90, 57);
            dataGridViewCellStyle24.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.White;
            dataGridViewCellStyle24.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle24.SelectionForeColor = Color.LightGray;
            Action.DefaultCellStyle = dataGridViewCellStyle24;
            Action.FillWeight = 50F;
            Action.HeaderText = "Acción";
            Action.Name = "Action";
            Action.Text = "ELIMINAR";
            Action.UseColumnTextForButtonValue = true;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(cartGrid);
            panel5.Location = new Point(566, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(451, 605);
            panel5.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnCancel);
            panel6.Location = new Point(3, 518);
            panel6.MaximumSize = new Size(1800, 465);
            panel6.MinimumSize = new Size(0, 65);
            panel6.Name = "panel6";
            panel6.Size = new Size(445, 65);
            panel6.TabIndex = 51;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundColor = Color.Transparent;
            btnSave.BorderColor = Color.FromArgb(79, 167, 135);
            btnSave.BorderRadius = 5;
            btnSave.BorderSize = 2;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 200, 164);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 200, 190);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(79, 167, 135);
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(299, 13);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6, 0, 5, 0);
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 24;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextColor = Color.FromArgb(79, 167, 135);
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            btnCancel.Location = new Point(27, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6, 0, 2, 0);
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.FromArgb(96, 96, 96);
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(ipPaymentMethod);
            panel3.Controls.Add(ipOrderType);
            panel3.Controls.Add(ipCUIT);
            panel3.Controls.Add(orderSubtotal);
            panel3.Controls.Add(orderIVA);
            panel3.Controls.Add(orderTotal);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblSubtotal);
            panel3.Location = new Point(5, 333);
            panel3.MaximumSize = new Size(1800, 465);
            panel3.MinimumSize = new Size(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 170);
            panel3.TabIndex = 45;
            // 
            // ipPaymentMethod
            // 
            ipPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipPaymentMethod.BackColor = Color.FromArgb(255, 219, 197);
            ipPaymentMethod.BorderColor = Color.FromArgb(145, 90, 57);
            ipPaymentMethod.BorderRadius = 5;
            ipPaymentMethod.BorderSize = 0;
            ipPaymentMethod.DropDownStyle = ComboBoxStyle.DropDown;
            ipPaymentMethod.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipPaymentMethod.ForeColor = Color.FromArgb(145, 90, 57);
            ipPaymentMethod.IconColor = Color.FromArgb(145, 90, 57);
            ipPaymentMethod.ListBackColor = Color.FromArgb(230, 228, 245);
            ipPaymentMethod.ListTextColor = Color.Black;
            ipPaymentMethod.Location = new Point(25, 65);
            ipPaymentMethod.MaximumSize = new Size(200, 37);
            ipPaymentMethod.MinimumSize = new Size(110, 32);
            ipPaymentMethod.Name = "ipPaymentMethod";
            ipPaymentMethod.Size = new Size(200, 32);
            ipPaymentMethod.TabIndex = 62;
            ipPaymentMethod.Texts = "EFECTIVO";
            // 
            // ipOrderType
            // 
            ipOrderType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipOrderType.BackColor = Color.FromArgb(255, 219, 197);
            ipOrderType.BorderColor = Color.FromArgb(145, 90, 57);
            ipOrderType.BorderRadius = 5;
            ipOrderType.BorderSize = 0;
            ipOrderType.DropDownStyle = ComboBoxStyle.DropDown;
            ipOrderType.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipOrderType.ForeColor = Color.FromArgb(145, 90, 57);
            ipOrderType.IconColor = Color.FromArgb(145, 90, 57);
            ipOrderType.ListBackColor = Color.FromArgb(230, 228, 245);
            ipOrderType.ListTextColor = Color.Black;
            ipOrderType.Location = new Point(25, 18);
            ipOrderType.MaximumSize = new Size(200, 37);
            ipOrderType.MinimumSize = new Size(110, 32);
            ipOrderType.Name = "ipOrderType";
            ipOrderType.Size = new Size(200, 32);
            ipOrderType.TabIndex = 61;
            ipOrderType.Texts = "FACTURA B";
            // 
            // ipCUIT
            // 
            ipCUIT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipCUIT.BackColor = Color.FromArgb(255, 219, 197);
            ipCUIT.BorderColor = Color.FromArgb(255, 219, 197);
            ipCUIT.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipCUIT.BorderRadius = 5;
            ipCUIT.BorderSize = 2;
            ipCUIT.Cursor = Cursors.IBeam;
            ipCUIT.Enabled = false;
            ipCUIT.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipCUIT.Location = new Point(25, 114);
            ipCUIT.MaximumSize = new Size(1200, 32);
            ipCUIT.MinimumSize = new Size(200, 32);
            ipCUIT.Multiline = false;
            ipCUIT.Name = "ipCUIT";
            ipCUIT.Padding = new Padding(8, 5, 4, 0);
            ipCUIT.PasswordChar = false;
            ipCUIT.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipCUIT.PlaceholderText = "CUIT";
            ipCUIT.Size = new Size(200, 32);
            ipCUIT.TabIndex = 60;
            ipCUIT.Texts = "";
            ipCUIT.UnderlinedStyle = false;
            // 
            // orderSubtotal
            // 
            orderSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderSubtotal.AutoSize = true;
            orderSubtotal.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderSubtotal.ForeColor = Color.Black;
            orderSubtotal.Location = new Point(356, 24);
            orderSubtotal.Name = "orderSubtotal";
            orderSubtotal.RightToLeft = RightToLeft.Yes;
            orderSubtotal.Size = new Size(51, 26);
            orderSubtotal.TabIndex = 59;
            orderSubtotal.Text = "00.00";
            orderSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderIVA
            // 
            orderIVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderIVA.AutoSize = true;
            orderIVA.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderIVA.ForeColor = Color.Black;
            orderIVA.Location = new Point(360, 71);
            orderIVA.Name = "orderIVA";
            orderIVA.RightToLeft = RightToLeft.Yes;
            orderIVA.Size = new Size(51, 26);
            orderIVA.TabIndex = 58;
            orderIVA.Text = "00.00";
            orderIVA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderTotal
            // 
            orderTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderTotal.AutoSize = true;
            orderTotal.Font = new Font("Poppins Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            orderTotal.ForeColor = Color.Red;
            orderTotal.Location = new Point(327, 113);
            orderTotal.Name = "orderTotal";
            orderTotal.RightToLeft = RightToLeft.Yes;
            orderTotal.Size = new Size(91, 39);
            orderTotal.TabIndex = 57;
            orderTotal.Text = "000.00";
            orderTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(240, 115);
            label2.Name = "label2";
            label2.Size = new Size(74, 34);
            label2.TabIndex = 56;
            label2.Text = "TOTAL:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 71);
            label1.Name = "label1";
            label1.Size = new Size(66, 26);
            label1.TabIndex = 55;
            label1.Text = "IVA 19%:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.ForeColor = Color.Black;
            lblSubtotal.Location = new Point(242, 24);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(87, 26);
            lblSubtotal.TabIndex = 54;
            lblSubtotal.Text = "SUBTOTAL:";
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 663);
            Controls.Add(panel1);
            Controls.Add(productsView);
            Controls.Add(panel5);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IcSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private utils.Custom.TextBox.TextBoxCustom ipSearch;
        private PictureBox IcSearch;
        private Panel panel1;
        private utils.Custom.TextBox.TextBoxCustom ipName;
        private Label lblName;
        private Panel productsView;
        private utils.Custom.TextBox.TextBoxCustom ipPhone;
        private utils.Custom.TextBox.TextBoxCustom ipAddress;
        private ButtonCustom btnCustomer;
        private Panel panel2;
        private DataGridView cartGrid;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewButtonColumn Action;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private ButtonCustom btnSave;
        private ButtonCustom btnCancel;
        private ComboBoxCustom ipPaymentMethod;
        private ComboBoxCustom ipOrderType;
        private utils.Custom.TextBox.TextBoxCustom ipCUIT;
        private Label orderSubtotal;
        private Label orderIVA;
        private Label orderTotal;
        private Label label2;
        private Label label1;
        private Label lblSubtotal;
    }
}