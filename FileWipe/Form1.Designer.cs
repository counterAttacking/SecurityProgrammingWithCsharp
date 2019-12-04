namespace FileWipe
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
            this.WipeLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.PerLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.WipeButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WipeLabel
            // 
            this.WipeLabel.AutoSize = true;
            this.WipeLabel.Location = new System.Drawing.Point(40, 50);
            this.WipeLabel.Name = "WipeLabel";
            this.WipeLabel.Size = new System.Drawing.Size(52, 15);
            this.WipeLabel.TabIndex = 0;
            this.WipeLabel.Text = "선택 : ";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(40, 112);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(52, 15);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "파일 : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "모든 파일(*.*)|*.*";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.PerLabel);
            this.ResultGroupBox.Controls.Add(this.TotalLabel);
            this.ResultGroupBox.Location = new System.Drawing.Point(43, 167);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(350, 177);
            this.ResultGroupBox.TabIndex = 2;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Status";
            // 
            // PerLabel
            // 
            this.PerLabel.AutoSize = true;
            this.PerLabel.Location = new System.Drawing.Point(22, 115);
            this.PerLabel.Name = "PerLabel";
            this.PerLabel.Size = new System.Drawing.Size(67, 15);
            this.PerLabel.TabIndex = 4;
            this.PerLabel.Text = "진행률 : ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(22, 54);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(57, 15);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Level : ";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(98, 109);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(320, 25);
            this.PathTextBox.TabIndex = 5;
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(432, 108);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(50, 26);
            this.PathButton.TabIndex = 6;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // WipeButton
            // 
            this.WipeButton.Location = new System.Drawing.Point(413, 167);
            this.WipeButton.Name = "WipeButton";
            this.WipeButton.Size = new System.Drawing.Size(82, 44);
            this.WipeButton.TabIndex = 7;
            this.WipeButton.Text = "Wipe";
            this.WipeButton.UseVisualStyleBackColor = true;
            this.WipeButton.Click += new System.EventHandler(this.WipeButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "British HMG IS5 (Base Line)",
            "British HMG IS5 (Enhanced)"});
            this.comboBox1.Location = new System.Drawing.Point(98, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 391);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.WipeButton);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.WipeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Wipe";
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WipeLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label PerLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Button WipeButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

