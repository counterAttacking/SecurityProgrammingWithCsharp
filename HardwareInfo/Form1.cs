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
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace HardwareInfo
{
    public partial class Form1 : Form
    {
        Thread ExcelSave = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string property in XmlSetup.GetWMIs("WMI"))
            {
                try
                {
                    this.WmiNameComboBox.Items.Add(property);
                }
                catch(SystemException)
                {
                    // ingore error
                }
            }
        }

        private void WmiNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.WmiNameComboBox.SelectedItem.ToString()!="")
            {
                this.WmiViewListView.Items.Clear();
                var _query = new SelectQuery(this.WmiNameComboBox.SelectedItem.ToString());
                var _search = new ManagementObjectSearcher(_query);

                foreach(ManagementObject _info in _search.Get())
                {
                    this.WmiViewListView.Groups.Add(_info.ToString(), _info.Properties["Name"].Value.ToString());

                    foreach(PropertyData tmpOB in _info.Properties)
                    {
                        string _val = null;
                        if (tmpOB.Value != null)
                            _val = tmpOB.Value.ToString();
                        string[] strArray = { tmpOB.Name, _val };
                        ListViewItem listViewItem = new ListViewItem(strArray);
                        listViewItem.Group = (ListViewGroup)WmiViewListView.Groups[_info.ToString()];
                        WmiViewListView.Items.Add(listViewItem);
                    }
                }
                this.ExcelBtn.Enabled = true;
            }
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            if(this.WmiNameComboBox.Text=="")
                return;
            else
            {
                if(this.saveFileDialogExcel.ShowDialog()==DialogResult.OK)
                {
                    ExcelSave = new Thread(ExcelWrite);
                    ExcelSave.Start();
                }
            }
        }

        private void ExcelWrite()
        {
            try
            {
                object missingType = Type.Missing;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelBook = excelApp.Workbooks.Add(missingType);
                Microsoft.Office.Interop.Excel.Worksheet excelworksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets.Add(missingType, missingType, missingType, missingType);
                excelworksheet.Name = this.WmiNameComboBox.SelectedItem.ToString();

                excelworksheet.Cells[1, 1] = this.WmiViewListView.Columns[0].Text;
                excelworksheet.Cells[1, 2] = this.WmiViewListView.Columns[1].Text;

                var _query = new SelectQuery(this.WmiNameComboBox.SelectedItem.ToString());
                var _search = new ManagementObjectSearcher(_query);

                int i = 2;
                foreach(ManagementObject _info in _search.Get())
                {
                    excelworksheet.get_Range("A" + i, "B" + i).MergeCells = true;
                    excelworksheet.get_Range("A" + i, "B" + i).Value = _info.Properties["Name"].Value.ToString();
                    i++;
                    foreach(PropertyData tmpOB in _info.Properties)
                    {
                        string _val = "";
                        if (tmpOB.Value != null)
                            _val = tmpOB.Value.ToString();
                        excelworksheet.Cells[i, 1] = tmpOB.Name;
                        excelworksheet.Cells[i, 2] = _val;
                        i++;
                    }
                }

                excelBook.SaveAs(this.saveFileDialogExcel.FileName);
                excelBook.Close();
                excelApp.Quit();

                Marshal.ReleaseComObject(excelBook);
                Marshal.ReleaseComObject(excelworksheet);
                Marshal.ReleaseComObject(excelApp);

                var _File = new FileInfo(this.saveFileDialogExcel.FileName);
                if (_File.Exists == true)
                    MessageBox.Show("파일이 정상적으로 생성되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("오류발생 : " + e);
            }
            finally
            {
                ExcelSave.Abort();
            }
        }
    }
}
