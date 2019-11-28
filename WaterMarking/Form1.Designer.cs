namespace WaterMarking
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
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.BackgroundTextBox = new System.Windows.Forms.TextBox();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.OpacityScrollBar = new System.Windows.Forms.HScrollBar();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Location = new System.Drawing.Point(36, 38);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(37, 15);
            this.BackgroundLabel.TabIndex = 0;
            this.BackgroundLabel.Text = "배경";
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(36, 86);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(37, 15);
            this.MarkLabel.TabIndex = 1;
            this.MarkLabel.Text = "마킹";
            // 
            // BackgroundTextBox
            // 
            this.BackgroundTextBox.Location = new System.Drawing.Point(98, 35);
            this.BackgroundTextBox.Name = "BackgroundTextBox";
            this.BackgroundTextBox.Size = new System.Drawing.Size(434, 25);
            this.BackgroundTextBox.TabIndex = 2;
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Location = new System.Drawing.Point(98, 83);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(434, 25);
            this.MarkTextBox.TabIndex = 3;
            // 
            // BackgroundButton
            // 
            this.BackgroundButton.Location = new System.Drawing.Point(553, 33);
            this.BackgroundButton.Name = "BackgroundButton";
            this.BackgroundButton.Size = new System.Drawing.Size(110, 25);
            this.BackgroundButton.TabIndex = 4;
            this.BackgroundButton.Text = "배경파일";
            this.BackgroundButton.UseVisualStyleBackColor = true;
            this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(553, 81);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(110, 25);
            this.ViewButton.TabIndex = 5;
            this.ViewButton.Text = "미리보기";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(21, 153);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(52, 15);
            this.OpacityLabel.TabIndex = 6;
            this.OpacityLabel.Text = "투명도";
            // 
            // OpacityScrollBar
            // 
            this.OpacityScrollBar.Location = new System.Drawing.Point(98, 147);
            this.OpacityScrollBar.Minimum = 1;
            this.OpacityScrollBar.Name = "OpacityScrollBar";
            this.OpacityScrollBar.Size = new System.Drawing.Size(434, 21);
            this.OpacityScrollBar.TabIndex = 7;
            this.OpacityScrollBar.Value = 50;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(553, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 53);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "저장하기";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(24, 189);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(639, 357);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "JPEG Images(*.jpg,*.jpeg)|*.jpg;*.jpeg|GIF Image(*.gif)|*.gif|Bitmap(*.bmp)|*.bmp" +
    "|All Image Format|*.jpg;*.jpeg;*.gif;*.bmp";
            // 
            // SaveImageDialog
            // 
            this.SaveImageDialog.Filter = "이미지 파일(*.jpg)|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 558);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpacityScrollBar);
            this.Controls.Add(this.OpacityLabel);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.BackgroundButton);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.BackgroundTextBox);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.BackgroundLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "WaterMarking";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.TextBox BackgroundTextBox;
        private System.Windows.Forms.TextBox MarkTextBox;
        private System.Windows.Forms.Button BackgroundButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.HScrollBar OpacityScrollBar;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveImageDialog;
    }
}

