using MineSweeper.DataStructure;
using System.Runtime.CompilerServices;
using Windows.Graphics.Printing.PrintTicket;

namespace MineSweeper.Controls
{
    internal class BasicGrid : Button, IData
    {
        #region 字段
        private GridType type;
        private GridMode mode;
        private GridState state = GridState.None;
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
            Type = type;
            Mode = mode;
        }
        #endregion

        #region 方法
        protected virtual void readFrom(Reader reader)
        {
            Type = (GridType)reader.ReadInt32();
            Mode = (GridMode)reader.ReadInt32();
            State = GridState.None;
        }

        protected virtual void writeTo(Writer writer)
        {
            writer.Write((int)Type);
            writer.Write((int)Mode);
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader) => readFrom(reader);

        void IWritable.WriteTo(Writer writer) => writeTo(writer);
        #endregion
    }
}