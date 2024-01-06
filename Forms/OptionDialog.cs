using MineSweeper.DataStructure;

namespace MineSweeper.Forms
{
    internal partial class OptionDialog : Form
    {
        #region 字段
        private GameSetting setting;
        #endregion

        #region 属性
        public GameSetting Setting => setting;
        #endregion

        #region 构造函数
        public OptionDialog(GameSetting setting)
        {
            InitializeComponent();
            this.setting = setting;
            if (setting.Level == GameLevel.Basic)
            {
                basicRadioButton.Checked = true;
            }
            else if (setting.Level == GameLevel.Intermidiate)
            {
                intermediateRadioButton.Checked = true;
            }
            else if (setting.Level == GameLevel.Advanced)
            {
                advancedRadioButton.Checked = true;
            }
            else
            {
                playerDefinedRadioButton.Checked = true;
                heightTextBox.Text = setting.Row.ToString();
                widthTextBox.Text = setting.Column.ToString();
                mineCountTextBox.Text = setting.MineCount.ToString();
            }
        }
        #endregion

        #region 方法
        private void playerDefinedRadioButtonCheckedChanged(object sender, EventArgs e) =>
            heightTextBox.Enabled = widthTextBox.Enabled = mineCountTextBox.Enabled = playerDefinedRadioButton.Checked;

        private void textBoxKeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;

        private void confirmButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void optionFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel) return;
            if (basicRadioButton.Checked)
            {
                setting = new(GameLevel.Basic);
            }
            else if (intermediateRadioButton.Checked)
            {
                setting = new(GameLevel.Intermidiate);
            }
            else if (advancedRadioButton.Checked)
            {
                setting = new(GameLevel.Advanced);
            }
            else
            {
                static int StringToInt(string s) { return s == "" ? 0 : int.Parse(s); }
                int row = StringToInt(heightTextBox.Text);
                int column = StringToInt(widthTextBox.Text);
                int mineCount = StringToInt(mineCountTextBox.Text);
                if (row < 9 || row > 24)
                {
                    MessageBox.Show("高度必须在9-24之间！", "扫雷-选项", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
                else if (column < 9 || column > 30)
                {
                    MessageBox.Show("宽度必须在9-24之间！", "扫雷-选项", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
                else if (mineCount < 10 || mineCount > 0.85 * row * column)
                {
                    MessageBox.Show("雷数必须在10-" + (int)(0.85 * row * column) + "之间！", "扫雷-选项", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
                else
                {
                    setting = new((row, column), mineCount);
                }
            }
        }
        #endregion
    }
}