﻿/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 15/09/2014
 * Time: 19:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ADBC2
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SqlExport = new System.Windows.Forms.ToolStripMenuItem();
            this.IdaExport = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContentListView = new BrightIdeasSoftware.FastObjectListView();
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentListView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientVersionToolStripMenuItem,
            this.LoadFile,
            this.SqlExport,
            this.IdaExport,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientVersionToolStripMenuItem
            // 
            this.clientVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.clientVersionToolStripMenuItem.Name = "clientVersionToolStripMenuItem";
            this.clientVersionToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.clientVersionToolStripMenuItem.Text = "Client version";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem2.Tag = "12340";
            this.toolStripMenuItem2.Text = "3.3.5.12340";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.OnBuildSelection);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem3.Tag = "15595";
            this.toolStripMenuItem3.Text = "4.3.4.15595";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.OnBuildSelection);
            // 
            // LoadFile
            // 
            this.LoadFile.Enabled = false;
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(64, 20);
            this.LoadFile.Text = "Load file";
            this.LoadFile.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnFileSelected);
            // 
            // SqlExport
            // 
            this.SqlExport.Enabled = false;
            this.SqlExport.Name = "SqlExport";
            this.SqlExport.Size = new System.Drawing.Size(90, 20);
            this.SqlExport.Text = "Export as SQL";
            this.SqlExport.Click += new System.EventHandler(this.ToSQL);
            // 
            // IdaExport
            // 
            this.IdaExport.Enabled = false;
            this.IdaExport.Name = "IdaExport";
            this.IdaExport.Size = new System.Drawing.Size(138, 20);
            this.IdaExport.Text = "Export structure to IDA";
            this.IdaExport.Click += new System.EventHandler(this.ToIDA);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.ShowHelp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(913, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ContentListView
            // 
            this.ContentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentListView.GridLines = true;
            this.ContentListView.HeaderWordWrap = true;
            this.ContentListView.IncludeColumnHeadersInCopy = true;
            this.ContentListView.Location = new System.Drawing.Point(0, 28);
            this.ContentListView.Name = "ContentListView";
            this.ContentListView.ShowCommandMenuOnRightClick = true;
            this.ContentListView.ShowGroups = false;
            this.ContentListView.Size = new System.Drawing.Size(913, 314);
            this.ContentListView.TabIndex = 3;
            this.ContentListView.UseCompatibleStateImageBehavior = false;
            this.ContentListView.View = System.Windows.Forms.View.Details;
            this.ContentListView.VirtualMode = true;
            this.ContentListView.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.OnCellEditStart);
            this.ContentListView.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.OnTooltipShow);
            this.ContentListView.Click += new System.EventHandler(this.OnSingleClick);
            this.ContentListView.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // hotItemStyle1
            // 
            this.hotItemStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 367);
            this.Controls.Add(this.ContentListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ADBC2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem IdaExport;
        private System.Windows.Forms.ToolStripMenuItem SqlExport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private BrightIdeasSoftware.FastObjectListView ContentListView;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
    }
}
