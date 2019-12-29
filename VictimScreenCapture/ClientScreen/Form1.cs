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
using System.Drawing.Imaging;

namespace ClientScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(ScreenCapture()!=true)
            {
                return;
            }
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            mySocket.Connect("127.0.0.1", 9000);
            FileStream fileStream = new FileStream("CaptureFile.png", FileMode.Open, FileAccess.Read);
            int fileLength = (int)fileStream.Length;
            byte[] buffer = BitConverter.GetBytes(fileLength);
            mySocket.Send(buffer);
            int cnt = fileLength / 1024 + 1;
            BinaryReader reader = new BinaryReader(fileStream);
            for(int i=0;i<cnt;i++)
            {
                buffer = reader.ReadBytes(1024);
                mySocket.Send(buffer);
            }
            reader.Close();
            mySocket.Close();
        }

        private bool ScreenCapture()
        {
            Graphics ScreenG;
            Bitmap CaptWin;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            CaptWin = new Bitmap(this.Width, this.Height);
            ScreenG = Graphics.FromImage(CaptWin);
            ScreenG.CopyFromScreen(this.Location, new Point(0, 0), this.Size);

            saveFileDialog.FileName = "CaptureFile.png";
            CaptWin.Save(saveFileDialog.FileName, ImageFormat.Png);

            FileInfo info = new FileInfo("CaptureFile.png");
            if (info.Exists)
                return true;
            else
                return false;
        }
    }
}
