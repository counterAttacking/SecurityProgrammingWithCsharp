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
using System.Threading;

namespace FileHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.PathTextBox.Text = this.openFileDialog1.FileName;

                try
                {
                    this.MD5TextBox.Text = HashConvert.GetMD5Hash(this.openFileDialog1.FileName);
                }
                catch
                {
                    return;
                }

                try
                {
                    this.SHATextBox.Text = HashConvert.GetSHA1Hash(this.openFileDialog1.FileName);
                }
                catch
                {
                    return;
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.PathTextBox.Text = "";
            this.MD5TextBox.Text = "";
            this.SHATextBox.Text = "";
        }
    }
}
