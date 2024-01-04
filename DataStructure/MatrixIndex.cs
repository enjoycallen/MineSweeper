namespace MineSweeper.DataStructure
{
    internal struct MatrixIndex : IData
    {
        #region 属性
        public int Row {  get; set; }

        public int Column {  get; set; }
        #endregion

        #region 构造函数
        public MatrixIndex() { }

        public MatrixIndex(int row, int column)
        {
            Row = row;
            Column = column;
        }
        #endregion

        #region 方法
        public static MatrixIndex operator +(MatrixIndex index, (int row, int column) offset)
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