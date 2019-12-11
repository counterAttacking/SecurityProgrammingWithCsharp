namespace UTF8Base64
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
            this.UTFEnBtn = new System.Windows.Forms.Button();
            this.UTFDeBtn = new System.Windows.Forms.Button();
            this.BaseEnBtn = new System.Windows.Forms.Button();
            this.BaseDeBtn = new System.Windows.Forms.Button();
            this.EncodeTextBox = new System.Windows.Forms.TextBox();
            this.DecodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UTFEnBtn
            // 
            this.UTFEnBtn.Location = new System.Drawing.Point(12, 12);
            this.UTFEnBtn.Name = "UTFEnBtn";
            this.UTFEnBtn.Size = new System.Drawing.Size(139, 40);
            this.UTFEnBtn.TabIndex = 0;
            this.UTFEnBtn.Text = "UTF8 Encode";
            this.UTFEnBtn.UseVisualStyleBackColor = true;
            this.UTFEnBtn.Click += new System.EventHandler(this.UTFEnBtn_Click);
            // 
            // UTFDeBtn
            // 
            this.UTFDeBtn.Location = new System.Drawing.Point(12, 70);
            this.UTFDeBtn.Name = "UTFDeBtn";
            this.UTFDeBtn.Size = new System.Drawing.Size(139, 40);
            this.UTFDeBtn.TabIndex = 1;
            this.UTFDeBtn.Text = "UTF8 Decode";
            this.UTFDeBtn.UseVisualStyleBackColor = true;
            this.UTFDeBtn.Click += new System.EventHandler(this.UTFDeBtn_Click);
            // 
            // BaseEnBtn
            // 
            this.BaseEnBtn.Location = new System.Drawing.Point(12, 168);
            this.BaseEnBtn.Name = "BaseEnBtn";
            this.BaseEnBtn.Size = new System.Drawing.Size(139, 40);
            this.BaseEnBtn.TabIndex = 2;
            this.BaseEnBtn.Text = "Base64 Encode";
            this.BaseEnBtn.UseVisualStyleBackColor = true;
            this.BaseEnBtn.Click += new System.EventHandler(this.BaseEnBtn_Click);
            // 
            // BaseDeBtn
            // 
            this.BaseDeBtn.Location = new System.Drawing.Point(12, 230);
            this.BaseDeBtn.Name = "BaseDeBtn";
            this.BaseDeBtn.Size = new System.Drawing.Size(139, 40);
            this.BaseDeBtn.TabIndex = 3;
            this.BaseDeBtn.Text = "Base64 Decode";
            this.BaseDeBtn.UseVisualStyleBackColor = true;
            this.BaseDeBtn.Click += new System.EventHandler(this.BaseDeBtn_Click);
            // 
            // EncodeTextBox
            // 
            this.EncodeTextBox.Location = new System.Drawing.Point(167, 12);
            this.EncodeTextBox.Multiline = true;
            this.EncodeTextBox.Name = "EncodeTextBox";
            this.EncodeTextBox.Size = new System.Drawing.Size(621, 98);
            this.EncodeTextBox.TabIndex = 4;
            // 
            // DecodeTextBox
            // 
            this.DecodeTextBox.Location = new System.Drawing.Point(167, 168);
            this.DecodeTextBox.Multiline = true;
            this.DecodeTextBox.Name = "DecodeTextBox";
            this.DecodeTextBox.Size = new System.Drawing.Size(621, 98);
            this.DecodeTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.DecodeTextBox);
            this.Controls.Add(this.EncodeTextBox);
            this.Controls.Add(this.BaseDeBtn);
            this.Controls.Add(this.BaseEnBtn);
            this.Controls.Add(this.UTFDeBtn);
            this.Controls.Add(this.UTFEnBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "UTF8 / Base64 EnDecoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UTFEnBtn;
        private System.Windows.Forms.Button UTFDeBtn;
        private System.Windows.Forms.Button BaseEnBtn;
        private System.Windows.Forms.Button BaseDeBtn;
        private System.Windows.Forms.TextBox EncodeTextBox;
        private System.Windows.Forms.TextBox DecodeTextBox;
    }
}

