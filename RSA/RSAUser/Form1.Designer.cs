namespace RSAUser
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
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicKeyLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageGroupBox = new System.Windows.Forms.GroupBox();
            this.EncryptGroupBox = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.MessageGroupBox.SuspendLayout();
            this.EncryptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(815, 61);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(135, 48);
            this.EncryptBtn.TabIndex = 0;
            this.EncryptBtn.Text = "암호화";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(815, 130);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(135, 48);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "내보내기";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicKeyLoadToolStripMenuItem,
            this.exitXToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // publicKeyLoadToolStripMenuItem
            // 
            this.publicKeyLoadToolStripMenuItem.Name = "publicKeyLoadToolStripMenuItem";
            this.publicKeyLoadToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.publicKeyLoadToolStripMenuItem.Text = "Public Key Load";
            this.publicKeyLoadToolStripMenuItem.Click += new System.EventHandler(this.publicKeyLoadToolStripMenuItem_Click);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // MessageGroupBox
            // 
            this.MessageGroupBox.Controls.Add(this.MessageTextBox);
            this.MessageGroupBox.Location = new System.Drawing.Point(12, 52);
            this.MessageGroupBox.Name = "MessageGroupBox";
            this.MessageGroupBox.Size = new System.Drawing.Size(797, 144);
            this.MessageGroupBox.TabIndex = 3;
            this.MessageGroupBox.TabStop = false;
            this.MessageGroupBox.Text = "메시지";
            // 
            // EncryptGroupBox
            // 
            this.EncryptGroupBox.Controls.Add(this.EncryptTextBox);
            this.EncryptGroupBox.Location = new System.Drawing.Point(12, 222);
            this.EncryptGroupBox.Name = "EncryptGroupBox";
            this.EncryptGroupBox.Size = new System.Drawing.Size(797, 144);
            this.EncryptGroupBox.TabIndex = 4;
            this.EncryptGroupBox.TabStop = false;
            this.EncryptGroupBox.Text = "암호화";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(6, 24);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(785, 114);
            this.MessageTextBox.TabIndex = 0;
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(6, 24);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.ReadOnly = true;
            this.EncryptTextBox.Size = new System.Drawing.Size(785, 114);
            this.EncryptTextBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Public Key Document(*.pke)|*.pke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 415);
            this.Controls.Add(this.EncryptGroupBox);
            this.Controls.Add(this.MessageGroupBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RSA User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MessageGroupBox.ResumeLayout(false);
            this.MessageGroupBox.PerformLayout();
            this.EncryptGroupBox.ResumeLayout(false);
            this.EncryptGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicKeyLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.GroupBox MessageGroupBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.GroupBox EncryptGroupBox;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

