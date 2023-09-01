namespace CorazonDeCafeStockManager
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            panel1 = new Panel();
            closeBtn = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            btnLogin = new ButtonCustom();
            ipUser = new utils.Custom.TextBox.TextBoxCustom();
            ipPassword = new utils.Custom.TextBox.TextBoxCustom();
            lblError = new Label();
            inError = new PictureBox();
            loading = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loading).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 0, 0, 0);
            lblTitle.Location = new Point(27, 28);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(92, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bienvenido!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(0, 0, 0, 0);
            lblSubtitle.Location = new Point(30, 67);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(209, 21);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Ingrese usuario y contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(147, 90, 57);
            panel1.BackgroundImage = Properties.Resources.CORAZÓN_DE_CAFÉ2;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(326, -40);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 546);
            panel1.TabIndex = 8;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundImage = Properties.Resources.close2;
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.ErrorImage = Properties.Resources.close1;
            closeBtn.Image = Properties.Resources.close1;
            closeBtn.Location = new Point(617, 42);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(34, 28);
            closeBtn.TabIndex = 0;
            closeBtn.TabStop = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(255, 219, 197);
            btnLogin.BorderRadius = 5;
            btnLogin.BorderSize = 2;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = false;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(147, 110, 77);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(255, 219, 197);
            btnLogin.Location = new Point(34, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(254, 41);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "INICIAR SESIÓN";
            btnLogin.TextColor = Color.FromArgb(255, 219, 197);
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // ipUser
            // 
            ipUser.BackColor = Color.FromArgb(255, 219, 197);
            ipUser.BorderColor = Color.FromArgb(255, 219, 197);
            ipUser.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipUser.BorderRadius = 5;
            ipUser.BorderSize = 2;
            ipUser.Cursor = Cursors.Hand;
            ipUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ipUser.Location = new Point(34, 194);
            ipUser.Multiline = false;
            ipUser.Name = "ipUser";
            ipUser.Padding = new Padding(8, 7, 8, 7);
            ipUser.PasswordChar = false;
            ipUser.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipUser.PlaceholderText = "USUARIO";
            ipUser.Size = new Size(254, 35);
            ipUser.TabIndex = 11;
            ipUser.Texts = "";
            ipUser.UnderlinedStyle = false;
            // 
            // ipPassword
            // 
            ipPassword.BackColor = Color.FromArgb(255, 219, 197);
            ipPassword.BorderColor = Color.FromArgb(255, 219, 197);
            ipPassword.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipPassword.BorderRadius = 5;
            ipPassword.BorderSize = 2;
            ipPassword.Cursor = Cursors.Hand;
            ipPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ipPassword.Location = new Point(34, 269);
            ipPassword.Multiline = false;
            ipPassword.Name = "ipPassword";
            ipPassword.Padding = new Padding(8, 7, 8, 7);
            ipPassword.PasswordChar = true;
            ipPassword.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipPassword.PlaceholderText = "CONTRASEÑA";
            ipPassword.Size = new Size(254, 35);
            ipPassword.TabIndex = 12;
            ipPassword.Texts = "";
            ipPassword.UnderlinedStyle = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(255, 95, 95);
            lblError.Location = new Point(57, 136);
            lblError.Name = "lblError";
            lblError.Size = new Size(236, 25);
            lblError.TabIndex = 13;
            lblError.Text = "Usuario o contraseña incorrecta";
            lblError.Visible = false;
            // 
            // inError
            // 
            inError.BackColor = Color.Transparent;
            inError.BackgroundImage = Properties.Resources.adv1;
            inError.BackgroundImageLayout = ImageLayout.Zoom;
            inError.ErrorImage = null;
            inError.Location = new Point(34, 135);
            inError.Name = "inError";
            inError.Size = new Size(22, 24);
            inError.TabIndex = 14;
            inError.TabStop = false;
            inError.Visible = false;
            // 
            // loading
            // 
            loading.BackColor = Color.Transparent;
            loading.Location = new Point(99, 194);
            loading.Name = "loading";
            loading.Size = new Size(106, 97);
            loading.SizeMode = PictureBoxSizeMode.Zoom;
            loading.TabIndex = 15;
            loading.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(977, 467);
            Controls.Add(loading);
            Controls.Add(inError);
            Controls.Add(lblError);
            Controls.Add(ipPassword);
            Controls.Add(ipUser);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)inError).EndInit();
            ((System.ComponentModel.ISupportInitialize)loading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panel1;
        private Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel3;
        private PictureBox closeBtn;
        private ButtonCustom btnLogin;


        private utils.Custom.TextBox.TextBoxCustom ipUser;
        private utils.Custom.TextBox.TextBoxCustom ipPassword;
        private Label lblError;
        private PictureBox inError;
        private PictureBox loading;
    }
}