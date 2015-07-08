using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingIdentifiers.Task4
{
    public class Highscores
    {
        private const int MaxPlayersOnScoreBoard = 5;
        private List<Player> players = new List<Player>();

        public void PrintPlayersHighscores()
        {
            if (players.Count > 0)
            {
                Console.WriteLine("\nHighScores:");
                for (int i = 0; i < players.Count; i++)
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
            if (!CheckIfPlayerExists(nickName))
            {
                // extract to method
                Player currentPlayer = new Player(nickName, correctGuessesCounter);
                if (players.Count < MaxPlayersOnScoreBoard)
                {
                    players.Add(currentPlayer);
                }
                else
                {
                    for (int i = 0; i < players.Count; i++)
                    {
                        if (players[i].Points < currentPlayer.Points)
                        {
                            players.Insert(i, currentPlayer);
                            players.RemoveAt(players.Count - 1);
                            break;
                        }
                    }
                }
            }
            else
            {
                AddScoreToExistingPlayer(nickName, correctGuessesCounter);
            }

            players.Sort((Player p1, Player p2) => p2.Name.CompareTo(p1.Name));
            players.Sort((Player p1, Player p2) => p2.Points.CompareTo(p1.Points));
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
