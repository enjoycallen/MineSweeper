using System.Collections;
using System.Runtime.CompilerServices;

namespace MineSweeper.DataStructure
{
    internal struct MatrixSize : IEnumerable<MatrixIndex>, IData
    {
        #region 属性
        public int Row { get; set; }

        public int Column {  get; set; }
        #endregion

        #region 构造函数
        public MatrixSize() { }
        public MatrixSize(int row, int column)
        {
            Row = row;
            Column = column;
        }
        #endregion

        #region 方法
        public bool ValidIndex(int row, int column) =>
            row >= 0 && row < Row && column >= 0 && column < Column;

        public bool ValidIndex(MatrixIndex index) => ValidIndex(index.Row, index.Column);

        public static implicit operator MatrixSize((int row, int column) size) => new(size.row, size.column);
        #endregion

        #region 接口实现
        public IEnumerator<MatrixIndex> GetEnumerator()
        {
            for (int i = 0; i < Row; ++i)
                for (int j = 0; j < Column; ++j)
                    yield return new(i, j);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        void IReadable.ReadFrom(Reader reader)
        {
            Row = reader.ReadInt32();
            Column = reader.ReadInt32();
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(Row);
            writer.Write(Column);
        }
        #endregion
    }
}