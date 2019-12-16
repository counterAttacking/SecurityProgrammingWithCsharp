namespace KeyAuthentication
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox01 = new System.Windows.Forms.TextBox();
            this.KeyTextBox02 = new System.Windows.Forms.TextBox();
            this.KeyTextBox03 = new System.Windows.Forms.TextBox();
            this.KeyTextBox04 = new System.Windows.Forms.TextBox();
            this.KeyTextBox05 = new System.Windows.Forms.TextBox();
            this.BarLabel01 = new System.Windows.Forms.Label();
            this.BarLabel02 = new System.Windows.Forms.Label();
            this.BarLabel03 = new System.Windows.Forms.Label();
            this.BarLabel04 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(26, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "UserName :";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(115, 41);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(579, 25);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // KeyTextBox01
            // 
            this.KeyTextBox01.Location = new System.Drawing.Point(29, 104);
            this.KeyTextBox01.Name = "KeyTextBox01";
            this.KeyTextBox01.Size = new System.Drawing.Size(95, 25);
            this.KeyTextBox01.TabIndex = 2;
            this.KeyTextBox01.TextChanged += new System.EventHandler(this.KeyTextBox01_TextChanged);
            // 
            // KeyTextBox02
            // 
            this.KeyTextBox02.Location = new System.Drawing.Point(170, 104);
            this.KeyTextBox02.Name = "KeyTextBox02";
            this.KeyTextBox02.Size = new System.Drawing.Size(95, 25);
            this.KeyTextBox02.TabIndex = 3;
            this.KeyTextBox02.TextChanged += new System.EventHandler(this.KeyTextBox02_TextChanged);
            // 
            // KeyTextBox03
            // 
            this.KeyTextBox03.Location = new System.Drawing.Point(310, 104);
            this.KeyTextBox03.Name = "KeyTextBox03";
            this.KeyTextBox03.Size = new System.Drawing.Size(95, 25);
            this.KeyTextBox03.TabIndex = 4;
            this.KeyTextBox03.TextChanged += new System.EventHandler(this.KeyTextBox03_TextChanged);
            // 
            // KeyTextBox04
            // 
            this.KeyTextBox04.Location = new System.Drawing.Point(459, 104);
            this.KeyTextBox04.Name = "KeyTextBox04";
            this.KeyTextBox04.Size = new System.Drawing.Size(95, 25);
            this.KeyTextBox04.TabIndex = 5;
            this.KeyTextBox04.TextChanged += new System.EventHandler(this.KeyTextBox04_TextChanged);
            // 
            // KeyTextBox05
            // 
            this.KeyTextBox05.Location = new System.Drawing.Point(599, 104);
            this.KeyTextBox05.Name = "KeyTextBox05";
            this.KeyTextBox05.Size = new System.Drawing.Size(95, 25);
            this.KeyTextBox05.TabIndex = 6;
            this.KeyTextBox05.TextChanged += new System.EventHandler(this.KeyTextBox05_TextChanged);
            // 
            // BarLabel01
            // 
            this.BarLabel01.AutoSize = true;
            this.BarLabel01.Location = new System.Drawing.Point(140, 107);
            this.BarLabel01.Name = "BarLabel01";
            this.BarLabel01.Size = new System.Drawing.Size(15, 15);
            this.BarLabel01.TabIndex = 7;
            this.BarLabel01.Text = "-";
            // 
            // BarLabel02
            // 
            this.BarLabel02.AutoSize = true;
            this.BarLabel02.Location = new System.Drawing.Point(280, 107);
            this.BarLabel02.Name = "BarLabel02";
            this.BarLabel02.Size = new System.Drawing.Size(15, 15);
            this.BarLabel02.TabIndex = 8;
            this.BarLabel02.Text = "-";
            // 
            // BarLabel03
            // 
            this.BarLabel03.AutoSize = true;
            this.BarLabel03.Location = new System.Drawing.Point(426, 107);
            this.BarLabel03.Name = "BarLabel03";
            this.BarLabel03.Size = new System.Drawing.Size(15, 15);
            this.BarLabel03.TabIndex = 9;
            this.BarLabel03.Text = "-";
            // 
            // BarLabel04
            // 
            this.BarLabel04.AutoSize = true;
            this.BarLabel04.Location = new System.Drawing.Point(569, 107);
            this.BarLabel04.Name = "BarLabel04";
            this.BarLabel04.Size = new System.Drawing.Size(15, 15);
            this.BarLabel04.TabIndex = 10;
            this.BarLabel04.Text = "-";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Red;
            this.ResultLabel.Location = new System.Drawing.Point(26, 175);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(56, 17);
            this.ResultLabel.TabIndex = 11;
            this.ResultLabel.Text = "결과 :";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(586, 165);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(108, 35);
            this.AuthButton.TabIndex = 12;
            this.AuthButton.Text = "입력";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 221);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BarLabel04);
            this.Controls.Add(this.BarLabel03);
            this.Controls.Add(this.BarLabel02);
            this.Controls.Add(this.BarLabel01);
            this.Controls.Add(this.KeyTextBox05);
            this.Controls.Add(this.KeyTextBox04);
            this.Controls.Add(this.KeyTextBox03);
            this.Controls.Add(this.KeyTextBox02);
            this.Controls.Add(this.KeyTextBox01);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CD Key 입력";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox KeyTextBox01;
        private System.Windows.Forms.TextBox KeyTextBox02;
        private System.Windows.Forms.TextBox KeyTextBox03;
        private System.Windows.Forms.TextBox KeyTextBox04;
        private System.Windows.Forms.TextBox KeyTextBox05;
        private System.Windows.Forms.Label BarLabel01;
        private System.Windows.Forms.Label BarLabel02;
        private System.Windows.Forms.Label BarLabel03;
        private System.Windows.Forms.Label BarLabel04;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button AuthButton;
    }
}

