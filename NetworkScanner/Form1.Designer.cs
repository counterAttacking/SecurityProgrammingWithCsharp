namespace NetworkScanner
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
            this.StartIPLabel = new System.Windows.Forms.Label();
            this.StartIPTextBox = new System.Windows.Forms.TextBox();
            this.EndIPTextBox = new System.Windows.Forms.TextBox();
            this.EndIPLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ScanListView = new System.Windows.Forms.ListView();
            this.columnHeaderIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // StartIPLabel
            // 
            this.StartIPLabel.AutoSize = true;
            this.StartIPLabel.Location = new System.Drawing.Point(12, 23);
            this.StartIPLabel.Name = "StartIPLabel";
            this.StartIPLabel.Size = new System.Drawing.Size(55, 15);
            this.StartIPLabel.TabIndex = 0;
            this.StartIPLabel.Text = "Start IP";
            // 
            // StartIPTextBox
            // 
            this.StartIPTextBox.Location = new System.Drawing.Point(73, 20);
            this.StartIPTextBox.Name = "StartIPTextBox";
            this.StartIPTextBox.Size = new System.Drawing.Size(246, 25);
            this.StartIPTextBox.TabIndex = 1;
            // 
            // EndIPTextBox
            // 
            this.EndIPTextBox.Location = new System.Drawing.Point(399, 20);
            this.EndIPTextBox.Name = "EndIPTextBox";
            this.EndIPTextBox.Size = new System.Drawing.Size(291, 25);
            this.EndIPTextBox.TabIndex = 3;
            // 
            // EndIPLabel
            // 
            this.EndIPLabel.AutoSize = true;
            this.EndIPLabel.Location = new System.Drawing.Point(343, 23);
            this.EndIPLabel.Name = "EndIPLabel";
            this.EndIPLabel.Size = new System.Drawing.Size(50, 15);
            this.EndIPLabel.TabIndex = 2;
            this.EndIPLabel.Text = "End IP";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(696, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(161, 37);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ScanListView
            // 
            this.ScanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIP,
            this.columnHeaderHostName,
            this.columnHeaderMAC});
            this.ScanListView.GridLines = true;
            this.ScanListView.HideSelection = false;
            this.ScanListView.Location = new System.Drawing.Point(12, 71);
            this.ScanListView.Name = "ScanListView";
            this.ScanListView.Size = new System.Drawing.Size(845, 367);
            this.ScanListView.TabIndex = 5;
            this.ScanListView.UseCompatibleStateImageBehavior = false;
            this.ScanListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIP
            // 
            this.columnHeaderIP.Text = "IP Address";
            this.columnHeaderIP.Width = 210;
            // 
            // columnHeaderHostName
            // 
            this.columnHeaderHostName.Text = "HostName";
            this.columnHeaderHostName.Width = 210;
            // 
            // columnHeaderMAC
            // 
            this.columnHeaderMAC.Text = "MAC Address";
            this.columnHeaderMAC.Width = 210;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(845, 30);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 496);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ScanListView);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.EndIPTextBox);
            this.Controls.Add(this.EndIPLabel);
            this.Controls.Add(this.StartIPTextBox);
            this.Controls.Add(this.StartIPLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartIPLabel;
        private System.Windows.Forms.TextBox StartIPTextBox;
        private System.Windows.Forms.TextBox EndIPTextBox;
        private System.Windows.Forms.Label EndIPLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ListView ScanListView;
        private System.Windows.Forms.ColumnHeader columnHeaderIP;
        private System.Windows.Forms.ColumnHeader columnHeaderHostName;
        private System.Windows.Forms.ColumnHeader columnHeaderMAC;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

