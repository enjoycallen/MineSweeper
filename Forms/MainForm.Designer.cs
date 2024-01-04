namespace MineSweeper.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TopMenu = new MenuStrip();
            游戏ToolStripMenuItem = new ToolStripMenuItem();
            新游戏ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            统计信息ToolStripMenuItem = new ToolStripMenuItem();
            选项ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            查看帮助ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            TopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.Items.AddRange(new ToolStripItem[] { 游戏ToolStripMenuItem, 帮助ToolStripMenuItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Padding = new Padding(7, 3, 0, 3);
            TopMenu.Size = new Size(317, 27);
            TopMenu.TabIndex = 1;
            TopMenu.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            游戏ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新游戏ToolStripMenuItem, toolStripMenuItem2, 统计信息ToolStripMenuItem, 选项ToolStripMenuItem, toolStripMenuItem3, 退出ToolStripMenuItem });
            游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            游戏ToolStripMenuItem.Size = new Size(61, 21);
            游戏ToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 新游戏ToolStripMenuItem
            // 
            新游戏ToolStripMenuItem.Name = "新游戏ToolStripMenuItem";
            新游戏ToolStripMenuItem.ShortcutKeys = Keys.F2;
            新游戏ToolStripMenuItem.Size = new Size(160, 22);
            新游戏ToolStripMenuItem.Text = "新游戏(&N)";
            新游戏ToolStripMenuItem.Click += 新游戏ToolStripMenuItemClick;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(157, 6);
            // 
            // 统计信息ToolStripMenuItem
            // 
            统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            统计信息ToolStripMenuItem.ShortcutKeys = Keys.F4;
            统计信息ToolStripMenuItem.Size = new Size(160, 22);
            统计信息ToolStripMenuItem.Text = "统计信息(&S)";
            // 
            // 选项ToolStripMenuItem
            // 
            选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            选项ToolStripMenuItem.ShortcutKeys = Keys.F5;
            选项ToolStripMenuItem.Size = new Size(160, 22);
            选项ToolStripMenuItem.Text = "选项(&O)";
            选项ToolStripMenuItem.Click += 选项OToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(157, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.ShortcutKeys = Keys.F7;
            退出ToolStripMenuItem.Size = new Size(160, 22);
            退出ToolStripMenuItem.Text = "退出(&X)";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItemClick;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 查看帮助ToolStripMenuItem, toolStripMenuItem4, 关于ToolStripMenuItem });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(61, 21);
            帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            查看帮助ToolStripMenuItem.ShortcutKeys = Keys.F1;
            查看帮助ToolStripMenuItem.Size = new Size(161, 22);
            查看帮助ToolStripMenuItem.Text = "查看帮助(&V)";
            查看帮助ToolStripMenuItem.Click += 查看帮助ToolStripMenuItemClick;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(158, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(161, 22);
            关于ToolStripMenuItem.Text = "关于(&A)";
            关于ToolStripMenuItem.Click += 关于AToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 170, 199);
            ClientSize = new Size(317, 345);
            Controls.Add(TopMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "扫雷";
            FormClosing += mainFormClosing;
            Load += mainFormLoad;
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 统计信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}