namespace USB_Shield
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.workLayout = new System.Windows.Forms.Panel();
            this.bgMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnScanUSB = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgHeader = new System.Windows.Forms.PictureBox();
            this.timerForNewDrivers = new System.Windows.Forms.Timer(this.components);
            this.bgMenu.SuspendLayout();
            this.menuNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // workLayout
            // 
            this.workLayout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.workLayout.Location = new System.Drawing.Point(154, 286);
            this.workLayout.Name = "workLayout";
            this.workLayout.Size = new System.Drawing.Size(442, 221);
            this.workLayout.TabIndex = 2;
            // 
            // bgMenu
            // 
            this.bgMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bgMenu.Controls.Add(this.btnClose);
            this.bgMenu.Controls.Add(this.btnAbout);
            this.bgMenu.Controls.Add(this.btnTools);
            this.bgMenu.Controls.Add(this.btnScanUSB);
            this.bgMenu.Controls.Add(this.btnHome);
            this.bgMenu.Location = new System.Drawing.Point(1, 89);
            this.bgMenu.Name = "bgMenu";
            this.bgMenu.Size = new System.Drawing.Size(154, 221);
            this.bgMenu.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Location = new System.Drawing.Point(0, 175);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbout.Location = new System.Drawing.Point(0, 133);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(154, 36);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTools
            // 
            this.btnTools.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTools.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTools.Location = new System.Drawing.Point(0, 91);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(154, 36);
            this.btnTools.TabIndex = 2;
            this.btnTools.Text = "Tools";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnScanUSB
            // 
            this.btnScanUSB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnScanUSB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnScanUSB.Location = new System.Drawing.Point(0, 49);
            this.btnScanUSB.Name = "btnScanUSB";
            this.btnScanUSB.Size = new System.Drawing.Size(154, 36);
            this.btnScanUSB.TabIndex = 1;
            this.btnScanUSB.Text = "Scan";
            this.btnScanUSB.UseVisualStyleBackColor = true;
            this.btnScanUSB.Click += new System.EventHandler(this.btnScanUSB_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHome.Location = new System.Drawing.Point(0, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(567, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 221);
            this.panel1.TabIndex = 3;
            // 
            // notifyMain
            // 
            this.notifyMain.ContextMenuStrip = this.menuNotify;
            this.notifyMain.Text = "USB Shield";
            this.notifyMain.Visible = true;
            // 
            // menuNotify
            // 
            this.menuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.eToolStripMenuItem});
            this.menuNotify.Name = "menuNotify";
            this.menuNotify.Size = new System.Drawing.Size(108, 98);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.eToolStripMenuItem.Text = "Exit";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // imgHeader
            // 
            this.imgHeader.Image = global::USB_Shield.Properties.Resources.BG3;
            this.imgHeader.Location = new System.Drawing.Point(0, 0);
            this.imgHeader.Name = "imgHeader";
            this.imgHeader.Size = new System.Drawing.Size(588, 90);
            this.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgHeader.TabIndex = 1;
            this.imgHeader.TabStop = false;
            // 
            // timerForNewDrivers
            // 
            this.timerForNewDrivers.Enabled = true;
            this.timerForNewDrivers.Tick += new System.EventHandler(this.timerForNewDrivers_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 305);
            this.ControlBox = false;
            this.Controls.Add(this.workLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgHeader);
            this.Controls.Add(this.bgMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Shield";
            this.Load += new System.EventHandler(this.Home_Load);
            this.bgMenu.ResumeLayout(false);
            this.menuNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHeader;
        private System.Windows.Forms.Panel workLayout;
        private System.Windows.Forms.Panel bgMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnScanUSB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyMain;
        private System.Windows.Forms.ContextMenuStrip menuNotify;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.Timer timerForNewDrivers;
    }
}

