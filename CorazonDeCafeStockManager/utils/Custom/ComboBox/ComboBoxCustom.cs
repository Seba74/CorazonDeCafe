using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace CorazonDeCafeStockManager
{
    public class ComboBoxCustom : UserControl
    {
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;
        //Items
        private ComboBox? cmbList;
        private Label? lblText;
        private Button? btnIcon;
        private int borderRadius = 0;
        //Events
        public event EventHandler? OnSelectedIndexChanged;//Default event


        public ComboBoxCustom()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();
            //ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged!);//Default event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged!);//Refresh text
                                                                           //Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click!);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint!);//Draw icon
                                                                //Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.FontFamily, 10F);
            //->Attach label events to user control event
            lblText.Click += new EventHandler(Surface_Click!);//Select combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter!);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave!);
            //User Control
            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            this.MinimumSize = new Size(180, 30);
            this.Size = new Size(180, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            this.Font = new Font(this.Font.FontFamily, 10F);
            base.BackColor = borderColor; //Border Color
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList!.Width = lblText!.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            pathTxt = GetFigurePath(lblText!.ClientRectangle, borderSize * 2);
            lblText!.Region = new Region(pathTxt);
            pathTxt.Dispose();
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblText!.Text = cmbList!.Text;
        }
        //-> Items actions
        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            cmbList!.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            //Attach label click to user control click
            this.OnClick(e);
            //Select combo box
            cmbList!.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;//Open dropdown list
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            lblText!.Text = cmbList!.Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new(this.Parent!.BackColor, smoothSize))
                using (Pen penBorder = new(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
            }
            else //Square/Normal TextBox
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon!.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        //Properties
        //-> Appearance
        [Category("Coffee Custom - Appearance")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText!.BackColor = backColor;
                btnIcon!.BackColor = backColor;
            }
        }
        [Category("Coffee Custom - Appearance")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon!.Invalidate();//Redraw icon
            }
        }
        [Category("Coffee Custom - Appearance")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList!.BackColor = listBackColor;
            }
        }
        [Category("Coffee Custom - Appearance")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList!.ForeColor = listTextColor;
            }
        }
        [Category("Coffee Custom - Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }
        [Category("Coffee Custom - Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }
        [Category("Coffee Custom - Appearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText!.ForeColor = value;
            }
        }
        [Category("Coffee Custom - Appearance")]
        public override Font Font
        {
            get { return base.Font; }
        }
        [Category("Coffee Custom - Appearance")]
        public string Texts
        {
            get { return lblText!.Text; }
            set { lblText!.Text = value; }
        }
        [Category("Coffee Custom - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList!.DropDownStyle; }
            set
            {
                if (cmbList!.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        [Category("Coffee Input Custom")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        [Category("Coffee Custom - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList!.Items; }
        }
        [Category("Coffee Custom - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList!.DataSource; }
            set { cmbList!.DataSource = value; }
        }
        [Category("Coffee Custom - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList!.AutoCompleteCustomSource; }
            set { cmbList!.AutoCompleteCustomSource = value; }
        }
        [Category("Coffee Custom - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList!.AutoCompleteSource; }
            set { cmbList!.AutoCompleteSource = value; }
        }
        [Category("Coffee Custom - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList!.AutoCompleteMode; }
            set { cmbList!.AutoCompleteMode = value; }
        }
        [Category("Coffee Custom - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmbList!.SelectedItem; }
            set { cmbList!.SelectedItem = value; }
        }
        [Category("Coffee Custom - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmbList!.SelectedIndex; }
            set { cmbList!.SelectedIndex = value; }
        }
        [Category("Coffee Custom - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmbList!.DisplayMember; }
            set { cmbList!.DisplayMember = value; }
        }
        [Category("Coffee Custom - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmbList!.ValueMember; }
            set { cmbList!.ValueMember = value; }
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}