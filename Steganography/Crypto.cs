using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Steganography
{
    class Crypto
    {
        private static byte[] _salt = Encoding.ASCII.GetBytes("123456789abcdefghijklmn");

        public static string EncryptStringAES(string HiddenText,string PrivateKey)
        {
            string outStr = null;
            RijndaelManaged rijndaelManaged = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(PrivateKey, _salt);

                rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Key = key.GetBytes(rijndaelManaged.KeySize / 8);

                ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(HiddenText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                if (rijndaelManaged != null)
                    rijndaelManaged.Clear();
            }

            return outStr;
        }

        public static string DecryptStringAES(string ExtractedText,string PrivateKey)
        {
            RijndaelManaged rijndaelManaged = null;
            string plainText = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(PrivateKey, _salt);
                byte[] bytes = Convert.FromBase64String(ExtractedText);

                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    rijndaelManaged = new RijndaelManaged();
                    rijndaelManaged.Key = key.GetBytes(rijndaelManaged.KeySize / 8);
                    rijndaelManaged.IV = ReadByteArray(msDecrypt);
                    ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            finally
            {
                if (rijndaelManaged != null)
                    rijndaelManaged.Clear();
            }

            return plainText;
        }

        private static byte[] ReadByteArray(Stream streamStr)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (streamStr.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
                throw new SystemException();

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (streamStr.Read(buffer, 0, buffer.Length) != buffer.Length)
                throw new SystemException();

            return buffer;
        }
    }
}
