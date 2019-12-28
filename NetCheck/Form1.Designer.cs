namespace NetCheck
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
            this.components = new System.ComponentModel.Container();
            this.AddrListBox = new System.Windows.Forms.ListBox();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.AddrTextBox = new System.Windows.Forms.TextBox();
            this.InputBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AddrListBox
            // 
            this.AddrListBox.FormattingEnabled = true;
            this.AddrListBox.ItemHeight = 15;
            this.AddrListBox.Location = new System.Drawing.Point(12, 12);
            this.AddrListBox.Name = "AddrListBox";
            this.AddrListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AddrListBox.Size = new System.Drawing.Size(283, 439);
            this.AddrListBox.TabIndex = 0;
            this.AddrListBox.SelectedIndexChanged += new System.EventHandler(this.AddrListBox_SelectedIndexChanged);
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 15;
            this.ResultListBox.Location = new System.Drawing.Point(316, 12);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(705, 439);
            this.ResultListBox.TabIndex = 1;
            // 
            // AddrTextBox
            // 
            this.AddrTextBox.Location = new System.Drawing.Point(12, 477);
            this.AddrTextBox.Name = "AddrTextBox";
            this.AddrTextBox.Size = new System.Drawing.Size(173, 25);
            this.AddrTextBox.TabIndex = 2;
            this.AddrTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddrTextBox_KeyDown);
            // 
            // InputBtn
            // 
            this.InputBtn.Location = new System.Drawing.Point(201, 477);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(94, 25);
            this.InputBtn.TabIndex = 3;
            this.InputBtn.Text = "입력";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Enabled = false;
            this.CheckBtn.Location = new System.Drawing.Point(927, 477);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(94, 25);
            this.CheckBtn.TabIndex = 4;
            this.CheckBtn.Text = "확인";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Items.AddRange(new object[] {
            "1초",
            "2초",
            "3초",
            "4초",
            "5초"});
            this.TimeComboBox.Location = new System.Drawing.Point(761, 477);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(150, 23);
            this.TimeComboBox.TabIndex = 5;
            this.TimeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 518);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.AddrTextBox);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.AddrListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Net Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AddrListBox;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.TextBox AddrTextBox;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.ComboBox TimeComboBox;
        private System.Windows.Forms.Timer timer1;
    }
}

