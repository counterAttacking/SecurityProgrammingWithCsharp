namespace ProxySetup
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
            this.labelPort = new System.Windows.Forms.Label();
            this.inputTextPort = new System.Windows.Forms.TextBox();
            this.OnBtn = new System.Windows.Forms.Button();
            this.OffBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(50, 68);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(49, 15);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port : ";
            // 
            // inputTextPort
            // 
            this.inputTextPort.Location = new System.Drawing.Point(105, 65);
            this.inputTextPort.Name = "inputTextPort";
            this.inputTextPort.Size = new System.Drawing.Size(144, 25);
            this.inputTextPort.TabIndex = 1;
            // 
            // OnBtn
            // 
            this.OnBtn.Location = new System.Drawing.Point(53, 123);
            this.OnBtn.Name = "OnBtn";
            this.OnBtn.Size = new System.Drawing.Size(93, 35);
            this.OnBtn.TabIndex = 2;
            this.OnBtn.Text = "Proxy ON";
            this.OnBtn.UseVisualStyleBackColor = true;
            this.OnBtn.Click += new System.EventHandler(this.OnBtn_Click);
            // 
            // OffBtn
            // 
            this.OffBtn.Location = new System.Drawing.Point(178, 123);
            this.OffBtn.Name = "OffBtn";
            this.OffBtn.Size = new System.Drawing.Size(93, 35);
            this.OffBtn.TabIndex = 3;
            this.OffBtn.Text = "Proxy OFF";
            this.OffBtn.UseVisualStyleBackColor = true;
            this.OffBtn.Click += new System.EventHandler(this.OffBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 211);
            this.Controls.Add(this.OffBtn);
            this.Controls.Add(this.OnBtn);
            this.Controls.Add(this.inputTextPort);
            this.Controls.Add(this.labelPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Proxy 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox inputTextPort;
        private System.Windows.Forms.Button OnBtn;
        private System.Windows.Forms.Button OffBtn;
    }
}

