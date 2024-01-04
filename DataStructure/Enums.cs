namespace MineSweeper.DataStructure
{
    public enum GameLevel { Basic, Intermidiate, Advanced, PlayerDefined }

    public enum ResultDialogMode { Lose, Win, Record }

    public enum GridType { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Mine, Undetermined }

    public enum GridMode { Concealed, Marked, Undetermined, Explored, Revealed }

    public enum GridState { None, MouseOver, MouseDown }
}