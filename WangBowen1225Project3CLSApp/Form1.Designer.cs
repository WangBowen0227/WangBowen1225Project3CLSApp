﻿namespace WangBowen1225Project3CLSApp
{
    partial class frmCreative
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreative));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.optGenerateLog = new System.Windows.Forms.CheckBox();
            this.txtProcessedFile = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDest = new System.Windows.Forms.TabPage();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupEventLog = new System.Windows.Forms.GroupBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.watchDir = new System.IO.FileSystemWatcher();
            this.mnuNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabDest.SuspendLayout();
            this.groupEventLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDir)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabDest);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.optGenerateLog);
            this.tabSource.Controls.Add(this.txtProcessedFile);
            this.tabSource.Controls.Add(this.txtSource);
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.label1);
            this.tabSource.ImageIndex = 0;
            this.tabSource.Location = new System.Drawing.Point(4, 25);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(489, 307);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source options";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // optGenerateLog
            // 
            this.optGenerateLog.AutoSize = true;
            this.optGenerateLog.Location = new System.Drawing.Point(31, 158);
            this.optGenerateLog.Name = "optGenerateLog";
            this.optGenerateLog.Size = new System.Drawing.Size(333, 19);
            this.optGenerateLog.TabIndex = 4;
            this.optGenerateLog.Text = "Generate event log for bed file format";
            this.optGenerateLog.UseVisualStyleBackColor = true;
            this.optGenerateLog.CheckedChanged += new System.EventHandler(this.optGenerateLog_CheckedChanged);
            // 
            // txtProcessedFile
            // 
            this.txtProcessedFile.Location = new System.Drawing.Point(31, 112);
            this.txtProcessedFile.Name = "txtProcessedFile";
            this.txtProcessedFile.Size = new System.Drawing.Size(308, 25);
            this.txtProcessedFile.TabIndex = 3;
            this.txtProcessedFile.TextChanged += new System.EventHandler(this.txtProcessedFile_TextChanged);
            this.txtProcessedFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProcessedFile_KeyUp);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(167, 35);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(172, 25);
            this.txtSource.TabIndex = 2;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            this.txtSource.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSource_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Processing . Move Source File to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabDest
            // 
            this.tabDest.Controls.Add(this.btnViewSummary);
            this.tabDest.Controls.Add(this.btnRefresh);
            this.tabDest.Controls.Add(this.groupEventLog);
            this.tabDest.Controls.Add(this.txtDest);
            this.tabDest.Controls.Add(this.label3);
            this.tabDest.ImageIndex = 1;
            this.tabDest.Location = new System.Drawing.Point(4, 25);
            this.tabDest.Name = "tabDest";
            this.tabDest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDest.Size = new System.Drawing.Size(489, 307);
            this.tabDest.TabIndex = 1;
            this.tabDest.Text = "Destination Options";
            this.tabDest.UseVisualStyleBackColor = true;
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(192, 254);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(75, 23);
            this.btnViewSummary.TabIndex = 5;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(37, 255);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Log";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupEventLog
            // 
            this.groupEventLog.Controls.Add(this.lstEvents);
            this.groupEventLog.Location = new System.Drawing.Point(37, 62);
            this.groupEventLog.Name = "groupEventLog";
            this.groupEventLog.Size = new System.Drawing.Size(320, 186);
            this.groupEventLog.TabIndex = 3;
            this.groupEventLog.TabStop = false;
            this.groupEventLog.Text = "Event Log";
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(6, 24);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(286, 139);
            this.lstEvents.TabIndex = 2;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(209, 31);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(211, 25);
            this.txtDest.TabIndex = 1;
            this.txtDest.TextChanged += new System.EventHandler(this.txtDest_TextChanged);
            this.txtDest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDest_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination Directory";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2.JPG");
            this.imageList1.Images.SetKeyName(1, "1.JPG");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(48, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // watchDir
            // 
            this.watchDir.EnableRaisingEvents = true;
            this.watchDir.Filter = "*.doc";
            this.watchDir.SynchronizingObject = this;
            // 
            // mnuNotify
            // 
            this.mnuNotify.Text = "notifyIcon1";
            this.mnuNotify.Visible = true;
            this.mnuNotify.DoubleClick += new System.EventHandler(this.mnuNotify_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mnuConfigure,
            this.mnuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 24);
            this.toolStripMenuItem2.Text = " ";
            // 
            // mnuConfigure
            // 
            this.mnuConfigure.Name = "mnuConfigure";
            this.mnuConfigure.Size = new System.Drawing.Size(238, 24);
            this.mnuConfigure.Text = "Configure Application";
            this.mnuConfigure.Click += new System.EventHandler(this.mnuConfigure_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(238, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmCreative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCreative";
            this.Text = "Creative Learning System ";
            this.Load += new System.EventHandler(this.frmCreative_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabDest.ResumeLayout(false);
            this.tabDest.PerformLayout();
            this.groupEventLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDir)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabDest;
        private System.Windows.Forms.CheckBox optGenerateLog;
        private System.Windows.Forms.TextBox txtProcessedFile;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupEventLog;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.IO.FileSystemWatcher watchDir;
        private System.Windows.Forms.NotifyIcon mnuNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigure;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

