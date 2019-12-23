using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Steganography
{
    public partial class Form1 : Form
    {
        Bitmap ImgBitmap = null;
        SteganographyConvert steganographyConvert = new SteganographyConvert();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.ImageViewPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
                this.EncryptBtn.Enabled = true;
                this.DecryptBtn.Enabled = true;
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            this.ResultLabel.Text = "Result : ";
            this.ResultLabel.Text += "0개의 픽셀이 변경되었습니다.";
            if(this.ImageViewPictureBox.Image==null)
            {
                MessageBox.Show("이미지를 선택해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImgBitmap = (Bitmap)this.ImageViewPictureBox.Image;
            string HiddenText = this.DataTextBox.Text;
            if(HiddenText.Equals(""))
            {
                MessageBox.Show("이미지에 숨길 문자열을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.KeyTextBox.Text.Length<8)
            {
                MessageBox.Show("비밀키는 8자리 이상 문자를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                HiddenText = Crypto.EncryptStringAES(HiddenText, this.KeyTextBox.Text);
            }

            steganographyConvert.runNum += new SteganographyConvert.ProcessEventHandler(StegaStatus);
            ImgBitmap = steganographyConvert.embedText(HiddenText, ImgBitmap);
            if(this.saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                switch(this.saveFileDialog1.FilterIndex)
                {
                    case 0:
                        ImgBitmap.Save(this.saveFileDialog1.FileName, ImageFormat.Png);
                        break;
                    case 1:
                        ImgBitmap.Save(this.saveFileDialog1.FileName, ImageFormat.Bmp);
                        break;
                }
            }
            ControlClearAll();
        }

        private void ControlClearAll()
        {
            this.ImageViewPictureBox.Image = null;
            this.DataTextBox.Clear();
            this.KeyTextBox.Clear();
            this.EncryptBtn.Enabled = false;
            this.DecryptBtn.Enabled = false;
            this.ResultLabel.Text = "Result : ";
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            this.ResultLabel.Text = "Result : ";
            this.ResultLabel.Text += "0개의 픽셀이 변경되었습니다.";
            ImgBitmap = (Bitmap)this.ImageViewPictureBox.Image;

            steganographyConvert.runNum += new SteganographyConvert.ProcessEventHandler(StegaStatus);
            string ExtractedText = steganographyConvert.ExtractText(ImgBitmap);

            try
            {
                ExtractedText = Crypto.DecryptStringAES(ExtractedText, this.KeyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("비밀키가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.KeyTextBox.Focus();
                return;
            }

            this.DataTextBox.Text = ExtractedText;
        }

        private void StegaStatus(int Current)
        {
            this.ResultLabel.Text = "Result : ";
            this.ResultLabel.Text += Current.ToString() + "개의 픽셀이 변경되었습니다.";
            Application.DoEvents();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
