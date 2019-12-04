namespace HexaEditor
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
            this.FileButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.HexaView = new System.Windows.Forms.RichTextBox();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(12, 12);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(90, 30);
            this.FileButton.TabIndex = 0;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(108, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(822, 30);
            this.progressBar1.TabIndex = 1;
            // 
            // HexaView
            // 
            this.HexaView.Font = new System.Drawing.Font("Courier New", 9F);
            this.HexaView.ForeColor = System.Drawing.Color.Black;
            this.HexaView.Location = new System.Drawing.Point(12, 48);
            this.HexaView.Name = "HexaView";
            this.HexaView.Size = new System.Drawing.Size(918, 493);
            this.HexaView.TabIndex = 2;
            this.HexaView.Text = "";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 548);
            this.statusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(942, 28);
            this.statusBar.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 576);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.HexaView);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hexa Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox HexaView;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

