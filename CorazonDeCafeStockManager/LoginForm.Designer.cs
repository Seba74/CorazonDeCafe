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
            ipPassword = new TextBox();
            lblSubtitle = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            closeBtn = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ipUser = new TextBox();
            btnError = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 0, 0, 0);
            lblTitle.Location = new Point(35, 28);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(92, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bienvenido!";
            lblTitle.Click += LblTitle_Click;
            // 
            // ipPassword
            // 
            ipPassword.BackColor = SystemColors.Window;
            ipPassword.BorderStyle = BorderStyle.None;
            ipPassword.Cursor = Cursors.Hand;
            ipPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ipPassword.ForeColor = Color.FromArgb(0, 0, 0, 0);
            ipPassword.Location = new Point(41, 269);
            ipPassword.Margin = new Padding(4);
            ipPassword.MaxLength = 25;
            ipPassword.Name = "ipPassword";
            ipPassword.PlaceholderText = "CONTRASEÑA";
            ipPassword.Size = new Size(253, 22);
            ipPassword.TabIndex = 3;
            ipPassword.UseSystemPasswordChar = true;
            ipPassword.TextChanged += IpPassword_TextChanged;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(0, 0, 0, 0);
            lblSubtitle.Location = new Point(38, 60);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(209, 21);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Ingrese usuario y contraseña";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(146, 90, 57);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnLogin.Location = new Point(38, 371);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(258, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(147, 90, 57);
            panel1.BackgroundImage = Properties.Resources.CORAZÓN_DE_CAFÉ2;
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(340, -40);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 546);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // closeBtn
            // 
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
            closeBtn.Click += closeBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(38, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 2);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(38, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 2);
            panel2.TabIndex = 6;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // ipUser
            // 
            ipUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            ipUser.BackColor = SystemColors.Window;
            ipUser.BorderStyle = BorderStyle.None;
            ipUser.Cursor = Cursors.Hand;
            ipUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ipUser.ForeColor = Color.FromArgb(0, 0, 0, 0);
            ipUser.Location = new Point(42, 185);
            ipUser.Margin = new Padding(8);
            ipUser.MaxLength = 25;
            ipUser.Name = "ipUser";
            ipUser.PlaceholderText = "USUARIO";
            ipUser.Size = new Size(253, 22);
            ipUser.TabIndex = 2;
            ipUser.TextChanged += IpUser_TextChanged;
            // 
            // btnError
            // 
            btnError.BackColor = Color.FromArgb(255, 186, 186);
            btnError.Enabled = false;
            btnError.FlatAppearance.BorderColor = Color.FromArgb(255, 95, 95);
            btnError.FlatAppearance.BorderSize = 2;
            btnError.FlatStyle = FlatStyle.Flat;
            btnError.ForeColor = Color.FromArgb(255, 95, 95);
            btnError.Location = new Point(38, 105);
            btnError.Name = "btnError";
            btnError.Size = new Size(258, 42);
            btnError.TabIndex = 9;
            btnError.Text = "Usuario o Contraseña Incorrecto";
            btnError.UseVisualStyleBackColor = false;
            btnError.Visible = false;
            btnError.Click += btnError_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(993, 467);
            Controls.Add(btnError);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(ipUser);
            Controls.Add(ipPassword);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox ipPassword;
        private Label lblSubtitle;
        private Button btnLogin;
        private Panel panel1;
        private Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel3;
        private TextBox ipUser;
        private PictureBox closeBtn;
        private Button btnError;
    }
}