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
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace ServerScreen
{
    public partial class Form1 : Form
    {
        Thread serverThread = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverThread = new Thread(FileReceiver);
            serverThread.Start();
        }

        private void FileReceiver()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point = new IPEndPoint(IPAddress.Loopback, 9000);
            socket.Bind(point);
            socket.Listen(1);
            socket = socket.Accept();

            byte[] buffer = new byte[4];
            socket.Receive(buffer);

            int fileLength = BitConverter.ToInt32(buffer, 0);
            buffer = new byte[1024];
            int totalLength = 0;

            FileStream fileStream = new FileStream("CaptureFile.png", FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(fileStream);

            this.StatusProgressBar.Minimum = 0;
            this.StatusProgressBar.Maximum = fileLength;
            while (totalLength < fileLength)
            {
                int receiveLength = socket.Receive(buffer);
                writer.Write(buffer, 0, receiveLength);
                totalLength += receiveLength;
                this.StatusProgressBar.Value = totalLength;
                this.StatusLabel.Text = "진행률 : " + ((int)(((float)totalLength / (float)fileLength) * 100.0)).ToString() + "%";
                Application.DoEvents();
            }

            fileStream.Close();
            socket.Close();
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "CaptureFile.png";
            process.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverThread != null)
                serverThread.Abort();
            Application.ExitThread();
        }
    }
}