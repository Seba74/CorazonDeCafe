﻿namespace CorazonDeCafeStockManager.App.Views.EmployeesForm
{
    partial class EmployeesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            employeesDataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ipSearch = new utils.Custom.TextBox.TextBoxCustom();
            panel1 = new Panel();
            endDate = new CalendarCustom();
            startDate = new CalendarCustom();
            reload = new ButtonCustom();
            btnEdit = new ButtonCustom();
            IcSearch = new PictureBox();
            btnAdd = new ButtonCustom();
            ((System.ComponentModel.ISupportInitialize)employeesDataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IcSearch).BeginInit();
            SuspendLayout();
            // 
            // employeesDataGrid
            // 
            employeesDataGrid.AllowUserToAddRows = false;
            employeesDataGrid.AllowUserToDeleteRows = false;
            employeesDataGrid.AllowUserToResizeColumns = false;
            employeesDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            employeesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            employeesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeesDataGrid.BackgroundColor = SystemColors.MenuBar;
            employeesDataGrid.BorderStyle = BorderStyle.None;
            employeesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            employeesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            employeesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            employeesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesDataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Email, Dni, Phone, Rol, Status });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            employeesDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            employeesDataGrid.GridColor = SystemColors.WindowText;
            employeesDataGrid.Location = new Point(12, 153);
            employeesDataGrid.MultiSelect = false;
            employeesDataGrid.Name = "employeesDataGrid";
            employeesDataGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.IndianRed;
            dataGridViewCellStyle5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            employeesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            employeesDataGrid.RowHeadersVisible = false;
            employeesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            employeesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            employeesDataGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            employeesDataGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            employeesDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 219, 197);
            employeesDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            employeesDataGrid.RowTemplate.Height = 35;
            employeesDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            employeesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesDataGrid.Size = new Size(928, 498);
            employeesDataGrid.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Id.DefaultCellStyle = dataGridViewCellStyle3;
            Id.FillWeight = 40F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.FillWeight = 160F;
            FullName.HeaderText = "Nombre";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.FillWeight = 180F;
            Email.HeaderText = "Correo";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Contacto";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // ipSearch
            // 
            ipSearch.BackColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipSearch.BorderRadius = 5;
            ipSearch.BorderSize = 2;
            ipSearch.Cursor = Cursors.Hand;
            ipSearch.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ipSearch.Location = new Point(0, 14);
            ipSearch.MaximumSize = new Size(650, 38);
            ipSearch.Multiline = false;
            ipSearch.Name = "ipSearch";
            ipSearch.Padding = new Padding(8, 8, 4, 6);
            ipSearch.PasswordChar = false;
            ipSearch.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSearch.PlaceholderText = "Buscar...";
            ipSearch.Size = new Size(248, 38);
            ipSearch.TabIndex = 12;
            ipSearch.Texts = "";
            ipSearch.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(endDate);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(reload);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(IcSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(ipSearch);
            panel1.Location = new Point(12, 77);
            panel1.MaximumSize = new Size(1800, 65);
            panel1.MinimumSize = new Size(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 65);
            panel1.TabIndex = 17;
            // 
            // endDate
            // 
            endDate.BorderColor = Color.PaleVioletRed;
            endDate.BorderRadius = 10;
            endDate.BorderSize = 0;
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Visible = false;
            endDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(395, 16);
            endDate.MaxDate = new DateTime(2023, 9, 22, 0, 0, 0, 0);
            endDate.MinDate = new DateTime(2023, 1, 25, 0, 0, 0, 0);
            endDate.MinimumSize = new Size(0, 37);
            endDate.Name = "endDate";
            endDate.Size = new Size(120, 37);
            endDate.SkinColor = Color.FromArgb(255, 219, 197);
            endDate.TabIndex = 20;
            endDate.TextColor = Color.FromArgb(145, 90, 57);
            endDate.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // startDate
            // 
            startDate.BorderColor = Color.PaleVioletRed;
            startDate.BorderRadius = 10;
            startDate.BorderSize = 0;
            startDate.CalendarForeColor = Color.FromArgb(145, 90, 57);
            startDate.CalendarTitleBackColor = Color.FromArgb(255, 219, 197);
            startDate.CalendarTitleForeColor = Color.FromArgb(145, 90, 57);
            startDate.CustomFormat = "dd/MM/yyyy";
            startDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(260, 15);
            startDate.MaxDate = new DateTime(2023, 9, 22, 0, 0, 0, 0);
            startDate.MinDate = new DateTime(2023, 1, 25, 0, 0, 0, 0);
            startDate.MinimumSize = new Size(0, 37);
            startDate.Name = "startDate";
            startDate.Size = new Size(120, 37);
            startDate.SkinColor = Color.FromArgb(255, 219, 197);
            startDate.TabIndex = 18;
            startDate.TextColor = Color.FromArgb(145, 90, 57);
            startDate.Value = new DateTime(2023, 9, 11, 0, 0, 0, 0);
            // 
            // reload
            // 
            reload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            reload.BackColor = Color.Transparent;
            reload.BackgroundColor = Color.Transparent;
            reload.BackgroundImageLayout = ImageLayout.Zoom;
            reload.BorderColor = Color.FromArgb(145, 90, 57);
            reload.BorderRadius = 5;
            reload.BorderSize = 2;
            reload.FlatAppearance.BorderSize = 0;
            reload.FlatStyle = FlatStyle.Flat;
            reload.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            reload.ForeColor = Color.FromArgb(145, 90, 57);
            reload.Image = Properties.Resources.reload;
            reload.Location = new Point(874, 17);
            reload.MaximumSize = new Size(80, 38);
            reload.Name = "reload";
            reload.Padding = new Padding(6, 0, 6, 0);
            reload.Size = new Size(50, 38);
            reload.TabIndex = 19;
            reload.TextAlign = ContentAlignment.MiddleLeft;
            reload.TextColor = Color.FromArgb(145, 90, 57);
            reload.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(145, 90, 57);
            btnEdit.BorderRadius = 5;
            btnEdit.BorderSize = 2;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(145, 90, 57);
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(761, 17);
            btnEdit.MaximumSize = new Size(160, 38);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(6, 0, 6, 0);
            btnEdit.Size = new Size(107, 38);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Editar";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextColor = Color.FromArgb(145, 90, 57);
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // IcSearch
            // 
            IcSearch.BackColor = Color.FromArgb(255, 219, 197);
            IcSearch.Image = Properties.Resources.search1;
            IcSearch.Location = new Point(216, 21);
            IcSearch.Name = "IcSearch";
            IcSearch.Size = new Size(25, 24);
            IcSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            IcSearch.TabIndex = 2;
            IcSearch.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundColor = Color.Transparent;
            btnAdd.BorderColor = Color.FromArgb(145, 90, 57);
            btnAdd.BorderRadius = 5;
            btnAdd.BorderSize = 2;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(145, 90, 57);
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(632, 16);
            btnAdd.MaximumSize = new Size(160, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(6, 0, 6, 0);
            btnAdd.Size = new Size(123, 38);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextColor = Color.FromArgb(145, 90, 57);
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 663);
            Controls.Add(panel1);
            Controls.Add(employeesDataGrid);
            Cursor = Cursors.Hand;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)employeesDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IcSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employeesDataGrid;
        private utils.Custom.TextBox.TextBoxCustom ipSearch;
        private PictureBox IcSearch;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Rol;
        private Panel panel1;
        private ButtonCustom btnAdd;
        private ButtonCustom btnEdit;
        private ButtonCustom reload;
        private CalendarCustom endDate;
        private CalendarCustom startDate;
    }
}