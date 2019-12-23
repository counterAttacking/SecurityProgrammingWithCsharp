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

namespace IPViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string hostname = null;
                IPAddress[] ipAddresses;

                hostname = Dns.GetHostName();
                ipAddresses = Dns.GetHostAddresses(hostname);
                foreach(IPAddress ip in ipAddresses)
                {
                    this.IPListBox.Items.Add("호스트 명 : " + hostname);
                    this.IPListBox.Items.Add("아이피 : " + ip.ToString());
                }
            }
            catch
            {
                MessageBox.Show("정보를 나타내는데 오류가 있습니다.", "오류 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.IPListBox.Items.Clear();
        }
    }
}
