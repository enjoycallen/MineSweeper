using Resources = MineSweeper.Properties.Resources;

namespace MineSweeper.Forms
{
    partial class AboutDialog
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
            captionLabel = new Label();
            repositoryLinkLabel = new LinkLabel();
            minePictureBox = new PictureBox();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)minePictureBox).BeginInit();
            SuspendLayout();
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new Point(117, 28);
            captionLabel.Margin = new Padding(4, 0, 4, 0);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new Size(0, 17);
            captionLabel.TabIndex = 0;
            // 
            // repositoryLinkLabel
            // 
            repositoryLinkLabel.AutoSize = true;
            repositoryLinkLabel.Location = new Point(117, 160);
            repositoryLinkLabel.Margin = new Padding(4, 0, 4, 0);
            repositoryLinkLabel.Name = "repositoryLinkLabel";
            repositoryLinkLabel.Size = new Size(0, 17);
            repositoryLinkLabel.TabIndex = 2;
            repositoryLinkLabel.TabStop = true;
            repositoryLinkLabel.LinkClicked += repositoryLinkLabelClicked;
            // 
            // minePictureBox
            // 
            minePictureBox.Image = Resources.mineSweeper;
            minePictureBox.Location = new Point(23, 28);
            minePictureBox.Margin = new Padding(4);
            minePictureBox.Name = "minePictureBox";
            minePictureBox.Size = new Size(75, 75);
            minePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            minePictureBox.TabIndex = 0;
            minePictureBox.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.DialogResult = DialogResult.Cancel;
            exitButton.Location = new Point(0, 0);
            exitButton.Margin = new Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(0, 0);
            exitButton.TabIndex = 1;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButtonClick;
            // 
            // AboutDialog
            // 
            AcceptButton = exitButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(420, 208);
            Controls.Add(exitButton);
            Controls.Add(repositoryLinkLabel);
            Controls.Add(captionLabel);
            Controls.Add(minePictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "关于“扫雷”";
            ((System.ComponentModel.ISupportInitialize)minePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox minePictureBox;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.LinkLabel repositoryLinkLabel;
        private System.Windows.Forms.Button exitButton;
    }
}