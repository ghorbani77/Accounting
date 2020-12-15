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
    public partial class frmShowUsers : Form
    {
        public frmShowUsers()
        {
            InitializeComponent();
        }
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            bsShowUsers.DataSource = db.sp_FillUsers();
            if (dgvShowUsers.Rows.Count==0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;

            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
        private void binddata()
        {
            bsShowUsers.DataSource = db.sp_FillUsers();
        }
        private void Check_buttons()
        {
            if (dgvShowUsers.Rows.Count==0)
            {


            }
        }
        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("مورد حذف میشه","حذف",MessageBoxFarsiButtons.YesNoCancel,MessageBoxFarsiIcon.Delete)==DialogResult.Yes)
            {
                db.sp_DeleteuserByID((int)(dgvShowUsers.CurrentRow.Cells[0].Value));
                binddata();

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            frmAddUsers.IsEdit = false;
            new frmAddUsers().ShowDialog();
            bsShowUsers.DataSource = db.sp_FillUsers();
            if (dgvShowUsers.Rows.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;

            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            frmAddUsers.IsEdit = true;
            frmAddUsers.User_ID = (int)dgvShowUsers.CurrentRow.Cells[0].Value;
            frmAddUsers.Role_ID = (int)dgvShowUsers.CurrentRow.Cells[1].Value;
            new frmAddUsers().ShowDialog();

            db = new dcAccountancyDataContext();

            if (dgvShowUsers.Rows.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;

            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }
    }
}
