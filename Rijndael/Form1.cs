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

namespace Rijndael
{
    public partial class Form1 : Form
    {
        private string FilePath = null;
        byte[] PrivateKey = null; // 16,24,32 중
        byte[] PrivateIV = null; // 16

        public Form1()
        {
            InitializeComponent();
        }

        private void FileOpenBtn_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FilePath = this.openFileDialog1.FileName;
                StreamReader streamReader = new StreamReader(FilePath, System.Text.Encoding.Default);
                this.DiaryTextBox.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if(this.PrivateKeyTextBox.Text==""||this.PrivateKeyTextBox.Text.Length<8)
            {
                MessageBox.Show("PrivateKey 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PrivateKeyTextBox.Focus();
                return;
            }

            string keyStr = this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text;
            PrivateKey = Encoding.ASCII.GetBytes(keyStr);
            byte[] arrIV = Encoding.ASCII.GetBytes(this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text);
            System.Array.Reverse(arrIV);
            PrivateIV = arrIV;

            try
            {
                MemoryStream memoryStreamDecrypt = null;
                CryptoStream cryptoStreamDecrypt = null;
                StreamReader streamReaderDecrypt = null;
                RijndaelManaged rijndael = new RijndaelManaged();
                string plainText = null;

                rijndael.Key = PrivateKey;
                rijndael.IV = PrivateIV;

                ICryptoTransform decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);
                byte[] cipherText = Convert.FromBase64String(this.DiaryTextBox.Text);
                memoryStreamDecrypt = new MemoryStream(cipherText);
                cryptoStreamDecrypt = new CryptoStream(memoryStreamDecrypt, decryptor, CryptoStreamMode.Read);
                streamReaderDecrypt = new StreamReader(cryptoStreamDecrypt);

                plainText = streamReaderDecrypt.ReadToEnd();

                if (streamReaderDecrypt != null)
                    streamReaderDecrypt.Close();
                if (cryptoStreamDecrypt != null)
                    cryptoStreamDecrypt.Close();
                if (memoryStreamDecrypt != null)
                    memoryStreamDecrypt.Close();
                if (rijndael != null)
                    rijndael.Clear();

                this.DiaryTextBox.Text = plainText;
            }
            catch
            {
                MessageBox.Show("복호화 장애가 발생하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(this.PrivateKeyTextBox.Text==""|this.PrivateKeyTextBox.Text.Length<8)
            {
                MessageBox.Show("PrivateKey 입력이 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PrivateKeyTextBox.Focus();
                return;
            }

            if(this.saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string saveFilePath = this.saveFileDialog1.FileName;
                StreamWriter streamWriter = new StreamWriter(saveFilePath, false, Encoding.Default);
                streamWriter.Write(StringEncrypt());
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private string StringEncrypt()
        {
            string keyStr = this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text;
            PrivateKey = Encoding.ASCII.GetBytes(keyStr);
            byte[] arrIV = Encoding.ASCII.GetBytes(this.PrivateKeyTextBox.Text + this.PrivateKeyTextBox.Text);
            System.Array.Reverse(arrIV);
            PrivateIV = arrIV;

            MemoryStream memoryStreamEncrypt = null;
            CryptoStream cryptoStreamEncrypt = null;
            StreamWriter streamWriterEncrypt = null;
            RijndaelManaged rijndael = new RijndaelManaged();

            rijndael.Key = PrivateKey;
            rijndael.IV = PrivateIV;

            ICryptoTransform encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);

            memoryStreamEncrypt = new MemoryStream();
            cryptoStreamEncrypt = new CryptoStream(memoryStreamEncrypt, encryptor, CryptoStreamMode.Write);
            streamWriterEncrypt = new StreamWriter(cryptoStreamEncrypt);

            streamWriterEncrypt.Write(this.DiaryTextBox.Text);

            if (streamWriterEncrypt != null)
                streamWriterEncrypt.Close();
            if (cryptoStreamEncrypt != null)
                cryptoStreamEncrypt.Close();
            if (memoryStreamEncrypt != null)
                memoryStreamEncrypt.Close();
            if (rijndael != null)
                rijndael.Clear();

            return Convert.ToBase64String(memoryStreamEncrypt.ToArray());
        }
    }
}
