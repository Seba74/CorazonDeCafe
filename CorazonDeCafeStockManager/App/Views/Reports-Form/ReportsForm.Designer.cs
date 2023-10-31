namespace CorazonDeCafeStockManager.App.Views.ReportsForm
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label1 = new Label();
            lastOrders = new Label();
            paymentPop = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            productPop = new Label();
            label2 = new Label();
            panel3 = new Panel();
            customerPop = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            filterBillings = new ButtonCustom();
            endDate = new CalendarCustom();
            panel7 = new Panel();
            chartAmount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label6 = new Label();
            label5 = new Label();
            startDate = new CalendarCustom();
            panel8 = new Panel();
            filterAmount = new ButtonCustom();
            endDate2 = new CalendarCustom();
            panel9 = new Panel();
            chartBillings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label7 = new Label();
            label8 = new Label();
            startDate2 = new CalendarCustom();
            label9 = new Label();
            panel10 = new Panel();
            label11 = new Label();
            selectedEmployee = new ComboBoxCustom();
            label12 = new Label();
            selectedEmployee2 = new ComboBoxCustom();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartAmount).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBillings).BeginInit();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 197);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lastOrders);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(146, 90, 57);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 41;
            label1.Text = "Ventas último mes";
            // 
            // lastOrders
            // 
            lastOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastOrders.AutoSize = true;
            lastOrders.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastOrders.ForeColor = Color.Black;
            lastOrders.Location = new Point(53, 27);
            lastOrders.Name = "lastOrders";
            lastOrders.Size = new Size(65, 25);
            lastOrders.TabIndex = 48;
            lastOrders.Text = "Imagen";
            // 
            // paymentPop
            // 
            paymentPop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paymentPop.AutoSize = true;
            paymentPop.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            paymentPop.ForeColor = Color.Black;
            paymentPop.Location = new Point(52, 27);
            paymentPop.Name = "paymentPop";
            paymentPop.Size = new Size(65, 25);
            paymentPop.TabIndex = 47;
            paymentPop.Text = "Imagen";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel1);
            panel5.Location = new Point(10, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(950, 63);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 219, 197);
            panel4.Controls.Add(productPop);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(422, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 63);
            panel4.TabIndex = 2;
            // 
            // productPop
            // 
            productPop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productPop.AutoSize = true;
            productPop.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productPop.ForeColor = Color.Black;
            productPop.Location = new Point(25, 27);
            productPop.Name = "productPop";
            productPop.Size = new Size(154, 25);
            productPop.TabIndex = 49;
            productPop.Text = "Cafe cafe cafe cafe";
            productPop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(146, 90, 57);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 42;
            label2.Text = "Producto popular - ventas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 219, 197);
            panel3.Controls.Add(customerPop);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(699, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 63);
            panel3.TabIndex = 3;
            // 
            // customerPop
            // 
            customerPop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerPop.AutoSize = true;
            customerPop.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerPop.ForeColor = Color.Black;
            customerPop.Location = new Point(81, 27);
            customerPop.Name = "customerPop";
            customerPop.Size = new Size(65, 25);
            customerPop.TabIndex = 50;
            customerPop.Text = "Imagen";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(146, 90, 57);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 43;
            label3.Text = "Cliente frecuente - compras";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 219, 197);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(paymentPop);
            panel2.Location = new Point(204, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 63);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(146, 90, 57);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(184, 25);
            label10.TabIndex = 49;
            label10.Text = "Metodo de pago popular";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(146, 90, 57);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 39);
            label4.TabIndex = 48;
            label4.Text = "Total Vendido";
            // 
            // panel6
            // 
            panel6.Controls.Add(label11);
            panel6.Controls.Add(selectedEmployee);
            panel6.Controls.Add(filterBillings);
            panel6.Controls.Add(endDate);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(startDate);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(473, 464);
            panel6.TabIndex = 49;
            // 
            // filterBillings
            // 
            filterBillings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            filterBillings.BackColor = Color.Transparent;
            filterBillings.BackgroundColor = Color.Transparent;
            filterBillings.BackgroundImageLayout = ImageLayout.Zoom;
            filterBillings.BorderColor = Color.FromArgb(145, 90, 57);
            filterBillings.BorderRadius = 5;
            filterBillings.BorderSize = 2;
            filterBillings.Cursor = Cursors.Hand;
            filterBillings.FlatAppearance.BorderSize = 0;
            filterBillings.FlatStyle = FlatStyle.Flat;
            filterBillings.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterBillings.ForeColor = Color.FromArgb(145, 90, 57);
            filterBillings.Image = Properties.Resources.search1;
            filterBillings.Location = new Point(417, 85);
            filterBillings.MaximumSize = new Size(80, 38);
            filterBillings.Name = "filterBillings";
            filterBillings.Padding = new Padding(6, 0, 6, 0);
            filterBillings.Size = new Size(40, 38);
            filterBillings.TabIndex = 53;
            filterBillings.TextAlign = ContentAlignment.MiddleLeft;
            filterBillings.TextColor = Color.FromArgb(145, 90, 57);
            filterBillings.UseVisualStyleBackColor = false;
            // 
            // endDate
            // 
            endDate.BorderColor = Color.PaleVioletRed;
            endDate.BorderRadius = 10;
            endDate.BorderSize = 0;
            endDate.CustomFormat = "dd/MM/yyyy";
            endDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(124, 86);
            endDate.MaxDate = new DateTime(2023, 10, 25, 21, 33, 45, 286);
            endDate.MinimumSize = new Size(0, 37);
            endDate.Name = "endDate";
            endDate.Size = new Size(107, 37);
            endDate.SkinColor = Color.FromArgb(255, 219, 197);
            endDate.TabIndex = 50;
            endDate.TextColor = Color.FromArgb(145, 90, 57);
            endDate.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // panel7
            // 
            panel7.Controls.Add(chartAmount);
            panel7.Location = new Point(11, 138);
            panel7.Name = "panel7";
            panel7.Size = new Size(449, 305);
            panel7.TabIndex = 52;
            // 
            // chartAmount
            // 
            chartArea3.Name = "ChartArea1";
            chartAmount.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartAmount.Legends.Add(legend3);
            chartAmount.Location = new Point(3, 3);
            chartAmount.Name = "chartAmount";
            chartAmount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            chartAmount.Series.Add(series3);
            chartAmount.Size = new Size(443, 300);
            chartAmount.TabIndex = 0;
            chartAmount.Text = "chart1";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(146, 90, 57);
            label6.Location = new Point(124, 56);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 51;
            label6.Text = "Hasta:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(146, 90, 57);
            label5.Location = new Point(11, 56);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 49;
            label5.Text = "Desde:";
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
            startDate.Location = new Point(11, 85);
            startDate.MaxDate = new DateTime(2222, 10, 25, 0, 0, 0, 0);
            startDate.MinimumSize = new Size(0, 37);
            startDate.Name = "startDate";
            startDate.Size = new Size(107, 37);
            startDate.SkinColor = Color.FromArgb(255, 219, 197);
            startDate.TabIndex = 49;
            startDate.TextColor = Color.FromArgb(145, 90, 57);
            startDate.Value = new DateTime(2001, 10, 25, 0, 0, 0, 0);
            // 
            // panel8
            // 
            panel8.Controls.Add(label12);
            panel8.Controls.Add(selectedEmployee2);
            panel8.Controls.Add(filterAmount);
            panel8.Controls.Add(endDate2);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(startDate2);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(479, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(473, 464);
            panel8.TabIndex = 53;
            // 
            // filterAmount
            // 
            filterAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            filterAmount.BackColor = Color.Transparent;
            filterAmount.BackgroundColor = Color.Transparent;
            filterAmount.BackgroundImageLayout = ImageLayout.Zoom;
            filterAmount.BorderColor = Color.FromArgb(145, 90, 57);
            filterAmount.BorderRadius = 5;
            filterAmount.BorderSize = 2;
            filterAmount.Cursor = Cursors.Hand;
            filterAmount.FlatAppearance.BorderSize = 0;
            filterAmount.FlatStyle = FlatStyle.Flat;
            filterAmount.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterAmount.ForeColor = Color.FromArgb(145, 90, 57);
            filterAmount.Image = Properties.Resources.search1;
            filterAmount.Location = new Point(417, 84);
            filterAmount.MaximumSize = new Size(40, 38);
            filterAmount.Name = "filterAmount";
            filterAmount.Padding = new Padding(6, 0, 6, 0);
            filterAmount.Size = new Size(40, 38);
            filterAmount.TabIndex = 54;
            filterAmount.TextAlign = ContentAlignment.MiddleLeft;
            filterAmount.TextColor = Color.FromArgb(145, 90, 57);
            filterAmount.UseVisualStyleBackColor = false;
            // 
            // endDate2
            // 
            endDate2.BorderColor = Color.PaleVioletRed;
            endDate2.BorderRadius = 10;
            endDate2.BorderSize = 0;
            endDate2.CustomFormat = "dd/MM/yyyy";
            endDate2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            endDate2.Format = DateTimePickerFormat.Custom;
            endDate2.Location = new Point(124, 85);
            endDate2.MaxDate = new DateTime(2023, 10, 26, 0, 0, 0, 0);
            endDate2.MinimumSize = new Size(0, 37);
            endDate2.Name = "endDate2";
            endDate2.Size = new Size(107, 37);
            endDate2.SkinColor = Color.FromArgb(255, 219, 197);
            endDate2.TabIndex = 50;
            endDate2.TextColor = Color.FromArgb(145, 90, 57);
            endDate2.Value = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // panel9
            // 
            panel9.Controls.Add(chartBillings);
            panel9.Location = new Point(11, 138);
            panel9.Name = "panel9";
            panel9.Size = new Size(449, 305);
            panel9.TabIndex = 52;
            // 
            // chartBillings
            // 
            chartArea4.Name = "ChartArea1";
            chartBillings.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartBillings.Legends.Add(legend4);
            chartBillings.Location = new Point(3, 3);
            chartBillings.Name = "chartBillings";
            chartBillings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            chartBillings.Series.Add(series4);
            chartBillings.Size = new Size(443, 300);
            chartBillings.TabIndex = 0;
            chartBillings.Text = "chart2";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(146, 90, 57);
            label7.Location = new Point(121, 57);
            label7.Name = "label7";
            label7.Size = new Size(55, 25);
            label7.TabIndex = 51;
            label7.Text = "Hasta:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(146, 90, 57);
            label8.Location = new Point(11, 57);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 49;
            label8.Text = "Desde:";
            // 
            // startDate2
            // 
            startDate2.BorderColor = Color.PaleVioletRed;
            startDate2.BorderRadius = 10;
            startDate2.BorderSize = 0;
            startDate2.CalendarForeColor = Color.FromArgb(145, 90, 57);
            startDate2.CalendarTitleBackColor = Color.FromArgb(255, 219, 197);
            startDate2.CalendarTitleForeColor = Color.FromArgb(145, 90, 57);
            startDate2.CustomFormat = "dd/MM/yyyy";
            startDate2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            startDate2.Format = DateTimePickerFormat.Custom;
            startDate2.Location = new Point(11, 85);
            startDate2.MaxDate = new DateTime(2023, 10, 25, 0, 0, 0, 0);
            startDate2.MinimumSize = new Size(0, 37);
            startDate2.Name = "startDate2";
            startDate2.Size = new Size(107, 37);
            startDate2.SkinColor = Color.FromArgb(255, 219, 197);
            startDate2.TabIndex = 49;
            startDate2.TextColor = Color.FromArgb(145, 90, 57);
            startDate2.Value = new DateTime(2023, 9, 11, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Poppins Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(146, 90, 57);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(239, 39);
            label9.TabIndex = 48;
            label9.Text = "Cantidad de Ventas";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(panel8);
            panel10.Controls.Add(panel6);
            panel10.Location = new Point(9, 146);
            panel10.Name = "panel10";
            panel10.Size = new Size(952, 464);
            panel10.TabIndex = 54;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(146, 90, 57);
            label11.Location = new Point(240, 57);
            label11.Name = "label11";
            label11.Size = new Size(80, 25);
            label11.TabIndex = 57;
            label11.Text = "Vendedor";
            // 
            // selectedEmployee
            // 
            selectedEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectedEmployee.BackColor = Color.FromArgb(255, 219, 197);
            selectedEmployee.BorderColor = Color.FromArgb(145, 90, 57);
            selectedEmployee.BorderRadius = 5;
            selectedEmployee.BorderSize = 0;
            selectedEmployee.DropDownStyle = ComboBoxStyle.DropDown;
            selectedEmployee.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectedEmployee.ForeColor = Color.FromArgb(145, 90, 57);
            selectedEmployee.IconColor = Color.FromArgb(145, 90, 57);
            selectedEmployee.ListBackColor = Color.FromArgb(230, 228, 245);
            selectedEmployee.ListTextColor = Color.FromArgb(145, 90, 57);
            selectedEmployee.Location = new Point(237, 85);
            selectedEmployee.MaximumSize = new Size(200, 38);
            selectedEmployee.MinimumSize = new Size(110, 30);
            selectedEmployee.Name = "selectedEmployee";
            selectedEmployee.Padding = new Padding(0, 0, 0, 2);
            selectedEmployee.Size = new Size(174, 38);
            selectedEmployee.TabIndex = 56;
            selectedEmployee.Texts = "Todos";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(146, 90, 57);
            label12.Location = new Point(239, 56);
            label12.Name = "label12";
            label12.Size = new Size(80, 25);
            label12.TabIndex = 57;
            label12.Text = "Vendedor";
            // 
            // selectedEmployee2
            // 
            selectedEmployee2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectedEmployee2.BackColor = Color.FromArgb(255, 219, 197);
            selectedEmployee2.BorderColor = Color.FromArgb(145, 90, 57);
            selectedEmployee2.BorderRadius = 5;
            selectedEmployee2.BorderSize = 0;
            selectedEmployee2.DropDownStyle = ComboBoxStyle.DropDown;
            selectedEmployee2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectedEmployee2.ForeColor = Color.FromArgb(145, 90, 57);
            selectedEmployee2.IconColor = Color.FromArgb(145, 90, 57);
            selectedEmployee2.ListBackColor = Color.FromArgb(230, 228, 245);
            selectedEmployee2.ListTextColor = Color.FromArgb(145, 90, 57);
            selectedEmployee2.Location = new Point(237, 84);
            selectedEmployee2.MaximumSize = new Size(200, 38);
            selectedEmployee2.MinimumSize = new Size(110, 30);
            selectedEmployee2.Name = "selectedEmployee2";
            selectedEmployee2.Padding = new Padding(0, 0, 0, 2);
            selectedEmployee2.Size = new Size(174, 38);
            selectedEmployee2.TabIndex = 58;
            selectedEmployee2.Texts = "Todos";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 613);
            Controls.Add(panel10);
            Controls.Add(panel5);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartAmount).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartBillings).EndInit();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label paymentPop;
        private Label customerPop;
        private Label productPop;
        private Label lastOrders;
        private Label label4;
        private Panel panel6;
        private Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmount;
        private Label label6;
        private Label label5;
        private CalendarCustom endDate;
        private CalendarCustom startDate;
        private Panel panel8;
        private Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBillings;
        private Label label7;
        private Label label8;
        private CalendarCustom endDate2;
        private CalendarCustom startDate2;
        private Label label9;
        private Panel panel10;
        private Label label10;
        private ButtonCustom filterBillings;
        private ButtonCustom filterAmount;
        private Label label11;
        private ComboBoxCustom selectedEmployee;
        private Label label12;
        private ComboBoxCustom selectedEmployee2;
    }
}