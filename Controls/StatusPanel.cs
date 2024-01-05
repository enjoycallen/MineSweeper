using MineSweeper.DataStructure;

namespace MineSweeper.Controls
{
    public partial class StatusPanel : UserControl, IData
    {
        #region 字段
        private int time;
        private int remainingMine;
        #endregion

        #region 属性
        public int Time
        {
            get => time;
            set
            {
                time = value;
                timeLabel.Text = time <= 999 ? time.ToString() : "999";
            }
        }

        public int RemainingMine
        {
            get => remainingMine;
            set
            {
                remainingMine = value;
                remainingMineLabel.Text = remainingMine.ToString();
            }
        }

        public bool InTiming { get => timer.Enabled; set => timer.Enabled = value; }

        public new int Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                minePictureBox.Location = new(value - 37, 10);
                remainingMineLabel.Location = new(value - 100, 13);
            }
        }
        #endregion

        #region 构造函数
        public StatusPanel()
        {
            InitializeComponent();
            timer.Tick += delegate { ++Time; };
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            Time = reader.ReadInt32();
            RemainingMine = reader.ReadInt32();
            InTiming = reader.ReadBoolean();
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(Time);
            writer.Write(RemainingMine);
            writer.Write(InTiming);
        }
        #endregion
    }
}