namespace CorazonDeCafeStockManager
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            lblTitle = new Label();
            btnGoBack = new PictureBox();
            btnSave = new ButtonCustom();
            btnCancel = new ButtonCustom();
            barHPanel = new Panel();
            title = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            lblCancelBilling = new Label();
            lblBillingData = new Label();
            lblCustomerData = new Label();
            ipStatus = new ComboBoxCustom();
            lblStatus = new Label();
            ipCustomerName = new utils.Custom.TextBox.TextBoxCustom();
            ipCustomerSurname = new utils.Custom.TextBox.TextBoxCustom();
            ipCustomerDni = new utils.Custom.TextBox.TextBoxCustom();
            ipEmployeeName = new utils.Custom.TextBox.TextBoxCustom();
            ipBillingType = new utils.Custom.TextBox.TextBoxCustom();
            ipPaymentMethod = new utils.Custom.TextBox.TextBoxCustom();
            lblDni = new Label();
            lblPhone = new Label();
            lblUser = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lblName = new Label();
            panel4 = new Panel();
            ipTotalPrice = new utils.Custom.TextBox.TextBoxCustom();
            lblTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)btnGoBack).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 41);
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
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.Dock = DockStyle.Left;
            btnGoBack.Location = new Point(0, 0);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(24, 48);
            btnGoBack.TabIndex = 24;
            btnGoBack.TabStop = false;
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
            btnSave.Location = new Point(868, 11);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(6, 0, 5, 0);
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 22;
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
            btnCancel.Location = new Point(718, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(6, 0, 2, 0);
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextColor = Color.FromArgb(96, 96, 96);
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // barHPanel
            // 
            barHPanel.Anchor = AnchorStyles.None;
            barHPanel.BackColor = Color.FromArgb(145, 90, 57);
            barHPanel.Location = new Point(-3, 543);
            barHPanel.MaximumSize = new Size(3400, 4);
            barHPanel.Name = "barHPanel";
            barHPanel.Size = new Size(999, 4);
            barHPanel.TabIndex = 26;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            title.AutoSize = true;
            title.Font = new Font("Poppins Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.FromArgb(146, 90, 57);
            title.Location = new Point(60, 7);
            title.Name = "title";
            title.Size = new Size(78, 37);
            title.TabIndex = 47;
            title.Text = "Venta";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(-3, 559);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 58);
            panel1.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-3, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(999, 407);
            panel2.TabIndex = 49;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.Controls.Add(ipTotalPrice);
            panel3.Controls.Add(lblTotalPrice);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblCancelBilling);
            panel3.Controls.Add(lblBillingData);
            panel3.Controls.Add(lblCustomerData);
            panel3.Controls.Add(ipStatus);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(ipCustomerName);
            panel3.Controls.Add(ipCustomerSurname);
            panel3.Controls.Add(ipCustomerDni);
            panel3.Controls.Add(ipEmployeeName);
            panel3.Controls.Add(ipBillingType);
            panel3.Controls.Add(ipPaymentMethod);
            panel3.Controls.Add(lblDni);
            panel3.Controls.Add(lblPhone);
            panel3.Controls.Add(lblUser);
            panel3.Controls.Add(lblSurname);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(60, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(878, 331);
            panel3.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(146, 90, 57);
            label1.Location = new Point(568, 189);
            label1.Name = "label1";
            label1.Size = new Size(197, 19);
            label1.TabIndex = 58;
            label1.Text = "(No se podrá revertir los cambios)";
            // 
            // lblCancelBilling
            // 
            lblCancelBilling.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCancelBilling.AutoSize = true;
            lblCancelBilling.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCancelBilling.ForeColor = Color.FromArgb(146, 90, 57);
            lblCancelBilling.Location = new Point(568, 163);
            lblCancelBilling.Name = "lblCancelBilling";
            lblCancelBilling.Size = new Size(156, 28);
            lblCancelBilling.TabIndex = 57;
            lblCancelBilling.Text = "Cancelar Compra";
            // 
            // lblBillingData
            // 
            lblBillingData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBillingData.AutoSize = true;
            lblBillingData.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBillingData.ForeColor = Color.FromArgb(146, 90, 57);
            lblBillingData.Location = new Point(297, 4);
            lblBillingData.Name = "lblBillingData";
            lblBillingData.Size = new Size(152, 28);
            lblBillingData.TabIndex = 56;
            lblBillingData.Text = "Datos de la venta";
            // 
            // lblCustomerData
            // 
            lblCustomerData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerData.AutoSize = true;
            lblCustomerData.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerData.ForeColor = Color.FromArgb(146, 90, 57);
            lblCustomerData.Location = new Point(25, 4);
            lblCustomerData.Name = "lblCustomerData";
            lblCustomerData.Size = new Size(145, 28);
            lblCustomerData.TabIndex = 55;
            lblCustomerData.Text = "Datos del cliente";
            // 
            // ipStatus
            // 
            ipStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipStatus.BackColor = Color.FromArgb(255, 219, 197);
            ipStatus.BorderColor = Color.FromArgb(145, 90, 57);
            ipStatus.BorderRadius = 5;
            ipStatus.BorderSize = 0;
            ipStatus.DropDownStyle = ComboBoxStyle.DropDown;
            ipStatus.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipStatus.ForeColor = Color.Black;
            ipStatus.IconColor = Color.FromArgb(145, 90, 57);
            ipStatus.Items.AddRange(new object[] { "activo", "inactivo" });
            ipStatus.ListBackColor = Color.FromArgb(230, 228, 245);
            ipStatus.ListTextColor = Color.Black;
            ipStatus.Location = new Point(568, 256);
            ipStatus.MaximumSize = new Size(420, 37);
            ipStatus.MinimumSize = new Size(110, 32);
            ipStatus.Name = "ipStatus";
            ipStatus.Size = new Size(240, 32);
            ipStatus.TabIndex = 54;
            ipStatus.Texts = "activo";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(146, 90, 57);
            lblStatus.Location = new Point(568, 225);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 26);
            lblStatus.TabIndex = 53;
            lblStatus.Text = "Estado";
            // 
            // ipCustomerName
            // 
            ipCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipCustomerName.BackColor = Color.FromArgb(255, 219, 197);
            ipCustomerName.BorderColor = Color.FromArgb(255, 219, 197);
            ipCustomerName.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipCustomerName.BorderRadius = 5;
            ipCustomerName.BorderSize = 2;
            ipCustomerName.Cursor = Cursors.IBeam;
            ipCustomerName.Enabled = false;
            ipCustomerName.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipCustomerName.Location = new Point(25, 82);
            ipCustomerName.MaximumSize = new Size(650, 37);
            ipCustomerName.MinimumSize = new Size(220, 34);
            ipCustomerName.Multiline = false;
            ipCustomerName.Name = "ipCustomerName";
            ipCustomerName.Padding = new Padding(8, 6, 4, 2);
            ipCustomerName.PasswordChar = false;
            ipCustomerName.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipCustomerName.PlaceholderText = "Cliente";
            ipCustomerName.Size = new Size(240, 34);
            ipCustomerName.TabIndex = 27;
            ipCustomerName.Texts = "";
            ipCustomerName.UnderlinedStyle = false;
            // 
            // ipCustomerSurname
            // 
            ipCustomerSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipCustomerSurname.BackColor = Color.FromArgb(255, 219, 197);
            ipCustomerSurname.BorderColor = Color.FromArgb(255, 219, 197);
            ipCustomerSurname.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipCustomerSurname.BorderRadius = 5;
            ipCustomerSurname.BorderSize = 2;
            ipCustomerSurname.Cursor = Cursors.IBeam;
            ipCustomerSurname.Enabled = false;
            ipCustomerSurname.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipCustomerSurname.Location = new Point(26, 164);
            ipCustomerSurname.MaximumSize = new Size(650, 37);
            ipCustomerSurname.MinimumSize = new Size(100, 34);
            ipCustomerSurname.Multiline = false;
            ipCustomerSurname.Name = "ipCustomerSurname";
            ipCustomerSurname.Padding = new Padding(10, 6, 4, 2);
            ipCustomerSurname.PasswordChar = false;
            ipCustomerSurname.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipCustomerSurname.PlaceholderText = "Apellido del cliente";
            ipCustomerSurname.Size = new Size(241, 34);
            ipCustomerSurname.TabIndex = 28;
            ipCustomerSurname.Texts = "";
            ipCustomerSurname.UnderlinedStyle = false;
            // 
            // ipCustomerDni
            // 
            ipCustomerDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipCustomerDni.BackColor = Color.FromArgb(255, 219, 197);
            ipCustomerDni.BorderColor = Color.FromArgb(255, 219, 197);
            ipCustomerDni.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipCustomerDni.BorderRadius = 5;
            ipCustomerDni.BorderSize = 2;
            ipCustomerDni.Cursor = Cursors.IBeam;
            ipCustomerDni.Enabled = false;
            ipCustomerDni.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipCustomerDni.Location = new Point(26, 254);
            ipCustomerDni.MaximumSize = new Size(650, 37);
            ipCustomerDni.MinimumSize = new Size(100, 34);
            ipCustomerDni.Multiline = false;
            ipCustomerDni.Name = "ipCustomerDni";
            ipCustomerDni.Padding = new Padding(10, 6, 4, 2);
            ipCustomerDni.PasswordChar = false;
            ipCustomerDni.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipCustomerDni.PlaceholderText = "Número de dni";
            ipCustomerDni.Size = new Size(241, 34);
            ipCustomerDni.TabIndex = 49;
            ipCustomerDni.Texts = "";
            ipCustomerDni.UnderlinedStyle = false;
            // 
            // ipEmployeeName
            // 
            ipEmployeeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipEmployeeName.BackColor = Color.FromArgb(255, 219, 197);
            ipEmployeeName.BorderColor = Color.FromArgb(255, 219, 197);
            ipEmployeeName.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipEmployeeName.BorderRadius = 5;
            ipEmployeeName.BorderSize = 2;
            ipEmployeeName.Cursor = Cursors.IBeam;
            ipEmployeeName.Enabled = false;
            ipEmployeeName.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipEmployeeName.Location = new Point(297, 82);
            ipEmployeeName.MaximumSize = new Size(650, 37);
            ipEmployeeName.MinimumSize = new Size(220, 34);
            ipEmployeeName.Multiline = false;
            ipEmployeeName.Name = "ipEmployeeName";
            ipEmployeeName.Padding = new Padding(8, 6, 4, 2);
            ipEmployeeName.PasswordChar = false;
            ipEmployeeName.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipEmployeeName.PlaceholderText = "Vendedor";
            ipEmployeeName.Size = new Size(240, 34);
            ipEmployeeName.TabIndex = 48;
            ipEmployeeName.Texts = "";
            ipEmployeeName.UnderlinedStyle = false;
            // 
            // ipBillingType
            // 
            ipBillingType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipBillingType.BackColor = Color.FromArgb(255, 219, 197);
            ipBillingType.BorderColor = Color.FromArgb(255, 219, 197);
            ipBillingType.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipBillingType.BorderRadius = 5;
            ipBillingType.BorderSize = 2;
            ipBillingType.Cursor = Cursors.IBeam;
            ipBillingType.Enabled = false;
            ipBillingType.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipBillingType.Location = new Point(297, 164);
            ipBillingType.MaximumSize = new Size(650, 37);
            ipBillingType.MinimumSize = new Size(100, 34);
            ipBillingType.Multiline = false;
            ipBillingType.Name = "ipBillingType";
            ipBillingType.Padding = new Padding(10, 6, 4, 2);
            ipBillingType.PasswordChar = false;
            ipBillingType.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipBillingType.PlaceholderText = "Factura";
            ipBillingType.Size = new Size(241, 34);
            ipBillingType.TabIndex = 44;
            ipBillingType.Texts = "";
            ipBillingType.UnderlinedStyle = false;
            // 
            // ipPaymentMethod
            // 
            ipPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipPaymentMethod.BackColor = Color.FromArgb(255, 219, 197);
            ipPaymentMethod.BorderColor = Color.FromArgb(255, 219, 197);
            ipPaymentMethod.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipPaymentMethod.BorderRadius = 5;
            ipPaymentMethod.BorderSize = 2;
            ipPaymentMethod.Cursor = Cursors.IBeam;
            ipPaymentMethod.Enabled = false;
            ipPaymentMethod.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipPaymentMethod.Location = new Point(297, 254);
            ipPaymentMethod.MaximumSize = new Size(650, 37);
            ipPaymentMethod.MinimumSize = new Size(100, 34);
            ipPaymentMethod.Multiline = false;
            ipPaymentMethod.Name = "ipPaymentMethod";
            ipPaymentMethod.Padding = new Padding(10, 6, 4, 2);
            ipPaymentMethod.PasswordChar = false;
            ipPaymentMethod.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPaymentMethod.PlaceholderText = "Método de Pago";
            ipPaymentMethod.Size = new Size(241, 34);
            ipPaymentMethod.TabIndex = 51;
            ipPaymentMethod.Texts = "";
            ipPaymentMethod.UnderlinedStyle = false;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.FromArgb(146, 90, 57);
            lblDni.Location = new Point(26, 225);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 26);
            lblDni.TabIndex = 50;
            lblDni.Text = "DNI";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(146, 90, 57);
            lblPhone.Location = new Point(297, 225);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(134, 26);
            lblPhone.TabIndex = 52;
            lblPhone.Text = "Método de Pago";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(146, 90, 57);
            lblUser.Location = new Point(297, 135);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(125, 26);
            lblUser.TabIndex = 45;
            lblUser.Text = "Tipo de Factura";
            // 
            // lblSurname
            // 
            lblSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.ForeColor = Color.FromArgb(146, 90, 57);
            lblSurname.Location = new Point(28, 135);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(70, 26);
            lblSurname.TabIndex = 42;
            lblSurname.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(146, 90, 57);
            lblEmail.Location = new Point(297, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 26);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "Vendedor";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(146, 90, 57);
            lblName.Location = new Point(26, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 26);
            lblName.TabIndex = 39;
            lblName.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(title);
            panel4.Controls.Add(btnGoBack);
            panel4.Location = new Point(-3, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(999, 48);
            panel4.TabIndex = 50;
            // 
            // ipTotalPrice
            // 
            ipTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipTotalPrice.BackColor = Color.FromArgb(255, 219, 197);
            ipTotalPrice.BorderColor = Color.FromArgb(255, 219, 197);
            ipTotalPrice.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipTotalPrice.BorderRadius = 5;
            ipTotalPrice.BorderSize = 2;
            ipTotalPrice.Cursor = Cursors.IBeam;
            ipTotalPrice.Enabled = false;
            ipTotalPrice.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipTotalPrice.Location = new Point(568, 82);
            ipTotalPrice.MaximumSize = new Size(650, 37);
            ipTotalPrice.MinimumSize = new Size(220, 34);
            ipTotalPrice.Multiline = false;
            ipTotalPrice.Name = "ipTotalPrice";
            ipTotalPrice.Padding = new Padding(8, 6, 4, 2);
            ipTotalPrice.PasswordChar = false;
            ipTotalPrice.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipTotalPrice.PlaceholderText = "venta";
            ipTotalPrice.Size = new Size(240, 34);
            ipTotalPrice.TabIndex = 60;
            ipTotalPrice.Texts = "";
            ipTotalPrice.UnderlinedStyle = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.FromArgb(146, 90, 57);
            lblTotalPrice.Location = new Point(568, 55);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(92, 26);
            lblTotalPrice.TabIndex = 59;
            lblTotalPrice.Text = "Venta total";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 651);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(barHPanel);
            Controls.Add(lblTitle);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)btnGoBack).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private PictureBox btnGoBack;
        private ButtonCustom btnSave;
        private ButtonCustom btnCancel;
        private Panel barHPanel;
        private Label title;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private ComboBoxCustom ipStatus;
        private Label lblStatus;
        private utils.Custom.TextBox.TextBoxCustom ipCustomerName;
        private utils.Custom.TextBox.TextBoxCustom ipCustomerSurname;
        private utils.Custom.TextBox.TextBoxCustom ipCustomerDni;
        private utils.Custom.TextBox.TextBoxCustom ipEmployeeName;
        private utils.Custom.TextBox.TextBoxCustom ipBillingType;
        private utils.Custom.TextBox.TextBoxCustom ipPaymentMethod;
        private Label lblDni;
        private Label lblPhone;
        private Label lblUser;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblName;
        private Label lblCancelBilling;
        private Label lblBillingData;
        private Label lblCustomerData;
        private Label label1;
        private utils.Custom.TextBox.TextBoxCustom ipTotalPrice;
        private Label lblTotalPrice;
    }
}