using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSAUser
{
    class EncryptionThread
    {
        private ContainerControl containerControl = null;
        private Delegate updateTextDelegate = null;

        public void Encrypt(object inputObject)
        {
            object[] inputObjects = (object[])inputObject;
            containerControl = (Form)inputObjects[0];
            updateTextDelegate = (Delegate)inputObjects[1];
            string encryptedStr = EncryptString((string)inputObjects[2], (int)inputObjects[3], (string)inputObjects[4]);
            containerControl.Invoke(updateTextDelegate, new object[] { encryptedStr });
        }

        public string EncryptString(string inputStr, int dwKeySize,string xmlStr)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlStr);
            int keySize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputStr);
            int maxLength = keySize - 42;
            int dataLength = bytes.Length;

            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0;i<=iterations;i++)
            {
                byte[] tmpBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tmpBytes, 0, tmpBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tmpBytes, true);
                Array.Reverse(encryptedBytes);
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }

            return stringBuilder.ToString();
        }
    }
}
