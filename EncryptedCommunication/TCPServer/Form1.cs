using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        private TcpListener Server;
        private TcpClient serClient;
        private NetworkStream myStream;
        private StreamWriter myWrite;
        private Boolean StartFlag = false;
        private Thread myServerThread;

        private TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        private byte[] PrivateKey = new byte[]
        {
            98,45,125,56,1,60,
            11,38,123,54,234,9,
            76,20,44,7,12,233,
            219,95,48,156,32,239
        };
        private byte[] PrivateIV = new byte[] { 67, 12, 3, 41, 66, 78, 34, 123 };
        Random randomNumber = new Random();
        private int rn = 0;
        private byte[] RPrivateKey = null;
        private byte[] RPrivateIV = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartFlag = true;
            var addr = new IPAddress(0);
            Server = new TcpListener(addr, 9000);
            Server.Start();

            myServerThread = new Thread(ServerStart);
            myServerThread.Start();
            this.timer1.Enabled = true;
            rn = randomNumber.Next(1, 9);
            RPrivate(rn);
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

        private void ServerStart()
        {
            MessageView("서버가 실행이 되었습니다.");
            while(StartFlag)
            {
                try
                {
                    serClient = Server.AcceptTcpClient();
                    MessageView("클라이언트가 접속하였습니다.");

                    myStream = serClient.GetStream();
                    myWrite = new StreamWriter(myStream);
                }
                catch
                {

                }
            }
        }

        private void MessageView(string str)
        {
            this.MessageTextBox.AppendText(str + "\r\n");
            this.MessageTextBox.Focus();
            this.MessageTextBox.ScrollToCaret();
        }

        private void SentBtn_Click(object sender, EventArgs e)
        {
            if(myStream!=null&&myWrite!=null)
            {
                myWrite.WriteLine(Encrypt("12345abcde"));
                myWrite.Flush();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Msg_send();
        }

        private void Msg_send()
        {
            try
            {
                var dt = Encrypt(Convert.ToString(DateTime.Now));
                myWrite.WriteLine(dt);
                myWrite.Flush();
            }
            catch
            {

            }
        }

        private string Encrypt(string str)
        {
            string encrypted = null;
            byte[] code = UTF8Encoding.UTF8.GetBytes(str);
            encrypted = Convert.ToBase64String(tripleDES.CreateEncryptor(RPrivateKey, RPrivateIV).TransformFinalBlock(code, 0, code.Length));
            code = UTF8Encoding.UTF8.GetBytes(rn.ToString() + encrypted);
            encrypted = Convert.ToBase64String(tripleDES.CreateEncryptor(PrivateKey, PrivateIV).TransformFinalBlock(code, 0, code.Length));

            return encrypted;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!(myWrite==null))
            {
                try
                {
                    myWrite.WriteLine(Encrypt("서버를 종료합니다."));
                    myWrite.Flush();
                }
                catch
                {

                }
            }

            this.StartFlag = false;
            this.timer1.Enabled = false;

            if (!(myWrite == null))
                myWrite.Close();
            if (!(myStream == null))
                myStream.Close();
            if (!(serClient == null))
                serClient.Close();
            if (!(Server == null))
                Server.Stop();
            if (!(myServerThread == null))
                myServerThread.Abort();

            Application.ExitThread();
        }
    }
}
