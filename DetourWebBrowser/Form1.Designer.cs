namespace DetourWebBrowser
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelAddress = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelProxy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxOn = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonSetup = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAddress,
            this.toolStripTextBoxUrl,
            this.toolStripButtonGo,
            this.toolStripLabelProxy,
            this.toolStripComboBoxOn,
            this.toolStripButtonSetup});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1232, 28);
            this.toolStripMenu.TabIndex = 3;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripLabelAddress
            // 
            this.toolStripLabelAddress.Name = "toolStripLabelAddress";
            this.toolStripLabelAddress.Size = new System.Drawing.Size(52, 25);
            this.toolStripLabelAddress.Text = "주소 : ";
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(571, 28);
            this.toolStripTextBoxUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxUrl_KeyPress);
            // 
            // toolStripButtonGo
            // 
            this.toolStripButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGo.Image")));
            this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGo.Name = "toolStripButtonGo";
            this.toolStripButtonGo.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonGo.Text = "이동";
            this.toolStripButtonGo.Click += new System.EventHandler(this.toolStripButtonGo_Click);
            // 
            // toolStripLabelProxy
            // 
            this.toolStripLabelProxy.Name = "toolStripLabelProxy";
            this.toolStripLabelProxy.Size = new System.Drawing.Size(59, 25);
            this.toolStripLabelProxy.Text = "Proxy : ";
            // 
            // toolStripComboBoxOn
            // 
            this.toolStripComboBoxOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxOn.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.toolStripComboBoxOn.Name = "toolStripComboBoxOn";
            this.toolStripComboBoxOn.Size = new System.Drawing.Size(85, 28);
            this.toolStripComboBoxOn.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxOn_SelectedIndexChanged);
            // 
            // toolStripButtonSetup
            // 
            this.toolStripButtonSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetup.Image")));
            this.toolStripButtonSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetup.Name = "toolStripButtonSetup";
            this.toolStripButtonSetup.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonSetup.Text = "설정";
            this.toolStripButtonSetup.Click += new System.EventHandler(this.toolStripButtonSetup_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1232, 422);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "Form1";
            this.Text = "IP 우회 브라우저";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAddress;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUrl;
        private System.Windows.Forms.ToolStripButton toolStripButtonGo;
        private System.Windows.Forms.ToolStripLabel toolStripLabelProxy;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxOn;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetup;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

