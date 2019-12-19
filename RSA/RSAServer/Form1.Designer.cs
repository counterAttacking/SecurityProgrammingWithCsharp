namespace RSAServer
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
            this.PublicKeySaveBtn = new System.Windows.Forms.Button();
            this.OpenEncryptedFileBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DataGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PublicKeySaveBtn
            // 
            this.PublicKeySaveBtn.Location = new System.Drawing.Point(866, 36);
            this.PublicKeySaveBtn.Name = "PublicKeySaveBtn";
            this.PublicKeySaveBtn.Size = new System.Drawing.Size(119, 37);
            this.PublicKeySaveBtn.TabIndex = 0;
            this.PublicKeySaveBtn.Text = "내보내기";
            this.PublicKeySaveBtn.UseVisualStyleBackColor = true;
            this.PublicKeySaveBtn.Click += new System.EventHandler(this.PublicKeySaveBtn_Click);
            // 
            // OpenEncryptedFileBtn
            // 
            this.OpenEncryptedFileBtn.Location = new System.Drawing.Point(866, 94);
            this.OpenEncryptedFileBtn.Name = "OpenEncryptedFileBtn";
            this.OpenEncryptedFileBtn.Size = new System.Drawing.Size(119, 37);
            this.OpenEncryptedFileBtn.TabIndex = 1;
            this.OpenEncryptedFileBtn.Text = "가져오기";
            this.OpenEncryptedFileBtn.UseVisualStyleBackColor = true;
            this.OpenEncryptedFileBtn.Click += new System.EventHandler(this.OpenEncryptedFileBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(866, 153);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(119, 37);
            this.DecryptBtn.TabIndex = 2;
            this.DecryptBtn.Text = "복호화";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(6, 24);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.Size = new System.Drawing.Size(822, 147);
            this.MessageTextBox.TabIndex = 3;
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Controls.Add(this.MessageTextBox);
            this.DataGroupBox.Location = new System.Drawing.Point(12, 36);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(848, 187);
            this.DataGroupBox.TabIndex = 4;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "메시지";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateKeyToolStripMenuItem,
            this.exitXToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // generateKeyToolStripMenuItem
            // 
            this.generateKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicKeyToolStripMenuItem,
            this.privateKeyToolStripMenuItem});
            this.generateKeyToolStripMenuItem.Name = "generateKeyToolStripMenuItem";
            this.generateKeyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.generateKeyToolStripMenuItem.Text = "Generate Key";
            // 
            // publicKeyToolStripMenuItem
            // 
            this.publicKeyToolStripMenuItem.Name = "publicKeyToolStripMenuItem";
            this.publicKeyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.publicKeyToolStripMenuItem.Text = "Public Key";
            this.publicKeyToolStripMenuItem.Click += new System.EventHandler(this.publicKeyToolStripMenuItem_Click);
            // 
            // privateKeyToolStripMenuItem
            // 
            this.privateKeyToolStripMenuItem.Name = "privateKeyToolStripMenuItem";
            this.privateKeyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.privateKeyToolStripMenuItem.Text = "Private Key";
            this.privateKeyToolStripMenuItem.Click += new System.EventHandler(this.privateKeyToolStripMenuItem_Click);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.DecryptTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(12, 247);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(848, 187);
            this.ResultGroupBox.TabIndex = 5;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "복호화";
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(6, 24);
            this.DecryptTextBox.Multiline = true;
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.ReadOnly = true;
            this.DecryptTextBox.Size = new System.Drawing.Size(822, 147);
            this.DecryptTextBox.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Public Key Document(*.pke)|*.pke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 447);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.DataGroupBox);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.OpenEncryptedFileBtn);
            this.Controls.Add(this.PublicKeySaveBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RSA Server";
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PublicKeySaveBtn;
        private System.Windows.Forms.Button OpenEncryptedFileBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

