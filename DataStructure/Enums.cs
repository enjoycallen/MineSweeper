namespace MineSweeper.DataStructure
{
    internal enum GameLevel { Basic, Intermidiate, Advanced, PlayerDefined }

    internal enum GameState { Pendnig, Started, Finished }

    internal enum GridType { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Mine, Undetermined }

    internal enum GridMode { Concealed, Marked, Undetermined, Explored, Revealed }

    internal enum GridState { None, MouseOver, MouseDown }

    internal enum ResultDialogMode { Lose, Win, Record }
}