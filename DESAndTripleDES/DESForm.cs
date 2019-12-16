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
    public partial class DESForm : Form
    {
        string DESKey = null;
        string DESIV = null;

        public DESForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // PrivateKey가 8자리만 입력을 받는 이유는 key의 크기가 64bit이기 때문이다.
            if(this.PrivateKeyTextBox.Text=="" || this.PrivateKeyTextBox.Text.Length<8)
            {
                MessageBox.Show("PrivateKey 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PrivateKeyTextBox.Focus();
                return;
            }

            if(this.OriginStringTextBox.Text=="")
            {
                MessageBox.Show("암호화할 문자열 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OriginStringTextBox.Focus();
                return;
            }

            PrivateKeyCreate(this.PrivateKeyTextBox.Text);

            DESCryptoServiceProvider desKey = new DESCryptoServiceProvider();
            desKey.Key = Encoding.Default.GetBytes(DESKey);
            desKey.IV = Encoding.Default.GetBytes(DESIV);

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, desKey.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter streamWriter = new StreamWriter(cryptoStream);

            streamWriter.Write(this.OriginStringTextBox.Text);
            streamWriter.Close();
            cryptoStream.Close();

            this.EncryptTextBox.Text = Convert.ToBase64String(memoryStream.ToArray());
            memoryStream.Close();
        }

        private void PrivateKeyCreate(string strKey)
        {
            DESKey = strKey;
            byte[] tmpKey = Encoding.ASCII.GetBytes(strKey);
            System.Array.Reverse(tmpKey);

            string tmpIV = Encoding.ASCII.GetString(tmpKey);
            DESIV = tmpIV;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if(this.PrivateKeyTextBox.Text==""||this.PrivateKeyTextBox.Text.Length<8)
            {
                MessageBox.Show("PrivateKey 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PrivateKeyTextBox.Focus();
                return;
            }

            if(this.EncryptTextBox.Text=="")
            {
                MessageBox.Show("복호화할 암호화 데이터 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.OriginStringTextBox.Focus();
                return;
            }

            PrivateKeyCreate(this.PrivateKeyTextBox.Text);
            DESCryptoServiceProvider desKey = new DESCryptoServiceProvider();
            desKey.Key = Encoding.Default.GetBytes(this.DESKey);
            desKey.IV = Encoding.Default.GetBytes(this.DESIV);

            byte[] buffer = Convert.FromBase64String(this.EncryptTextBox.Text);
            MemoryStream memoryStream = new MemoryStream(buffer);
            ICryptoTransform cryptoTransform = desKey.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(cryptoStream);

            this.DecryptTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
            cryptoStream.Close();
            memoryStream.Close();
        }
    }
}
