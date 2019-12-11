using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTF8Base64
{
    class Conv
    {
        public string sTemp1 = null, sTemp2 = null;

        public string UTF8Encode(string sParam)
        {
            sTemp1 = sParam;
            sTemp2 = String.Empty;

            if(sParam==String.Empty||sParam==null)
            {
                sTemp2 = "입력된 문자가 없습니다.";
                return sTemp2;
            }

            UTF8Encoding _UTF8 = new UTF8Encoding();

            try
            {
                byte[] enbytes = _UTF8.GetBytes(sTemp1);
                foreach (byte bt in enbytes)
                    sTemp2 += String.Format("%{0:X2}", bt);
                sTemp2 = sTemp2.ToUpper();
            }
            catch(Exception ex)
            {
                sTemp2 = "오류 발생 : " + ex.Message.ToString();
            }
            return sTemp2;
        }

        public string UTF8Decode(string sParam)
        {
            sTemp1 = sParam;
            sTemp2 = String.Empty;
            int discarded;

            if(sParam==String.Empty||sTemp1==null)
            {
                sTemp2 = "입력된 문자가 없습니다.";
                return sTemp2;
            }

            try
            {
                byte[] debytes = GetBytes(sTemp1, out discarded);
                char[] chars = new char[debytes.Length];
                chars = Encoding.UTF8.GetChars(debytes);

                foreach (char c in chars)
                    sTemp2 += c;
            }
            catch(Exception ex)
            {
                sTemp2 = "오류 발생 : " + ex.Message.ToString();
            }

            return sTemp2;
        }

        public static byte[] GetBytes(string hexString,out int discarded)
        {
            discarded = 0;
            string newStr = "";
            char c;
            for(int i=0;i<hexString.Length;i++)
            {
                c = hexString[i];
                if (IsHexDigit(c))
                    newStr += c;
                else
                    discarded += 1;
            }
            if(newStr.Length%2!=0)
            {
                discarded += 1;
                newStr = newStr.Substring(0, newStr.Length - 1);
            }

            int byteLength = newStr.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for(int i=0;i<bytes.Length;i++)
            {
                hex = new string(new Char[] { newStr[j], newStr[j + 1] });
                bytes[i] = HexToByte(hex);
                j += 2;
            }
            return bytes;
        }

        public static bool IsHexDigit(Char c)
        {
            int numChar;
            int numA = Convert.ToInt32('A');
            int num1 = Convert.ToInt32('0');
            c = Char.ToUpper(c);
            numChar = Convert.ToInt32(c);
            if (numChar >= numA && numChar < (numA + 6))
                return true;
            if (numChar >= num1 && numChar < (num1 + 10))
                return true;
            return false;
        }

        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }

        public string Base64Encode(string sParam)
        {
            sTemp2 = String.Empty;
            if(sParam==String.Empty||sParam==null)
            {
                sTemp2 = "입력된 문자가 없습니다.";
                return sTemp2;
            }

            try
            {
                byte[] enbytes = Encoding.Default.GetBytes(sParam);
                sTemp2 = Convert.ToBase64String(enbytes);
            }
            catch(Exception ex)
            {
                sTemp2 = "오류 발생 : " + ex.Message.ToString();
            }

            return sTemp2;
        }

        public string Base64Decode(string sParam)
        {
            sTemp2 = String.Empty;
            if(sParam==String.Empty||sParam==null)
            {
                sTemp2 = "입력된 문자가 없습니다.";
                return sTemp2;
            }

            try
            {
                byte[] debytes = Convert.FromBase64String(sParam);
                sTemp2 = Encoding.Default.GetString(debytes);
            }
            catch(Exception ex)
            {
                sTemp2 = "오류 발생 : " + ex.Message.ToString();
            }

            return sTemp2;
        }
    }
}
