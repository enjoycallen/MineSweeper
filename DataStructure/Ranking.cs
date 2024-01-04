using System.Runtime.CompilerServices;

namespace MineSweeper.DataStructure
{
    internal class Ranking : IData
    {
        #region 字段
        private List<Record> records = [];
        #endregion

        #region 属性
        public int Count => records.Count;
        #endregion

        #region 构造函数
        public Ranking() { }
        #endregion

        #region 方法
        public void Add(Record record)
        {
            records.Add(record);
            records.Sort();
            if (records.Count > 5) records.Remove(records.Last());
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            records.Clear();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; ++i)
            {
                Record record = new();
                reader.Read(ref record);
                records.Add(record);
            }
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(records.Count);
            foreach (var record in records) writer.Write(record);
        }
        #endregion
    }
}