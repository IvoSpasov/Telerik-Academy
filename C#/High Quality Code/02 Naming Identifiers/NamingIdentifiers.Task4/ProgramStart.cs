namespace NamingIdentifiers.Task4
{
    using System.Collections.Generic;
    using NamingIdentifiers.Task4.Interfaces;

    public class ProgramStart
    {
        private const int NumberOfRows = 6;
        private const int NumberOfCols = 10;
        private const int NumberOfMines = 15;

        public static void Main()
        {
            var players = new List<IPlayer>();
            var higscores = new Highscores(players);
            var playingBoard = new PlayingBoard(NumberOfRows, NumberOfCols, NumberOfMines);
            var game = new Game(higscores, playingBoard);
            game.Start();
        }
    }
}