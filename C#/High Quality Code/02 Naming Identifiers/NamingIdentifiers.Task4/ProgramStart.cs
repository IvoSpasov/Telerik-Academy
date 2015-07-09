namespace NamingIdentifiers.Task4
{
    using System.Collections.Generic;

    public class ProgramStart
    {
        public static void Main()
        {
            var players = new List<Player>();
            var higscores = new Highscores(players);
            var game = new Game(higscores);
            game.Start();
        }
    }
}