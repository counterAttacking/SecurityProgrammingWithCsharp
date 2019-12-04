using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWipe
{
    public partial class Form1 : Form
    {
        FileDelete fd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.PathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void WipeButton_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.Text=="")
            {
                MessageBox.Show("Wipe 방법을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.Focus();
                return;
            }
            else if(this.PathTextBox.Text=="")
            {
                MessageBox.Show("삭제할 파일을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.PathButton.Focus();
                return;
            }

            switch(this.comboBox1.Text)
            {
                case "British HMG IS5 (Base Line)":
                    fd = new FileDelete(this.PathTextBox.Text);
                    fd.runPer += new FileDelete.ProcessEventHandler(WipeStatus);
                    fd.British_HMG_IS5_BaseLine(this.PathTextBox.Text);
                    break;
                case "British HMG IS5 (Enhanced)":
                    fd = new FileDelete(this.PathTextBox.Text);
                    fd.runPer += new FileDelete.ProcessEventHandler(WipeStatus);
                    fd.British_HMG_IS5_Enhanced(this.PathTextBox.Text);
                    break;
            }
        }

        private void WipeStatus(int Current)
        {
            switch(Current)
            {
                case 0:
                    this.PerLabel.Text = "진행률 : " + Current + "%;";
                    break;
                default:
                    this.PerLabel.Text = "진행률 : " + Current + "%";
                    if (Current == 100)
                        this.PathTextBox.Text = "";
                    break;
            }
            Application.DoEvents();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBox1.Text)
            {
                case "British HMG IS5 (Base Line)":
                    this.TotalLabel.Text = "Level : 1";
                    break;
                case "British HMG IS5 (Enhanced)":
                    this.TotalLabel.Text = "Level : 3";
                    break;
            }
        }
    }
}
