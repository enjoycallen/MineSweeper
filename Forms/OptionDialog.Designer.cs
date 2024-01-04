namespace MineSweeper.Forms
{
    partial class OptionDialog
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
            groupBox1 = new GroupBox();
            mineCountTextBox = new TextBox();
            widthTextBox = new TextBox();
            heightTextBox = new TextBox();
            mineCountCaption = new Label();
            widthCaption = new Label();
            heightCaption = new Label();
            playerDefinedRadioButton = new RadioButton();
            advancedRadioButton = new RadioButton();
            intermediateRadioButton = new RadioButton();
            basicRadioButton = new RadioButton();
            confirmButton = new Button();
            cancelButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mineCountTextBox);
            groupBox1.Controls.Add(widthTextBox);
            groupBox1.Controls.Add(heightTextBox);
            groupBox1.Controls.Add(mineCountCaption);
            groupBox1.Controls.Add(widthCaption);
            groupBox1.Controls.Add(heightCaption);
            groupBox1.Controls.Add(playerDefinedRadioButton);
            groupBox1.Controls.Add(advancedRadioButton);
            groupBox1.Controls.Add(intermediateRadioButton);
            groupBox1.Controls.Add(basicRadioButton);
            groupBox1.Location = new Point(23, 22);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(383, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "难度";
            // 
            // mineCountTextBox
            // 
            mineCountTextBox.Enabled = false;
            mineCountTextBox.Location = new Point(282, 159);
            mineCountTextBox.Margin = new Padding(4);
            mineCountTextBox.MaxLength = 3;
            mineCountTextBox.Name = "mineCountTextBox";
            mineCountTextBox.Size = new Size(80, 23);
            mineCountTextBox.TabIndex = 10;
            mineCountTextBox.KeyPress += textBoxKeyPress;
            // 
            // widthTextBox
            // 
            widthTextBox.Enabled = false;
            widthTextBox.Location = new Point(282, 115);
            widthTextBox.Margin = new Padding(4);
            widthTextBox.MaxLength = 2;
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(80, 23);
            widthTextBox.TabIndex = 8;
            widthTextBox.KeyPress += textBoxKeyPress;
            // 
            // heightTextBox
            // 
            heightTextBox.Enabled = false;
            heightTextBox.Location = new Point(282, 71);
            heightTextBox.Margin = new Padding(4);
            heightTextBox.MaxLength = 2;
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(80, 23);
            heightTextBox.TabIndex = 6;
            heightTextBox.KeyPress += textBoxKeyPress;
            // 
            // mineCountCaption
            // 
            mineCountCaption.AutoSize = true;
            mineCountCaption.Location = new Point(188, 162);
            mineCountCaption.Margin = new Padding(4, 0, 4, 0);
            mineCountCaption.Name = "mineCountCaption";
            mineCountCaption.Size = new Size(82, 17);
            mineCountCaption.TabIndex = 9;
            mineCountCaption.Text = "雷数(10-)(&M):";
            // 
            // widthCaption
            // 
            widthCaption.AutoSize = true;
            widthCaption.Location = new Point(188, 118);
            widthCaption.Margin = new Padding(4, 0, 4, 0);
            widthCaption.Name = "widthCaption";
            widthCaption.Size = new Size(89, 17);
            widthCaption.TabIndex = 7;
            widthCaption.Text = "宽度(9-30)(&W):";
            // 
            // heightCaption
            // 
            heightCaption.AutoSize = true;
            heightCaption.Location = new Point(188, 74);
            heightCaption.Margin = new Padding(4, 0, 4, 0);
            heightCaption.Name = "heightCaption";
            heightCaption.Size = new Size(86, 17);
            heightCaption.TabIndex = 5;
            heightCaption.Text = "高度(9-24)(&H):";
            // 
            // playerDefinedRadioButton
            // 
            playerDefinedRadioButton.AutoSize = true;
            playerDefinedRadioButton.Location = new Point(192, 36);
            playerDefinedRadioButton.Margin = new Padding(4);
            playerDefinedRadioButton.Name = "playerDefinedRadioButton";
            playerDefinedRadioButton.Size = new Size(79, 21);
            playerDefinedRadioButton.TabIndex = 4;
            playerDefinedRadioButton.TabStop = true;
            playerDefinedRadioButton.Text = "自定义(&U)";
            playerDefinedRadioButton.UseVisualStyleBackColor = true;
            playerDefinedRadioButton.CheckedChanged += playerDefinedRadioButtonCheckedChanged;
            // 
            // advancedRadioButton
            // 
            advancedRadioButton.AutoSize = true;
            advancedRadioButton.Location = new Point(18, 162);
            advancedRadioButton.Margin = new Padding(4);
            advancedRadioButton.Name = "advancedRadioButton";
            advancedRadioButton.Size = new Size(111, 55);
            advancedRadioButton.TabIndex = 3;
            advancedRadioButton.TabStop = true;
            advancedRadioButton.Text = "高级(&V)\r\n99个雷\r\n16×30平铺网格";
            advancedRadioButton.UseVisualStyleBackColor = true;
            // 
            // intermediateRadioButton
            // 
            intermediateRadioButton.AutoSize = true;
            intermediateRadioButton.Location = new Point(18, 99);
            intermediateRadioButton.Margin = new Padding(4);
            intermediateRadioButton.Name = "intermediateRadioButton";
            intermediateRadioButton.Size = new Size(111, 55);
            intermediateRadioButton.TabIndex = 2;
            intermediateRadioButton.TabStop = true;
            intermediateRadioButton.Text = "中级(&I)\r\n40个雷\r\n16×16平铺网格";
            intermediateRadioButton.UseVisualStyleBackColor = true;
            // 
            // basicRadioButton
            // 
            basicRadioButton.AutoSize = true;
            basicRadioButton.Location = new Point(18, 36);
            basicRadioButton.Margin = new Padding(4);
            basicRadioButton.Name = "basicRadioButton";
            basicRadioButton.Size = new Size(97, 55);
            basicRadioButton.TabIndex = 1;
            basicRadioButton.TabStop = true;
            basicRadioButton.Text = "初级(&B)\r\n10个雷\r\n9×9平铺网格";
            basicRadioButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(129, 269);
            confirmButton.Margin = new Padding(4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(120, 40);
            confirmButton.TabIndex = 11;
            confirmButton.Text = "确定";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButtonClick;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(286, 269);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 40);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "取消";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButtonClick;
            // 
            // OptionDialog
            // 
            AcceptButton = confirmButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(425, 324);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OptionDialog";
            Text = "选项";
            FormClosing += optionFormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton advancedRadioButton;
        private System.Windows.Forms.RadioButton intermediateRadioButton;
        private System.Windows.Forms.RadioButton basicRadioButton;
        private System.Windows.Forms.RadioButton playerDefinedRadioButton;
        private System.Windows.Forms.TextBox mineCountTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label mineCountCaption;
        private System.Windows.Forms.Label widthCaption;
        private System.Windows.Forms.Label heightCaption;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}