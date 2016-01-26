namespace HoverTreeBatch
{
    partial class HoverTreeBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoverTreeBatch));
            this.menuStrip_hoverTreeBatch = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_hoverTreeBatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_hoverTreeBatch
            // 
            this.menuStrip_hoverTreeBatch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip_hoverTreeBatch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip_hoverTreeBatch.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_hoverTreeBatch.Name = "menuStrip_hoverTreeBatch";
            this.menuStrip_hoverTreeBatch.Size = new System.Drawing.Size(701, 25);
            this.menuStrip_hoverTreeBatch.TabIndex = 2;
            this.menuStrip_hoverTreeBatch.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.mainToolStripMenuItem.Text = "菜单";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filesToolStripMenuItem.Text = "文件操作";

            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "帮助";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // HoverTreeBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoverTreeBatch.Properties.Resources.何问起批量;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(701, 377);
            this.Controls.Add(this.menuStrip_hoverTreeBatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_hoverTreeBatch;
            this.Name = "HoverTreeBatch";
            this.Text = "何问起批量";
            this.menuStrip_hoverTreeBatch.ResumeLayout(false);
            this.menuStrip_hoverTreeBatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

          


        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_hoverTreeBatch;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

