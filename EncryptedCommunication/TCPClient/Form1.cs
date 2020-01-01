using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream myStream;
        private StreamReader myReader;
        private Thread myReaderThread;

        private TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        private byte[] PrivateKey = new byte[]
        {
            98,45,125,56,1,60,
            11,38,123,54,234,9,
            76,20,44,7,12,233,
            219,95,48,156,32,239
        };
        private byte[] PrivateIV = new byte[] { 67, 12, 3, 41, 66, 78, 34, 123 };
        private byte[] RPrivateKey = null;
        private byte[] RPrivateIV = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("192.168.7.25", 9000);
                MessageView("서버에 접속했습니다.");
                myStream = client.GetStream();

                myReader = new StreamReader(myStream);
                myReaderThread = new Thread(Receive);
                myReaderThread.Start();
            }
            catch
            {
                MessageView("서버에 접속하지 못했습니다.");
            }
        }

        private void Receive()
        {
            try
            {
                while(true)
                {
                    if(myStream.CanRead)
                    {
                        var msg = myReader.ReadLine();
                        if(msg.Length>0)
                        {
                            msg = Decrypt(msg);
                            MessageView(msg);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private string Decrypt(string str)
        {
            string decrypted = null;
            byte[] code = Convert.FromBase64String(str);
            decrypted = UTF8Encoding.UTF8.GetString(tripleDES.CreateDecryptor(PrivateKey, PrivateIV).TransformFinalBlock(code, 0, code.Length));
            RPrivate(Convert.ToInt32(decrypted.Substring(0, 1)));
            code = Convert.FromBase64String(decrypted.Substring(1, decrypted.Length - 1));
            decrypted = UTF8Encoding.UTF8.GetString(tripleDES.CreateDecryptor(RPrivateKey, RPrivateIV).TransformFinalBlock(code, 0, code.Length));

            return decrypted;
        }

        private void RPrivate(int rn)
        {
            RPrivateKey = new byte[PrivateKey.Length];
            RPrivateIV = new byte[PrivateIV.Length];
            for (int k = 0; k < PrivateKey.Length; k++)
            {
                int tmpN = (int)PrivateKey[k];
                RPrivateKey[k] = Convert.ToByte(tmpN / rn);
            }

            for (int i = 0; i < PrivateIV.Length; i++)
            {
                int tmpN = (int)PrivateIV[i];
                RPrivateIV[i] = Convert.ToByte(tmpN / rn);
            }
        }

        private void MessageView(string str)
        {
            this.MessageTextBox.AppendText(str + "\r\n");
            this.MessageTextBox.Focus();
            this.MessageTextBox.ScrollToCaret();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!(myReader == null))
                    myReader.Close();
                if (!(myStream == null))
                    myStream.Close();
                if (!(client == null))
                    client.Close();
                if (!(myReaderThread == null))
                    myReaderThread.Abort();
            }
            catch
            {
                return;
            }

            Application.ExitThread();
        }
    }
}
