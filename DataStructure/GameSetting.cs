namespace MineSweeper.DataStructure
{
    internal struct GameSetting : IData
    {
        #region 字段
        private GameLevel level;
        private MatrixSize size;
        private int mineCount;
        #endregion

        #region 属性
        public GameLevel Level
        {
            get => level;
            set
            {
                level = value;
                switch (level)
                {
                    case GameLevel.Basic:
                        size = new(9, 9);
                        mineCount = 10;
                        break;
                    case GameLevel.Intermidiate:
                        size = new(16, 16);
                        mineCount = 40;
                        break;
                    case GameLevel.Advanced:
                        size = new(16, 30);
                        mineCount = 99;
                        break;
                }
            }
        }

        public MatrixSize Size
        {
            get => size;
            set
            {
                size = value;
                level = GameLevel.PlayerDefined;
            }
        }

        public int Row
        {
            get => size.Row;
            set
            {
                size.Row = value;
                level = GameLevel.PlayerDefined;
            }
        }

        public int Column
        {
            get => size.Column;
            set
            {
                size.Column = value;
                level = GameLevel.PlayerDefined;
            }
        }

        public int MineCount
        {
            get => mineCount;
            set
            {
                mineCount = value;
                level = GameLevel.PlayerDefined;
            }
        }
        #endregion

        #region 构造函数
        public GameSetting() { }

        public GameSetting(GameLevel level) => Level = level;

        public GameSetting(MatrixSize size, int mineCount)
        {
            Size = size;
            MineCount = mineCount;
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            Level = (GameLevel)reader.ReadInt32();
            if (Level == GameLevel.PlayerDefined)
            {
                reader.Read(ref size);
                mineCount = reader.ReadInt32();
            }
        }

        void IWritable.WriteTo(Writer writer)
        {
            writer.Write((int)level);
            if (level == GameLevel.PlayerDefined)
            {
                writer.Write(size);
                writer.Write(mineCount);
            }
        }
        #endregion
    }
}