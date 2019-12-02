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

namespace SecurityScreen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(this.PasswdTextBoxt.Text!=""&&this.RePasswdTextBox.Text!="")
            {
                if(this.PasswdTextBoxt.Text!=this.RePasswdTextBox.Text)
                {
                    this.ResultLabel.Text = "비밀번호가 다릅니다.";
                    return;
                }
                else
                {
                    var sw = File.CreateText(@"config.ini");
                    var PassStr = this.PasswdTextBoxt.Text;
                    sw.WriteLine(PassStr);
                    sw.Close();
                    DialogResult = MessageBox.Show("비밀번호가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            else
            {
                this.ResultLabel.Text = "비밀번호를 입력하세요.";
                return;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
