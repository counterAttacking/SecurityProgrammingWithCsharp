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

namespace DNSLookUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string HostName = null;
            if(this.HostTextBox.Text.Contains("://")==true)
            {
                HostName = this.HostTextBox.Text.Replace("http://", "");
            }
            else
            {
                HostName = this.HostTextBox.Text;
                try
                {
                    IPHostEntry ipHostEntry = Dns.GetHostEntry(HostName);
                    IPAddress[] addrs = ipHostEntry.AddressList;

                    if (AddrListBox.Items.Count > 0)
                        AddrListBox.Items.Clear();

                    foreach (IPAddress addr in addrs)
                        AddrListBox.Items.Add(addr);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HostTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 텍스트 박스에서 엔터키를 누르면 nslookup 시작
                this.SearchBtn_Click(sender, e);
            if (e.KeyCode == Keys.Escape) // 텍스트 박스에서 ESC키를 누르면 텍스트 박스 초기화
                this.HostTextBox.Text = "";
        }
    }
}
