using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; // For using PictureBox

namespace WaterMarking
{
    class Mark
    {
        public static string BackImgPath = null;
        public static string MarkImgText = null;
        public static float MarkOpacity = 50;
        public static Image ImageSize = null;

        public static PictureBox NewImage()
        {
            Image orgImg = Image.FromFile(BackImgPath);
            ImageSize = orgImg;
            Bitmap tmpImg = new Bitmap(orgImg.Width, orgImg.Height);
            Bitmap markImg = new Bitmap(100, 100);

            markImg.SetResolution(100, 100);
            Graphics g = Graphics.FromImage(markImg);
            g.PageUnit = GraphicsUnit.Point;
            g.Clear(Color.Empty);
            Font font = new Font("MD아트체", 15, GraphicsUnit.Point);
            g.DrawString(MarkImgText, font, Brushes.YellowGreen, new RectangleF(0, 0, 100, 100), StringFormat.GenericDefault);

            float setOpacity = MarkOpacity / 100;
            Graphics newGrp = Graphics.FromImage(tmpImg);

            float[][] setColorMatrix =
            {
                new float[]{1,0,0,0,0 },
                new float[]{0,1,0,0,0 },
                new float[]{0,0,1,0,0 },
                new float[]{0,0,0,setOpacity,0 },
                new float[]{0,0,0,0,1 }
            };

            System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(setColorMatrix);
            System.Drawing.Imaging.ImageAttributes setImage = new System.Drawing.Imaging.ImageAttributes();
            setImage.SetColorMatrix(colorMatrix, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);

            newGrp.DrawImage(orgImg, 0, 0, orgImg.Width, orgImg.Height);

            float orw = (float)(orgImg.Width * 0.4);
            float orh = (float)(orgImg.Height * 0.4);
            float mix = (float)((orgImg.Width / 2) + (orw / 2));
            float miy = (float)((orgImg.Height / 2) + (orh / 2) + ((orh / 2) / 2));
            float msw = markImg.Width;
            float msh = markImg.Height;

            newGrp.DrawImage(markImg, new Rectangle((int)mix, (int)miy, (int)orw, (int)orh), 0.0F, 0.0F, msw, msh, GraphicsUnit.Pixel, setImage);

            PictureBox NewMarkImage = new PictureBox();
            NewMarkImage.Image = tmpImg;
            return NewMarkImage;
        }
    }
}
