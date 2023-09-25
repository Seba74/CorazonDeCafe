namespace CorazonDeCafeStockManager
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            lblTitle = new Label();
            btnGoBack = new PictureBox();
            btnSave = new ButtonCustom();
            btnCancel = new ButtonCustom();
            btnDelete = new ButtonCustom();
            barHPanel = new Panel();
            title = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ipCity = new utils.Custom.TextBox.TextBoxCustom();
            lblCity = new Label();
            ipNumber = new utils.Custom.TextBox.TextBoxCustom();
            lblNumber = new Label();
            ipStatus = new ComboBoxCustom();
            lblStatus = new Label();
            ipName = new utils.Custom.TextBox.TextBoxCustom();
            ipSurname = new utils.Custom.TextBox.TextBoxCustom();
            ipDni = new utils.Custom.TextBox.TextBoxCustom();
            ipEmail = new utils.Custom.TextBox.TextBoxCustom();
            ipStreet = new utils.Custom.TextBox.TextBoxCustom();
            ipPhone = new utils.Custom.TextBox.TextBoxCustom();
            lblDni = new Label();
            lblPhone = new Label();
            lblStreet = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lblName = new Label();
            ipPostalCode = new utils.Custom.TextBox.TextBoxCustom();
            lblPostalCode = new Label();
            ipProvince = new utils.Custom.TextBox.TextBoxCustom();
            lblProvince = new Label();
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
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnDelete.Location = new Point(15, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(8, 0, 0, 0);
            btnDelete.Size = new Size(115, 38);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextColor = Color.FromArgb(255, 95, 95);
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
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
            title.Size = new Size(170, 37);
            title.TabIndex = 47;
            title.Text = "NUEVO CLIENTE";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelete);
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
            panel3.Controls.Add(ipPostalCode);
            panel3.Controls.Add(lblPostalCode);
            panel3.Controls.Add(ipProvince);
            panel3.Controls.Add(lblProvince);
            panel3.Controls.Add(ipCity);
            panel3.Controls.Add(lblCity);
            panel3.Controls.Add(ipNumber);
            panel3.Controls.Add(lblNumber);
            panel3.Controls.Add(ipStatus);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(ipName);
            panel3.Controls.Add(ipSurname);
            panel3.Controls.Add(ipDni);
            panel3.Controls.Add(ipEmail);
            panel3.Controls.Add(ipStreet);
            panel3.Controls.Add(ipPhone);
            panel3.Controls.Add(lblDni);
            panel3.Controls.Add(lblPhone);
            panel3.Controls.Add(lblStreet);
            panel3.Controls.Add(lblSurname);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(27, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(943, 331);
            panel3.TabIndex = 39;
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
            // ipCity
            // 
            ipCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipCity.BackColor = Color.FromArgb(255, 219, 197);
            ipCity.BorderColor = Color.FromArgb(255, 219, 197);
            ipCity.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipCity.BorderRadius = 5;
            ipCity.BorderSize = 2;
            ipCity.Cursor = Cursors.Hand;
            ipCity.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipCity.Location = new Point(477, 246);
            ipCity.MaximumSize = new Size(650, 37);
            ipCity.MinimumSize = new Size(100, 34);
            ipCity.Multiline = false;
            ipCity.Name = "ipCity";
            ipCity.Padding = new Padding(10, 6, 4, 2);
            ipCity.PasswordChar = false;
            ipCity.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipCity.PlaceholderText = "Nombre de la ciudad";
            ipCity.Size = new Size(210, 34);
            ipCity.TabIndex = 75;
            ipCity.Texts = "";
            ipCity.UnderlinedStyle = false;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.ForeColor = Color.FromArgb(146, 90, 57);
            lblCity.Location = new Point(477, 217);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(66, 26);
            lblCity.TabIndex = 76;
            lblCity.Text = "Ciudad";
            // 
            // ipNumber
            // 
            ipNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipNumber.BackColor = Color.FromArgb(255, 219, 197);
            ipNumber.BorderColor = Color.FromArgb(255, 219, 197);
            ipNumber.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipNumber.BorderRadius = 5;
            ipNumber.BorderSize = 2;
            ipNumber.Cursor = Cursors.Hand;
            ipNumber.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipNumber.Location = new Point(477, 162);
            ipNumber.MaximumSize = new Size(650, 37);
            ipNumber.MinimumSize = new Size(100, 34);
            ipNumber.Multiline = false;
            ipNumber.Name = "ipNumber";
            ipNumber.Padding = new Padding(10, 6, 4, 2);
            ipNumber.PasswordChar = false;
            ipNumber.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipNumber.PlaceholderText = "Número de la calle";
            ipNumber.Size = new Size(210, 34);
            ipNumber.TabIndex = 73;
            ipNumber.Texts = "";
            ipNumber.UnderlinedStyle = false;
            // 
            // lblNumber
            // 
            lblNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber.ForeColor = Color.FromArgb(146, 90, 57);
            lblNumber.Location = new Point(477, 133);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(70, 26);
            lblNumber.TabIndex = 74;
            lblNumber.Text = "Número";
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
            ipStatus.Location = new Point(12, 248);
            ipStatus.MaximumSize = new Size(420, 37);
            ipStatus.MinimumSize = new Size(110, 32);
            ipStatus.Name = "ipStatus";
            ipStatus.Size = new Size(210, 32);
            ipStatus.TabIndex = 72;
            ipStatus.Texts = "activo";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(146, 90, 57);
            lblStatus.Location = new Point(12, 217);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 26);
            lblStatus.TabIndex = 71;
            lblStatus.Text = "Estado";
            // 
            // ipName
            // 
            ipName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipName.BackColor = Color.FromArgb(255, 219, 197);
            ipName.BorderColor = Color.FromArgb(255, 219, 197);
            ipName.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipName.BorderRadius = 5;
            ipName.BorderSize = 2;
            ipName.Cursor = Cursors.Hand;
            ipName.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipName.Location = new Point(11, 76);
            ipName.MaximumSize = new Size(650, 37);
            ipName.MinimumSize = new Size(200, 34);
            ipName.Multiline = false;
            ipName.Name = "ipName";
            ipName.Padding = new Padding(8, 6, 4, 2);
            ipName.PasswordChar = false;
            ipName.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipName.PlaceholderText = "Corazón de Café";
            ipName.Size = new Size(210, 34);
            ipName.TabIndex = 59;
            ipName.Texts = "";
            ipName.UnderlinedStyle = false;
            // 
            // ipSurname
            // 
            ipSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipSurname.BackColor = Color.FromArgb(255, 219, 197);
            ipSurname.BorderColor = Color.FromArgb(255, 219, 197);
            ipSurname.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipSurname.BorderRadius = 5;
            ipSurname.BorderSize = 2;
            ipSurname.Cursor = Cursors.Hand;
            ipSurname.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipSurname.Location = new Point(241, 76);
            ipSurname.MaximumSize = new Size(650, 37);
            ipSurname.MinimumSize = new Size(100, 34);
            ipSurname.Multiline = false;
            ipSurname.Name = "ipSurname";
            ipSurname.Padding = new Padding(10, 6, 4, 2);
            ipSurname.PasswordChar = false;
            ipSurname.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSurname.PlaceholderText = "apellido";
            ipSurname.Size = new Size(210, 34);
            ipSurname.TabIndex = 60;
            ipSurname.Texts = "";
            ipSurname.UnderlinedStyle = false;
            // 
            // ipDni
            // 
            ipDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipDni.BackColor = Color.FromArgb(255, 219, 197);
            ipDni.BorderColor = Color.FromArgb(255, 219, 197);
            ipDni.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipDni.BorderRadius = 5;
            ipDni.BorderSize = 2;
            ipDni.Cursor = Cursors.Hand;
            ipDni.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipDni.Location = new Point(241, 246);
            ipDni.MaximumSize = new Size(650, 37);
            ipDni.MinimumSize = new Size(100, 34);
            ipDni.Multiline = false;
            ipDni.Name = "ipDni";
            ipDni.Padding = new Padding(10, 6, 4, 2);
            ipDni.PasswordChar = false;
            ipDni.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipDni.PlaceholderText = "Número de dni";
            ipDni.Size = new Size(210, 34);
            ipDni.TabIndex = 67;
            ipDni.Texts = "";
            ipDni.UnderlinedStyle = false;
            // 
            // ipEmail
            // 
            ipEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipEmail.BackColor = Color.FromArgb(255, 219, 197);
            ipEmail.BorderColor = Color.FromArgb(255, 219, 197);
            ipEmail.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipEmail.BorderRadius = 5;
            ipEmail.BorderSize = 2;
            ipEmail.Cursor = Cursors.Hand;
            ipEmail.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipEmail.Location = new Point(11, 160);
            ipEmail.MaximumSize = new Size(650, 37);
            ipEmail.MinimumSize = new Size(200, 34);
            ipEmail.Multiline = false;
            ipEmail.Name = "ipEmail";
            ipEmail.Padding = new Padding(8, 6, 4, 2);
            ipEmail.PasswordChar = false;
            ipEmail.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipEmail.PlaceholderText = "ejemplo @gmail.com";
            ipEmail.Size = new Size(210, 34);
            ipEmail.TabIndex = 66;
            ipEmail.Texts = "";
            ipEmail.UnderlinedStyle = false;
            // 
            // ipStreet
            // 
            ipStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipStreet.BackColor = Color.FromArgb(255, 219, 197);
            ipStreet.BorderColor = Color.FromArgb(255, 219, 197);
            ipStreet.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipStreet.BorderRadius = 5;
            ipStreet.BorderSize = 2;
            ipStreet.Cursor = Cursors.Hand;
            ipStreet.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipStreet.Location = new Point(477, 76);
            ipStreet.MaximumSize = new Size(650, 37);
            ipStreet.MinimumSize = new Size(100, 34);
            ipStreet.Multiline = false;
            ipStreet.Name = "ipStreet";
            ipStreet.Padding = new Padding(10, 6, 4, 2);
            ipStreet.PasswordChar = false;
            ipStreet.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipStreet.PlaceholderText = "Nombre de la calle";
            ipStreet.Size = new Size(210, 34);
            ipStreet.TabIndex = 64;
            ipStreet.Texts = "";
            ipStreet.UnderlinedStyle = false;
            // 
            // ipPhone
            // 
            ipPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipPhone.BackColor = Color.FromArgb(255, 219, 197);
            ipPhone.BorderColor = Color.FromArgb(255, 219, 197);
            ipPhone.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipPhone.BorderRadius = 5;
            ipPhone.BorderSize = 2;
            ipPhone.Cursor = Cursors.Hand;
            ipPhone.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipPhone.Location = new Point(241, 162);
            ipPhone.MaximumSize = new Size(650, 37);
            ipPhone.MinimumSize = new Size(100, 34);
            ipPhone.Multiline = false;
            ipPhone.Name = "ipPhone";
            ipPhone.Padding = new Padding(10, 6, 4, 2);
            ipPhone.PasswordChar = false;
            ipPhone.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPhone.PlaceholderText = "Número de telefono";
            ipPhone.Size = new Size(210, 34);
            ipPhone.TabIndex = 69;
            ipPhone.Texts = "";
            ipPhone.UnderlinedStyle = false;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.FromArgb(146, 90, 57);
            lblDni.Location = new Point(241, 217);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 26);
            lblDni.TabIndex = 68;
            lblDni.Text = "Dni";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(146, 90, 57);
            lblPhone.Location = new Point(241, 133);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(75, 26);
            lblPhone.TabIndex = 70;
            lblPhone.Text = "Telefono";
            // 
            // lblStreet
            // 
            lblStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStreet.ForeColor = Color.FromArgb(146, 90, 57);
            lblStreet.Location = new Point(477, 47);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(49, 26);
            lblStreet.TabIndex = 65;
            lblStreet.Text = "Calle";
            // 
            // lblSurname
            // 
            lblSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.ForeColor = Color.FromArgb(146, 90, 57);
            lblSurname.Location = new Point(241, 47);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(70, 26);
            lblSurname.TabIndex = 62;
            lblSurname.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(146, 90, 57);
            lblEmail.Location = new Point(11, 133);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 26);
            lblEmail.TabIndex = 63;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(146, 90, 57);
            lblName.Location = new Point(12, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 26);
            lblName.TabIndex = 61;
            lblName.Text = "Nombre";
            // 
            // ipPostalCode
            // 
            ipPostalCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipPostalCode.BackColor = Color.FromArgb(255, 219, 197);
            ipPostalCode.BorderColor = Color.FromArgb(255, 219, 197);
            ipPostalCode.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipPostalCode.BorderRadius = 5;
            ipPostalCode.BorderSize = 2;
            ipPostalCode.Cursor = Cursors.Hand;
            ipPostalCode.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipPostalCode.Location = new Point(713, 162);
            ipPostalCode.MaximumSize = new Size(650, 37);
            ipPostalCode.MinimumSize = new Size(100, 34);
            ipPostalCode.Multiline = false;
            ipPostalCode.Name = "ipPostalCode";
            ipPostalCode.Padding = new Padding(10, 6, 4, 2);
            ipPostalCode.PasswordChar = false;
            ipPostalCode.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPostalCode.PlaceholderText = "Código Postal";
            ipPostalCode.Size = new Size(210, 34);
            ipPostalCode.TabIndex = 79;
            ipPostalCode.Texts = "";
            ipPostalCode.UnderlinedStyle = false;
            // 
            // lblPostalCode
            // 
            lblPostalCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPostalCode.ForeColor = Color.FromArgb(146, 90, 57);
            lblPostalCode.Location = new Point(713, 133);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(115, 26);
            lblPostalCode.TabIndex = 80;
            lblPostalCode.Text = "Código Postal";
            // 
            // ipProvince
            // 
            ipProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipProvince.BackColor = Color.FromArgb(255, 219, 197);
            ipProvince.BorderColor = Color.FromArgb(255, 219, 197);
            ipProvince.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipProvince.BorderRadius = 5;
            ipProvince.BorderSize = 2;
            ipProvince.Cursor = Cursors.Hand;
            ipProvince.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipProvince.Location = new Point(713, 76);
            ipProvince.MaximumSize = new Size(650, 37);
            ipProvince.MinimumSize = new Size(100, 34);
            ipProvince.Multiline = false;
            ipProvince.Name = "ipProvince";
            ipProvince.Padding = new Padding(10, 6, 4, 2);
            ipProvince.PasswordChar = false;
            ipProvince.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipProvince.PlaceholderText = "Nombre de la provincia";
            ipProvince.Size = new Size(210, 34);
            ipProvince.TabIndex = 77;
            ipProvince.Texts = "";
            ipProvince.UnderlinedStyle = false;
            // 
            // lblProvince
            // 
            lblProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProvince.ForeColor = Color.FromArgb(146, 90, 57);
            lblProvince.Location = new Point(713, 47);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(77, 26);
            lblProvince.TabIndex = 78;
            lblProvince.Text = "Provincia";
            // 
            // CustomerForm
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
            Name = "CustomerForm";
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
        private ButtonCustom btnDelete;
        private Panel barHPanel;
        private Label title;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private utils.Custom.TextBox.TextBoxCustom ipPostalCode;
        private Label lblPostalCode;
        private utils.Custom.TextBox.TextBoxCustom ipProvince;
        private Label lblProvince;
        private utils.Custom.TextBox.TextBoxCustom ipCity;
        private Label lblCity;
        private utils.Custom.TextBox.TextBoxCustom ipNumber;
        private Label lblNumber;
        private ComboBoxCustom ipStatus;
        private Label lblStatus;
        private utils.Custom.TextBox.TextBoxCustom ipName;
        private utils.Custom.TextBox.TextBoxCustom ipSurname;
        private utils.Custom.TextBox.TextBoxCustom ipDni;
        private utils.Custom.TextBox.TextBoxCustom ipEmail;
        private utils.Custom.TextBox.TextBoxCustom ipStreet;
        private utils.Custom.TextBox.TextBoxCustom ipPhone;
        private Label lblDni;
        private Label lblPhone;
        private Label lblStreet;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblName;
    }
}