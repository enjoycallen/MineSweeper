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
        #endregion

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
    }
}