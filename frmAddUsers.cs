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
    public partial class frmAddUsers : Form
    {
        Message mymsg = new Message();
        dcAccountancyDataContext db = new dcAccountancyDataContext();
        public static bool ExitType = false;
        public static bool IsEdit = false;
        public static int User_ID = 0;
        public static int Role_ID = 0;

        bool? CheckName = false; //نام کاربری تکراری


        public frmAddUsers()
        {
            InitializeComponent();
        }

        private void frmAddUsers_Load(object sender, EventArgs e)
        {  
            try
            {
                bsRolles.DataSource = db.FillRoles();
                if (IsEdit == true)
                {
                    bsUsers.DataSource = db.sp_FindUserByID(User_ID);
                    cmbRolles.SelectedValue = Role_ID;
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                erpAdduser.Clear();
                if (IsEdit)
                {
                    //bsUsers.DataSource = db.sp_FindUserByID(User_ID);
                    bsUsers.EndEdit();
                    db.updateusers_tbl(User_ID, (int)cmbRolles.SelectedValue, txtUserName.Text, txtPassword.Text,
                        chk_isactive.Checked, txtName.Text, txtFamily.Text, txtAddress.Text, txtEmail.Text, txtPhone.Text, txtMobile.Text, "13990701", 1, 1);

                }
                else
                {
                    db.sp_UserNameCheck(ref CheckName, txtUserName.Text);
                    if (CheckName == true)
                    {
                        erpAdduser.SetError(txtUserName, "نام کاربری تکراری است");
                        txtUserName.Focus();
                    }
                    else
                    {
                        db.insertusers_tbl((int)cmbRolles.SelectedValue, txtUserName.Text, txtPassword.Text, chk_isactive.Checked,
                         txtName.Text, txtFamily.Text, txtAddress.Text, txtEmail.Text, txtPhone.Text, txtMobile.Text, "13990918", 1, 1);
                        ExitType = false;
                    }



                }
            }
            catch (Exception)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }
    }
}
