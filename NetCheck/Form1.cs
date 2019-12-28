using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NetCheck
{
    public partial class Form1 : Form
    {
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        string data = "abcdefghijklmnopqrstuvwxyzhello";
        const int timeOut = 120;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TimeComboBox.Text = "1초";
        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            if (this.AddrTextBox.Text.Length > 0)
            {
                this.AddrListBox.Items.Add(this.AddrTextBox.Text);
                this.AddrTextBox.Text = "";
            }
        }

        private void AddrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.AddrListBox.SelectedItems.Count > 0)
                this.CheckBtn.Enabled = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if(this.AddrListBox.SelectedItems.Count==0)
            {
                MessageBox.Show("체크할 IP를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(this.CheckBtn.Text=="확인")
            {
                this.timer1.Enabled = true;
                this.AddrListBox.Enabled = false;
                this.CheckBtn.Text = "중지";
            }
            else
            {
                this.timer1.Enabled = false;
                this.AddrListBox.Enabled = true;
                this.CheckBtn.Text = "확인";
            }
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.TimeComboBox.Text)
            {
                case "1초":
                    this.timer1.Interval = 1000;
                    break;
                case "2초":
                    this.timer1.Interval = 2000;
                    break;
                case "3초":
                    this.timer1.Interval = 3000;
                    break;
                case "4초":
                    this.timer1.Interval = 4000;
                    break;
                case "5초":
                    this.timer1.Interval = 5000;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PingCheck();
        }

        private void PingCheck()
        {
            try
            {
                Byte[] buffer = Encoding.ASCII.GetBytes(data);
                options.DontFragment = true;

                foreach(var args in this.AddrListBox.SelectedItems)
                {
                    PingReply reply = pingSender.Send(args.ToString(), timeOut, buffer, options);
                    string ResultStr = null;
                    if(reply.Status==IPStatus.Success)
                    {
                        ResultStr = args.ToString() + " 아이피 " + DateTime.Now + " Reply Form " + args.ToString() + " bytes = " + reply.Buffer.Length.ToString()
                            + " TTL = " + reply.Options.Ttl.ToString();
                        this.ResultListBox.Items.Add(ResultStr);
                    }
                    else
                    {
                        this.ResultListBox.Items.Add(args.ToString() + " 아이피 확인 실패");
                    }
                }
                this.ResultListBox.Items.Add("");
                if (this.ResultListBox.Items.Count + 5 > this.AddrListBox.Items.Count * 10)
                    this.ResultListBox.Items.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("네크워크 장애 : " + ex.ToString(), "에러 알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddrTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.InputBtn_Click(sender, e);
            }
        }
    }
}
