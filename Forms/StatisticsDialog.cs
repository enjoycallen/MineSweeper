using MineSweeper.DataStructure;

namespace MineSweeper.Dialogs
{
    internal partial class StatisticsDialog : Form
    {
        public Rankings rankings;

        public StatisticsDialog(Rankings rankings)
        {
            InitializeComponent();
            this.rankings = rankings;
        }

        private void levelListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (levelListBox.SelectedIndex)
            {
                case 0:
                    listViewLoad(rankings.Basic);
                    break;
                case 1:
                    listViewLoad(rankings.Intermidiate);
                    break;
                default:
                    listViewLoad(rankings.Advanced);
                    break;
            }
        }

        private void listViewLoad(Ranking ranking)
        {
            rankingListView.Items.Clear();
            for (int i = 0; i < ranking.Count; ++i)
            {
                var record = ranking[i];
                var subItems = rankingListView.Items.Add((i + 1).ToString()).SubItems;
                subItems.Add(record.PlayerName);
                subItems.Add(record.Time.ToString());
                subItems.Add(record.Date.ToString());
            }
        }

        private void resetButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除所有记录吗？", "扫雷-统计信息", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                rankings.Clear();
                rankingListView.Items.Clear();
                levelListBox.SelectedIndex = -1;
            }
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}