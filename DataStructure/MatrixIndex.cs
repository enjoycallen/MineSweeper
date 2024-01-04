namespace MineSweeper.DataStructure
{
    internal struct MatrixIndex : IData
    {
        #region 字段
        private int row;
        private int column;
        #endregion

        #region 属性
        public int Row { get => row; set => row = value; }

        public int Column { get => column; set => column = value; }
        #endregion

        #region 构造函数
        public MatrixIndex() { }

        public MatrixIndex(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
        #endregion

        #region 方法
        public static MatrixIndex operator +(MatrixIndex index, MatrixIndex offset)
            => new(index.Row + offset.row, index.Column + offset.column);
        public static implicit operator MatrixIndex((int row, int column) index) => new(index.row, index.column);
        #endregion

        #region 接口实现
        public void ReadFrom(Reader reader)
        {
            Row = reader.ReadInt32();
            Column = reader.ReadInt32();
        }

        public void WriteTo(Writer writer)
        {
            writer.Write(Row);
            writer.Write(Column);
        }
        #endregion
    }
}