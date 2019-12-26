namespace NetStat
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
            this.NetStateListView = new System.Windows.Forms.ListView();
            this.LocalPortLabel = new System.Windows.Forms.Label();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.ForeignAddrTextBox = new System.Windows.Forms.TextBox();
            this.ForeignAddrLabel = new System.Windows.Forms.Label();
            this.ForeignPortTextBox = new System.Windows.Forms.TextBox();
            this.ForeignPortLabel = new System.Windows.Forms.Label();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.columnHeaderLocalIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocalPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRemoteIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRemotePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // NetStateListView
            // 
            this.NetStateListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLocalIP,
            this.columnHeaderLocalPort,
            this.columnHeaderRemoteIP,
            this.columnHeaderRemotePort,
            this.columnHeaderState});
            this.NetStateListView.GridLines = true;
            this.NetStateListView.HideSelection = false;
            this.NetStateListView.Location = new System.Drawing.Point(12, 12);
            this.NetStateListView.Name = "NetStateListView";
            this.NetStateListView.Size = new System.Drawing.Size(879, 462);
            this.NetStateListView.TabIndex = 0;
            this.NetStateListView.UseCompatibleStateImageBehavior = false;
            this.NetStateListView.View = System.Windows.Forms.View.Details;
            // 
            // LocalPortLabel
            // 
            this.LocalPortLabel.AutoSize = true;
            this.LocalPortLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.LocalPortLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalPortLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.LocalPortLabel.Location = new System.Drawing.Point(37, 495);
            this.LocalPortLabel.Name = "LocalPortLabel";
            this.LocalPortLabel.Size = new System.Drawing.Size(78, 19);
            this.LocalPortLabel.TabIndex = 1;
            this.LocalPortLabel.Text = "로컬포트";
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(121, 494);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(92, 25);
            this.LocalPortTextBox.TabIndex = 2;
            // 
            // ForeignAddrTextBox
            // 
            this.ForeignAddrTextBox.Location = new System.Drawing.Point(303, 494);
            this.ForeignAddrTextBox.Name = "ForeignAddrTextBox";
            this.ForeignAddrTextBox.Size = new System.Drawing.Size(201, 25);
            this.ForeignAddrTextBox.TabIndex = 4;
            // 
            // ForeignAddrLabel
            // 
            this.ForeignAddrLabel.AutoSize = true;
            this.ForeignAddrLabel.BackColor = System.Drawing.Color.LightPink;
            this.ForeignAddrLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForeignAddrLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.ForeignAddrLabel.Location = new System.Drawing.Point(219, 495);
            this.ForeignAddrLabel.Name = "ForeignAddrLabel";
            this.ForeignAddrLabel.Size = new System.Drawing.Size(78, 19);
            this.ForeignAddrLabel.TabIndex = 3;
            this.ForeignAddrLabel.Text = "외부주소";
            // 
            // ForeignPortTextBox
            // 
            this.ForeignPortTextBox.Location = new System.Drawing.Point(594, 494);
            this.ForeignPortTextBox.Name = "ForeignPortTextBox";
            this.ForeignPortTextBox.Size = new System.Drawing.Size(100, 25);
            this.ForeignPortTextBox.TabIndex = 6;
            // 
            // ForeignPortLabel
            // 
            this.ForeignPortLabel.AutoSize = true;
            this.ForeignPortLabel.BackColor = System.Drawing.Color.Aqua;
            this.ForeignPortLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForeignPortLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.ForeignPortLabel.Location = new System.Drawing.Point(510, 495);
            this.ForeignPortLabel.Name = "ForeignPortLabel";
            this.ForeignPortLabel.Size = new System.Drawing.Size(78, 19);
            this.ForeignPortLabel.TabIndex = 5;
            this.ForeignPortLabel.Text = "외부포트";
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(712, 489);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(74, 30);
            this.CheckBtn.TabIndex = 7;
            this.CheckBtn.Text = "체크";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(793, 489);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(74, 30);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // columnHeaderLocalIP
            // 
            this.columnHeaderLocalIP.Text = "로컬주소";
            this.columnHeaderLocalIP.Width = 180;
            // 
            // columnHeaderLocalPort
            // 
            this.columnHeaderLocalPort.Text = "로컬포트";
            this.columnHeaderLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLocalPort.Width = 120;
            // 
            // columnHeaderRemoteIP
            // 
            this.columnHeaderRemoteIP.Text = "외부주소";
            this.columnHeaderRemoteIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRemoteIP.Width = 180;
            // 
            // columnHeaderRemotePort
            // 
            this.columnHeaderRemotePort.Text = "외부포트";
            this.columnHeaderRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRemotePort.Width = 120;
            // 
            // columnHeaderState
            // 
            this.columnHeaderState.Text = "상태";
            this.columnHeaderState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderState.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 532);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.ForeignPortTextBox);
            this.Controls.Add(this.ForeignPortLabel);
            this.Controls.Add(this.ForeignAddrTextBox);
            this.Controls.Add(this.ForeignAddrLabel);
            this.Controls.Add(this.LocalPortTextBox);
            this.Controls.Add(this.LocalPortLabel);
            this.Controls.Add(this.NetStateListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NetStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView NetStateListView;
        private System.Windows.Forms.ColumnHeader columnHeaderLocalIP;
        private System.Windows.Forms.ColumnHeader columnHeaderLocalPort;
        private System.Windows.Forms.ColumnHeader columnHeaderRemoteIP;
        private System.Windows.Forms.ColumnHeader columnHeaderRemotePort;
        private System.Windows.Forms.ColumnHeader columnHeaderState;
        private System.Windows.Forms.Label LocalPortLabel;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.TextBox ForeignAddrTextBox;
        private System.Windows.Forms.Label ForeignAddrLabel;
        private System.Windows.Forms.TextBox ForeignPortTextBox;
        private System.Windows.Forms.Label ForeignPortLabel;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

