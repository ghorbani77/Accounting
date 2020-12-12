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
    public partial class frmShowrolles : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();
        public frmShowrolles()
        {
            InitializeComponent();
        }

        private void frmShowrolles_Load(object sender, EventArgs e)
        {
            try
            {
                bsShowRolles.DataSource = db.FillRoles();
                if (dgvRolls.Rows.Count == 0)
                {
                    btnDelete.Enabled = btnEdit.Enabled = false;

                }
                else
                {
                    btnDelete.Enabled = btnEdit.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNewrool_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddRoles.Is_Edit = false;
                new frmAddRoles().ShowDialog();
                bsShowRolles.DataSource = db.FillRoles();
                if (dgvRolls.Rows.Count == 0)
                {
                    btnDelete.Enabled = btnEdit.Enabled = false;

                }
                else
                {
                    btnDelete.Enabled = btnEdit.Enabled = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddRoles.Is_Edit = true;
            frmAddRoles.RoleID = Convert.ToInt32(dgvRolls.CurrentRow.Cells[0].Value.ToString());
            new frmAddRoles().ShowDialog();
            db = new dcAccountancyDataContext();

            bsShowRolles.DataSource = db.FillRoles();
            if (dgvRolls.Rows.Count == 0)
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
            if (MessageBoxFarsi.Show("مورد حذف شود؟","حذف",MessageBoxFarsiButtons.YesNoCancel,MessageBoxFarsiIcon.Delete)==DialogResult.Yes)
            {
                db.DeleteRoles((int)dgvRolls.CurrentRow.Cells[0].Value);
                bsShowRolles.DataSource = db.FillRoles();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
