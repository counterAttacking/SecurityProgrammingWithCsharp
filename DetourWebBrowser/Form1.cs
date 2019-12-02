using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace DetourWebBrowser
{
    public partial class Form1 : Form
    {
        static public string NetIPPort;

        RegistryKey regisrty = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr IpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        bool settingsReturn, refreshReturn;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBoxUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13) // Enter key 누를 때
            {
                this.webBrowser1.Navigate(this.toolStripTextBoxUrl.Text);
            }
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(this.toolStripTextBoxUrl.Text);
        }

        private void toolStripComboBoxOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.toolStripComboBoxOn.Text=="ON")
            {
                regisrty.SetValue("ProxyServer", NetIPPort.Split(':')[0] + ":" + NetIPPort.Split(':')[1]);
                regisrty.SetValue("ProxyEnable", 1);
                settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            }
            else
            {
                regisrty.SetValue("ProxyServer", "");
                regisrty.SetValue("ProxyEnable", "");
                settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            }
        }

        private void toolStripButtonSetup_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripComboBoxOn.Text = "OFF";
        }


    }
}
