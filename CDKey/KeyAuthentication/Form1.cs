using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;

namespace KeyAuthentication
{
    public partial class Form1 : Form
    {
        private char[] KEYWord = new char[] {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
        'Q','R','S','T','U','V','W','X','Y','Z' };
        private string userMACAddr, correctCDKey;

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            ManagementObjectSearcher query = new ManagementObjectSearcher(objectQuery);
            foreach(ManagementObject managementObject in query.Get())
            {
                if(managementObject["MACAddress"]!=null)
                {
                    userMACAddr = managementObject["MACAddress"].ToString().Replace(":", "");
                }
            }
        }

        private void KeyTextBox01_TextChanged(object sender, EventArgs e)
        {
            if(this.KeyTextBox01.TextLength==5)
            {
                this.KeyTextBox02.Focus();
            }
        }

        private void KeyTextBox02_TextChanged(object sender, EventArgs e)
        {
            if (this.KeyTextBox02.TextLength == 5)
            {
                this.KeyTextBox03.Focus();
            }
        }

        private void KeyTextBox03_TextChanged(object sender, EventArgs e)
        {
            if (this.KeyTextBox03.TextLength == 5)
            {
                this.KeyTextBox04.Focus();
            }
        }

        private void KeyTextBox04_TextChanged(object sender, EventArgs e)
        {
            if (this.KeyTextBox04.TextLength == 5)
            {
                this.KeyTextBox05.Focus();
            }
        }

        private void KeyTextBox05_TextChanged(object sender, EventArgs e)
        {
            if (this.KeyTextBox05.TextLength == 5)
            {
                this.AuthButton.Focus();
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            this.ResultLabel.Text = "결과 :";
            if(this.UserNameTextBox.Text=="")
            {
                MessageBox.Show("사용자 이름을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UserNameTextBox.Focus();
                return;
            }
            if(this.KeyTextBox01.Text==""||this.KeyTextBox02.Text==""||this.KeyTextBox03.Text==""||this.KeyTextBox04.Text==""||this.KeyTextBox05.Text=="")
            {
                MessageBox.Show("CD Key를 입력을 해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CDKeyGen();
            string inputCDkey = this.KeyTextBox01.Text + "-" + this.KeyTextBox02.Text + "-" + this.KeyTextBox03.Text + "-" + this.KeyTextBox04.Text + "-" + this.KeyTextBox05.Text;
            if (correctCDKey == inputCDkey)
                this.ResultLabel.Text += " CD Key가 일치합니다.";
            else
                this.ResultLabel.Text += " CD Key가 일치하지 않습니다.";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CDKeyGen()
        {
            string dateYear = DateTime.Now.Year.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(KEYWord[Convert.ToInt32(dateYear) % 36]);
            stringBuilder.Append(KEYWord[Convert.ToInt32(dateYear.Substring(0, 1))]);
            stringBuilder.Append(KEYWord[Convert.ToInt32(dateYear.Substring(2, 1))]);
            stringBuilder.Append(KEYWord[Convert.ToInt32(dateYear.Substring(3, 1))]);
            stringBuilder.Append(userMACAddr);
            stringBuilder.Append(userMACAddr.Substring(0, 1));
            stringBuilder.Append(userMACAddr.Substring(1, 1));
            stringBuilder.Append(MD5Hash(this.UserNameTextBox.Text).Substring(0, 1));
            stringBuilder.Append(MD5Hash(this.UserNameTextBox.Text).Substring(29, 1));

            StringBuilder newStringBuilder = new StringBuilder();
            string cd = stringBuilder.ToString().ToUpper();
            char[] key = cd.ToCharArray();
            int[] num = new int[key.Length];

            int add = DateTime.Now.Year;
            int z;

            int con0 = 0, con1 = 0, con2 = 0, con3 = 0, con4 = 0;

            for(int i=0;i<key.Length;i++)
            {
                z = (i + 10) * add;
                num[i] = (int)key[i];
                newStringBuilder.Append(KEYWord[(z ^ num[i]) % 36]);

                if(((i+1)%5==0))
                {
                    newStringBuilder.Append("-");
                }

                switch(i%5)
                {
                    case 0:
                        con0 += ((z ^ num[i]) % 36);
                        break;
                    case 1:
                        con1 += ((z ^ num[i]) % 36);
                        break;
                    case 2:
                        con2 += ((z ^ num[i]) % 36);
                        break;
                    case 3:
                        con3 += ((z ^ num[i]) % 36);
                        break;
                    case 4:
                        con4 += ((z ^ num[i]) % 36);
                        break;
                }
            }
            newStringBuilder.Append(KEYWord[con0 % 36]);
            newStringBuilder.Append(KEYWord[con1 % 36]);
            newStringBuilder.Append(KEYWord[con2 % 36]);
            newStringBuilder.Append(KEYWord[con3 % 36]);
            newStringBuilder.Append(KEYWord[con4 % 36]);

            correctCDKey = newStringBuilder.ToString();
        }

        private string MD5Hash(string MdName)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            Byte[] hasehd = md5.ComputeHash(Encoding.Default.GetBytes(MdName));
            StringBuilder transName = new StringBuilder();
            for(var i=0;i<hasehd.Length;i++)
            {
                transName.AppendFormat("{0:x2}", hasehd[i]);
            }

            return transName.ToString();
        }
    }
}
