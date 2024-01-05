using MineSweeper.DataStructure;
using MineSweeper.Forms;

namespace MineSweeper.Controls
{
    internal class Game : Control, IData
    {
        #region 字段
        private Plane plane;
        private StatusPanel statusPanel;
        private GameState state = GameState.Pendnig;
        #endregion

        #region 属性
        public GameSetting Setting { get; init; }

        public GameLevel Level => Setting.Level;

        public new MatrixSize Size => Setting.Size;

        public int Row => Setting.Row;

        public int Column => Setting.Column;

        public int MineCount => Setting.MineCount;

        public int Time { get => statusPanel.Time; set => statusPanel.Time = value; }

        public int RemainingMine { get => statusPanel.RemainingMine; set => statusPanel.RemainingMine = value; }

        public bool InTiming { get => statusPanel.InTiming; set => statusPanel.InTiming = value; }

        public GameState State
        {
            get => state;
            set
            {
                state = value;
                switch (state)
                {
                    case GameState.Pendnig:
                        InTiming = false;
                        break;
                    case GameState.Started:
                        InTiming = true;
                        break;
                    default:
                        InTiming = false;
                        plane.Reveal();
                        break;
                }
            }
        }

        public MainForm MainForm => Parent as MainForm;
        #endregion

        #region 构造函数
        public Game(GameSetting setting)
        {
            Setting = setting;
            initializeComponent();
        }
        #endregion

        #region 方法
        private void initializeComponent()
        {
            base.Size = new(26 * Column + 1, 26 * Row + 50);
            plane = new(Size, MineCount);
            statusPanel = new()
            {
                Width = 26 * Column,
                Location = new(0, 26 * Row),
                Time = 0,
                RemainingMine = MineCount
            };
            Controls.Add(plane);
            Controls.Add(statusPanel);
        }

        public void Win()
        {
            State = GameState.Finished;
            RemainingMine = 0;
            MainForm.Win();
        }

        public void Lose()
        {
            State = GameState.Finished;
            MainForm.Lose();
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            reader.Read(plane);
            reader.Read(statusPanel);
            State = (GameState)reader.ReadInt32();
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(plane);
            writer.Write(statusPanel);
            writer.Write((int)State);
        }
        #endregion
    }
}