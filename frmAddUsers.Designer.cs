namespace Accounting
{
    partial class frmAddUsers
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
            this.components = new System.ComponentModel.Container();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbRolles = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bsRolles = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_isactive = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.erpAdduser = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRolles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAdduser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnExit);
            this.panelEx1.Controls.Add(this.btnSave);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(924, 633);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Location = new System.Drawing.Point(12, 463);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.FocusCuesEnabled = false;
            this.btnSave.Location = new System.Drawing.Point(98, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "  ثبت";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbRolles);
            this.groupPanel1.Controls.Add(this.checkBoxX2);
            this.groupPanel1.Controls.Add(this.chk_isactive);
            this.groupPanel1.Controls.Add(this.txtMobile);
            this.groupPanel1.Controls.Add(this.txtPhone);
            this.groupPanel1.Controls.Add(this.txtEmail);
            this.groupPanel1.Controls.Add(this.txtAddress);
            this.groupPanel1.Controls.Add(this.txtFamily);
            this.groupPanel1.Controls.Add(this.txtName);
            this.groupPanel1.Controls.Add(this.txtPassword);
            this.groupPanel1.Controls.Add(this.txtUserName);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(924, 444);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "مشخصات کاربر";
            // 
            // cmbRolles
            // 
            this.cmbRolles.DataSource = this.bsRolles;
            this.cmbRolles.DisplayMember = "rolename";
            this.cmbRolles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRolles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolles.FormattingEnabled = true;
            this.cmbRolles.ItemHeight = 20;
            this.cmbRolles.Location = new System.Drawing.Point(561, 84);
            this.cmbRolles.Name = "cmbRolles";
            this.cmbRolles.Size = new System.Drawing.Size(225, 26);
            this.cmbRolles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbRolles.TabIndex = 2;
            this.cmbRolles.ValueMember = "roleid";
            // 
            // bsRolles
            // 
            this.bsRolles.DataSource = typeof(Accounting.model.roles_tbl);
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Location = new System.Drawing.Point(561, 116);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(73, 23);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 23;
            this.checkBoxX2.Text = "غیر فعال";
            // 
            // chk_isactive
            // 
            // 
            // 
            // 
            this.chk_isactive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_isactive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsUsers, "is_actve", true));
            this.chk_isactive.DataBindings.Add(new System.Windows.Forms.Binding("CheckValue", this.bsUsers, "is_actve", true));
            this.chk_isactive.Location = new System.Drawing.Point(694, 116);
            this.chk_isactive.Name = "chk_isactive";
            this.chk_isactive.Size = new System.Drawing.Size(73, 23);
            this.chk_isactive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_isactive.TabIndex = 3;
            this.chk_isactive.Text = "فعال";
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = typeof(Accounting.model.users_tbl);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "mobile", true));
            this.txtMobile.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtMobile.FocusHighlightEnabled = true;
            this.txtMobile.Location = new System.Drawing.Point(561, 305);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PreventEnterBeep = true;
            this.txtMobile.Size = new System.Drawing.Size(225, 26);
            this.txtMobile.TabIndex = 9;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.Border.Class = "TextBoxBorder";
            this.txtPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "phone", true));
            this.txtPhone.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtPhone.FocusHighlightEnabled = true;
            this.txtPhone.Location = new System.Drawing.Point(561, 273);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PreventEnterBeep = true;
            this.txtPhone.Size = new System.Drawing.Size(225, 26);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "email", true));
            this.txtEmail.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtEmail.FocusHighlightEnabled = true;
            this.txtEmail.Location = new System.Drawing.Point(561, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(225, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "u_address", true));
            this.txtAddress.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtAddress.FocusHighlightEnabled = true;
            this.txtAddress.Location = new System.Drawing.Point(561, 209);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.Size = new System.Drawing.Size(225, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // txtFamily
            // 
            // 
            // 
            // 
            this.txtFamily.Border.Class = "TextBoxBorder";
            this.txtFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "family", true));
            this.txtFamily.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtFamily.FocusHighlightEnabled = true;
            this.txtFamily.Location = new System.Drawing.Point(561, 177);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.PreventEnterBeep = true;
            this.txtFamily.Size = new System.Drawing.Size(225, 26);
            this.txtFamily.TabIndex = 5;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "name", true));
            this.txtName.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtName.FocusHighlightEnabled = true;
            this.txtName.Location = new System.Drawing.Point(561, 145);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(225, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "userpassword", true));
            this.txtPassword.FocusHighlightColor = System.Drawing.Color.Empty;
            this.txtPassword.FocusHighlightEnabled = true;
            this.txtPassword.Location = new System.Drawing.Point(561, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(225, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.WatermarkText = "مقدار بابد وارد شود";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "username", true));
            this.txtUserName.FocusHighlightColor = System.Drawing.Color.Empty;
            this.txtUserName.FocusHighlightEnabled = true;
            this.txtUserName.Location = new System.Drawing.Point(561, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(225, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.WatermarkText = "مقدار بابد وارد شود";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX7.Location = new System.Drawing.Point(792, 301);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(117, 23);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "موبایل :";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX7.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX6.Location = new System.Drawing.Point(792, 269);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(117, 23);
            this.labelX6.TabIndex = 20;
            this.labelX6.Text = "تلفن :";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX6.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX5.Location = new System.Drawing.Point(792, 237);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(117, 23);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "ایمیل :";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX5.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX4.Location = new System.Drawing.Point(792, 205);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(117, 23);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "آدرس :";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX4.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX3.Location = new System.Drawing.Point(792, 173);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(117, 23);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "نام خانوادگی :";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX3.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX9.Location = new System.Drawing.Point(792, 116);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(117, 23);
            this.labelX9.TabIndex = 20;
            this.labelX9.Text = "وضعیت :";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX9.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX2.Location = new System.Drawing.Point(792, 141);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(117, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "نام :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX8.Location = new System.Drawing.Point(792, 84);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(117, 23);
            this.labelX8.TabIndex = 20;
            this.labelX8.Text = "انتخاب نقش :";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX8.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX1.Location = new System.Drawing.Point(792, 48);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(117, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "رمز عبور:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX14.Location = new System.Drawing.Point(792, 16);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(117, 23);
            this.labelX14.TabIndex = 20;
            this.labelX14.Text = "نام کاربری:";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX14.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // erpAdduser
            // 
            this.erpAdduser.ContainerControl = this;
            this.erpAdduser.RightToLeft = true;
            this.erpAdduser.RightToLeftChanged += new System.EventHandler(this.errorProvider1_RightToLeftChanged);
            // 
            // frmAddUsers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(924, 633);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddUsers_FormClosed);
            this.Load += new System.EventHandler(this.frmAddUsers_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsRolles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAdduser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRolles;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_isactive;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFamily;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.BindingSource bsRolles;
        private System.Windows.Forms.ErrorProvider erpAdduser;
    }
}