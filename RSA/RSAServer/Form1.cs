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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading;
using System.Xml.Serialization;

namespace RSAServer
{
    public partial class Form1 : Form
    {
        public delegate void UpdateTextDelegate(string inputText);
        RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(1024);

        private void UpdateText(string inputText)
        {
            this.DecryptTextBox.Text = inputText;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void publicKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Public Key Document(*.pke)|*.pke";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string PrivateKeys = rsaCryptoServiceProvider.ToXmlString(false);
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, false);
                    if (PrivateKeys != null)
                        streamWriter.Write(PrivateKeys);
                    streamWriter.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void privateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Private Keys Document(*.kez)|*.kez";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string PrivateKeys = rsaCryptoServiceProvider.ToXmlString(true);
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, false);
                    if (PrivateKeys != null)
                        streamWriter.Write(PrivateKeys);
                    streamWriter.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PublicKeySaveBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Public Key Document(*.pke)|*.pke";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                saveFileDialog1.Filter = "Public Key Document(*.pke)|*.pke";
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(this.openFileDialog1.FileName);
                    fileInfo.CopyTo(this.saveFileDialog1.FileName);
                }
            }
        }

        private void OpenEncryptedFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File(*.txt)|*.txt";
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName);
                    this.MessageTextBox.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            string fileString = null;
            openFileDialog1.Filter = "Private Keys Document(*.kez)|*.kez";
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName, true);
                fileString = streamReader.ReadToEnd();
                streamReader.Close();
            }

            if(fileString!=null)
            {
                UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateText);
                int bitNum = 1024;

                try
                {
                    DecryptionThread decryptionThread = new DecryptionThread();
                    Thread decryptThread = new Thread(decryptionThread.Decrypt);
                    decryptThread.IsBackground = true;
                    decryptThread.Start(new object[] { this, updateTextDelegate, this.MessageTextBox.Text, bitNum, fileString });
                }
                catch(Exception ex)
                {
                    MessageBox.Show("에러발생 : " + ex.Message);
                }
            }
        }
    }
}
