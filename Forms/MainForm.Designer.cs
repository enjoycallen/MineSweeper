namespace MineSweeper
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
            游戏GToolStripMenuItem = new ToolStripMenuItem();
            新游戏NToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            统计信息ToolStripMenuItem = new ToolStripMenuItem();
            选项OToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            退出XToolStripMenuItem = new ToolStripMenuItem();
            帮助HToolStripMenuItem = new ToolStripMenuItem();
            查看帮助ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            关于AToolStripMenuItem = new ToolStripMenuItem();
            TopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.Items.AddRange(new ToolStripItem[] { 游戏GToolStripMenuItem, 帮助HToolStripMenuItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Padding = new Padding(7, 3, 0, 3);
            TopMenu.Size = new Size(317, 27);
            TopMenu.TabIndex = 1;
            TopMenu.Text = "menuStrip1";
            // 
            // 游戏GToolStripMenuItem
            // 
            游戏GToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新游戏NToolStripMenuItem, toolStripMenuItem2, 统计信息ToolStripMenuItem, 选项OToolStripMenuItem, toolStripMenuItem3, 退出XToolStripMenuItem });
            游戏GToolStripMenuItem.Name = "游戏GToolStripMenuItem";
            游戏GToolStripMenuItem.Size = new Size(61, 21);
            游戏GToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 新游戏NToolStripMenuItem
            // 
            新游戏NToolStripMenuItem.Name = "新游戏NToolStripMenuItem";
            新游戏NToolStripMenuItem.ShortcutKeys = Keys.F2;
            新游戏NToolStripMenuItem.Size = new Size(160, 22);
            新游戏NToolStripMenuItem.Text = "新游戏(&N)";
            新游戏NToolStripMenuItem.Click += 新游戏NToolStripMenuItem_Click;
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
            // 选项OToolStripMenuItem
            // 
            选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            选项OToolStripMenuItem.ShortcutKeys = Keys.F5;
            选项OToolStripMenuItem.Size = new Size(160, 22);
            选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(157, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            退出XToolStripMenuItem.ShortcutKeys = Keys.F7;
            退出XToolStripMenuItem.Size = new Size(160, 22);
            退出XToolStripMenuItem.Text = "退出(&X)";
            退出XToolStripMenuItem.Click += 退出XToolStripMenuItem_Click;
            // 
            // 帮助HToolStripMenuItem
            // 
            帮助HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 查看帮助ToolStripMenuItem, toolStripMenuItem4, 关于AToolStripMenuItem });
            帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            帮助HToolStripMenuItem.Size = new Size(61, 21);
            帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            查看帮助ToolStripMenuItem.ShortcutKeys = Keys.F1;
            查看帮助ToolStripMenuItem.Size = new Size(161, 22);
            查看帮助ToolStripMenuItem.Text = "查看帮助(&V)";
            查看帮助ToolStripMenuItem.Click += 查看帮助ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(158, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            关于AToolStripMenuItem.Size = new Size(161, 22);
            关于AToolStripMenuItem.Text = "关于(&A)";
            关于AToolStripMenuItem.Click += 关于AToolStripMenuItem_Click;
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
            Load += mainForm_Load;
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem 游戏GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新游戏NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 统计信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}