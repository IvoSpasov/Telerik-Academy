namespace NamingIdentifiers.Task4.Interfaces
{
    public interface IPlayingBoard
    {
        int Rows { get; }

        int Cols { get; }

        int NumberOfSafeCells { get; }

        char[,] BoardWithHiddenMines { get; }

        char[,] BoardWithMines { get; }

        void PrintBoardWithHiddenMines();

        void PrintBoardWithMines();
    }
}