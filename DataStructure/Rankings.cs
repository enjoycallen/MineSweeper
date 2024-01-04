namespace MineSweeper.DataStructure
{
    internal class Rankings : IData
    {
        #region 字段
        private Ranking basic = new();
        private Ranking intermidiate = new();
        private Ranking advanced = new();
        #endregion

        #region 属性
        public Ranking Basic => basic;

        public Ranking Intermidiate => intermidiate;

        public Ranking Advanced => advanced;
        #endregion

        #region 构造函数
        public Rankings() { }
        #endregion

        #region 方法
        public void Add(GameLevel level, Record record)
        {
            switch (level)
            {
                case GameLevel.Basic:
                    basic.Add(record);
                    break;
                case GameLevel.Intermidiate:
                    intermidiate.Add(record);
                    break;
                case GameLevel.Advanced:
                    advanced.Add(record);
                    break;
            }
        }

        public void Clear()
        {
            basic.Clear();
            intermidiate.Clear();
            advanced.Clear();
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            reader.Read(basic);
            reader.Read(intermidiate);
            reader.Read(advanced);
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write(basic);
            writer.Write(intermidiate);
            writer.Write(advanced);
        }
        #endregion
    }
}