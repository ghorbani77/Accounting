using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Accounting.Modula;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace Accounting
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ///خواندن رشته اتصال از رجیستری
            string RegisteryConnectionString = "";
            RegistryKey ConnectionString = Registry.CurrentUser.CreateSubKey("SOFTWARE\\AutomationConnection");
            RegisteryConnectionString = ConnectionString.GetValue("ConnectionForAutomation").ToString();

            try
            {
                if (RegisteryConnectionString == "")
                {
                    MessageBox.Show("ارتباط با سرور برقرار نیست");

                    btn_enter.Enabled = false;
                }
                else
                {
                    PublicVariable.MainConnectionString = CryptionAlgorithm.DecryptTextUsingUTF8(RegisteryConnectionString);
                }
            }
            catch
            {
                btn_enter.Enabled = false;
                MessageBox.Show("ارتباط با سرور برقرار نیست");

            }

            //Show Date
            System.Globalization.PersianCalendar PC = new System.Globalization.PersianCalendar();
            lbl_date.Text = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime((PC.GetYear(DateTime.Now) + "/" + PC.GetMonth(DateTime.Now) + "/" + PC.GetDayOfMonth(DateTime.Now))));
            PublicVariable.TodayDate = lbl_date.Text.Trim();


            //Show IP
            string ComputerName = System.Environment.MachineName;
            lblComputername.Text = ComputerName.ToString();
            // string IP = "";
            IPHostEntry ipe = Dns.GetHostByName(ComputerName);
            IPAddress[] IpAdrress = ipe.AddressList;
            lbl_IP.Text = IpAdrress[0].ToString();
            //Show Time
            
            timer1_Tick(sender, e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            lbl_time.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
            lbl_time.Refresh();

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            notify.BalloonTipText = "test";
            notify.BalloonTipTitle = "عنوان خطا";
            notify.Icon = SystemIcons.Information;
            notify.ShowBalloonTip(10);

            //Automation_systemEntities database = new Automation_systemEntities(PublicVariable.MainConnectionString);
            //int addad = database.Users.Count();
            MessageBox.Show(addad.ToString());
            try
            {
                if (txt_username.Text.Trim() != "" && txt_password.Text.Trim() != "")
                {
                    /////Hash Password
                    SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                    Byte[] B1;
                    Byte[] B2;
                    B1 = UTF8Encoding.UTF8.GetBytes(txt_password.Text.Trim());
                    B2 = SHA256.ComputeHash(B1);
                    string HashedPassword = BitConverter.ToString(B2);
                    ////////


                    var Login_query = (from U in database.Users
                                       where U.UserName == txt_username.Text.Trim()
                                       where U.Password == HashedPassword
                                       where U.Activity == 1
                                       select U).ToList();


                    if (Login_query.Count == 1)
                    {

                        ////بدست آوردن مشخصات کاربر جهت استفاده در سرتاسر برنامه
                        PublicVariable.gUserFirstName = Login_query[0].UserFirstName;
                        PublicVariable.gUserFamily = Login_query[0].UserFamily;
                        PublicVariable.gUserID = Login_query[0].UserID;

                        /////ثبت اطلاعات کامپیوتر و آی پی کاربر جهت کنترل ورود و خروج
                        string ComputerName = System.Environment.MachineName;
                        //UserLog UL = new UserLog();
                       // UL.ComputerName = ComputerName;
                      //  UL.IpAddress = lbl_IP.Text.Trim();
                       // UL.EnterDateTime = lbl_date.Text + "-" +
                            string.Format("{0:HH:mm:ss}", Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second));
                        //UL.Userid = PublicVariable.gUserID;

                       // database.UserLogs.Add(UL);
                       // database.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("کاربری با این مشخصات یافت نشد.");
                        return;
                    }
                    //////////////////////////////////////////////////

                    if (rdb_admin.Checked)
                    {
                        if (Login_query[0].UserName == "admin")
                        {
                            PublicVariable.gSetUser = 1; ///admin
                        }
                        else
                        {
                            MessageBox.Show("کاربری با این مشخصات یافت نشد.");
                            return;
                        }
                    }
                    else
                    {
                        PublicVariable.gSetUser = 2; ///users
                    }


                    this.Close();


                }


            }
            catch
            {
                MessageBox.Show("در ازتباط با سرور مشکلی بوجومد آمده است. لطفا مجددا تلاش کنید");
                return;

            }
        }
    }
}
