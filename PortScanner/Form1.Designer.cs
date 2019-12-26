namespace PortScanner
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.StartPortLabel = new System.Windows.Forms.Label();
            this.EndPortLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ScanListView = new System.Windows.Forms.ListView();
            this.FileBtn = new System.Windows.Forms.Button();
            this.ScanProgressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.columnHeaderPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(37, 40);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(65, 15);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "Target IP";
            // 
            // StartPortLabel
            // 
            this.StartPortLabel.AutoSize = true;
            this.StartPortLabel.Location = new System.Drawing.Point(37, 110);
            this.StartPortLabel.Name = "StartPortLabel";
            this.StartPortLabel.Size = new System.Drawing.Size(69, 15);
            this.StartPortLabel.TabIndex = 1;
            this.StartPortLabel.Text = "Start Port";
            // 
            // EndPortLabel
            // 
            this.EndPortLabel.AutoSize = true;
            this.EndPortLabel.Location = new System.Drawing.Point(37, 183);
            this.EndPortLabel.Name = "EndPortLabel";
            this.EndPortLabel.Size = new System.Drawing.Size(64, 15);
            this.EndPortLabel.TabIndex = 2;
            this.EndPortLabel.Text = "End Port";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(37, 319);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(86, 15);
            this.FileLabel.TabIndex = 3;
            this.FileLabel.Text = "Create File :";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(115, 37);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(270, 25);
            this.IPTextBox.TabIndex = 4;
            this.IPTextBox.Text = "127.0.0.1";
            this.IPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(115, 107);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(113, 25);
            this.StartTextBox.TabIndex = 5;
            this.StartTextBox.Text = "1";
            this.StartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(115, 180);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(113, 25);
            this.EndTextBox.TabIndex = 6;
            this.EndTextBox.Text = "65535";
            this.EndTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(253, 107);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(132, 98);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Scan";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ScanListView
            // 
            this.ScanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPort,
            this.columnHeaderState});
            this.ScanListView.GridLines = true;
            this.ScanListView.HideSelection = false;
            this.ScanListView.Location = new System.Drawing.Point(414, 37);
            this.ScanListView.Name = "ScanListView";
            this.ScanListView.Size = new System.Drawing.Size(374, 344);
            this.ScanListView.TabIndex = 8;
            this.ScanListView.UseCompatibleStateImageBehavior = false;
            this.ScanListView.View = System.Windows.Forms.View.Details;
            // 
            // FileBtn
            // 
            this.FileBtn.Location = new System.Drawing.Point(40, 250);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(345, 38);
            this.FileBtn.TabIndex = 9;
            this.FileBtn.Text = "File Path";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // ScanProgressBar
            // 
            this.ScanProgressBar.Location = new System.Drawing.Point(40, 353);
            this.ScanProgressBar.Name = "ScanProgressBar";
            this.ScanProgressBar.Size = new System.Drawing.Size(345, 28);
            this.ScanProgressBar.TabIndex = 10;
            // 
            // columnHeaderPort
            // 
            this.columnHeaderPort.Text = "Port";
            this.columnHeaderPort.Width = 200;
            // 
            // columnHeaderState
            // 
            this.columnHeaderState.Text = "State";
            this.columnHeaderState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderState.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.ScanProgressBar);
            this.Controls.Add(this.FileBtn);
            this.Controls.Add(this.ScanListView);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.StartTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.EndPortLabel);
            this.Controls.Add(this.StartPortLabel);
            this.Controls.Add(this.IPLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Port Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label StartPortLabel;
        private System.Windows.Forms.Label EndPortLabel;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ListView ScanListView;
        private System.Windows.Forms.Button FileBtn;
        private System.Windows.Forms.ProgressBar ScanProgressBar;
        private System.Windows.Forms.ColumnHeader columnHeaderPort;
        private System.Windows.Forms.ColumnHeader columnHeaderState;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

