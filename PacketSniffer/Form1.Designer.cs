namespace PacketSniffer
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblIp = new System.Windows.Forms.ToolStripLabel();
            this.tscbIp = new System.Windows.Forms.ToolStripComboBox();
            this.tslblNum = new System.Windows.Forms.ToolStripLabel();
            this.tscbNum = new System.Windows.Forms.ToolStripComboBox();
            this.ReceivedPacketListView = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProtocl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacketDetailTreeView = new System.Windows.Forms.TreeView();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.tsbtnStop,
            this.toolStripSeparator1,
            this.tslblIp,
            this.tscbIp,
            this.tslblNum,
            this.tscbNum});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.MinimumSize = new System.Drawing.Size(0, 35);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1146, 35);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "tsManu";
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(24, 32);
            this.tsbtnStart.Text = "Start";
            this.tsbtnStart.Click += new System.EventHandler(this.tsbtnStart_Click);
            // 
            // tsbtnStop
            // 
            this.tsbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStop.Enabled = false;
            this.tsbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStop.Image")));
            this.tsbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStop.Name = "tsbtnStop";
            this.tsbtnStop.Size = new System.Drawing.Size(24, 32);
            this.tsbtnStop.Text = "Stop";
            this.tsbtnStop.Click += new System.EventHandler(this.tsbtnStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tslblIp
            // 
            this.tslblIp.Name = "tslblIp";
            this.tslblIp.Size = new System.Drawing.Size(105, 32);
            this.tslblIp.Text = "Select IP Addr";
            // 
            // tscbIp
            // 
            this.tscbIp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbIp.Name = "tscbIp";
            this.tscbIp.Size = new System.Drawing.Size(285, 35);
            // 
            // tslblNum
            // 
            this.tslblNum.Name = "tslblNum";
            this.tslblNum.Size = new System.Drawing.Size(92, 32);
            this.tslblNum.Text = "Packet Num";
            // 
            // tscbNum
            // 
            this.tscbNum.Items.AddRange(new object[] {
            "100",
            "300",
            "400",
            "500",
            "1000"});
            this.tscbNum.Name = "tscbNum";
            this.tscbNum.Size = new System.Drawing.Size(91, 35);
            // 
            // ReceivedPacketListView
            // 
            this.ReceivedPacketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderTime,
            this.columnHeaderSource,
            this.columnHeaderDest,
            this.columnHeaderProtocl,
            this.columnHeaderPack});
            this.ReceivedPacketListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReceivedPacketListView.FullRowSelect = true;
            this.ReceivedPacketListView.GridLines = true;
            this.ReceivedPacketListView.HideSelection = false;
            this.ReceivedPacketListView.Location = new System.Drawing.Point(0, 35);
            this.ReceivedPacketListView.Name = "ReceivedPacketListView";
            this.ReceivedPacketListView.Size = new System.Drawing.Size(1146, 281);
            this.ReceivedPacketListView.TabIndex = 4;
            this.ReceivedPacketListView.UseCompatibleStateImageBehavior = false;
            this.ReceivedPacketListView.View = System.Windows.Forms.View.Details;
            this.ReceivedPacketListView.Click += new System.EventHandler(this.ReceivedPacketListView_Click);
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No.";
            this.columnHeaderNo.Width = 80;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 200;
            // 
            // columnHeaderSource
            // 
            this.columnHeaderSource.Text = "Source";
            this.columnHeaderSource.Width = 200;
            // 
            // columnHeaderDest
            // 
            this.columnHeaderDest.Text = "Destination";
            this.columnHeaderDest.Width = 200;
            // 
            // columnHeaderProtocl
            // 
            this.columnHeaderProtocl.Text = "Protocol";
            this.columnHeaderProtocl.Width = 120;
            // 
            // columnHeaderPack
            // 
            this.columnHeaderPack.Text = "Package Size";
            this.columnHeaderPack.Width = 120;
            // 
            // PacketDetailTreeView
            // 
            this.PacketDetailTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PacketDetailTreeView.Location = new System.Drawing.Point(0, 316);
            this.PacketDetailTreeView.Name = "PacketDetailTreeView";
            this.PacketDetailTreeView.Size = new System.Drawing.Size(1146, 241);
            this.PacketDetailTreeView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 557);
            this.Controls.Add(this.PacketDetailTreeView);
            this.Controls.Add(this.ReceivedPacketListView);
            this.Controls.Add(this.tsMenu);
            this.Name = "Form1";
            this.Text = "Packet Sniffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton tsbtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblIp;
        private System.Windows.Forms.ToolStripComboBox tscbIp;
        private System.Windows.Forms.ToolStripLabel tslblNum;
        private System.Windows.Forms.ToolStripComboBox tscbNum;
        private System.Windows.Forms.ListView ReceivedPacketListView;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderSource;
        private System.Windows.Forms.ColumnHeader columnHeaderDest;
        private System.Windows.Forms.ColumnHeader columnHeaderProtocl;
        private System.Windows.Forms.ColumnHeader columnHeaderPack;
        private System.Windows.Forms.TreeView PacketDetailTreeView;
    }
}

