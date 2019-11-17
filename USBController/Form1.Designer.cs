namespace USBController
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
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.radioBtnEnable = new System.Windows.Forms.RadioButton();
            this.radioBtnDisable = new System.Windows.Forms.RadioButton();
            this.checkBoxReal = new System.Windows.Forms.CheckBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.groupBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.btnSetup);
            this.groupBoxControl.Controls.Add(this.checkBoxReal);
            this.groupBoxControl.Controls.Add(this.radioBtnDisable);
            this.groupBoxControl.Controls.Add(this.radioBtnEnable);
            this.groupBoxControl.Location = new System.Drawing.Point(12, 12);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(370, 266);
            this.groupBoxControl.TabIndex = 0;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Enable / Disable USB";
            // 
            // radioBtnEnable
            // 
            this.radioBtnEnable.AutoSize = true;
            this.radioBtnEnable.Location = new System.Drawing.Point(53, 52);
            this.radioBtnEnable.Name = "radioBtnEnable";
            this.radioBtnEnable.Size = new System.Drawing.Size(139, 19);
            this.radioBtnEnable.TabIndex = 0;
            this.radioBtnEnable.TabStop = true;
            this.radioBtnEnable.Text = "Enable USB Port";
            this.radioBtnEnable.UseVisualStyleBackColor = true;
            this.radioBtnEnable.CheckedChanged += new System.EventHandler(this.radioBtnEnable_CheckedChanged);
            // 
            // radioBtnDisable
            // 
            this.radioBtnDisable.AutoSize = true;
            this.radioBtnDisable.Location = new System.Drawing.Point(53, 118);
            this.radioBtnDisable.Name = "radioBtnDisable";
            this.radioBtnDisable.Size = new System.Drawing.Size(143, 19);
            this.radioBtnDisable.TabIndex = 1;
            this.radioBtnDisable.TabStop = true;
            this.radioBtnDisable.Text = "Disable USB Port";
            this.radioBtnDisable.UseVisualStyleBackColor = true;
            // 
            // checkBoxReal
            // 
            this.checkBoxReal.AutoSize = true;
            this.checkBoxReal.Location = new System.Drawing.Point(53, 205);
            this.checkBoxReal.Name = "checkBoxReal";
            this.checkBoxReal.Size = new System.Drawing.Size(109, 19);
            this.checkBoxReal.TabIndex = 2;
            this.checkBoxReal.Text = "실시간 감시";
            this.checkBoxReal.UseVisualStyleBackColor = true;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(168, 197);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(196, 33);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.Text = "설정";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 290);
            this.Controls.Add(this.groupBoxControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "USB Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.CheckBox checkBoxReal;
        private System.Windows.Forms.RadioButton radioBtnDisable;
        private System.Windows.Forms.RadioButton radioBtnEnable;
    }
}

