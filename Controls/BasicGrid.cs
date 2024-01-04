using MineSweeper.DataStructure;

namespace MineSweeper.Controls
{
    internal class BasicGrid : Button, IData
    {
        #region 字段
        private GridType type;
        private GridMode mode;
        private GridState state;
        #endregion

        #region 属性
        public GridType Type
        {
            get => type;
            set
            {
                type = value;
                GridImage.Paint(this);
            }
        }

        public GridMode Mode
        {
            get => mode;
            protected set
            {
                mode = value;
                GridImage.Paint(this);
            }
        }

        public GridState State
        {
            get => state;
            set
            {
                state = value;
                GridImage.Paint(this);
            }
        }
        #endregion

        #region 构造函数
        public BasicGrid() : this(GridType.Undetermined, GridMode.Concealed) { }

        public BasicGrid(GridType type, GridMode mode)
        {
            FlatStyle = FlatStyle.Flat;
            Location = new(0, 0);
            Size = new(27, 27);
            this.type = type;
            this.mode = mode;
            State = GridState.None;
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            type = (GridType)reader.ReadInt32();
            mode = (GridMode)reader.ReadInt32();
            State = GridState.None;
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write((int)type);
            writer.Write((int)mode);
        }
        #endregion
    }
}