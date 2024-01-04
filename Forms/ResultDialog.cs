using MineSweeper.DataStructure;

namespace MineSweeper.Dialogs
{
    internal partial class ResultDialog : Form
    {
        #region 字段
        private Record record;
        #endregion

        #region 属性
        public Record Record => record;
        #endregion

        #region 构造函数
        public ResultDialog(ResultDialogMode mode, int time)
        {
            InitializeComponent();
            record.Time = time;
            record.Date = DateTime.Now;
            (mode == ResultDialogMode.Lose ? loseCaptionLabel : winCaptionLabel).Visible = true;
            timeLabel.Text = time + " 秒";
            dateLabel.Text = record.Date.ToString();
            playerNameCaptionLabel.Visible = playerNameTextBox.Visible = mode == ResultDialogMode.Record;
        }
        #endregion

        #region 方法
        private void exitButtonClick(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void replayButtonClick(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        private void resultDialogFormClosing(object sender, FormClosingEventArgs e)
        {
            if (playerNameTextBox.Visible && playerNameTextBox.Text == "")
            {
                MessageBox.Show("玩家名称不能为空！", "扫雷", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            else
            {
                record.PlayerName = playerNameTextBox.Text;
            }
        }
        #endregion
    }
}