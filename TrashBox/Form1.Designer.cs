namespace TrashBox
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
            this.FileListView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileListView
            // 
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPath,
            this.columnDate});
            this.FileListView.FullRowSelect = true;
            this.FileListView.GridLines = true;
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(12, 12);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(1034, 416);
            this.FileListView.TabIndex = 0;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "이름";
            this.columnName.Width = 200;
            // 
            // columnPath
            // 
            this.columnPath.Text = "원래 위치";
            this.columnPath.Width = 480;
            // 
            // columnDate
            // 
            this.columnDate.Text = "삭제된 날짜";
            this.columnDate.Width = 200;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(619, 455);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 36);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "휴지통 비우기";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Location = new System.Drawing.Point(778, 455);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(113, 36);
            this.RestoreBtn.TabIndex = 2;
            this.RestoreBtn.Text = "복원";
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(933, 455);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(113, 36);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "새로고침";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 522);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.FileListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "휴지통";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

