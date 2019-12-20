namespace BruteForceLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tlslblAddress = new System.Windows.Forms.ToolStripLabel();
            this.tlstxtAddress = new System.Windows.Forms.ToolStripTextBox();
            this.tlslblId = new System.Windows.Forms.ToolStripLabel();
            this.tlstxtId = new System.Windows.Forms.ToolStripTextBox();
            this.tlsbtnPwd = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnRun = new System.Windows.Forms.ToolStripButton();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(961, 559);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // tlsMenu
            // 
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlslblAddress,
            this.tlstxtAddress,
            this.tlslblId,
            this.tlstxtId,
            this.tlsbtnPwd,
            this.tlsbtnRun});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(961, 27);
            this.tlsMenu.TabIndex = 2;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // tlslblAddress
            // 
            this.tlslblAddress.Name = "tlslblAddress";
            this.tlslblAddress.Size = new System.Drawing.Size(52, 24);
            this.tlslblAddress.Text = "주소 : ";
            // 
            // tlstxtAddress
            // 
            this.tlstxtAddress.Name = "tlstxtAddress";
            this.tlstxtAddress.Size = new System.Drawing.Size(457, 27);
            // 
            // tlslblId
            // 
            this.tlslblId.Name = "tlslblId";
            this.tlslblId.Size = new System.Drawing.Size(37, 24);
            this.tlslblId.Text = "ID : ";
            // 
            // tlstxtId
            // 
            this.tlstxtId.Name = "tlstxtId";
            this.tlstxtId.Size = new System.Drawing.Size(114, 27);
            // 
            // tlsbtnPwd
            // 
            this.tlsbtnPwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnPwd.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnPwd.Image")));
            this.tlsbtnPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnPwd.Name = "tlsbtnPwd";
            this.tlsbtnPwd.Size = new System.Drawing.Size(24, 24);
            this.tlsbtnPwd.Text = "비밀번호";
            this.tlsbtnPwd.Click += new System.EventHandler(this.tlsbtnPwd_Click);
            // 
            // tlsbtnRun
            // 
            this.tlsbtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnRun.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnRun.Image")));
            this.tlsbtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnRun.Name = "tlsbtnRun";
            this.tlsbtnRun.Size = new System.Drawing.Size(24, 24);
            this.tlsbtnRun.Text = "Run";
            this.tlsbtnRun.Click += new System.EventHandler(this.tlsbtnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 559);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "자동 로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripLabel tlslblAddress;
        private System.Windows.Forms.ToolStripTextBox tlstxtAddress;
        private System.Windows.Forms.ToolStripLabel tlslblId;
        private System.Windows.Forms.ToolStripTextBox tlstxtId;
        private System.Windows.Forms.ToolStripButton tlsbtnPwd;
        private System.Windows.Forms.ToolStripButton tlsbtnRun;
    }
}

