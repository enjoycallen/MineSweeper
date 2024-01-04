using MineSweeper.Controls;
using MineSweeper.DataStructure;
using MineSweeper.Dialogs;
using System.Diagnostics;
using System.Media;
using Resources = MineSweeper.Properties.Resources;

namespace MineSweeper.Forms
{
    internal partial class MainForm : Form, IData
    {
        #region 字段
        private GameSetting setting;
        private Game game;
        private Rankings rankings = new();
        #endregion

        #region 属性
        public GameLevel Level => setting.Level;

        public int Time => game.Time;
        #endregion

        #region 构造函数
        public MainForm() => InitializeComponent();
        #endregion

        #region 方法
        private void loadGame()
        {
            Size = (game as Control).Size + new Size(100, 100);
            game.Location = new(40, 50);
            Controls.Add(game);
        }

        private void mainFormLoad(object sender, EventArgs e)
        {
            if (File.Exists(Resources.archive))
            {
                using Reader reader = new();
                reader.Read(this);
                loadGame();
            }
            else
            {
                setting = new(GameLevel.Basic);
                NewGame();
            }
        }

        public void NewGame()
        {
            game?.Dispose();
            game = new(setting);
            loadGame();
        }

        public void 新游戏ToolStripMenuItemClick(object sender, EventArgs e) => NewGame();

        private void 退出ToolStripMenuItemClick(object sender, EventArgs e) => Close();

        private void 查看帮助ToolStripMenuItemClick(object sender, EventArgs e) =>
            Process.Start("explorer.exe", Resources.helpPage);

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AboutDialog about = new();
            about.ShowDialog();
        }

        /*private void 统计信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var statistics = new StatisticsDialog())
            {
                statistics.ShowDialog();
            }
        }*/

        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OptionDialog optionDialog = new(setting);
            if (optionDialog.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("游戏正在进行中，确定改变设置并开始新游戏吗？", "扫雷", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    setting = optionDialog.setting;
                    NewGame();
                }
            }
        }

        public void Win()
        {
            using (SoundPlayer bgm = new(Resources.winBgm))
            {
                bgm.Play();
            }
            using var resultDialog = new ResultDialog();
            if (Level == GameLevel.PlayerDefined)
            {
                resultDialog.ShowDialog(ResultDialogMode.Win, Time);
            }
            else
            {
                rankings.Add(Level, resultDialog.ShowDialog(ResultDialogMode.Record, Time));
            }
            NewGame();
            if (resultDialog.DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        public void Lose()
        {
            using (SoundPlayer bgm = new(Resources.loseBgm))
            {
                bgm.Play();
            }
            using var resultDialog = new ResultDialog();
            resultDialog.ShowDialog(ResultDialogMode.Lose, Time);
            NewGame();
            if (resultDialog.DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void mainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (game.Started && MessageBox.Show("游戏正在进行，要保存并退出吗？", "扫雷", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                using Writer writer = new();
                writer.Write(this);
            }
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            reader.Read(ref setting);
            reader.Read(game = new(setting));
            reader.Read(rankings);
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(setting);
            writer.Write(game);
            writer.Write(rankings);
        }
        #endregion
    }
}