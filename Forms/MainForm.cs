using MineSweeper.DataStructure;
using MineSweeper.Controls;
using System.Diagnostics;

namespace MineSweeper
{
    internal partial class MainForm : Form
    {
        #region 字段
        private GameSetting setting;
        private Game game;
        private Ranking basicRanking;
        private Ranking intermidiateRanking;
        private Ranking advancedRanking;
        #endregion

        #region 属性
        public GameSetting Setting => setting;
        #endregion

        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
            
        }
        #endregion

        #region 方法
        private void loadGame()
        {
            //Size = game.Size + new Size(100, 100);
            //game.Location = new Point(40, 50);
            //Controls.Add(game);
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            //Archive.Load(this);
            loadGame();
            Size = new(400, 600);
            Game game = new(new(GameLevel.Basic));
            Size = (game as Control).Size + new Size(100, 100);
            game.Location = new(40, 50);
            Controls.Add(game);
        }
        public void NewGame()
        {
            /*if (game != null)
            {
                game.Dispose();
            }
            game = new Game(setting);
            LoadGame();*/
        }
        public void 新游戏NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Properties.Resources.helpPage);
        }
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var about = new AboutDialog())
            {
                about.ShowDialog();
            }
        }
        /*private void 统计信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var statistics = new StatisticsDialog())
            {
                statistics.ShowDialog();
            }
        }
        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var option = new OptionDialog(setting))
            {
                if (option.ShowDialog() == DialogResult.OK)
                {
                    setting = option.setting;
                    NewGame();
                }
            }
        }*/
        #endregion
    }
}
