namespace DNSLookUp
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
            this.URLLabel = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddrListBox = new System.Windows.Forms.ListBox();
            this.IPAddrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(20, 29);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(67, 15);
            this.URLLabel.TabIndex = 0;
            this.URLLabel.Text = "도메인 : ";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(102, 26);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(281, 25);
            this.HostTextBox.TabIndex = 1;
            this.HostTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HostTextBox_KeyDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(389, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 33);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddrListBox
            // 
            this.AddrListBox.FormattingEnabled = true;
            this.AddrListBox.ItemHeight = 15;
            this.AddrListBox.Location = new System.Drawing.Point(23, 132);
            this.AddrListBox.Name = "AddrListBox";
            this.AddrListBox.Size = new System.Drawing.Size(456, 199);
            this.AddrListBox.TabIndex = 3;
            // 
            // IPAddrLabel
            // 
            this.IPAddrLabel.AutoSize = true;
            this.IPAddrLabel.Location = new System.Drawing.Point(20, 103);
            this.IPAddrLabel.Name = "IPAddrLabel";
            this.IPAddrLabel.Size = new System.Drawing.Size(78, 15);
            this.IPAddrLabel.TabIndex = 4;
            this.IPAddrLabel.Text = "IP Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 343);
            this.Controls.Add(this.IPAddrLabel);
            this.Controls.Add(this.AddrListBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.URLLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DNS LookUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ListBox AddrListBox;
        private System.Windows.Forms.Label IPAddrLabel;
    }
}

