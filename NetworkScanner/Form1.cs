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
using System.Runtime.InteropServices;
using System.Threading;

namespace NetworkScanner
{
    public partial class Form1 : Form
    {
        Thread NetworkScan = null;
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        static extern int SendARP(int DestIP, int SrcIP, byte[] pMACAddr, ref uint PhyAddrLen);

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            NetworkScan = new Thread(NetworkCheck);
            NetworkScan.Start();
        }

        private void NetworkCheck()
        {
            try
            {
                this.ScanListView.Items.Clear();

                Application.DoEvents();

                IPAddress startIp = IPAddress.Parse(this.StartIPTextBox.Text);
                IPAddress endIp = IPAddress.Parse(this.EndIPTextBox.Text);
                IPAddress scanIP = null;
                string hostName = null;

                int[] startAddr = new int[4], endAddr = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    startAddr[i] = Convert.ToInt32(startIp.GetAddressBytes()[i]);
                    endAddr[i] = Convert.ToInt32(endIp.GetAddressBytes()[i]);
                }

                this.progressBar1.Minimum = Convert.ToInt32(startIp.GetAddressBytes()[3]);
                this.progressBar1.Maximum = Convert.ToInt32(endIp.GetAddressBytes()[3]);
                this.progressBar1.Value = Convert.ToInt32(startIp.GetAddressBytes()[3]);

                for(int a=startAddr[0];a<=endAddr[0];a++)
                {
                    for(int b=startAddr[1];b<=endAddr[1];b++)
                    {
                        for(int c=startAddr[2];c<=endAddr[2];c++)
                        {
                            for(int d=startAddr[3];d<=endAddr[3];d++)
                            {
                                this.progressBar1.Value = d;
                                scanIP = IPAddress.Parse(a.ToString() + "." + b.ToString() + "." + c.ToString() + "." + d.ToString());
                                Ping pingSender = new Ping();
                                PingOptions options = new PingOptions();
                                options.DontFragment = true;
                                string data = "abcdefghijklmnopqrstuvwxyzhello";
                                byte[] buffer = Encoding.ASCII.GetBytes(data);
                                int timeOut = 150;
                                PingReply reply = pingSender.Send(scanIP, timeOut, buffer, options);
                                hostName = null;
                                string MACAddr = null;
                                
                                if(reply.Status==IPStatus.Success)
                                {
                                    hostName = GetHostName(scanIP);
                                    MACAddr = GetMACUsingARP(scanIP.ToString());
                                    ListViewItem item = new ListViewItem();
                                    item.Text = scanIP.ToString();
                                    item.SubItems.Add(hostName);
                                    item.SubItems.Add(MACAddr);
                                    this.ScanListView.Items.Add(item);
                                }

                                if (d == this.progressBar1.Maximum)
                                    MessageBox.Show("네트워크 스캔을 완료하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NetworkScan.Abort();
            }
        }

        private string GetHostName(IPAddress address)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(address);
                return entry.HostName;
            }
            catch(Exception)
            {
                return address.ToString();
            }
        }

        private string GetMACUsingARP(string IPAddr)
        {
            IPAddress IP = IPAddress.Parse(IPAddr);
            byte[] macAddr = new byte[6];
            uint macAddrLen = (uint)macAddr.Length;
            if (SendARP((int)IP.Address, 0, macAddr, ref macAddrLen) != 0)
                return "ARP command failed";
            string[] str = new string[(int)macAddrLen];
            for (int i = 0; i < macAddrLen; i++)
                str[i] = macAddr[i].ToString("x2");
            return string.Join(":", str);
        }
    }
}
