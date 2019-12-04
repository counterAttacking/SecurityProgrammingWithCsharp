using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileWipe
{
    class FileDelete
    {
        FileInfo fileInfo = null;
        FileStream fileStream = null;
        byte[] byteArray = null;
        public delegate void ProcessEventHandler(int Current);
        public event ProcessEventHandler runPer;

        public FileDelete(string FilePath)
        {
            fileInfo = new FileInfo(FilePath);
        }

        public void British_HMG_IS5_BaseLine(string FilePath)
        {
            try
            {
                byteArray = new byte[fileInfo.Length];
                runPer(0);
                Application.DoEvents();
                for(int i=0;i<fileInfo.Length;i++)
                {
                    byteArray[i] = 0x0;
                    runPer((int)(((float)i / (float)(fileInfo.Length - 1.0)) * 100.0));
                }
                RunBuffer(FilePath, byteArray);
                fileInfo.Delete();
                Application.DoEvents();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void RunBuffer(string FilePath,byte[] Buffer)
        {
            fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Write, FileShare.None);
            fileStream.Write(Buffer, 0, Buffer.Length);
            fileStream.Flush();
            fileStream.Close();
        }

        public void British_HMG_IS5_Enhanced(string FilePath)
        {
            try
            {
                byteArray = new byte[fileInfo.Length];
                runPer(0);
                Application.DoEvents();

                int n = 0;
                for(int i=0;i<4;i++)
                {
                    switch(i)
                    {
                        case 1:
                            for(int j=0;j<fileInfo.Length;j++)
                            {
                                byteArray[j] = 0x0;
                                runPer((int)(((float)n / (float)((fileInfo.Length - 1.0) * 3.0)) * 100.0));
                                n++;
                            }
                            RunBuffer(FilePath, byteArray);
                            byteArray = new byte[fileInfo.Length];
                            break;
                        case 2:
                            for (int j = 0; j < fileInfo.Length; j++)
                            {
                                byteArray[j] = 0x0;
                                runPer((int)(((float)n / (float)((fileInfo.Length - 1.0) * 3.0)) * 100.0));
                                n++;
                            }
                            RunBuffer(FilePath, byteArray);
                            byteArray = new byte[fileInfo.Length];
                            break;
                        case 3:
                            switch(RandomBuffer(n))
                            {
                                case true:
                                    break;
                            }
                            RunBuffer(FilePath, byteArray);
                            byteArray = new byte[fileInfo.Length];
                            break;
                    }
                }
                fileInfo.Delete();
                Application.DoEvents();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private bool RandomBuffer(int n)
        {
            byteArray = new byte[fileInfo.Length];
            Application.DoEvents();
            for(int i=0;i<fileInfo.Length;i++)
            {
                byteArray[i] = RandomByte();
                runPer((int)(((float)n / (float)((fileInfo.Length - 1.0) * 3.0)) * 100.0));
                n++;
            }
            return true;
        }

        private byte RandomByte()
        {
            byte minVal = 0;
            byte maxVal = 255;
            Random random = new Random();
            byte resultRandom = (byte)(random.Next(minVal, maxVal));
            return resultRandom;
        }
    }
}
