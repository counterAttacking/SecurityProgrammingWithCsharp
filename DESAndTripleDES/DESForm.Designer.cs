namespace DESAndTripleDES
{
    partial class DESForm
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
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.OrgStringLabel = new System.Windows.Forms.Label();
            this.EncryptStringLabel = new System.Windows.Forms.Label();
            this.DecryptLabel = new System.Windows.Forms.Label();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.OriginStringTextBox = new System.Windows.Forms.TextBox();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Location = new System.Drawing.Point(25, 34);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(86, 15);
            this.PrivateKeyLabel.TabIndex = 0;
            this.PrivateKeyLabel.Text = "PrivateKey :";
            // 
            // OrgStringLabel
            // 
            this.OrgStringLabel.AutoSize = true;
            this.OrgStringLabel.Location = new System.Drawing.Point(25, 99);
            this.OrgStringLabel.Name = "OrgStringLabel";
            this.OrgStringLabel.Size = new System.Drawing.Size(97, 15);
            this.OrgStringLabel.TabIndex = 1;
            this.OrgStringLabel.Text = "Origin String :";
            // 
            // EncryptStringLabel
            // 
            this.EncryptStringLabel.AutoSize = true;
            this.EncryptStringLabel.Location = new System.Drawing.Point(25, 224);
            this.EncryptStringLabel.Name = "EncryptStringLabel";
            this.EncryptStringLabel.Size = new System.Drawing.Size(66, 15);
            this.EncryptStringLabel.TabIndex = 2;
            this.EncryptStringLabel.Text = "Encrypt :";
            // 
            // DecryptLabel
            // 
            this.DecryptLabel.AutoSize = true;
            this.DecryptLabel.Location = new System.Drawing.Point(25, 353);
            this.DecryptLabel.Name = "DecryptLabel";
            this.DecryptLabel.Size = new System.Drawing.Size(67, 15);
            this.DecryptLabel.TabIndex = 3;
            this.DecryptLabel.Text = "Decrypt :";
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(129, 31);
            this.PrivateKeyTextBox.MaxLength = 8;
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(319, 25);
            this.PrivateKeyTextBox.TabIndex = 4;
            // 
            // OriginStringTextBox
            // 
            this.OriginStringTextBox.Location = new System.Drawing.Point(129, 99);
            this.OriginStringTextBox.Multiline = true;
            this.OriginStringTextBox.Name = "OriginStringTextBox";
            this.OriginStringTextBox.Size = new System.Drawing.Size(498, 106);
            this.OriginStringTextBox.TabIndex = 5;
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(129, 224);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.ReadOnly = true;
            this.EncryptTextBox.Size = new System.Drawing.Size(498, 106);
            this.EncryptTextBox.TabIndex = 6;
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(129, 353);
            this.DecryptTextBox.Multiline = true;
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.ReadOnly = true;
            this.DecryptTextBox.Size = new System.Drawing.Size(498, 106);
            this.DecryptTextBox.TabIndex = 7;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(673, 21);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(90, 40);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(673, 86);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(90, 40);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptTextBox);
            this.Controls.Add(this.EncryptTextBox);
            this.Controls.Add(this.OriginStringTextBox);
            this.Controls.Add(this.PrivateKeyTextBox);
            this.Controls.Add(this.DecryptLabel);
            this.Controls.Add(this.EncryptStringLabel);
            this.Controls.Add(this.OrgStringLabel);
            this.Controls.Add(this.PrivateKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DESForm";
            this.Text = "DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.Label OrgStringLabel;
        private System.Windows.Forms.Label EncryptStringLabel;
        private System.Windows.Forms.Label DecryptLabel;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.TextBox OriginStringTextBox;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
    }
}