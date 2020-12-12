using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using Accounting.model;

namespace Accounting
{
    public partial class frmAddRoles : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();
        public static bool Is_Edit=false;
        public static int RoleID = 0;
        public static bool ExitType = false; 


        public frmAddRoles()
        {
            InitializeComponent();
        }

        private void frmAddRoles_Load(object sender, EventArgs e)
        {
            try
            {
                if (Is_Edit==true)
                {
                    bsRoles_tbl.DataSource = db.FillRolesById(RoleID);
                }
            }
            catch (Exception)
            {

                throw;
            }

            bsRoles_tbl.DataSource = db.FillRoles();

            //if (dgvRolls.Rows.Count==0)
            //{
            //    btnDelete.Enabled = false;
            //    btnEdit.Enabled = false;
            //}
            //else
            //{
            //    btnEdit.Enabled = btnDelete.Enabled = true;
            //}

        }

        private void btnNewrool_Click(object sender, EventArgs e)
        {
            Is_Edit = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Is_Edit = true;
            //RoleID = (int)dgvRolls.CurrentRow.Cells[0].Value;
            //db = new dcAccountancyDataContext();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("رکورد جاری حذف شود ؟","تایید حذف",MessageBoxFarsiButtons.YesNoCancel,MessageBoxFarsiIcon.Delete,MessageBoxFarsiDefaultButton.Button1) ==DialogResult.Yes)
            {
                //db.DeleteRoles((int)dgvRolls.CurrentRow.Cells[0].Value);
                //bsRoles_tbl.DataSource = db.FillRoles();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ExitType)
            {
                Application.Exit();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtRoleName.Text == "")
            {
                erproles.SetError(txtRoleName, "مقداری وارد کنید ");
                txtRoleName.Focus();

            }
            else
            {
                erproles.Clear();
                if (Is_Edit)
                {

                    db.UpdateRoles(RoleID, txtRoleName.Text, chkDeppo.Checked, chkBank.Checked, chkPerson.Checked, chkFactor.Checked, chkSetting.Checked, chkUsers.Checked
                       , chkIsActive.Checked, 1, 1, "1");
                }
                else
                {
                    db.InsertRoles(txtRoleName.Text, chkDeppo.Checked, chkBank.Checked, chkPerson.Checked, chkFactor.Checked, chkSetting.Checked, chkUsers.Checked
                        , chkIsActive.Checked, 1, 1, "1");
                    txtRoleName.Text = string.Empty;
                    chkBank.Checked = chkDeppo.Checked = chkFactor.Checked = chkIsActive.Checked = chkPerson.Checked =
                        chkSetting.Checked = chkUsers.Checked = false;
                    txtRoleName.Focus();
                    MessageBoxFarsi.Show("عملیات انجام شد", "ثبت انجام شد", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Help);
                    bsRoles_tbl.DataSource = db.FillRoles();
                    ExitType = false;

                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
