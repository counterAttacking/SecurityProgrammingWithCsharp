using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DetourWebBrowser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            while(true)
            {
                if (this.Opacity != 1)
                    this.Opacity += 0.01;
                else
                    break;
                Thread.Sleep(3);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Add(this.textBoxIp.Text + ":" + this.textBoxPort.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(this.checkedListBox1.SelectedItems.Count!=0)
            {
                Form1.NetIPPort = this.checkedListBox1.SelectedItems[0].ToString();
                this.Dispose(true);
            }
            else
            {
                MessageBox.Show("프록시 서버를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
