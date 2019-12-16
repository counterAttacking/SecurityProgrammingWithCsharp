namespace KeyGen
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
            this.DateYearLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.MacAddLabel = new System.Windows.Forms.Label();
            this.CDKeyLabel = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.MacAddTextBox = new System.Windows.Forms.TextBox();
            this.CDKeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateYearLabel
            // 
            this.DateYearLabel.AutoSize = true;
            this.DateYearLabel.Location = new System.Drawing.Point(31, 40);
            this.DateYearLabel.Name = "DateYearLabel";
            this.DateYearLabel.Size = new System.Drawing.Size(75, 15);
            this.DateYearLabel.TabIndex = 0;
            this.DateYearLabel.Text = "KEY Year :";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(31, 113);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(88, 15);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User Name :";
            // 
            // MacAddLabel
            // 
            this.MacAddLabel.AutoSize = true;
            this.MacAddLabel.Location = new System.Drawing.Point(31, 188);
            this.MacAddLabel.Name = "MacAddLabel";
            this.MacAddLabel.Size = new System.Drawing.Size(82, 15);
            this.MacAddLabel.TabIndex = 2;
            this.MacAddLabel.Text = "MAC ADD :";
            // 
            // CDKeyLabel
            // 
            this.CDKeyLabel.AutoSize = true;
            this.CDKeyLabel.Location = new System.Drawing.Point(31, 259);
            this.CDKeyLabel.Name = "CDKeyLabel";
            this.CDKeyLabel.Size = new System.Drawing.Size(67, 15);
            this.CDKeyLabel.TabIndex = 3;
            this.CDKeyLabel.Text = "CD KEY :";
            // 
            // YearComboBox
            // 
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(125, 37);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(159, 23);
            this.YearComboBox.TabIndex = 4;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(125, 110);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(385, 25);
            this.UserNameTextBox.TabIndex = 5;
            // 
            // MacAddTextBox
            // 
            this.MacAddTextBox.Location = new System.Drawing.Point(125, 185);
            this.MacAddTextBox.Name = "MacAddTextBox";
            this.MacAddTextBox.Size = new System.Drawing.Size(385, 25);
            this.MacAddTextBox.TabIndex = 6;
            // 
            // CDKeyTextBox
            // 
            this.CDKeyTextBox.Location = new System.Drawing.Point(125, 256);
            this.CDKeyTextBox.Name = "CDKeyTextBox";
            this.CDKeyTextBox.ReadOnly = true;
            this.CDKeyTextBox.Size = new System.Drawing.Size(619, 25);
            this.CDKeyTextBox.TabIndex = 7;
            // 
            // KeyBtn
            // 
            this.KeyBtn.Location = new System.Drawing.Point(550, 37);
            this.KeyBtn.Name = "KeyBtn";
            this.KeyBtn.Size = new System.Drawing.Size(194, 173);
            this.KeyBtn.TabIndex = 8;
            this.KeyBtn.Text = "CD KEY 생성";
            this.KeyBtn.UseVisualStyleBackColor = true;
            this.KeyBtn.Click += new System.EventHandler(this.KeyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 309);
            this.Controls.Add(this.KeyBtn);
            this.Controls.Add(this.CDKeyTextBox);
            this.Controls.Add(this.MacAddTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.CDKeyLabel);
            this.Controls.Add(this.MacAddLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.DateYearLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CD KEY 생성";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateYearLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label MacAddLabel;
        private System.Windows.Forms.Label CDKeyLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox MacAddTextBox;
        private System.Windows.Forms.TextBox CDKeyTextBox;
        private System.Windows.Forms.Button KeyBtn;
    }
}

