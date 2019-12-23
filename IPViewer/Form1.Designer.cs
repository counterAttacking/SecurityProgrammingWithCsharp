namespace IPViewer
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
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPListBox
            // 
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.ItemHeight = 15;
            this.IPListBox.Location = new System.Drawing.Point(12, 12);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.Size = new System.Drawing.Size(461, 379);
            this.IPListBox.TabIndex = 0;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(195, 416);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(136, 42);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "확인";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(337, 416);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(136, 42);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "지우기";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 470);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.IPListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "아이피 추출기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox IPListBox;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}

