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
using System.Collections;
using System.Threading;

namespace HexaEditor
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        Thread HexAnalysis = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                this.HexaView.Text = "";
            }
            openFileDialog1.Dispose();
            int fileSize = getFileSize(fileName);
            if(fileSize>0)
            {
                HexAnalysis = new Thread(new ParameterizedThreadStart(hexEditor));
                HexAnalysis.Start(fileName + "?" + fileSize);
            }
            else
            {
                this.HexaView.AppendText("\n파일 선택이 잘못되었습니다.\n");
            }
        }

        private int getFileSize(string inFile)
        {
            long size = -1;
            try
            {
                FileInfo fileInfo = new FileInfo(inFile);
                size = fileInfo.Length;
                if (size > 2147483640)
                    return -1;
                else
                    return (int)size;
            }
            catch
            {
                return -1;
            }
        }

        private void hexEditor(object _inFileinSize)
        {
            var inFile = _inFileinSize.ToString().Split('?')[0];
            int inSize = Convert.ToInt32(_inFileinSize.ToString().Split('?')[1]);

            StringBuilder biglocal = new StringBuilder();
            StringBuilder sblocal = new StringBuilder();

            string message = "\n " + fileName + " " + (int)inSize + " bytes\n\n";
            this.HexaView.AppendText(message);
            statusBar.Text = " " + fileName + " " + (int)inSize + " bytes";
            this.HexaView.Update();

            FileStream fileStream;
            byte[] MyData;
            try
            {
                fileStream = new FileStream((string)inFile, FileMode.OpenOrCreate, FileAccess.Read);
                MyData = new byte[fileStream.Length];
            }
            catch
            {
                this.HexaView.AppendText("\n 파일 분석에 오류가 발생하였습니다.\\n\n");
                return;
            }

            statusBar.Text = "하드 디스크 파일 분석";
            fileStream.Read(MyData, 0, (int)fileStream.Length);
            fileStream.Close();

            int newrow = 0; // 라인
            int global = 0; // offset 넘버링
            string hex = " "; // hex 값
            string numb = " "; // offset 값

            this.progressBar1.Maximum = MyData.Length;
            this.progressBar1.Value = 0;

            statusBar.Text = "메모리 영역 분석";
            for(int i=0;i<MyData.Length;i++)
            {
                if (i % 1000 == 0)
                    this.progressBar1.Value = i;

                if(newrow==0)
                {
                    numb = padZeros(global);
                    biglocal.Append(" " + numb + " ");
                    global += 16;
                }

                hex = convertByteToHexString(MyData[i]);
                biglocal.Append(" " + hex); // 3 characters

                int g = MyData[i];
                if (g > 13 || (g > 0 && g < 9))
                    sblocal.Append((char)MyData[i]);
                else
                    sblocal.Append(".");

                newrow += 1;
                if(newrow>16)
                {
                    biglocal.Append("   " + sblocal.ToString() + "\n");
                    sblocal = new StringBuilder();
                    newrow = 0;
                }
            }

            if(newrow>0&&newrow<16)
            {
                for (int i = 0; i < (16 - newrow); i++)
                    biglocal.Append("   ");
                biglocal.Append("   " + sblocal);
            }
            biglocal.Append("\n\n");
            statusBar.Text = "Hex 값을 쓰기";
            this.HexaView.AppendText(biglocal.ToString());
            statusBar.Text = "작업 완료";
            this.progressBar1.Value = MyData.Length;
            HexAnalysis.Abort();
        }

        private string padZeros(int inInt)
        {
            StringBuilder sblocal = new StringBuilder();
            string hex = Convert.ToString(inInt, 16);
            if(hex.Length<8)
            {
                int ix = 8 - hex.Length;
                for (int i = 0; i < ix; i++)
                    sblocal.Append("0");
            }
            sblocal.Append(hex);
            return sblocal.ToString().ToUpper();
        }

        public string convertByteToHexString(byte inByte)
        {
            StringBuilder sblocal = new StringBuilder();
            string hex = Convert.ToString(inByte, 16);
            if (hex.Length == 1)
            {
                sblocal.Append("0");
                sblocal.Append(hex);
            }
            else
                sblocal.Append(hex);

            return sblocal.ToString().ToUpper();
        }
    }
}
