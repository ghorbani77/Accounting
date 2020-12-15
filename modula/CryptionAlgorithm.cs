using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Modula
{
    public static class CryptionAlgorithm
    {

        public static string EncryptTextUsingUTF8(string strText)
        {
            return EncryptUsingUTF8(strText, "&%#@?,:*");
        }
        public static string DecryptTextUsingUTF8(string strText)
        {
            return DecryptUsingUTF8(strText, "&%#@?,:*");
        }


        private static string DecryptUsingUTF8(string strText, string sDecrKey)
        {
            byte[] byKey = {

            };
            byte[] IV = {
                0x12,
                0x34,
                0x56,
                0x78,
                0x90,
                0xab,
                0xcd,
                0xef
            };
            byte[] inputByteArray = new byte[strText.Length + 1];

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey.ToString().Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;

                return encoding.GetString(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static string EncryptUsingUTF8(string strText, string strEncrKey)
        {
            byte[] byKey = {

            };
            byte[] IV = {
                0x12,
                0x34,
                0x56,
                0x78,
                0x90,
                0xab,
                0xcd,
                0xef
            };

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }



    }
}
