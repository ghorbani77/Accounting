using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.model;
using BehComponents;

namespace Accounting
{
    public partial class frmSettings : Form
    {
        Messages er = new Messages();
        dcAccountancyDataContext db = new dcAccountancyDataContext();
        bool? Exists_Settings = false; //by refrence 

        public bool ExitType = false;
        public frmSettings()
        {
            InitializeComponent();
        }
        
        
        private void frmSettings_Load(object sender, EventArgs e)
        {
            db.ExistsSettings_tbl(ref Exists_Settings);
            if (Exists_Settings==true)
            {
                bsSettings_tbl.DataSource = db.FillSettings_tbl();

            }
        }

        private void chkSmsTarakonesh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbSmsFactor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text == string.Empty)
                {
                    erpSettings.SetError(txtCompanyName, "مقداری وارد کنید");
                    txtCompanyName.Focus();

                }
                else
                {
                    erpSettings.Clear();
                    if (Exists_Settings == true)   // go to edit
                    {
                        bsSettings_tbl.EndEdit();
                        db.UpdateSettings_tbl(txtCompanyName.Text, txtCodeEghtesadi.Text, txtCodeMelli.Text, txtCompanyAddress.Text
                            , txtInvoicePhone.Text, txtInvtracePhone.Text, txtSmsPanelUserName.Text, txtSmsPanelPassword.Text, txtFerestandePayamak.Text,
                            txtGirandePayamak.Text, txtHoshdarSarresidAz.Value, txtHoshdarSarresidTa.Value, txtInvtraceAddress.Text,
                            txtMobile.Text, chkSmsTarakonesh.Checked, chkSmsFactor.Checked, txtmodiramel.Text, txtcodesabt.Text, "ax", "ax2", chkIsActive.Checked, 1, 1, "1");

                    }
                    else
                    {
                        db.InsertSettings_tbl(txtCompanyName.Text, txtCodeEghtesadi.Text, txtCodeMelli.Text, txtCompanyAddress.Text
                            , txtInvoicePhone.Text, txtInvtracePhone.Text, txtSmsPanelUserName.Text, txtSmsPanelPassword.Text, txtFerestandePayamak.Text,
                            txtGirandePayamak.Text, txtHoshdarSarresidAz.Value, txtHoshdarSarresidTa.Value, txtInvtraceAddress.Text,
                            txtMobile.Text, chkSmsTarakonesh.Checked, chkSmsFactor.Checked, txtmodiramel.Text, txtcodesabt.Text, "ax", "ax2", chkIsActive.Checked, 1, 1, "1");

                    }
                    MessageBoxFarsi.Show("ایجاد شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    Exists_Settings = true;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                er.CopyError(ex.Number, ex.Message);
            }
            catch (Exception ep)
            {

                MessageBox.Show(ep.Message);
                er.CopyError2(ep.Message);
            }
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            if (Exists_Settings == false)
            {
                MessageBoxFarsi.Show("هیچ تنظیماتی وجود ندارد- از نرم افزار خارج میشوید", "راه اندازی", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning);
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
    }
}
