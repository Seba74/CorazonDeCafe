using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Views.OrdersForm
{
    partial class OrdersForm
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            ordersDataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            BillingType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Action = new DataGridViewLinkColumn();
            Rol = new DataGridViewTextBoxColumn();
            ipSearch = new utils.Custom.TextBox.TextBoxCustom();
            panel1 = new Panel();
            selectedBillingType = new ComboBoxCustom();
            selectedPaymentMethod = new ComboBoxCustom();
            endDate = new CalendarCustom();
            startDate = new CalendarCustom();
            reload = new ButtonCustom();
            btnEdit = new ButtonCustom();
            IcSearch = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ordersDataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IcSearch).BeginInit();
            SuspendLayout();
            // 
            // ordersDataGrid
            // 
            ordersDataGrid.AllowUserToAddRows = false;
            ordersDataGrid.AllowUserToDeleteRows = false;
            ordersDataGrid.AllowUserToResizeColumns = false;
            ordersDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ordersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ordersDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersDataGrid.BackgroundColor = SystemColors.MenuBar;
            ordersDataGrid.BorderStyle = BorderStyle.None;
            ordersDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ordersDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ordersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ordersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Date, Total, PaymentMethod, BillingType, Status, Action });
            ordersDataGrid.Cursor = Cursors.Hand;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            ordersDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            ordersDataGrid.GridColor = SystemColors.WindowText;
            ordersDataGrid.Location = new Point(12, 153);
            ordersDataGrid.MultiSelect = false;
            ordersDataGrid.Name = "ordersDataGrid";
            ordersDataGrid.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.IndianRed;
            dataGridViewCellStyle10.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ordersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            ordersDataGrid.RowHeadersVisible = false;
            ordersDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(146, 90, 57);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            ordersDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            ordersDataGrid.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Menu;
            ordersDataGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            ordersDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 219, 197);
            ordersDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            ordersDataGrid.RowTemplate.Height = 35;
            ordersDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            ordersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGrid.Size = new Size(928, 498);
            ordersDataGrid.TabIndex = 0;
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
            FullName.HeaderText = "Cliente";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            Date.DefaultCellStyle = dataGridViewCellStyle4;
            Date.HeaderText = "Fecha";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle5;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PaymentMethod.DefaultCellStyle = dataGridViewCellStyle6;
            PaymentMethod.FillWeight = 120F;
            PaymentMethod.HeaderText = "Metodo de Pago";
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.ReadOnly = true;
            // 
            // BillingType
            // 
            BillingType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BillingType.DefaultCellStyle = dataGridViewCellStyle7;
            BillingType.FillWeight = 120F;
            BillingType.HeaderText = "Tipo de Factura";
            BillingType.Name = "BillingType";
            BillingType.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Status.DefaultCellStyle = dataGridViewCellStyle8;
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Resizable = DataGridViewTriState.True;
            Action.Text = "Factura";
            Action.UseColumnTextForLinkValue = true;
            // 
            // Rol
            // 
            Rol.Name = "Rol";
            // 
            // ipSearch
            // 
            ipSearch.BackColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderColor = Color.FromArgb(255, 219, 197);
            ipSearch.BorderFocusColor = Color.FromArgb(146, 90, 57);
            ipSearch.BorderRadius = 5;
            ipSearch.BorderSize = 2;
            ipSearch.Cursor = Cursors.IBeam;
            ipSearch.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ipSearch.Location = new Point(0, 14);
            ipSearch.MaximumSize = new Size(650, 38);
            ipSearch.Multiline = false;
            ipSearch.Name = "ipSearch";
            ipSearch.Padding = new Padding(8, 8, 4, 6);
            ipSearch.PasswordChar = false;
            ipSearch.PlaceholderColor = Color.FromArgb(146, 90, 57);
            ipSearch.PlaceholderText = "Buscar...";
            ipSearch.Size = new Size(233, 38);
            ipSearch.TabIndex = 12;
            ipSearch.Texts = "";
            ipSearch.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(selectedBillingType);
            panel1.Controls.Add(selectedPaymentMethod);
            panel1.Controls.Add(endDate);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(reload);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(IcSearch);
            panel1.Controls.Add(ipSearch);
            panel1.Location = new Point(12, 77);
            panel1.MaximumSize = new Size(1800, 65);
            panel1.MinimumSize = new Size(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 65);
            panel1.TabIndex = 17;
            // 
            // selectedBillingType
            // 
            selectedBillingType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectedBillingType.BackColor = Color.FromArgb(255, 219, 197);
            selectedBillingType.BorderColor = Color.FromArgb(145, 90, 57);
            selectedBillingType.BorderRadius = 5;
            selectedBillingType.BorderSize = 0;
            selectedBillingType.DropDownStyle = ComboBoxStyle.DropDown;
            selectedBillingType.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectedBillingType.ForeColor = Color.FromArgb(145, 90, 57);
            selectedBillingType.IconColor = Color.FromArgb(145, 90, 57);
            selectedBillingType.ListBackColor = Color.FromArgb(230, 228, 245);
            selectedBillingType.ListTextColor = Color.FromArgb(145, 90, 57);
            selectedBillingType.Location = new Point(413, 16);
            selectedBillingType.MaximumSize = new Size(200, 38);
            selectedBillingType.MinimumSize = new Size(110, 30);
            selectedBillingType.Name = "selectedBillingType";
            selectedBillingType.Padding = new Padding(0, 0, 0, 2);
            selectedBillingType.Size = new Size(136, 38);
            selectedBillingType.TabIndex = 21;
            selectedBillingType.Texts = "Todos";
            // 
            // selectedPaymentMethod
            // 
            selectedPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectedPaymentMethod.BackColor = Color.FromArgb(255, 219, 197);
            selectedPaymentMethod.BorderColor = Color.FromArgb(145, 90, 57);
            selectedPaymentMethod.BorderRadius = 5;
            selectedPaymentMethod.BorderSize = 0;
            selectedPaymentMethod.DropDownStyle = ComboBoxStyle.DropDown;
            selectedPaymentMethod.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectedPaymentMethod.ForeColor = Color.FromArgb(145, 90, 57);
            selectedPaymentMethod.IconColor = Color.FromArgb(145, 90, 57);
            selectedPaymentMethod.ListBackColor = Color.FromArgb(230, 228, 245);
            selectedPaymentMethod.ListTextColor = Color.FromArgb(145, 90, 57);
            selectedPaymentMethod.Location = new Point(244, 15);
            selectedPaymentMethod.MaximumSize = new Size(200, 38);
            selectedPaymentMethod.MinimumSize = new Size(110, 30);
            selectedPaymentMethod.Name = "selectedPaymentMethod";
            selectedPaymentMethod.Padding = new Padding(0, 0, 0, 2);
            selectedPaymentMethod.Size = new Size(163, 38);
            selectedPaymentMethod.TabIndex = 18;
            selectedPaymentMethod.Texts = "Todos";
            // 
            // endDate
            // 
            endDate.BorderColor = Color.PaleVioletRed;
            endDate.BorderRadius = 10;
            endDate.BorderSize = 0;
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(688, 18);
            endDate.MaxDate = new DateTime(2023, 9, 22, 0, 0, 0, 0);
            endDate.MinDate = new DateTime(2023, 1, 25, 0, 0, 0, 0);
            endDate.MinimumSize = new Size(0, 37);
            endDate.Name = "endDate";
            endDate.Size = new Size(120, 37);
            endDate.SkinColor = Color.FromArgb(255, 219, 197);
            endDate.TabIndex = 20;
            endDate.TextColor = Color.FromArgb(145, 90, 57);
            endDate.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            endDate.Visible = false;
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
            startDate.Location = new Point(558, 18);
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
            reload.Cursor = Cursors.Hand;
            reload.FlatAppearance.BorderSize = 0;
            reload.FlatStyle = FlatStyle.Flat;
            reload.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            reload.ForeColor = Color.FromArgb(145, 90, 57);
            reload.Image = Properties.Resources.reload;
            reload.Location = new Point(876, 17);
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
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(145, 90, 57);
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(763, 17);
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
            IcSearch.Location = new Point(201, 21);
            IcSearch.Name = "IcSearch";
            IcSearch.Size = new Size(25, 24);
            IcSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            IcSearch.TabIndex = 2;
            IcSearch.TabStop = false;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 663);
            Controls.Add(panel1);
            Controls.Add(ordersDataGrid);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)ordersDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IcSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ordersDataGrid;
        private utils.Custom.TextBox.TextBoxCustom ipSearch;
        private PictureBox IcSearch;
        private DataGridViewTextBoxColumn Rol;
        private Panel panel1;
        private ButtonCustom btnEdit;
        private ButtonCustom reload;
        private CalendarCustom endDate;
        private CalendarCustom startDate;
        private ComboBoxCustom selectedPaymentMethod;
        private ComboBoxCustom selectedBillingType;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn BillingType;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewLinkColumn Action;
    }
}