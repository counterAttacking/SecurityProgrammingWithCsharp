using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace PortScanner
{
    public partial class Form1 : Form
    {
        private IPAddress scanIP = null;
        private string filePath = null;
        Thread PortScanThread = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                filePath = this.folderBrowserDialog1.SelectedPath + "PortScan(" + this.IPTextBox.Text + ").txt";
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(filePath!=null)
            {
                this.ScanProgressBar.Minimum = Convert.ToInt32(this.StartTextBox.Text);
                this.ScanProgressBar.Maximum = Convert.ToInt32(this.EndTextBox.Text);
                this.StartBtn.Enabled = false;
                this.FileBtn.Enabled = false;
                PortScanThread = new Thread(PortScanner);
                PortScanThread.Start();
            }
        }

        private void PortScanner()
        {
            int i, startIdx, endIdx;
            this.FileLabel.Text = "Create File : " + filePath;

            StreamWriter streamWriter = new StreamWriter(filePath);
            scanIP = IPAddress.Parse(this.IPTextBox.Text);
            startIdx = Convert.ToInt32(this.StartTextBox.Text);
            endIdx = Convert.ToInt32(this.EndTextBox.Text);

            streamWriter.WriteLine("*************** Scan Start ***************   " + DateTime.Now);
            streamWriter.WriteLine();
            for(i=startIdx;i<=endIdx;i++)
            {
                this.ScanProgressBar.Value = i;
                try
                {
                    IPEndPoint endPoint = new IPEndPoint(scanIP, i);
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(endPoint);
                    streamWriter.WriteLine("Scan Port {0} Opened", i);
                    this.ScanListView.Items.Add(new ListViewItem(new string[] { i.ToString(), "Open" }));
                    continue;
                }
                catch(SocketException ex)
                {
                    if (ex.ErrorCode != 10061)
                        streamWriter.WriteLine("Error : {0}", ex.Message);
                }
                streamWriter.WriteLine("Scan Port {0} Closed", i);
                this.ScanListView.Items.Add(new ListViewItem(new string[] { i.ToString(), "Close" }));
            }

            streamWriter.WriteLine();
            streamWriter.WriteLine("*************** Scan Completed ***************   " + DateTime.Now);
            streamWriter.Close();

            this.StartBtn.Enabled = true;
            this.FileBtn.Enabled = true;
            MessageBox.Show("Port Scan is done.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process process = new Process();
            process.StartInfo.FileName = filePath;
            process.Start();
            PortScanThread.Abort();
        }
    }
}
