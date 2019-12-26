namespace WifiScanner
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
            this.APListView = new System.Windows.Forms.ListView();
            this.columnHeaderSSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderChannel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlgorithm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // APListView
            // 
            this.APListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSSID,
            this.columnHeaderQuality,
            this.columnHeaderEnabled,
            this.columnHeaderChannel,
            this.columnHeaderAlgorithm,
            this.columnHeaderAuth,
            this.columnHeaderMAC});
            this.APListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.APListView.GridLines = true;
            this.APListView.HideSelection = false;
            this.APListView.Location = new System.Drawing.Point(0, 0);
            this.APListView.Name = "APListView";
            this.APListView.Size = new System.Drawing.Size(965, 591);
            this.APListView.TabIndex = 0;
            this.APListView.UseCompatibleStateImageBehavior = false;
            this.APListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSSID
            // 
            this.columnHeaderSSID.Text = "이름";
            this.columnHeaderSSID.Width = 120;
            // 
            // columnHeaderQuality
            // 
            this.columnHeaderQuality.Text = "신호강도";
            this.columnHeaderQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderEnabled
            // 
            this.columnHeaderEnabled.Text = "암호화";
            this.columnHeaderEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderEnabled.Width = 80;
            // 
            // columnHeaderChannel
            // 
            this.columnHeaderChannel.Text = "채널";
            this.columnHeaderChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderAlgorithm
            // 
            this.columnHeaderAlgorithm.Text = "암호방식";
            this.columnHeaderAlgorithm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAlgorithm.Width = 80;
            // 
            // columnHeaderAuth
            // 
            this.columnHeaderAuth.Text = "인증방식";
            this.columnHeaderAuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAuth.Width = 120;
            // 
            // columnHeaderMAC
            // 
            this.columnHeaderMAC.Text = "MAC Address";
            this.columnHeaderMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMAC.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 591);
            this.Controls.Add(this.APListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Wi-fi Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView APListView;
        private System.Windows.Forms.ColumnHeader columnHeaderSSID;
        private System.Windows.Forms.ColumnHeader columnHeaderQuality;
        private System.Windows.Forms.ColumnHeader columnHeaderEnabled;
        private System.Windows.Forms.ColumnHeader columnHeaderChannel;
        private System.Windows.Forms.ColumnHeader columnHeaderAlgorithm;
        private System.Windows.Forms.ColumnHeader columnHeaderAuth;
        private System.Windows.Forms.ColumnHeader columnHeaderMAC;
    }
}

