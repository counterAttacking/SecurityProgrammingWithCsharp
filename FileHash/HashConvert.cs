using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FileHash
{
    class HashConvert
    {
        public static string GetMD5Hash(string pathNaeme)
        {
            string resultStr = "";
            string hashDataStr = "";

            byte[] arrbyteHashValue;
            FileStream fileStream = null;

            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            try
            {
                fileStream = GetFileStream(pathNaeme);
                arrbyteHashValue = md5Hasher.ComputeHash(fileStream);
                fileStream.Close();

                hashDataStr = BitConverter.ToString(arrbyteHashValue);
                hashDataStr = hashDataStr.Replace("-", "");
                resultStr = hashDataStr;
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultStr;
        }

        private static FileStream GetFileStream(string pathName)
        {
            return (new FileStream(pathName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
        }

        public static string GetSHA1Hash(string pathName)
        {
            string resutlStr = "";
            string hashDataStr = "";

            byte[] arrbytHashValue;
            FileStream fileStream = null;

            SHA1CryptoServiceProvider sha1Hasher = new SHA1CryptoServiceProvider();

            try
            {
                fileStream = GetFileStream(pathName);
                arrbytHashValue = sha1Hasher.ComputeHash(fileStream);
                fileStream.Close();

                hashDataStr = BitConverter.ToString(arrbytHashValue);
                hashDataStr = hashDataStr.Replace("-", "");
                resutlStr = hashDataStr;
            }
            catch(Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resutlStr;
        }
    }
}
