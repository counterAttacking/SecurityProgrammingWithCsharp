namespace USBController
{
    partial class Form2
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
            this.panelBack = new System.Windows.Forms.Panel();
            this.linkLabelMessage = new System.Windows.Forms.LinkLabel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBack.Controls.Add(this.picClose);
            this.panelBack.Controls.Add(this.linkLabelMessage);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(300, 0);
            this.panelBack.TabIndex = 0;
            // 
            // linkLabelMessage
            // 
            this.linkLabelMessage.AutoSize = true;
            this.linkLabelMessage.Location = new System.Drawing.Point(34, 51);
            this.linkLabelMessage.Name = "linkLabelMessage";
            this.linkLabelMessage.Size = new System.Drawing.Size(52, 15);
            this.linkLabelMessage.TabIndex = 0;
            this.linkLabelMessage.TabStop = true;
            this.linkLabelMessage.Text = "메시지";
            this.linkLabelMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMessage_LinkClicked);
            // 
            // picClose
            // 
            this.picClose.Image = global::USBController.Properties.Resources.CloseImg;
            this.picClose.Location = new System.Drawing.Point(234, 11);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(53, 37);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseDown);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseMove);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 0);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.LinkLabel linkLabelMessage;
    }
}