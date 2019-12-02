namespace FindHiddenFile
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
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonHidden = new System.Windows.Forms.RadioButton();
            this.FileListView = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(25, 28);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(52, 15);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "경로 : ";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(82, 25);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(611, 25);
            this.PathTextBox.TabIndex = 1;
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(715, 25);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(104, 28);
            this.PathButton.TabIndex = 2;
            this.PathButton.Text = "경로";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAll.Location = new System.Drawing.Point(28, 81);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(57, 24);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonHidden
            // 
            this.radioButtonHidden.AutoSize = true;
            this.radioButtonHidden.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHidden.ForeColor = System.Drawing.Color.Black;
            this.radioButtonHidden.Location = new System.Drawing.Point(111, 81);
            this.radioButtonHidden.Name = "radioButtonHidden";
            this.radioButtonHidden.Size = new System.Drawing.Size(84, 24);
            this.radioButtonHidden.TabIndex = 4;
            this.radioButtonHidden.Text = "Hidden";
            this.radioButtonHidden.UseVisualStyleBackColor = true;
            this.radioButtonHidden.CheckedChanged += new System.EventHandler(this.radioButtonHidden_CheckedChanged);
            // 
            // FileListView
            // 
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chFileSize,
            this.chFileTime});
            this.FileListView.GridLines = true;
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(28, 128);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(791, 390);
            this.FileListView.TabIndex = 5;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            // 
            // chFileName
            // 
            this.chFileName.Text = "FileName";
            this.chFileName.Width = 360;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "FileSize";
            this.chFileSize.Width = 150;
            // 
            // chFileTime
            // 
            this.chFileTime.Text = "CreationTime";
            this.chFileTime.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 530);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.radioButtonHidden);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Find Hidden File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonHidden;
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.ColumnHeader chFileTime;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

