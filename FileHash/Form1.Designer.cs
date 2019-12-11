namespace FileHash
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
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.MD5Label = new System.Windows.Forms.Label();
            this.SHALabel = new System.Windows.Forms.Label();
            this.SHATextBox = new System.Windows.Forms.TextBox();
            this.MD5TextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(110, 40);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open File";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(148, 12);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(110, 40);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 98);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(74, 15);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "File Path :";
            // 
            // MD5Label
            // 
            this.MD5Label.AutoSize = true;
            this.MD5Label.Location = new System.Drawing.Point(12, 170);
            this.MD5Label.Name = "MD5Label";
            this.MD5Label.Size = new System.Drawing.Size(86, 15);
            this.MD5Label.TabIndex = 3;
            this.MD5Label.Text = "MD5 Hash :";
            // 
            // SHALabel
            // 
            this.SHALabel.AutoSize = true;
            this.SHALabel.Location = new System.Drawing.Point(12, 245);
            this.SHALabel.Name = "SHALabel";
            this.SHALabel.Size = new System.Drawing.Size(101, 15);
            this.SHALabel.TabIndex = 4;
            this.SHALabel.Text = "SHA-1 Hash :";
            // 
            // SHATextBox
            // 
            this.SHATextBox.Location = new System.Drawing.Point(119, 242);
            this.SHATextBox.Name = "SHATextBox";
            this.SHATextBox.Size = new System.Drawing.Size(658, 25);
            this.SHATextBox.TabIndex = 5;
            // 
            // MD5TextBox
            // 
            this.MD5TextBox.Location = new System.Drawing.Point(119, 167);
            this.MD5TextBox.Name = "MD5TextBox";
            this.MD5TextBox.Size = new System.Drawing.Size(658, 25);
            this.MD5TextBox.TabIndex = 6;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(119, 95);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(658, 25);
            this.PathTextBox.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Files(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 304);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.MD5TextBox);
            this.Controls.Add(this.SHATextBox);
            this.Controls.Add(this.SHALabel);
            this.Controls.Add(this.MD5Label);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.OpenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Hash Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label MD5Label;
        private System.Windows.Forms.Label SHALabel;
        private System.Windows.Forms.TextBox SHATextBox;
        private System.Windows.Forms.TextBox MD5TextBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

