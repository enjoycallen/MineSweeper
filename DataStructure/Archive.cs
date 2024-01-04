using Resources = MineSweeper.Properties.Resources;

namespace MineSweeper.DataStructure
{
    #region 接口
    internal interface IReadable { void ReadFrom(Reader reader); }

    internal interface IWritable { void WriteTo(Writer writer); }

    internal interface IData : IReadable, IWritable;
    #endregion

    internal class Reader() : BinaryReader(new FileStream(Resources.archive, FileMode.Open))
    {
        public void Read<T>(ref T var) where T : struct, IReadable => var.ReadFrom(this);

        public void Read<T>(T var) where T : class, IReadable => var.ReadFrom(this);
    }

    internal class Writer() : BinaryWriter(new FileStream(Resources.archive, FileMode.Open))
    {
        public void Write(IWritable var) => var.WriteTo(this);
    }

    internal static class Archive
    {
        public static void Load(MainForm mainForm)
        {
            if(File.Exists(Resources.archive)) { }
            using Reader reader = new();
            //reader.Read(mainForm.)
        }

        public static void Save(MainForm mainForm)
        {
            using Writer writer = new();
            writer.Write(mainForm.Setting);
            //writer.Write()
        }
    }
}