namespace Accounting
{
    partial class frmAddRoles
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
            this.erproles = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chkIsActive = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkUsers = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkSetting = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkFactor = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkPerson = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkBank = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkDeppo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtRoleName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bsRoles_tbl = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.erproles)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRoles_tbl)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // erproles
            // 
            this.erproles.ContainerControl = this;
            this.erproles.RightToLeft = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.chkIsActive);
            this.groupPanel1.Controls.Add(this.chkUsers);
            this.groupPanel1.Controls.Add(this.chkSetting);
            this.groupPanel1.Controls.Add(this.chkFactor);
            this.groupPanel1.Controls.Add(this.chkPerson);
            this.groupPanel1.Controls.Add(this.chkBank);
            this.groupPanel1.Controls.Add(this.chkDeppo);
            this.groupPanel1.Controls.Add(this.txtRoleName);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(316, 436);
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
            this.groupPanel1.Text = "ثبت مشخصات نقش";
            // 
            // chkIsActive
            // 
            // 
            // 
            // 
            this.chkIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "is_active", true));
            this.chkIsActive.Location = new System.Drawing.Point(88, 226);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(143, 23);
            this.chkIsActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsActive.TabIndex = 7;
            this.chkIsActive.Text = "فعال باشد ؟";
            // 
            // chkUsers
            // 
            // 
            // 
            // 
            this.chkUsers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkUsers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "userpermission", true));
            this.chkUsers.Location = new System.Drawing.Point(88, 197);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(143, 23);
            this.chkUsers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkUsers.TabIndex = 6;
            this.chkUsers.Text = "دسترسی به کاربران";
            // 
            // chkSetting
            // 
            // 
            // 
            // 
            this.chkSetting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSetting.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "settingspermission", true));
            this.chkSetting.Location = new System.Drawing.Point(61, 168);
            this.chkSetting.Name = "chkSetting";
            this.chkSetting.Size = new System.Drawing.Size(170, 23);
            this.chkSetting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkSetting.TabIndex = 5;
            this.chkSetting.Text = "دسترسی به تنظیمات";
            // 
            // chkFactor
            // 
            // 
            // 
            // 
            this.chkFactor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFactor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "factorpermission", true));
            this.chkFactor.Location = new System.Drawing.Point(75, 139);
            this.chkFactor.Name = "chkFactor";
            this.chkFactor.Size = new System.Drawing.Size(156, 23);
            this.chkFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFactor.TabIndex = 4;
            this.chkFactor.Text = "دسترسی به فاکتورها";
            // 
            // chkPerson
            // 
            // 
            // 
            // 
            this.chkPerson.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkPerson.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "personpermission", true));
            this.chkPerson.Location = new System.Drawing.Point(75, 110);
            this.chkPerson.Name = "chkPerson";
            this.chkPerson.Size = new System.Drawing.Size(156, 23);
            this.chkPerson.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkPerson.TabIndex = 3;
            this.chkPerson.Text = "دسترسی به اشخاص";
            // 
            // chkBank
            // 
            // 
            // 
            // 
            this.chkBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBank.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "bankpermission", true));
            this.chkBank.Location = new System.Drawing.Point(75, 81);
            this.chkBank.Name = "chkBank";
            this.chkBank.Size = new System.Drawing.Size(156, 23);
            this.chkBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkBank.TabIndex = 2;
            this.chkBank.Text = "دسترسی به حسابها";
            // 
            // chkDeppo
            // 
            // 
            // 
            // 
            this.chkDeppo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkDeppo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsRoles_tbl, "depotpermission", true));
            this.chkDeppo.Location = new System.Drawing.Point(88, 52);
            this.chkDeppo.Name = "chkDeppo";
            this.chkDeppo.Size = new System.Drawing.Size(143, 23);
            this.chkDeppo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkDeppo.TabIndex = 1;
            this.chkDeppo.Text = "دسترسی به انبار";
            // 
            // txtRoleName
            // 
            // 
            // 
            // 
            this.txtRoleName.Border.Class = "TextBoxBorder";
            this.txtRoleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRoleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRoles_tbl, "rolename", true));
            this.txtRoleName.FocusHighlightColor = System.Drawing.Color.Empty;
            this.txtRoleName.FocusHighlightEnabled = true;
            this.txtRoleName.Location = new System.Drawing.Point(61, 20);
            this.txtRoleName.MaxLength = 110;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.PreventEnterBeep = true;
            this.txtRoleName.Size = new System.Drawing.Size(170, 26);
            this.txtRoleName.TabIndex = 0;
            this.txtRoleName.WatermarkText = "مقدار بابد وارد شود";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX14.Location = new System.Drawing.Point(237, 20);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(67, 23);
            this.labelX14.TabIndex = 19;
            this.labelX14.Text = "نام نقش:";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX14.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(347, 464);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // bsRoles_tbl
            // 
            this.bsRoles_tbl.DataSource = typeof(Accounting.model.roles_tbl);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(22, 345);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(272, 61);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Image = global::Accounting.Properties.Resources.Cancel;
            this.btnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnExit.Location = new System.Drawing.Point(3, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnExit.Size = new System.Drawing.Size(97, 30);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.FocusCuesEnabled = false;
            this.buttonX1.Image = global::Accounting.Properties.Resources.Save;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(166, 14);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.buttonX1.Size = new System.Drawing.Size(97, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "ذخیره";
            this.buttonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmAddRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddRoles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddRoles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddRoles_FormClosed);
            this.Load += new System.EventHandler(this.frmAddRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erproles)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsRoles_tbl)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsRoles_tbl;
        private System.Windows.Forms.ErrorProvider erproles;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIsActive;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUsers;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSetting;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFactor;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkPerson;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBank;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkDeppo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRoleName;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}