using MineSweeper.DataStructure;

namespace MineSweeper.Controls
{
    internal class Grid(MatrixIndex index) : BasicGrid
    {
        #region 字段
        private MatrixIndex index = index;
        #endregion

        #region 属性
        public MatrixIndex Index { get => index; }

        public Plane Plane => Parent as Plane;

        public Game Game => Plane.Game;

        public new GridMode Mode
        {
            get => base.Mode;
            set
            {
                if (base.Mode == GridMode.Marked) Game.RemainingMine += 1;
                base.Mode = value;
                if (base.Mode == GridMode.Marked) Game.RemainingMine -= 1;
            }
        }

        public bool Explorable => Mode == GridMode.Concealed || Mode == GridMode.Undetermined;
        #endregion

        #region 方法
        public bool Explore()
        {
            if (!Explorable) return false;
            Mode = GridMode.Explored;
            return Type == GridType.Mine;
        }

        public void SwitchMode()
        {
            switch (Mode)
            {
                case GridMode.Concealed:
                    Mode = GridMode.Marked;
                    break;
                case GridMode.Marked:
                    Mode = GridMode.Undetermined;
                    break;
                case GridMode.Undetermined:
                    Mode = GridMode.Concealed;
                    break;
            }
        }

        public void Reveal()
        {
            if (Type == GridType.Mine && Explorable || Type != GridType.Mine && Mode == GridMode.Marked)
            {
                Mode = GridMode.Revealed;
            }
        }
        #endregion
    }
}