using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBController
{
    public partial class Form2 : Form
    {
        private Image imgMinimizeBtn; // Image 개체 생성
        private string strCurImgPath; // Image 설정
        private static System.Timers.Timer TimerEvent; // Timer 개체 생성
        public string Msg = "";

        public Form2()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20; // 스크린의 가로 위치
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height; // 스크린의 세로 위치
            DesktopLocation = new Point(x, y); // 폼의 위치 설정
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var fullScreen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.Location = new System.Drawing.Point((int)fullScreen.Width - 320, (int)fullScreen.Height - 80);
            this.linkLabelMessage.Text = Msg;
            TimerEvent = new System.Timers.Timer(2);
            TimerEvent.Elapsed += new System.Timers.ElapsedEventHandler(OnPopUp);
            TimerEvent.Start();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 종료
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            strCurImgPath = @"..\..\img\CloseDown.jpg";
            imgMinimizeBtn = Image.FromFile(strCurImgPath);
            this.picClose.Image = imgMinimizeBtn; // 마우스 누름 이미지 설정
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            strCurImgPath = @"..\..\img\CloseImg.jpg";
            imgMinimizeBtn = Image.FromFile(strCurImgPath);
            this.picClose.Image = imgMinimizeBtn; // 마우스 떠남 이미지 설정
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)
        {
            strCurImgPath = @"..\..\img\CloseDown.jpg";
            imgMinimizeBtn = Image.FromFile(strCurImgPath);
            this.picClose.Image = imgMinimizeBtn; // 마우스 오버 이미지 설정
        }

        private void linkLabelMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void OnPopUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Height < 120)
            {
                Height += 1;
                Application.DoEvents();
                Top -= 1;
                Application.DoEvents();
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new System.Timers.ElapsedEventHandler(OnPopUp);
                TimerEvent.Elapsed += new System.Timers.ElapsedEventHandler(OnPopOut);
                TimerEvent.Interval = 3000;
                TimerEvent.Start();
            }
        }

        private void OnPopOut(object sender, System.Timers.ElapsedEventArgs e)
        {
            while(Height>2)
            {
                Height -= 1;
                Application.DoEvents();
                Top += 1;
                Application.DoEvents();
            }
            this.Close();
        }
    }
}