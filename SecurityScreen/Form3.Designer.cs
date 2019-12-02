namespace SecurityScreen
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswdLabel = new System.Windows.Forms.Label();
            this.RePasswdLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PasswdTextBoxt = new System.Windows.Forms.TextBox();
            this.RePasswdTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswdLabel
            // 
            this.PasswdLabel.AutoSize = true;
            this.PasswdLabel.Location = new System.Drawing.Point(39, 42);
            this.PasswdLabel.Name = "PasswdLabel";
            this.PasswdLabel.Size = new System.Drawing.Size(67, 15);
            this.PasswdLabel.TabIndex = 0;
            this.PasswdLabel.Text = "비밀번호";
            // 
            // RePasswdLabel
            // 
            this.RePasswdLabel.AutoSize = true;
            this.RePasswdLabel.Location = new System.Drawing.Point(39, 95);
            this.RePasswdLabel.Name = "RePasswdLabel";
            this.RePasswdLabel.Size = new System.Drawing.Size(117, 15);
            this.RePasswdLabel.TabIndex = 1;
            this.RePasswdLabel.Text = "비밀번호 재입력";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.ForeColor = System.Drawing.Color.Red;
            this.ResultLabel.Location = new System.Drawing.Point(39, 147);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 15);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "결과";
            // 
            // PasswdTextBoxt
            // 
            this.PasswdTextBoxt.Location = new System.Drawing.Point(166, 39);
            this.PasswdTextBoxt.Name = "PasswdTextBoxt";
            this.PasswdTextBoxt.PasswordChar = '*';
            this.PasswdTextBoxt.Size = new System.Drawing.Size(210, 25);
            this.PasswdTextBoxt.TabIndex = 3;
            // 
            // RePasswdTextBox
            // 
            this.RePasswdTextBox.Location = new System.Drawing.Point(166, 92);
            this.RePasswdTextBox.Name = "RePasswdTextBox";
            this.RePasswdTextBox.PasswordChar = '*';
            this.RePasswdTextBox.Size = new System.Drawing.Size(210, 25);
            this.RePasswdTextBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(402, 39);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 79);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "저장";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 187);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RePasswdTextBox);
            this.Controls.Add(this.PasswdTextBoxt);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.RePasswdLabel);
            this.Controls.Add(this.PasswdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 생성";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswdLabel;
        private System.Windows.Forms.Label RePasswdLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox PasswdTextBoxt;
        private System.Windows.Forms.TextBox RePasswdTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}