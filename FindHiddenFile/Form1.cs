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

namespace FindHiddenFile
{
    public partial class Form1 : Form
    {
        Thread threadFileView = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            if(this.folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                this.FileListView.Items.Clear();
                this.PathTextBox.Text = this.folderBrowserDialog1.SelectedPath;
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.folderBrowserDialog1.SelectedPath);
            }
        }

        private void FileView(object filepath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filepath.ToString());
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

            foreach(FileInfo file in fileInfos)
            {
                if(this.radioButtonAll.Checked==true)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        file.Name,file.Length.ToString(),file.CreationTime.ToString()
                    });
                    this.FileListView.Items.Add(item);
                }
                else
                {
                    if(file.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            file.Name,file.Length.ToString(),file.CreationTime.ToString()
                        });
                        this.FileListView.Items.Add(item);
                    }
                }
            }

            for (int i = 0; i < directoryInfos.Length; i++)
                FileView(directoryInfos[i].FullName);
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (threadFileView != null)
                threadFileView.Abort();
            if(this.PathTextBox.Text!="")
            {
                this.FileListView.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.folderBrowserDialog1.SelectedPath);
            }
        }

        private void radioButtonHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (threadFileView != null)
                threadFileView.Abort();
            if(this.PathTextBox.Text!="")
            {
                this.FileListView.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
