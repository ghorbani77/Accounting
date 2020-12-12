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
        private void buttonX8_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("حذف مورد؟","حذف",MessageBoxFarsiButtons.YesNoCancel,MessageBoxFarsiIcon.Delete)==DialogResult.Yes)
            {
                db.sp_DeleteuserByID((int)dgvShowUsers.CurrentRow.Cells[0].Value);
              
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
