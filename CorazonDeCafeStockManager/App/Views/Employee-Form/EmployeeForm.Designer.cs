namespace CorazonDeCafeStockManager
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
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
            ipStatus = new ComboBoxCustom();
            lblStatus = new Label();
            ipName = new utils.Custom.TextBox.TextBoxCustom();
            ipSurname = new utils.Custom.TextBox.TextBoxCustom();
            ipDni = new utils.Custom.TextBox.TextBoxCustom();
            ipEmail = new utils.Custom.TextBox.TextBoxCustom();
            ipUser = new utils.Custom.TextBox.TextBoxCustom();
            ipPhone = new utils.Custom.TextBox.TextBoxCustom();
            ipRole = new ComboBoxCustom();
            lblDni = new Label();
            lblPhone = new Label();
            lblUser = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblRole = new Label();
            panel4 = new Panel();
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
            title.Size = new Size(192, 37);
            title.TabIndex = 47;
            title.Text = "Nuevo Empleado";
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
            panel3.Controls.Add(ipStatus);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(ipName);
            panel3.Controls.Add(ipSurname);
            panel3.Controls.Add(ipDni);
            panel3.Controls.Add(ipEmail);
            panel3.Controls.Add(ipUser);
            panel3.Controls.Add(ipPhone);
            panel3.Controls.Add(ipRole);
            panel3.Controls.Add(lblDni);
            panel3.Controls.Add(lblPhone);
            panel3.Controls.Add(lblUser);
            panel3.Controls.Add(lblSurname);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(lblRole);
            panel3.Location = new Point(60, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(878, 331);
            panel3.TabIndex = 39;
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
            ipStatus.Location = new Point(25, 166);
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
            lblStatus.Location = new Point(25, 135);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 26);
            lblStatus.TabIndex = 53;
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
            ipName.Location = new Point(25, 82);
            ipName.MaximumSize = new Size(650, 37);
            ipName.MinimumSize = new Size(220, 34);
            ipName.Multiline = false;
            ipName.Name = "ipName";
            ipName.Padding = new Padding(8, 6, 4, 2);
            ipName.PasswordChar = false;
            ipName.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipName.PlaceholderText = "Corazón de Café";
            ipName.Size = new Size(240, 34);
            ipName.TabIndex = 27;
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
            ipSurname.Location = new Point(297, 82);
            ipSurname.MaximumSize = new Size(650, 37);
            ipSurname.MinimumSize = new Size(100, 34);
            ipSurname.Multiline = false;
            ipSurname.Name = "ipSurname";
            ipSurname.Padding = new Padding(10, 6, 4, 2);
            ipSurname.PasswordChar = false;
            ipSurname.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSurname.PlaceholderText = "apellido";
            ipSurname.Size = new Size(241, 34);
            ipSurname.TabIndex = 28;
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
            ipDni.Location = new Point(567, 82);
            ipDni.MaximumSize = new Size(650, 37);
            ipDni.MinimumSize = new Size(100, 34);
            ipDni.Multiline = false;
            ipDni.Name = "ipDni";
            ipDni.Padding = new Padding(10, 6, 4, 2);
            ipDni.PasswordChar = false;
            ipDni.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipDni.PlaceholderText = "Número de dni";
            ipDni.Size = new Size(241, 34);
            ipDni.TabIndex = 49;
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
            ipEmail.Location = new Point(297, 164);
            ipEmail.MaximumSize = new Size(650, 37);
            ipEmail.MinimumSize = new Size(220, 34);
            ipEmail.Multiline = false;
            ipEmail.Name = "ipEmail";
            ipEmail.Padding = new Padding(8, 6, 4, 2);
            ipEmail.PasswordChar = false;
            ipEmail.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipEmail.PlaceholderText = "ejemplo @gmail.com";
            ipEmail.Size = new Size(240, 34);
            ipEmail.TabIndex = 48;
            ipEmail.Texts = "";
            ipEmail.UnderlinedStyle = false;
            // 
            // ipUser
            // 
            ipUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipUser.BackColor = Color.FromArgb(255, 219, 197);
            ipUser.BorderColor = Color.FromArgb(255, 219, 197);
            ipUser.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipUser.BorderRadius = 5;
            ipUser.BorderSize = 2;
            ipUser.Cursor = Cursors.Hand;
            ipUser.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipUser.Location = new Point(569, 166);
            ipUser.MaximumSize = new Size(650, 37);
            ipUser.MinimumSize = new Size(100, 34);
            ipUser.Multiline = false;
            ipUser.Name = "ipUser";
            ipUser.Padding = new Padding(10, 6, 4, 2);
            ipUser.PasswordChar = false;
            ipUser.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipUser.PlaceholderText = "Nombre de Usuario";
            ipUser.Size = new Size(241, 34);
            ipUser.TabIndex = 44;
            ipUser.Texts = "";
            ipUser.UnderlinedStyle = false;
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
            ipPhone.Location = new Point(297, 254);
            ipPhone.MaximumSize = new Size(650, 37);
            ipPhone.MinimumSize = new Size(100, 34);
            ipPhone.Multiline = false;
            ipPhone.Name = "ipPhone";
            ipPhone.Padding = new Padding(10, 6, 4, 2);
            ipPhone.PasswordChar = false;
            ipPhone.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPhone.PlaceholderText = "Número de contacto";
            ipPhone.Size = new Size(241, 34);
            ipPhone.TabIndex = 51;
            ipPhone.Texts = "";
            ipPhone.UnderlinedStyle = false;
            // 
            // ipRole
            // 
            ipRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ipRole.BackColor = Color.FromArgb(255, 219, 197);
            ipRole.BorderColor = Color.FromArgb(145, 90, 57);
            ipRole.BorderRadius = 5;
            ipRole.BorderSize = 0;
            ipRole.DropDownStyle = ComboBoxStyle.DropDown;
            ipRole.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ipRole.ForeColor = Color.Black;
            ipRole.IconColor = Color.FromArgb(145, 90, 57);
            ipRole.Items.AddRange(new object[] { "vendedor", "supervisor", "gerente", "admin" });
            ipRole.ListBackColor = Color.FromArgb(230, 228, 245);
            ipRole.ListTextColor = Color.Black;
            ipRole.Location = new Point(26, 254);
            ipRole.MaximumSize = new Size(420, 37);
            ipRole.MinimumSize = new Size(110, 32);
            ipRole.Name = "ipRole";
            ipRole.Size = new Size(240, 32);
            ipRole.TabIndex = 41;
            ipRole.Texts = "vendedor";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.FromArgb(146, 90, 57);
            lblDni.Location = new Point(567, 53);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 26);
            lblDni.TabIndex = 50;
            lblDni.Text = "Dni";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(146, 90, 57);
            lblPhone.Location = new Point(297, 225);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(82, 26);
            lblPhone.TabIndex = 52;
            lblPhone.Text = "Contacto";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(146, 90, 57);
            lblUser.Location = new Point(569, 137);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(67, 26);
            lblUser.TabIndex = 45;
            lblUser.Text = "Usuario";
            // 
            // lblSurname
            // 
            lblSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.ForeColor = Color.FromArgb(146, 90, 57);
            lblSurname.Location = new Point(297, 53);
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
            lblEmail.Location = new Point(297, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 26);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "Email";
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
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(146, 90, 57);
            lblRole.Location = new Point(26, 223);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(34, 26);
            lblRole.TabIndex = 40;
            lblRole.Text = "Rol";
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
            // EmployeeForm
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
            Name = "EmployeeForm";
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
        private ComboBoxCustom ipStatus;
        private Label lblStatus;
        private utils.Custom.TextBox.TextBoxCustom ipName;
        private utils.Custom.TextBox.TextBoxCustom ipSurname;
        private utils.Custom.TextBox.TextBoxCustom ipDni;
        private utils.Custom.TextBox.TextBoxCustom ipEmail;
        private utils.Custom.TextBox.TextBoxCustom ipUser;
        private utils.Custom.TextBox.TextBoxCustom ipPhone;
        private ComboBoxCustom ipRole;
        private Label lblDni;
        private Label lblPhone;
        private Label lblUser;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblName;
        private Label lblRole;
    }
}