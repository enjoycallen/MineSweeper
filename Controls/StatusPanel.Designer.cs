namespace MineSweeper.Controls
{
    partial class StatusPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timePictureBox = new PictureBox();
            minePictureBox = new PictureBox();
            timeLabel = new Label();
            remainingMineLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)timePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minePictureBox).BeginInit();
            SuspendLayout();
            // 
            // timePictureBox
            // 
            timePictureBox.Image = Properties.Resources.clockBox;
            timePictureBox.Location = new Point(0, 10);
            timePictureBox.Margin = new Padding(4);
            timePictureBox.Name = "timePictureBox";
            timePictureBox.Size = new Size(35, 35);
            timePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            timePictureBox.TabIndex = 1;
            timePictureBox.TabStop = false;
            // 
            // minePictureBox
            // 
            minePictureBox.Image = Properties.Resources.mineBox;
            minePictureBox.Location = new Point(0, 10);
            minePictureBox.Margin = new Padding(4);
            minePictureBox.Name = "minePictureBox";
            minePictureBox.Size = new Size(37, 37);
            minePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            minePictureBox.TabIndex = 2;
            minePictureBox.TabStop = false;
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.FromArgb(48, 85, 155);
            timeLabel.Font = new Font("Arial", 18F);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(40, 13);
            timeLabel.Margin = new Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(60, 30);
            timeLabel.TabIndex = 3;
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mineLabel
            // 
            remainingMineLabel.BackColor = Color.FromArgb(48, 85, 155);
            remainingMineLabel.Font = new Font("Arial", 18F);
            remainingMineLabel.ForeColor = Color.White;
            remainingMineLabel.Location = new Point(0, 13);
            remainingMineLabel.Margin = new Padding(4, 0, 4, 0);
            remainingMineLabel.Name = "mineLabel";
            remainingMineLabel.Size = new Size(60, 30);
            remainingMineLabel.TabIndex = 4;
            remainingMineLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // StatusPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(timePictureBox);
            Controls.Add(minePictureBox);
            Controls.Add(timeLabel);
            Controls.Add(remainingMineLabel);
            Margin = new Padding(4);
            Name = "StatusPanel";
            Size = new Size(175, 71);
            ((System.ComponentModel.ISupportInitialize)timePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox timePictureBox;
        private System.Windows.Forms.PictureBox minePictureBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label remainingMineLabel;
        private System.Windows.Forms.Timer timer;
    }
}
