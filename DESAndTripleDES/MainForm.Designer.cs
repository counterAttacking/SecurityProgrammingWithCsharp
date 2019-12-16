namespace DESAndTripleDES
{
    partial class MainForm
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
            this.DESFormButton = new System.Windows.Forms.Button();
            this.TDESFromButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DESFormButton
            // 
            this.DESFormButton.Location = new System.Drawing.Point(62, 79);
            this.DESFormButton.Name = "DESFormButton";
            this.DESFormButton.Size = new System.Drawing.Size(149, 57);
            this.DESFormButton.TabIndex = 0;
            this.DESFormButton.Text = "DES 암복호화";
            this.DESFormButton.UseVisualStyleBackColor = true;
            this.DESFormButton.Click += new System.EventHandler(this.DESFormButton_Click);
            // 
            // TDESFromButton
            // 
            this.TDESFromButton.Location = new System.Drawing.Point(62, 194);
            this.TDESFromButton.Name = "TDESFromButton";
            this.TDESFromButton.Size = new System.Drawing.Size(149, 57);
            this.TDESFromButton.TabIndex = 1;
            this.TDESFromButton.Text = "TDES 암복호화";
            this.TDESFromButton.UseVisualStyleBackColor = true;
            this.TDESFromButton.Click += new System.EventHandler(this.TDESFromButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 307);
            this.Controls.Add(this.TDESFromButton);
            this.Controls.Add(this.DESFormButton);
            this.Name = "MainForm";
            this.Text = "DES&TDES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DESFormButton;
        private System.Windows.Forms.Button TDESFromButton;
    }
}

