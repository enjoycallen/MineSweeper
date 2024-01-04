namespace MineSweeper.DataStructure
{
    internal class Ranking : IData
    {
        #region 字段
        private List<Record> records = [];
        #endregion

        #region 方法
        public void Add(Record record)
        {
            records.Add(record);
            records.Sort();
            if (records.Count > 5) records.Remove(records.Last());
        }

        public void Clear() => records = [];
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            records = [];
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