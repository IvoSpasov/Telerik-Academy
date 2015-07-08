namespace NamingIdentifiers.Task4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Highscores
    {
        private const int MaxPlayersOnScoreBoard = 5;
        private readonly List<Player> players = new List<Player>();

        public void PrintPlayersHighscores()
        {
            if (this.players.Any())
            {
                Console.WriteLine("\nHighScores:");
                for (int i = 0; i < this.players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, this.players[i].Name, this.players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores yet.\n");
            }
        }

        public void AddPlayerToScoreBoard(int correctGuessesCounter)
        {
            Console.WriteLine("Please enter your nickname:");
            string nickName = Console.ReadLine();
            if (!this.CheckIfPlayerExists(nickName))
            {
                Player currentPlayer = new Player(nickName, correctGuessesCounter);
                this.AddNewPlayerToScoreboard(currentPlayer);                
            }
            else
            {
                this.AddScoreToExistingPlayer(nickName, correctGuessesCounter);
            }

            this.players.Sort((Player p1, Player p2) => p2.Name.CompareTo(p1.Name));
            this.players.Sort((Player p1, Player p2) => p2.Points.CompareTo(p1.Points));
        }

        private bool CheckIfPlayerExists(string nickName)
        {
            foreach (var player in this.players)
            {
                if (player.Name == nickName)
                {
                    return true;
                }
            }

            return false;
        }

        private void AddNewPlayerToScoreboard(Player currentPlayer)
        {
            if (this.players.Count < MaxPlayersOnScoreBoard)
            {
                this.players.Add(currentPlayer);
            }
            else
            {
                for (int i = 0; i < this.players.Count; i++)
                {
                    if (this.players[i].Points < currentPlayer.Points)
                    {
                        this.players.Insert(i, currentPlayer);
                        this.players.RemoveAt(this.players.Count - 1);
                        break;
                    }
                }
            }
        }

        // This method adds the score olny if it is higher than the current one the player has.
        private void AddScoreToExistingPlayer(string nickName, int correctGuessesCounter)
        {
            foreach (var player in this.players)
            {
                if (player.Name == nickName && player.Points < correctGuessesCounter)
                {
                    player.Points = correctGuessesCounter;
                }
            }
        }
    }
}
