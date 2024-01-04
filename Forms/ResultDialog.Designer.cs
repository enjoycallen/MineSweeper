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
            playerNameCaptionLabel = new Label();
            dateCaptionLabel = new Label();
            timeCaptionLabel = new Label();
            winCaptionLabel = new Label();
            loseCaptionLabel = new Label();
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
            // playerNameCaptionLabel
            // 
            playerNameCaptionLabel.AutoSize = true;
            playerNameCaptionLabel.Location = new Point(35, 158);
            playerNameCaptionLabel.Margin = new Padding(4, 0, 4, 0);
            playerNameCaptionLabel.Name = "playerNameCaptionLabel";
            playerNameCaptionLabel.Size = new Size(68, 17);
            playerNameCaptionLabel.TabIndex = 6;
            playerNameCaptionLabel.Text = "玩家名称：";
            // 
            // dateCaptionLabel
            // 
            dateCaptionLabel.AutoSize = true;
            dateCaptionLabel.Location = new Point(35, 118);
            dateCaptionLabel.Margin = new Padding(4, 0, 4, 0);
            dateCaptionLabel.Name = "dateCaptionLabel";
            dateCaptionLabel.Size = new Size(44, 17);
            dateCaptionLabel.TabIndex = 7;
            dateCaptionLabel.Text = "日期：";
            // 
            // timeCaptionLabel
            // 
            timeCaptionLabel.AutoSize = true;
            timeCaptionLabel.Location = new Point(35, 78);
            timeCaptionLabel.Margin = new Padding(4, 0, 4, 0);
            timeCaptionLabel.Name = "timeCaptionLabel";
            timeCaptionLabel.Size = new Size(44, 17);
            timeCaptionLabel.TabIndex = 8;
            timeCaptionLabel.Text = "用时：";
            // 
            // winCaptionLabel
            // 
            winCaptionLabel.AutoSize = true;
            winCaptionLabel.Location = new Point(135, 35);
            winCaptionLabel.Margin = new Padding(4, 0, 4, 0);
            winCaptionLabel.Name = "winCaptionLabel";
            winCaptionLabel.Size = new Size(92, 17);
            winCaptionLabel.TabIndex = 5;
            winCaptionLabel.Text = "恭喜！您赢了！";
            winCaptionLabel.TextAlign = ContentAlignment.TopCenter;
            winCaptionLabel.Visible = false;
            // 
            // loseCaptionLabel
            // 
            loseCaptionLabel.AutoSize = true;
            loseCaptionLabel.Location = new Point(93, 35);
            loseCaptionLabel.Margin = new Padding(4, 0, 4, 0);
            loseCaptionLabel.Name = "loseCaptionLabel";
            loseCaptionLabel.Size = new Size(176, 17);
            loseCaptionLabel.TabIndex = 5;
            loseCaptionLabel.Text = "不好意思，您输了。下次走运！";
            loseCaptionLabel.TextAlign = ContentAlignment.TopCenter;
            loseCaptionLabel.Visible = false;
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
            Controls.Add(playerNameCaptionLabel);
            Controls.Add(dateCaptionLabel);
            Controls.Add(timeCaptionLabel);
            Controls.Add(loseCaptionLabel);
            Controls.Add(winCaptionLabel);
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
        private System.Windows.Forms.Label playerNameCaptionLabel;
        private System.Windows.Forms.Label dateCaptionLabel;
        private System.Windows.Forms.Label timeCaptionLabel;
        private System.Windows.Forms.Label winCaptionLabel;
        private Label loseCaptionLabel;
    }
}