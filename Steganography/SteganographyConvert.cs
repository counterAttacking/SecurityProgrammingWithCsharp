using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Steganography
{
    class SteganographyConvert
    {
        public delegate void ProcessEventHandler(int Current);
        public event ProcessEventHandler runNum;

        public Bitmap embedText(string HiddenText,Bitmap ImgBmp)
        {
            int charIdx = 0, charVal = 0;
            long colorUnitIdx = 0;
            int R = 0, G = 0, B = 0;
            int RunStatus = 0;

            Application.DoEvents();
            for(int i=0;i<ImgBmp.Height;i++)
            {
                for(int j=0;j<ImgBmp.Width;j++)
                {
                    Color pixel = ImgBmp.GetPixel(j, i);
                    pixel = Color.FromArgb(pixel.R - pixel.R % 2, pixel.G - pixel.G % 2, pixel.B - pixel.B % 2);

                    R = pixel.R;
                    G = pixel.G;
                    B = pixel.B;

                    for(int n=0;n<3;n++)
                    {
                        if(colorUnitIdx%8==0)
                        {
                            if(charIdx<HiddenText.Length)
                            {
                                charVal = HiddenText[charIdx++];
                                runNum(++RunStatus);
                            }
                        }

                        switch(colorUnitIdx%3)
                        {
                            case 0:
                                R += charVal % 2;
                                charVal /= 2;
                                break;
                            case 1:
                                G += charVal % 2;
                                charVal /= 2;
                                break;
                            case 2:
                                B += charVal % 2;
                                charVal /= 2;
                                break;
                        }

                        ImgBmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                        colorUnitIdx++;
                    }
                }
            }
            Application.DoEvents();
            return ImgBmp;
        }

        public string ExtractText(Bitmap ImgBmp)
        {
            int colorUnitIdx = 0, charVal = 0;
            string ExtractedText = String.Empty;
            int RunStatus = 0;

            Application.DoEvents();
            for(int i=0;i<ImgBmp.Height;i++)
            {
                for(int j=0;j<ImgBmp.Width;j++)
                {
                    Color pixel = ImgBmp.GetPixel(j, i);

                    for(int n=0;n<3;n++)
                    {
                        switch(colorUnitIdx%3)
                        {
                            case 0:
                                charVal = charVal * 2 + pixel.R % 2;
                                break;
                            case 1:
                                charVal = charVal * 2 + pixel.G % 2;
                                break;
                            case 2:
                                charVal = charVal * 2 + pixel.B % 2;
                                break;
                        }
                        colorUnitIdx++;
                        if(colorUnitIdx%8==0)
                        {
                            charVal = ReverseBits(charVal);
                            if (charVal == 0)
                                return ExtractedText;

                            runNum(++RunStatus);
                            char c = (char)charVal;
                            ExtractedText += c.ToString();
                        }
                    }
                }
            }
            Application.DoEvents();
            return ExtractedText;
        }

        public static int ReverseBits(int n)
        {
            int result = 0;

            for(int i=0;i<8;i++)
            {
                result = result * 2 + n % 2;
                n /= 2;
            }

            return result;
        }
    }
}
