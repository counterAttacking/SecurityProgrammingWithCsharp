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
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;

namespace NetStat
{
    public partial class Form1 : Form
    {
        IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
        Thread NetThread = null;
        string localPort, remoteAddr, remotePort;
        bool checkFlag = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            NetThread = new Thread(NetView);
            NetThread.Start();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            this.localPort = this.LocalPortTextBox.Text;
            this.remoteAddr = this.ForeignAddrTextBox.Text;
            this.remotePort = this.ForeignPortTextBox.Text;
            NCheck();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.FileName);
                streamWriter.WriteLine("파일 생성 : " + DateTime.Now);
                streamWriter.WriteLine();
                streamWriter.WriteLine("로컬 주소\t\t로컬포트\t\t외부주소\t\t외부포트\t\t상태");
                for(int i=0;i<this.NetStateListView.Items.Count-1;i++)
                {
                    // IP 주소 길이에 따른 출력 길이 조절
                    if (this.NetStateListView.Items[i].SubItems[0].Text.Length < 10)
                        streamWriter.Write(this.NetStateListView.Items[i].SubItems[0].Text + "\t\t" + this.NetStateListView.Items[i].SubItems[1].Text + "\t\t");
                    else if (this.NetStateListView.Items[i].SubItems[0].Text.Length >= 10)
                        streamWriter.Write(this.NetStateListView.Items[i].SubItems[0].Text + "\t" + this.NetStateListView.Items[i].SubItems[1].Text + "\t\t");

                    if (this.NetStateListView.Items[i].SubItems[2].Text.Length < 10)
                        streamWriter.Write(this.NetStateListView.Items[i].SubItems[2].Text + "\t\t" + this.NetStateListView.Items[i].SubItems[3].Text + "\t\t" + this.NetStateListView.Items[i].SubItems[4].Text);
                    else if (this.NetStateListView.Items[i].SubItems[2].Text.Length >= 10)
                        streamWriter.Write(this.NetStateListView.Items[i].SubItems[2].Text + "\t" + this.NetStateListView.Items[i].SubItems[3].Text + "\t\t" + this.NetStateListView.Items[i].SubItems[4].Text);

                    streamWriter.WriteLine();
                }
                streamWriter.WriteLine();
                streamWriter.WriteLine("파일생성 종료 : " + DateTime.Now);
                streamWriter.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NetThread != null)
                NetThread.Abort();
            Application.ExitThread();
        }

        private void NetView()
        {
            while(true)
            {
                this.checkFlag = true;
                NCheck();
                this.NetStateListView.Items.Clear();
                TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();
                int i = 0;
                foreach(TcpConnectionInformation information in tcpConnections)
                {
                    this.NetStateListView.Items.Add(information.LocalEndPoint.Address.ToString());
                    this.NetStateListView.Items[i].SubItems.Add(information.LocalEndPoint.Port.ToString());
                    this.NetStateListView.Items[i].SubItems.Add(information.RemoteEndPoint.Address.ToString());
                    this.NetStateListView.Items[i].SubItems.Add(information.RemoteEndPoint.Port.ToString());
                    this.NetStateListView.Items[i].SubItems.Add(information.State.ToString());

                    if (information.LocalEndPoint.Port.ToString() == localPort)
                        this.NetStateListView.Items[i].SubItems[0].BackColor = Color.GreenYellow;
                    if (information.RemoteEndPoint.Address.ToString() == remoteAddr)
                        this.NetStateListView.Items[i].SubItems[0].BackColor = Color.LightPink;
                    if (information.RemoteEndPoint.Port.ToString() == remotePort)
                        this.NetStateListView.Items[i].SubItems[0].BackColor = Color.Aqua;
                    i += 1;
                }
                this.checkFlag = false;
                NCheck();
                Thread.Sleep(30000);
            }
        }

        private void NCheck()
        {
            if(checkFlag)
            {
                this.LocalPortTextBox.Enabled = false;
                this.ForeignAddrTextBox.Enabled = false;
                this.ForeignPortTextBox.Enabled = false;
                this.CheckBtn.Enabled = false;
                this.SaveBtn.Enabled = false;
            }
            else
            {
                this.LocalPortTextBox.Enabled = true;
                this.ForeignAddrTextBox.Enabled = true;
                this.ForeignPortTextBox.Enabled = true;
                this.CheckBtn.Enabled = true;
                this.SaveBtn.Enabled = true;
            }
        }
    }
}
