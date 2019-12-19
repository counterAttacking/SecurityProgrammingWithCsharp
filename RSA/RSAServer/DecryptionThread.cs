using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSAServer
{
    class DecryptionThread
    {
        private ContainerControl containerControl = null;
        private Delegate updateTextDelegate = null;

        public void Decrypt(object inputObject)
        {
            object[] inputObjects = (object[])inputObject;
            containerControl = (Form)inputObjects[0];
            updateTextDelegate = (Delegate)inputObjects[1];
            string decryptedStr = DecryptString((string)inputObjects[2], (int)inputObjects[3], (string)inputObjects[4]);
            containerControl.Invoke(updateTextDelegate, new object[] { decryptedStr });
        }

        public string DecryptString(string inputStr,int dwKeySize,string xmlStr)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlStr);
            int base64BlockSize = 172;
            int iterations = inputStr.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for(int i=0;i<iterations;i++)
            {
                byte[] decryptedBytes = Convert.FromBase64String(inputStr.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(decryptedBytes);

                rsaCryptoServiceProvider.Decrypt(decryptedBytes, true);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(decryptedBytes, true));
            }

            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }
    }
}
