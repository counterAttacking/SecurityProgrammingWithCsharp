using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; // 레지스트리 설정 관련
using System.Threading; // thread 생성 및 사용 관련

namespace USBController
{
    public partial class Form1 : Form
    {
        enum Permission
        {
            Allow = 3,
            Deny = 4
        };

        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\services\USBSTOR", true);
        Thread USBDisable = null;

        private delegate void WarningDelegate(string strText); // delegate 개체 정의
        private WarningDelegate WarningMsg = null; // delegate 개체 선언

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (this.radioBtnEnable.Checked == true)
            {
                registryKey.SetValue("Start", (int)Permission.Allow);
                if (USBDisable != null)
                    USBDisable.Abort();
            }
            else if (this.radioBtnDisable.Checked == true)
            {
                registryKey.SetValue("Start", (int)Permission.Deny);
                WarningMsg = new WarningDelegate(WarningView);
                if (this.checkBoxReal.Checked == true)
                {
                    USBDisable = new Thread(USBReg);
                    USBDisable.Start();
                }
            }
        }

        private void USBReg()
        {
            while (true)
            {
                if ((int)registryKey.GetValue("Start") != (int)Permission.Deny)
                {
                    registryKey.SetValue("Start", (int)Permission.Deny);
                    Invoke(WarningMsg, "레지스트리 비정상 접근 차단");
                }
            }
        }

        private void WarningView(string strText)
        {
            Form2 form2 = new Form2();
            form2.Msg = strText;
            form2.ShowDialog();
        }

        private void radioBtnEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxReal.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (USBDisable != null)
                USBDisable.Abort();
            Application.ExitThread();
        }
    }
}