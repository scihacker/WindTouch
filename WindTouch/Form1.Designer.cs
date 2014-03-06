namespace WindTouch
{
    partial class WindTouch
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindTouch));
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.MenuList = new System.Windows.Forms.MenuStrip();
            this.SettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerialSettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DashBoardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.StatusStrip();
            this.ToolStrip_Cond = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip_Value = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuList.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp
            // 
            this.sp.BaudRate = 115200;
            this.sp.PortName = "COM3";
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // MenuList
            // 
            this.MenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingMenuItem,
            this.HelpMenuItem});
            resources.ApplyResources(this.MenuList, "MenuList");
            this.MenuList.Name = "MenuList";
            // 
            // SettingMenuItem
            // 
            this.SettingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerialSettingMenuItem,
            this.Separator1,
            this.DashBoardMenuItem,
            this.ExitMenuItem});
            this.SettingMenuItem.Name = "SettingMenuItem";
            resources.ApplyResources(this.SettingMenuItem, "SettingMenuItem");
            // 
            // SerialSettingMenuItem
            // 
            this.SerialSettingMenuItem.Name = "SerialSettingMenuItem";
            resources.ApplyResources(this.SerialSettingMenuItem, "SerialSettingMenuItem");
            this.SerialSettingMenuItem.Click += new System.EventHandler(this.SerialSettingMenuItem_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            resources.ApplyResources(this.Separator1, "Separator1");
            // 
            // DashBoardMenuItem
            // 
            this.DashBoardMenuItem.CheckOnClick = true;
            this.DashBoardMenuItem.Name = "DashBoardMenuItem";
            resources.ApplyResources(this.DashBoardMenuItem, "DashBoardMenuItem");
            this.DashBoardMenuItem.Click += new System.EventHandler(this.DashBoardMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            resources.ApplyResources(this.HelpMenuItem, "HelpMenuItem");
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            resources.ApplyResources(this.AboutMenuItem, "AboutMenuItem");
            this.AboutMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Cond,
            this.ToolStrip_Value});
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // ToolStrip_Cond
            // 
            this.ToolStrip_Cond.Name = "ToolStrip_Cond";
            resources.ApplyResources(this.ToolStrip_Cond, "ToolStrip_Cond");
            // 
            // ToolStrip_Value
            // 
            this.ToolStrip_Value.Name = "ToolStrip_Value";
            resources.ApplyResources(this.ToolStrip_Value, "ToolStrip_Value");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // WindTouch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.MenuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuList;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindTouch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindTouch_FormClosing);
            this.Load += new System.EventHandler(this.WindTouch_Load);
            this.MenuList.ResumeLayout(false);
            this.MenuList.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuList;
        private System.Windows.Forms.ToolStripMenuItem SettingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SerialSettingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        public System.Windows.Forms.ToolStripMenuItem DashBoardMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel ToolStrip_Value;
        private System.Windows.Forms.ToolStripStatusLabel ToolStrip_Cond;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.IO.Ports.SerialPort sp;
    }
}

