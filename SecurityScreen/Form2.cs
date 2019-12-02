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
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace SecurityScreen
{
    public partial class Form2 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(int hhk);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var f = new FileInfo(@"config.ini");
            if(f.Exists==true)
            {
                this.PasswdTextBox.Focus();
            }
            else
            {
                this.Hide();
                Form3 frm3 = new Form3();
                if(frm3.ShowDialog()==DialogResult.OK)
                {

                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var StrPwd = "";
            var sr = File.OpenText(@"config.ini");
            if(sr!=null)
            {
                StrPwd = sr.ReadLine();
            }
            sr.Close();

            if(StrPwd==this.PasswdTextBox.Text)
            {
                Cursor.Show();
                Form1 frm1 = new Form1();
                UnhookWindowsHookEx(frm1.frm2_hookID);
                EnableCtrlAltDel();
                Application.ExitThread(); // 폼 종료
            }
            else
            {
                this.ResultLabel.Text = "비밀번호 오류";
            }
        }

        public static void EnableCtrlAltDel()
        {
            try
            {
                string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
                RegistryKey rk = Registry.CurrentUser;
                RegistryKey sk1 = rk.OpenSubKey(subKey);

                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            this.PasswdTextBox.Focus();
            this.PasswdTextBox.Clear();
            DialogResult = DialogResult.OK;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult!=DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
