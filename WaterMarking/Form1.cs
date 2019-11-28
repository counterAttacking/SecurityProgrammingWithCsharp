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

namespace WaterMarking
{
    public partial class Form1 : Form
    {
        Bitmap ImageFile = null;
        Graphics gh = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            if (this.OpenFileDialog.ShowDialog() == DialogResult.OK)
                this.BackgroundTextBox.Text = this.OpenFileDialog.FileName;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if(txtCheck())
            {
                Mark.BackImgPath = this.BackgroundTextBox.Text;
                Mark.MarkImgText = this.MarkTextBox.Text;
                Mark.MarkOpacity = this.OpacityScrollBar.Value;
                this.PictureBox.Image = Mark.NewImage().Image;
            }
        }

        private bool txtCheck()
        {
            if(this.BackgroundTextBox.Text=="")
            {
                MessageBox.Show("배경 이미지 파일을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(this.MarkTextBox.Text=="")
            {
                MessageBox.Show("마킹 이미지 파일을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(this.PictureBox.Image!=null)
            {
                if(this.SaveImageDialog.ShowDialog()==DialogResult.OK)
                {
                    ImageFile = new Bitmap(Mark.ImageSize.Width, Mark.ImageSize.Height);
                    ImageFile = (Bitmap)this.PictureBox.Image;
                    this.ImageFile.Save(SaveImageDialog.FileName, ImageFormat.Jpeg);
                }
            }
        }
    }
}
