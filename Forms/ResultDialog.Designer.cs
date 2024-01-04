namespace MineSweeper.Dialogs
{
    partial class ResultDialog
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
            dateLabel = new Label();
            timeLabel = new Label();
            replayButton = new Button();
            exitButton = new Button();
            playerNameTextBox = new TextBox();
            playerNameCaption = new Label();
            dateCaption = new Label();
            timeCaption = new Label();
            winCaption = new Label();
            loseCaption = new Label();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(102, 118);
            dateLabel.Margin = new Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(0, 17);
            dateLabel.TabIndex = 12;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(102, 78);
            timeLabel.Margin = new Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 17);
            timeLabel.TabIndex = 13;
            // 
            // replayButton
            // 
            replayButton.DialogResult = DialogResult.Cancel;
            replayButton.Location = new Point(178, 209);
            replayButton.Margin = new Padding(4);
            replayButton.Name = "replayButton";
            replayButton.Size = new Size(110, 29);
            replayButton.TabIndex = 10;
            replayButton.Text = "再玩一局(&P)";
            replayButton.UseVisualStyleBackColor = true;
            replayButton.Click += replayButtonClick;
            // 
            // exitButton
            // 
            exitButton.DialogResult = DialogResult.Cancel;
            exitButton.Location = new Point(35, 209);
            exitButton.Margin = new Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(110, 29);
            exitButton.TabIndex = 11;
            exitButton.Text = "退出(&X)";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButtonClick;
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(102, 155);
            playerNameTextBox.Margin = new Padding(4);
            playerNameTextBox.MaxLength = 16;
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(186, 23);
            playerNameTextBox.TabIndex = 9;
            // 
            // playerNameCaption
            // 
            playerNameCaption.AutoSize = true;
            playerNameCaption.Location = new Point(35, 158);
            playerNameCaption.Margin = new Padding(4, 0, 4, 0);
            playerNameCaption.Name = "playerNameCaption";
            playerNameCaption.Size = new Size(68, 17);
            playerNameCaption.TabIndex = 6;
            playerNameCaption.Text = "玩家名称：";
            // 
            // dateCaption
            // 
            dateCaption.AutoSize = true;
            dateCaption.Location = new Point(35, 118);
            dateCaption.Margin = new Padding(4, 0, 4, 0);
            dateCaption.Name = "dateCaption";
            dateCaption.Size = new Size(44, 17);
            dateCaption.TabIndex = 7;
            dateCaption.Text = "日期：";
            // 
            // timeCaption
            // 
            timeCaption.AutoSize = true;
            timeCaption.Location = new Point(35, 78);
            timeCaption.Margin = new Padding(4, 0, 4, 0);
            timeCaption.Name = "timeCaption";
            timeCaption.Size = new Size(44, 17);
            timeCaption.TabIndex = 8;
            timeCaption.Text = "用时：";
            // 
            // winCaption
            // 
            winCaption.AutoSize = true;
            winCaption.Location = new Point(135, 35);
            winCaption.Margin = new Padding(4, 0, 4, 0);
            winCaption.Name = "winCaption";
            winCaption.Size = new Size(92, 17);
            winCaption.TabIndex = 5;
            winCaption.Text = "恭喜！您赢了！";
            winCaption.TextAlign = ContentAlignment.TopCenter;
            winCaption.Visible = false;
            // 
            // loseCaption
            // 
            loseCaption.AutoSize = true;
            loseCaption.Location = new Point(93, 35);
            loseCaption.Margin = new Padding(4, 0, 4, 0);
            loseCaption.Name = "loseCaption";
            loseCaption.Size = new Size(176, 17);
            loseCaption.TabIndex = 5;
            loseCaption.Text = "不好意思，您输了。下次走运！";
            loseCaption.TextAlign = ContentAlignment.TopCenter;
            loseCaption.Visible = false;
            // 
            // ResultDialog
            // 
            AcceptButton = replayButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = replayButton;
            ClientSize = new Size(335, 263);
            Controls.Add(dateLabel);
            Controls.Add(timeLabel);
            Controls.Add(replayButton);
            Controls.Add(exitButton);
            Controls.Add(playerNameTextBox);
            Controls.Add(playerNameCaption);
            Controls.Add(dateCaption);
            Controls.Add(timeCaption);
            Controls.Add(loseCaption);
            Controls.Add(winCaption);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResultDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "游戏胜利";
            FormClosing += resultDialogFormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameCaption;
        private System.Windows.Forms.Label dateCaption;
        private System.Windows.Forms.Label timeCaption;
        private System.Windows.Forms.Label winCaption;
        private Label loseCaption;
    }
}