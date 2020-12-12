namespace Accounting
{
    partial class frmShowrolles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnNewrool = new DevComponents.DotNetBar.ButtonX();
            this.dgvRolls = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bsShowRolles = new System.Windows.Forms.BindingSource(this.components);
            this.roleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotpermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.bankpermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.personpermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.factorpermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.settingspermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.userpermissionDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.isactiveDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.adduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edituserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolls)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsShowRolles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.btnDelete);
            this.groupPanel2.Controls.Add(this.btnEdit);
            this.groupPanel2.Controls.Add(this.btnNewrool);
            this.groupPanel2.Controls.Add(this.dgvRolls);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(917, 514);
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
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "نمایش دسترسی ها";
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Location = new System.Drawing.Point(9, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.FocusCuesEnabled = false;
            this.btnDelete.Location = new System.Drawing.Point(473, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.FocusCuesEnabled = false;
            this.btnEdit.Location = new System.Drawing.Point(619, 454);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnEdit.Size = new System.Drawing.Size(140, 30);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewrool
            // 
            this.btnNewrool.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewrool.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewrool.FocusCuesEnabled = false;
            this.btnNewrool.Location = new System.Drawing.Point(765, 454);
            this.btnNewrool.Name = "btnNewrool";
            this.btnNewrool.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnNewrool.Size = new System.Drawing.Size(140, 30);
            this.btnNewrool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewrool.TabIndex = 2;
            this.btnNewrool.Text = "جدید";
            this.btnNewrool.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNewrool.Click += new System.EventHandler(this.btnNewrool_Click);
            // 
            // dgvRolls
            // 
            this.dgvRolls.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleidDataGridViewTextBoxColumn,
            this.rolenameDataGridViewTextBoxColumn,
            this.depotpermissionDataGridViewTextBoxColumn,
            this.bankpermissionDataGridViewTextBoxColumn,
            this.personpermissionDataGridViewTextBoxColumn,
            this.factorpermissionDataGridViewTextBoxColumn,
            this.settingspermissionDataGridViewTextBoxColumn,
            this.userpermissionDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn,
            this.adduserDataGridViewTextBoxColumn,
            this.edituserDataGridViewTextBoxColumn,
            this.adddateDataGridViewTextBoxColumn});
            this.dgvRolls.DataSource = this.bsShowRolles;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRolls.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRolls.EnableHeadersVisualStyles = false;
            this.dgvRolls.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvRolls.Location = new System.Drawing.Point(3, 3);
            this.dgvRolls.Name = "dgvRolls";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolls.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRolls.RowTemplate.Height = 24;
            this.dgvRolls.Size = new System.Drawing.Size(902, 430);
            this.dgvRolls.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(917, 514);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // bsShowRolles
            // 
            this.bsShowRolles.DataSource = typeof(Accounting.model.roles_tbl);
            // 
            // roleidDataGridViewTextBoxColumn
            // 
            this.roleidDataGridViewTextBoxColumn.DataPropertyName = "roleid";
            this.roleidDataGridViewTextBoxColumn.HeaderText = "roleid";
            this.roleidDataGridViewTextBoxColumn.Name = "roleidDataGridViewTextBoxColumn";
            this.roleidDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolenameDataGridViewTextBoxColumn
            // 
            this.rolenameDataGridViewTextBoxColumn.DataPropertyName = "rolename";
            this.rolenameDataGridViewTextBoxColumn.HeaderText = "نام نقش";
            this.rolenameDataGridViewTextBoxColumn.Name = "rolenameDataGridViewTextBoxColumn";
            this.rolenameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // depotpermissionDataGridViewTextBoxColumn
            // 
            this.depotpermissionDataGridViewTextBoxColumn.Checked = true;
            this.depotpermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.depotpermissionDataGridViewTextBoxColumn.CheckValue = null;
            this.depotpermissionDataGridViewTextBoxColumn.DataPropertyName = "depotpermission";
            this.depotpermissionDataGridViewTextBoxColumn.HeaderText = "انیار";
            this.depotpermissionDataGridViewTextBoxColumn.Name = "depotpermissionDataGridViewTextBoxColumn";
            this.depotpermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.depotpermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bankpermissionDataGridViewTextBoxColumn
            // 
            this.bankpermissionDataGridViewTextBoxColumn.Checked = true;
            this.bankpermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.bankpermissionDataGridViewTextBoxColumn.CheckValue = null;
            this.bankpermissionDataGridViewTextBoxColumn.DataPropertyName = "bankpermission";
            this.bankpermissionDataGridViewTextBoxColumn.HeaderText = "حسابها";
            this.bankpermissionDataGridViewTextBoxColumn.Name = "bankpermissionDataGridViewTextBoxColumn";
            this.bankpermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bankpermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // personpermissionDataGridViewTextBoxColumn
            // 
            this.personpermissionDataGridViewTextBoxColumn.Checked = true;
            this.personpermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.personpermissionDataGridViewTextBoxColumn.CheckValue = null;
            this.personpermissionDataGridViewTextBoxColumn.DataPropertyName = "personpermission";
            this.personpermissionDataGridViewTextBoxColumn.HeaderText = "اشخاص";
            this.personpermissionDataGridViewTextBoxColumn.Name = "personpermissionDataGridViewTextBoxColumn";
            this.personpermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personpermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // factorpermissionDataGridViewTextBoxColumn
            // 
            this.factorpermissionDataGridViewTextBoxColumn.Checked = true;
            this.factorpermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.factorpermissionDataGridViewTextBoxColumn.CheckValue = null;
            this.factorpermissionDataGridViewTextBoxColumn.DataPropertyName = "factorpermission";
            this.factorpermissionDataGridViewTextBoxColumn.HeaderText = "فاکتورها";
            this.factorpermissionDataGridViewTextBoxColumn.Name = "factorpermissionDataGridViewTextBoxColumn";
            this.factorpermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factorpermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // settingspermissionDataGridViewTextBoxColumn
            // 
            this.settingspermissionDataGridViewTextBoxColumn.Checked = true;
            this.settingspermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.settingspermissionDataGridViewTextBoxColumn.CheckValue = null;
            this.settingspermissionDataGridViewTextBoxColumn.DataPropertyName = "settingspermission";
            this.settingspermissionDataGridViewTextBoxColumn.HeaderText = "تنظیمات";
            this.settingspermissionDataGridViewTextBoxColumn.Name = "settingspermissionDataGridViewTextBoxColumn";
            this.settingspermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.settingspermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userpermissionDataGridViewTextBoxColumn
            // 
            this.userpermissionDataGridViewTextBoxColumn.Checked = true;
            this.userpermissionDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.userpermissionDataGridViewTextBoxColumn.CheckValue = null;
            this.userpermissionDataGridViewTextBoxColumn.DataPropertyName = "userpermission";
            this.userpermissionDataGridViewTextBoxColumn.HeaderText = "کاربران";
            this.userpermissionDataGridViewTextBoxColumn.Name = "userpermissionDataGridViewTextBoxColumn";
            this.userpermissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userpermissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.Checked = true;
            this.isactiveDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.isactiveDataGridViewTextBoxColumn.CheckValue = null;
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "is_active";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "فعال";
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // adduserDataGridViewTextBoxColumn
            // 
            this.adduserDataGridViewTextBoxColumn.DataPropertyName = "add_user";
            this.adduserDataGridViewTextBoxColumn.HeaderText = "یوزر";
            this.adduserDataGridViewTextBoxColumn.Name = "adduserDataGridViewTextBoxColumn";
            // 
            // edituserDataGridViewTextBoxColumn
            // 
            this.edituserDataGridViewTextBoxColumn.DataPropertyName = "edit_user";
            this.edituserDataGridViewTextBoxColumn.HeaderText = "edit_user";
            this.edituserDataGridViewTextBoxColumn.Name = "edituserDataGridViewTextBoxColumn";
            // 
            // adddateDataGridViewTextBoxColumn
            // 
            this.adddateDataGridViewTextBoxColumn.DataPropertyName = "add_date";
            this.adddateDataGridViewTextBoxColumn.HeaderText = "add_date";
            this.adddateDataGridViewTextBoxColumn.Name = "adddateDataGridViewTextBoxColumn";
            // 
            // frmShowrolles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(917, 514);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmShowrolles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت دسترسی ها";
            this.Load += new System.EventHandler(this.frmShowrolles_Load);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolls)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsShowRolles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnNewrool;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRolls;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.BindingSource bsShowRolles;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolenameDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn depotpermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn bankpermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn personpermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn factorpermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn settingspermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn userpermissionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn isactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edituserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adddateDataGridViewTextBoxColumn;
    }
}