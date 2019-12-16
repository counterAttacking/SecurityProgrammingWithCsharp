namespace DESAndTripleDES
{
    partial class TDESForm
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
            this.OriginStringLabel = new System.Windows.Forms.Label();
            this.EncryptLabel = new System.Windows.Forms.Label();
            this.DecryptLabel = new System.Windows.Forms.Label();
            this.OriginStringTextBox = new System.Windows.Forms.TextBox();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginStringLabel
            // 
            this.OriginStringLabel.AutoSize = true;
            this.OriginStringLabel.Location = new System.Drawing.Point(12, 32);
            this.OriginStringLabel.Name = "OriginStringLabel";
            this.OriginStringLabel.Size = new System.Drawing.Size(97, 15);
            this.OriginStringLabel.TabIndex = 0;
            this.OriginStringLabel.Text = "Origin String :";
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.AutoSize = true;
            this.EncryptLabel.Location = new System.Drawing.Point(12, 180);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(66, 15);
            this.EncryptLabel.TabIndex = 1;
            this.EncryptLabel.Text = "Encrypt :";
            // 
            // DecryptLabel
            // 
            this.DecryptLabel.AutoSize = true;
            this.DecryptLabel.Location = new System.Drawing.Point(12, 331);
            this.DecryptLabel.Name = "DecryptLabel";
            this.DecryptLabel.Size = new System.Drawing.Size(67, 15);
            this.DecryptLabel.TabIndex = 2;
            this.DecryptLabel.Text = "Decrypt :";
            // 
            // OriginStringTextBox
            // 
            this.OriginStringTextBox.Location = new System.Drawing.Point(137, 32);
            this.OriginStringTextBox.Multiline = true;
            this.OriginStringTextBox.Name = "OriginStringTextBox";
            this.OriginStringTextBox.Size = new System.Drawing.Size(509, 119);
            this.OriginStringTextBox.TabIndex = 3;
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(137, 177);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.ReadOnly = true;
            this.EncryptTextBox.Size = new System.Drawing.Size(509, 119);
            this.EncryptTextBox.TabIndex = 4;
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(137, 331);
            this.DecryptTextBox.Multiline = true;
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.ReadOnly = true;
            this.DecryptTextBox.Size = new System.Drawing.Size(509, 119);
            this.DecryptTextBox.TabIndex = 5;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(661, 32);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(127, 52);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(661, 108);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(127, 52);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // TDESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptTextBox);
            this.Controls.Add(this.EncryptTextBox);
            this.Controls.Add(this.OriginStringTextBox);
            this.Controls.Add(this.DecryptLabel);
            this.Controls.Add(this.EncryptLabel);
            this.Controls.Add(this.OriginStringLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TDESForm";
            this.Text = "TDES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginStringLabel;
        private System.Windows.Forms.Label EncryptLabel;
        private System.Windows.Forms.Label DecryptLabel;
        private System.Windows.Forms.TextBox OriginStringTextBox;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
    }
}