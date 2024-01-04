using System.Collections;

namespace MineSweeper.DataStructure
{
    internal class Matrix<T>(MatrixSize size) : IEnumerable<T>
    {
        #region 字段
        private MatrixSize size = size;
        private T[,] matrix = new T[size.Row, size.Column];
        #endregion

        #region 属性
        public MatrixSize Size => size;

        public int Row => size.Row;

        public int Column => size.Column;

        public T this[int row, int column]
        {
            get => this[(row, column)];
            set => this[(row, column)] = value;
        }

        public T this[MatrixIndex index]
        {
            get => size.ValidIndex(index) ? matrix[index.Row, index.Column] : default;
            set
            {
                if (size.ValidIndex(index)) matrix[index.Row, index.Column] = value;
            }
        }
        #endregion

        #region 方法
        public IEnumerable<T> Neighbour(MatrixIndex index)
        {
            MatrixIndex[] Offset = [(-1, -1), (-1, 0), (-1, 1), (0, -1), (0, 1), (1, -1), (1, 0), (1, 1)];
            foreach (var offset in Offset)
            {
                if (size.ValidIndex(index + offset))
                {
                    yield return this[index + offset];
                }
            }

        }

        public IEnumerable<T> NeighbourWithin(MatrixIndex index)
        {
            yield return this[index];
            foreach (var element in Neighbour(index)) yield return element;
        }
        #endregion

        #region 接口实现
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in matrix)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion
    }
}