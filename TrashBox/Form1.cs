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
using Shell32;
using System.Runtime.InteropServices;

namespace TrashBox
{
    public partial class Form1 : Form
    {
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION=0x00000001,
            SHERB_NOPROGRESSUI=0x00000002,
            SHERB_NOSOUND=0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_RecycleBinFile();
        }

        private void Load_RecycleBinFile()
        {
            this.FileListView.Items.Clear();
            Shell shell = new Shell();
            Folder Recycler = shell.NameSpace(10);
            for(int i=0;i<Recycler.Items().Count;i++)
            {
                FolderItem folderItem = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(folderItem, 0);

                if (Path.GetExtension(FileName) == "")
                    FileName += Path.GetExtension(folderItem.Path);
                string FilePath = Recycler.GetDetailsOf(folderItem, 1);
                string FileDelDate = Recycler.GetDetailsOf(folderItem, 2);
                var lvt = new ListViewItem(new string[] { FileName, FilePath, FileDelDate });
                this.FileListView.Items.Add(lvt);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Load_RecycleBinFile();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOCONFIRMATION);
                MessageBox.Show(this, "휴지통을 비웠습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "휴지통 비우는 작업이 실패하였습니다." + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            finally
            {
                Load_RecycleBinFile();
            }
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            if(this.FileListView.SelectedItems.Count!=0)
            {
                FileRestore(this.FileListView.SelectedItems[0].SubItems[1].Text + @"\" + this.FileListView.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                MessageBox.Show("복원할 파일을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool FileRestore(string Item)
        {
            Shell shell = new Shell();
            Folder Recycler = shell.NameSpace(10);
            for(int i=0;i<Recycler.Items().Count;i++)
            {
                FolderItem folderItem = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(folderItem, 0);
                if (Path.GetExtension(FileName) == "")
                    FileName += Path.GetExtension(folderItem.Path);
                string FilePath = Recycler.GetDetailsOf(folderItem, 1);

                if(Item==Path.Combine(FilePath,FileName))
                {
                    DoVerb(folderItem, "복원(&E)");
                    return true;
                }
            }
            return false;
        }

        private bool DoVerb(FolderItem Item,string Verb)
        {
            foreach(FolderItemVerb folderItemVerb in Item.Verbs())
            {
                if(folderItemVerb.Name.ToUpper().Contains(Verb.ToUpper()))
                {
                    folderItemVerb.DoIt();
                    Load_RecycleBinFile();
                    return true;
                }
            }
            return false;
        }
    }
}
