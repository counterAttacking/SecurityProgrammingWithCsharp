using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace DESAndTripleDES
{
    public partial class TDESForm : Form
    {
        private TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        private byte[] PrivateKey = new byte[] { 98, 45, 125, 56, 1, 60, 11, 38, 123, 54, 234, 9, 76, 20, 44, 7, 12, 223, 219, 95, 48, 156, 32, 239 };
        private byte[] PrivateIV = new byte[] { 97, 12, 3, 41, 66, 78, 34, 123 };

        public TDESForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if(this.OriginStringTextBox.Text=="")
            {
                MessageBox.Show("암호화할 문자열 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OriginStringTextBox.Focus();
                return;
            }
            else
            {
                this.EncryptTextBox.Text = Encrypt(this.OriginStringTextBox.Text);
            }
        }

        private string Encrypt(string inputStr)
        {
            string encryptedStr = null;
            byte[] code = UTF8Encoding.UTF8.GetBytes(inputStr);
            encryptedStr = Convert.ToBase64String(tripleDES.CreateEncryptor(PrivateKey, PrivateIV).TransformFinalBlock(code, 0, code.Length));
            return encryptedStr;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if(this.EncryptTextBox.Text=="")
            {
                MessageBox.Show("복호화할 암호화 데이터 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OriginStringTextBox.Focus();
                return;
            }
            else
            {
                this.DecryptTextBox.Text = Decrypt(this.EncryptTextBox.Text);
            }
        }

        private string Decrypt(string inputStr)
        {
            string decryptedStr = null;
            byte[] code = Convert.FromBase64String(inputStr);
            decryptedStr = UTF8Encoding.UTF8.GetString(tripleDES.CreateDecryptor(PrivateKey, PrivateIV).TransformFinalBlock(code, 0, code.Length));
            return decryptedStr;
        }
    }
}
