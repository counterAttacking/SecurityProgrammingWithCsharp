namespace Rijndael
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
            this.FileOpenBtn = new System.Windows.Forms.Button();
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DiaryTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileOpenBtn
            // 
            this.FileOpenBtn.Location = new System.Drawing.Point(12, 12);
            this.FileOpenBtn.Name = "FileOpenBtn";
            this.FileOpenBtn.Size = new System.Drawing.Size(108, 36);
            this.FileOpenBtn.TabIndex = 0;
            this.FileOpenBtn.Text = "File Open";
            this.FileOpenBtn.UseVisualStyleBackColor = true;
            this.FileOpenBtn.Click += new System.EventHandler(this.FileOpenBtn_Click);
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Location = new System.Drawing.Point(145, 23);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(86, 15);
            this.PrivateKeyLabel.TabIndex = 1;
            this.PrivateKeyLabel.Text = "PrivateKey :";
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(237, 20);
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(281, 25);
            this.PrivateKeyTextBox.TabIndex = 2;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(557, 12);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(108, 36);
            this.ConvertBtn.TabIndex = 3;
            this.ConvertBtn.Text = "Decrypt";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(680, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 36);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "File Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DiaryTextBox
            // 
            this.DiaryTextBox.Location = new System.Drawing.Point(12, 65);
            this.DiaryTextBox.Multiline = true;
            this.DiaryTextBox.Name = "DiaryTextBox";
            this.DiaryTextBox.Size = new System.Drawing.Size(776, 373);
            this.DiaryTextBox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiaryTextBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.PrivateKeyTextBox);
            this.Controls.Add(this.PrivateKeyLabel);
            this.Controls.Add(this.FileOpenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Rijndael Diary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileOpenBtn;
        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox DiaryTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

