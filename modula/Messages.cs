using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BehComponents;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting
{
    public class Messages
    {


        public const string MSG_Error_100 = "لطفاً کلمه کاربری را وارد کنید";
        public const string MSG_Error_101 = "لطفاً کلمه رمز راوارد کنید";
        public const string MSG_Error_102 = "کلمه کاربری و یا کلمه رمز شمااشتباه می باشد";
        public const string MSG_Error_103 = "چنین کاربری در سیستم موجود نمی باشد";
        public const string MSG_Error_104 = "لطفاً متن مورد نظر را وارد کنید";
        public const string MSG_Error_105 = "اندازه عكس مورد نظر برابر 180*590 پيكسل نمي باشد";
        public const string MSG_Error_106 = "لطفاً عنوان  مورد نظر را وارد كنيد";
        public const string MSG_Error_107 = "لطفاً نوع فايل انتخابي را تعيين كنيد";
        public const string MSG_Error_108 = "اندازه عكس مورد نظر برابر 32*32 پيكسل نمي باشد ";
        public const string MSG_Error_109 = " مطلب مورد نظر شما با موفقيت اضافه شد";
        public const string MSG_Error_110 = "لطفاً مطلب مورد نظررا برای تغییر انتخاب کنید";
        public const string MSG_Error_111 = "آيا براي حذف مطلب مورد نظر اطمينان كافي داريد ؟";
        public const string MSG_Error_112 = "مطلب مورد نظر با موفقيت حدف گرديد";
        public const string MSG_Error_113 = "آيا براي بروزرساني مطلب مورد نظر اطمينان كافي داريد ؟";
        public const string MSG_Error_114 = "مطلب مورد نظر با موفقيت بروزرساني گرديد";
        public const string MSG_Error_115 = "شما حداقل بايد همراه عنوان يكي از موارد ديگر از جمله متن ، تصوير ويا فايل پيوست را نيز ارسال فرمائيد ";
        public const string MSG_Error_116 = "مورد انتخاب شده براي حذف در اطلاعات ديگري مورد استفاده قرار گرفته و توانائي حذف آن را نداريد";
        public const string MSG_Error_117 = "لطفاً نام فايل مورد نظر را وارد كنيد";
        public const string MSG_Error_118 = "آیا برای ارسال اطلاعات به وب سایت اطمینان کافی دارید ؟";
        public const string MSG_Error_119 = "تغییرات با موفقیت به وب سایت ارسال شد";
        public const string MSG_Error_120 = "لطفاً به اینترنت متصل شوید";
        public const string MSG_Error_121 = "اندازه پهناي عكس مورد نظر برابر 630 پيكسل نمي باشد";
        public const string MSG_Error_122 = "لطفاً براي بروزرساني مطلب مورد نظر به اینترنت متصل شوید";
        public const string MSG_Error_123 = "لطفاً نام شخص مورد نظر را وارد كنيد";
        public const string MSG_Error_124 = "لطفاً نام خانوادگي شخص مورد نظر را وارد كنيد";
        public const string MSG_Error_125 = "لطفاً مدرك تحصيلي شخص مورد نظر را وارد كنيد";
        public const string MSG_Error_126 = "اندازه عكس مورد نظر برابر 472*354 پيكسل نمي باشد";
        public const string MSG_Error_127 = "کلمه رمز جدید با تکرارش برابری نمی کند";
        public const string MSG_Error_128 = "لطفاً سمت شخص مورد نظر را وارد كنيد";
        public const string MSG_Error_129 = "لطفاً به اینترنت متصل شوید";
        public const string MSG_Error_130 = "لطفاً نام شركت مورد نظر را وارد كنيد";
        public const string MSG_Error_131 = "لطفاً نوع شركت مورد نظر را وارد كنيد";
        public const string MSG_Error_132 = "لطفاً طرح پيشنهادي شركت مورد نظر را وارد كنيد";
        public const string MSG_Error_133 = "لطفاً نوع طرح شركت مورد نظر را وارد كنيد";
        public const string MSG_Error_134 = "برای حذف آگهی مورد نظر اطمینان کافی دارید؟";
        public const string MSG_Error_135 = "آگهی مورد نظر با موفقیت حذف شد";
        public const string MSG_Error_136 = "برای بروزرسانی آگهی مورد نظر اطمینان کافی دارید؟";
        public const string MSG_Error_137 = "آگهی مورد نظر بروزرسانی شد";
        public const string MSG_Error_138 = "لطفاً عنوان تصویر را وارد کنید";
        public const string MSG_Error_139 = "لطفاً تاریخ صفحه اول را وارد کنید";
        public const string MSG_Error_214 = "عملیات پشتیبان گیری با مشکل مواجه گردید";
        public const string MSG_Error_333 = " لطفاً مسیر فایل پشتیبان گیری را انتخاب کنید";
        public void CopyError(int errorNo, string errorText)
        {
            try
            {
                if (!File.Exists("c:\\errorFile.DAT"))
                {
                    FileStream fs = new FileStream("c:\\errorFile.DAT", FileMode.CreateNew, FileAccess.Write, FileShare.Read);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(errorNo.ToString() + "       " + errorText + "\n");
                    sw.Flush();
                    sw.Close();

                }
                else
                {

                    FileStream fs = new FileStream("d:\\errorFile.DAT", FileMode.Append, FileAccess.Write, FileShare.Read);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(errorNo.ToString() + "       " + errorText + "\n");
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void CopyError2(string errorText)
        {
            try
            {
                if (!File.Exists("d:\\errorFile.DAT"))
                {
                    FileStream fs = new FileStream("d:\\errorFile.DAT", FileMode.CreateNew, FileAccess.Write, FileShare.Read);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(errorText + "\n");
                    sw.Flush();
                    sw.Close();
                }
                else
                {

                    FileStream fs = new FileStream("d:\\errorFile.DAT", FileMode.Append, FileAccess.Write, FileShare.Read);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(errorText + "\n");
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }

}

