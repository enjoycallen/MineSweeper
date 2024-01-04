using MineSweeper.DataStructure;

namespace MineSweeper.Dialogs
{
    internal partial class ResultDialog : Form
    {
        #region 构造函数
        public ResultDialog() => InitializeComponent();
        #endregion

        #region 方法
        public Record ShowDialog(ResultDialogMode mode, int time)
        {
            var date = DateTime.Now;
            (mode == ResultDialogMode.Lose ? loseCaption : winCaption).Visible = true;
            timeLabel.Text = time + " 秒";
            dateLabel.Text = date.ToString();
            playerNameCaption.Visible = playerNameTextBox.Visible = mode == ResultDialogMode.Record;
            ShowDialog();
            return mode == ResultDialogMode.Record ? new Record(playerNameTextBox.Text, time, date) : default;
        }

        private void exitButtonClick(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void replayButtonClick(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        private void resultDialogFormClosing(object sender, FormClosingEventArgs e)
        {
            if (playerNameTextBox.Visible && playerNameTextBox.Text == "")
            {
                MessageBox.Show("玩家名称不能为空！", "扫雷", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }
        #endregion
    }
}