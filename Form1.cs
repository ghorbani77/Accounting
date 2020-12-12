using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.model;
using BehComponents;

namespace Accounting
{
    public partial class frmMain : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();
        bool? ExistsRolle=false;
        bool? ExistsSettings = false;
        bool? ExistsUsers = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            db.ExistRoles(ref ExistsRolle);
            if (ExistsRolle==false)
            {
                frmAddRoles.Is_Edit = false;
                frmAddRoles.ExitType = true;
                new frmAddRoles().ShowDialog();
            }
            db.ExistsSettings_tbl(ref ExistsSettings);
            if (ExistsSettings==false)
            {
                 
                new frmSettings().ShowDialog();
            }
            db.sp_UsersExists(ref ExistsUsers);
            if (ExistsUsers == false)
            {
                frmAddUsers.ExitType = true;
                frmAddUsers.IsEdit = false;
                new frmAddUsers().ShowDialog();
            }

        }

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmSettings formsettings = new frmSettings();
            formsettings.ShowDialog();
        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            new frmShowrolles().ShowDialog();
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            new frmShowUsers().ShowDialog();
        }
    }
}
