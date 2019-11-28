namespace HardwareInfo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.WmiNameLabel = new System.Windows.Forms.Label();
            this.WmiNameComboBox = new System.Windows.Forms.ComboBox();
            this.WmiViewListView = new System.Windows.Forms.ListView();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // WmiNameLabel
            // 
            this.WmiNameLabel.AutoSize = true;
            this.WmiNameLabel.Location = new System.Drawing.Point(31, 47);
            this.WmiNameLabel.Name = "WmiNameLabel";
            this.WmiNameLabel.Size = new System.Drawing.Size(46, 15);
            this.WmiNameLabel.TabIndex = 0;
            this.WmiNameLabel.Text = "WMI :";
            // 
            // WmiNameComboBox
            // 
            this.WmiNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WmiNameComboBox.FormattingEnabled = true;
            this.WmiNameComboBox.Location = new System.Drawing.Point(93, 44);
            this.WmiNameComboBox.Name = "WmiNameComboBox";
            this.WmiNameComboBox.Size = new System.Drawing.Size(444, 23);
            this.WmiNameComboBox.TabIndex = 1;
            this.WmiNameComboBox.SelectedIndexChanged += new System.EventHandler(this.WmiNameComboBox_SelectedIndexChanged);
            // 
            // WmiViewListView
            // 
            this.WmiViewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chValue});
            this.WmiViewListView.GridLines = true;
            this.WmiViewListView.HideSelection = false;
            this.WmiViewListView.Location = new System.Drawing.Point(34, 99);
            this.WmiViewListView.Name = "WmiViewListView";
            this.WmiViewListView.Size = new System.Drawing.Size(671, 285);
            this.WmiViewListView.TabIndex = 2;
            this.WmiViewListView.UseCompatibleStateImageBehavior = false;
            this.WmiViewListView.View = System.Windows.Forms.View.Details;
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Location = new System.Drawing.Point(604, 404);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(101, 34);
            this.ExcelBtn.TabIndex = 3;
            this.ExcelBtn.Text = "Excel 저장";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // saveFileDialogExcel
            // 
            this.saveFileDialogExcel.CreatePrompt = true;
            this.saveFileDialogExcel.DefaultExt = "xlxs";
            this.saveFileDialogExcel.Filter = "Excel 2019(*.xlsx)|*.xlsx|Excel 2016(*.xlsx)|*.xlsx|Excel 2013(*.xlsx)|*.xlsx|Exc" +
    "el 2003(*.xls)|*.xls";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 180;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.WmiViewListView);
            this.Controls.Add(this.WmiNameComboBox);
            this.Controls.Add(this.WmiNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hardware 정보 얻기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WmiNameLabel;
        private System.Windows.Forms.ComboBox WmiNameComboBox;
        private System.Windows.Forms.ListView WmiViewListView;
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chValue;
    }
}

