namespace NamingIdentifiers.Task4
{
    using System.Collections.Generic;
    using NamingIdentifiers.Task4.Interfaces;

    public class ProgramStart
    {
        public static void Main()
        {
            var players = new List<IPlayer>();
            var higscores = new Highscores(players);
            var game = new Game(higscores);
            game.Start();
        }
    }
}