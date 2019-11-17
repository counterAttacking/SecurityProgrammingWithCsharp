using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; // to control Image

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        Point orgLocalPoint;
        Size orgLocalSize;
        bool orgbool = true;
        bool capbool = false;
        Graphics ScreenG;
        Bitmap Captwin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='c')
            {
                orgbool = false;
                capbool = true;
                this.Opacity = 0.0;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                var fullScreen = Screen.PrimaryScreen.Bounds;
                Captwin = new Bitmap(fullScreen.Width, fullScreen.Height);
                ScreenG = Graphics.FromImage(Captwin);
                ScreenG.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), fullScreen.Size);
                this.pictureBoxScreen.Image = Captwin;
                this.Opacity = 100.0;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Location = orgLocalPoint;
                this.Size = orgLocalSize;
                orgbool = true;
            }
            else if(e.KeyChar=='e')
            {
                capbool = false;
                this.pictureBoxScreen.Image = null;
            }
            else if(e.KeyChar=='s')
            {
                if(capbool==true)
                {
                    using (var SFile = new SaveFileDialog())
                    {
                        SFile.OverwritePrompt = true;
                        SFile.FileName = "Capture";
                        SFile.Filter = "Image File(*.jpg)|*.jpg";
                        DialogResult dialogResult = SFile.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                            Captwin.Save(SFile.FileName, ImageFormat.Jpeg);
                    }
                }
                else
                {
                    MessageBox.Show("캡처한 화면이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if(orgbool==true)
            {
                orgLocalPoint = this.Location;
                orgLocalSize = this.Size;
            }
        }
    }
}
