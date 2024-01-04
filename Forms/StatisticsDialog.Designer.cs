namespace MineSweeper.Dialogs
{
    partial class StatisticsDialog
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
            levelListBox = new ListBox();
            rankingGroupBox = new GroupBox();
            resetButton = new Button();
            rankingListView = new ListView();
            Rank = new ColumnHeader();
            PlayerName = new ColumnHeader();
            Time = new ColumnHeader();
            Date = new ColumnHeader();
            exitButton = new Button();
            rankingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // levelListBox
            // 
            levelListBox.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            levelListBox.FormattingEnabled = true;
            levelListBox.ItemHeight = 14;
            levelListBox.Items.AddRange(new object[] { "初级", "中级", "高级" });
            levelListBox.Location = new Point(19, 33);
            levelListBox.Margin = new Padding(4);
            levelListBox.Name = "levelListBox";
            levelListBox.Size = new Size(130, 74);
            levelListBox.TabIndex = 0;
            levelListBox.SelectedIndexChanged += levelListBoxSelectedIndexChanged;
            // 
            // rankingGroupBox
            // 
            rankingGroupBox.Controls.Add(resetButton);
            rankingGroupBox.Controls.Add(rankingListView);
            rankingGroupBox.Controls.Add(levelListBox);
            rankingGroupBox.Location = new Point(13, 13);
            rankingGroupBox.Margin = new Padding(4);
            rankingGroupBox.Name = "rankingGroupBox";
            rankingGroupBox.Padding = new Padding(4);
            rankingGroupBox.Size = new Size(617, 175);
            rankingGroupBox.TabIndex = 1;
            rankingGroupBox.TabStop = false;
            rankingGroupBox.Text = "排行榜";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(32, 125);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(105, 33);
            resetButton.TabIndex = 4;
            resetButton.Text = "重置";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButtonClick;
            // 
            // rankingListView
            // 
            rankingListView.Columns.AddRange(new ColumnHeader[] { Rank, PlayerName, Time, Date });
            rankingListView.Location = new Point(180, 23);
            rankingListView.Name = "rankingListView";
            rankingListView.Size = new Size(424, 135);
            rankingListView.TabIndex = 3;
            rankingListView.UseCompatibleStateImageBehavior = false;
            rankingListView.View = View.Details;
            // 
            // Rank
            // 
            Rank.Text = "排名";
            Rank.Width = 40;
            // 
            // PlayerName
            // 
            PlayerName.Text = "玩家名称";
            PlayerName.Width = 150;
            // 
            // Time
            // 
            Time.Text = "用时(秒)";
            Time.Width = 80;
            // 
            // Date
            // 
            Date.Text = "登记日期";
            Date.Width = 150;
            // 
            // exitButton
            // 
            exitButton.DialogResult = DialogResult.Cancel;
            exitButton.Location = new Point(0, 0);
            exitButton.Margin = new Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(0, 0);
            exitButton.TabIndex = 2;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButtonClick;
            // 
            // StatisticsDialog
            // 
            AcceptButton = exitButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(641, 200);
            Controls.Add(exitButton);
            Controls.Add(rankingGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StatisticsDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "统计信息";
            rankingGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox levelListBox;
        private System.Windows.Forms.GroupBox rankingGroupBox;
        private ListView rankingListView;
        private ColumnHeader Rank;
        private ColumnHeader PlayerName;
        private ColumnHeader Time;
        private ColumnHeader Date;
        private Button resetButton;
        private Button exitButton;
    }
}