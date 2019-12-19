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

namespace RSAUser
{
    public partial class Form1 : Form
    {
        string fileString = null;
        public delegate void UpdateTextDelegate(string inputText);
        public void UpdateText(string inputText)
        {
            this.EncryptTextBox.Text = inputText;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void publicKeyLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName, true);
                fileString = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if(fileString!=null)
            {
                UpdateTextDelegate updateTextDelegate = new UpdateTextDelegate(UpdateText);
                int bitNum = 1024;

                try
                {
                    EncryptionThread encryptionThread = new EncryptionThread();
                    Thread encryptThread = new Thread(encryptionThread.Encrypt);
                    encryptThread.IsBackground = true;
                    encryptThread.Start(new Object[] { this, updateTextDelegate, this.MessageTextBox.Text, bitNum, fileString });
                }
                catch(Exception ex)
                {
                    MessageBox.Show("에러 발생 : " + ex.Message);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, false);
                    if(this.EncryptTextBox.Text!=null)
                    {
                        streamWriter.Write(this.EncryptTextBox.Text);
                    }
                    streamWriter.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
