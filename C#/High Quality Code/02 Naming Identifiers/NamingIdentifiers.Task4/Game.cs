using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingIdentifiers.Task4
{
    public class Game
    {
        private const int NumberOfRows = 5;
        private const int NumberOfCols = 10;
        private const string GreetingMessage = "Let's play \"mines\". Try to guess the boxes without mines." +
                            "\nCommands:\n\"scores\": shows highscores\n\"restart\": starts a new game\n\"exit\": ends the game";
        private const int MaxPlayersOnScoreBoard = 5;

        private PlayingBoard playingBoard;
        private int selectedRow = 0;
        private int selectedCol = 0;
        private bool mineIsHit = false;
        private bool commandIsExit = false; 
        private bool gameIsWon = false;
        private bool showGreetingMessage = true;
        private int correctGuessesCounter = 0;
        private List<Player> players = new List<Player>();

        private const int max = 35;
        

        public void Start()
        {
            if (showGreetingMessage)
            {
                Console.WriteLine(GreetingMessage);
            }

            this.playingBoard = new PlayingBoard(NumberOfRows, NumberOfCols);
            this.playingBoard.PrintBoardWithHiddenMines();
            string command;

            while (!this.mineIsHit && !this.commandIsExit && !this.gameIsWon)
            {
                Console.Write("Please enter command or row and column: ");
                command = Console.ReadLine();
                this.ProcessCommand(command);
            }

            if (mineIsHit)
            {
                this.playingBoard.PrintBoardWithMines();
                Console.Write("\n You hit a mine. Your score is: {0} ", correctGuessesCounter);
                AddPlayerToScoreBoard();
                PrintHighscores(players);
                this.RestartGame();
            }

            if (this.gameIsWon)
            {
                Console.WriteLine("\n You win.");
                this.playingBoard.PrintBoardWithMines();
                AddPlayerToScoreBoard();
                PrintHighscores(players);

                this.RestartGame();
            }
        }

        private void ProcessCommand(string command)
        {
            if (CheckForValidRowAndCol(command))
            {
                if (this.playingBoard.BoardWithMines[selectedRow, selectedCol] == '*')
                {
                    mineIsHit = true;
                }
                else
                {
                    CalculateNumberOfBombs();
                    correctGuessesCounter++;

                    if (max == correctGuessesCounter)
                    {
                        gameIsWon = true;
                    }
                    else
                    {
                        playingBoard.PrintBoardWithHiddenMines();
                    }
                }
            }
            else
            {
                switch (command)
                {
                    case "scores":
                        PrintHighscores(players);
                        break;
                    case "restart":
                        this.RestartGame();
                        break;
                    case "exit":
                        commandIsExit = true;
                        Console.WriteLine("Thank you for playing.");
                        break;
                    default:
                        Console.WriteLine("Invalid command or row or column.");
                        break;
                }
            }
        }

        private bool CheckForValidRowAndCol(string command)
        {
            char[] validSeparators = { ' ', ',', '-' };
            var numbers = command.Split(validSeparators, StringSplitOptions.RemoveEmptyEntries);
            bool isValidRowAndCol = numbers.Length == 2 &&
                                    int.TryParse(numbers[0], out this.selectedRow) &&
                                    int.TryParse(numbers[1], out this.selectedCol) &&
                                    this.selectedRow <= this.playingBoard.Rows &&
                                    this.selectedCol <= playingBoard.Cols;

            return isValidRowAndCol;
        }

        private void CalculateNumberOfBombs()
        {
            int numberOfBombs = 0;

            if (this.selectedRow - 1 >= 0)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow - 1, this.selectedCol] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (this.selectedRow + 1 < this.playingBoard.Rows)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow + 1, this.selectedCol] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (this.selectedCol - 1 >= 0)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (this.selectedCol + 1 < this.playingBoard.Cols)
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow - 1 >= 0) && (this.selectedCol - 1 >= 0))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow - 1, this.selectedCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow - 1 >= 0) && (this.selectedCol + 1 < this.playingBoard.Cols))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow - 1, this.selectedCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow + 1 < this.playingBoard.Rows) && (this.selectedCol - 1 >= 0))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow + 1, this.selectedCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((this.selectedRow + 1 < this.playingBoard.Rows) && (this.selectedCol + 1 < this.playingBoard.Cols))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow + 1, this.selectedCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
            this.playingBoard.BoardWithHiddenMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
        }

        private void RestartGame()
        {
            this.mineIsHit = false;
            this.showGreetingMessage = false;
            this.gameIsWon = false;
            this.correctGuessesCounter = 0;
            this.Start();
        }

        private void PrintHighscores(List<Player> players)
        {
            if (players.Count > 0)
            {
                Console.WriteLine("\nPoints:");
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores yet.\n");
            }
        }

        private void AddPlayerToScoreBoard()
        {
            Console.WriteLine("Please enter your nickname");
            string nickName = Console.ReadLine();
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

            players.Sort((Player p1, Player p2) => p2.Name.CompareTo(p1.Name));
            players.Sort((Player p1, Player p2) => p2.Points.CompareTo(p1.Points));
        }
    }
}
