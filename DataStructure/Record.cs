namespace MineSweeper.DataStructure
{
    internal struct Record : IComparable<Record>, IData
    {
        #region 字段
        private string playerName;
        private int time;
        private DateTime date;
        #endregion

        #region 属性
        public string PlayerName { get => playerName; set => playerName = value; }

        public int Time { get => time; set => time = value; }

        public DateTime Date { get => date; set => date = value; }
        #endregion

        #region 构造函数
        public Record() { }

        public Record(string playerName, int time, DateTime date)
        {
            this.playerName= playerName;
            this.time = time;
            this.date = date;
        }
        #endregion

        #region 接口实现
        int IComparable<Record>.CompareTo(Record other) => time < other.time || time == other.time && date > other.date ? -1 : 1;

        void IReadable.ReadFrom(Reader reader)
        {
            playerName = reader.ReadString();
            time = reader.ReadInt32();
            date = new(reader.ReadInt64());
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(playerName);
            writer.Write(time);
            writer.Write(date.Ticks);
        }
        #endregion
    }
}