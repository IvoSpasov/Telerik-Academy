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

        private PlayingBoard playingBoard;
        private int selectedRow = 0;
        private int selectedCol = 0;
        private bool MineIsHit = false;
        private bool CommandIsExit = false;
        private bool ShowGreetingMessage = true;
        private int correctGuessesCounter = 0;

        // private var players = new List<Player>();

        private const int max = 35;
        private bool isGameWon = false;

        public void Start()
        {
            if (ShowGreetingMessage)
            {
                Console.WriteLine(GreetingMessage);
            }

            this.playingBoard = new PlayingBoard(NumberOfRows, NumberOfCols);
            this.playingBoard.Print();
            string command;

            while (!MineIsHit && !CommandIsExit)
            {
                Console.Write("Please enter command or row and column: ");
                command = Console.ReadLine().Trim();
                this.ProcessCommand(command);
            }

            //    if (MineIsHit)
            //    {
            //        PrintPlayingBoard(bombsBoard);
            //        Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
            //            "Daj si niknejm: ", counter);
            //        string niknejm = Console.ReadLine();
            //        Player t = new Player(niknejm, counter);
            //        if (players.Count < 5)
            //        {
            //            players.Add(t);
            //        }
            //        else
            //        {
            //            for (int i = 0; i < players.Count; i++)
            //            {
            //                if (players[i].Points < t.Points)
            //                {
            //                    players.Insert(i, t);
            //                    players.RemoveAt(players.Count - 1);
            //                    break;
            //                }
            //            }
            //        }
            //        players.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
            //        players.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
            //        PrintHighscores(players);

            //        playingBoard = CreatePlayingBoard();
            //        bombsBoard = slojibombite();
            //        counter = 0;
            //        grum = false;
            //        flag = true;
            //    }
            //    if (flag2)
            //    {
            //        Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
            //        PrintPlayingBoard(bombsBoard);
            //        Console.WriteLine("Daj si imeto, batka: ");
            //        string imeee = Console.ReadLine();
            //        Player to4kii = new Player(imeee, counter);
            //        players.Add(to4kii);
            //        PrintHighscores(players);
            //        playingBoard = CreatePlayingBoard();
            //        bombsBoard = slojibombite();
            //        counter = 0;
            //        flag2 = false;
            //        flag = true;
            //    }
        }

        private void ProcessCommand(string command)
        {
            if (CheckForValidRowAndCol(command))
            {
                if (this.playingBoard.BoardWithMines[selectedRow, selectedCol] == '*')
                {
                    MineIsHit = true;
                }
                else
                {
                    CalculateNumberOfBombs();
                    correctGuessesCounter++;

                    if (max == correctGuessesCounter)
                    {
                        isGameWon = true;
                    }
                    else
                    {
                        playingBoard.Print();
                    }
                }
            }
            else
            {
                switch (command)
                {
                    case "scores":
                        //PrintHighscores(players);
                        break;
                    case "restart":
                        this.MineIsHit = false;
                        this.ShowGreetingMessage = false;
                        this.Start();
                        break;
                    case "exit":
                        CommandIsExit = true;
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

            this.playingBoard.BoardWithHiddenMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
        }
    }
}
