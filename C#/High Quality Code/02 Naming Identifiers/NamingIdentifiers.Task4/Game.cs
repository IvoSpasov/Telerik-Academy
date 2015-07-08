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
        private PlayingBoard playingBoard;
        private int row = 0;
        private int col = 0;

        private int counter = 0;
        private bool grum = false;
        // private var players = new List<Player>();

        private bool flag = true;
        private const int max = 35;
        private bool flag2 = false;

        public void Start()
        {
            this.playingBoard = new PlayingBoard(NumberOfRows, NumberOfCols);
            string command;

            Console.WriteLine("Let's play “mines”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                            " Komanda 'scores' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza!");

            playingBoard.Print();

            while (true)
            {
                Console.Write("Please enter command or row and column: ");
                command = Console.ReadLine().Trim();
                if (command == "exit")
                {
                    break;
                }

                ProcessCommand(command);
            }
        }

        private void ProcessCommand(string command)
        {
            //TODO: add to method?
            char[] validSeparators = { ' ', ',', '-' };
            var numbers = command.Split(validSeparators, StringSplitOptions.RemoveEmptyEntries);

            //TODO: check if this is valid formatting!
            bool isValidRowAndCol = numbers.Length == 2 &&
                                    int.TryParse(numbers[0], out row) &&
                                    int.TryParse(numbers[1], out col) &&
                                row <= playingBoard.Rows && col <= playingBoard.Cols;

            if (isValidRowAndCol)
            {
                if (this.playingBoard.BoardWithMines[row, col] == '*')
                {
                    grum = true;
                }
                else
                {
                    CalculateNumberOfBombs();
                    counter++;

                    if (max == counter)
                    {
                        flag2 = true;
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
                    //case "top":
                    //    //PrintHighscores(players);
                    //    break;
                    //case "restart":
                    //    playingBoard = CreatePlayingBoard();
                    //    bombsBoard = slojibombite();
                    //    PrintPlayingBoard(playingBoard);
                    //    grum = false;
                    //    flag = false;
                    //    break;
                    //case "exit":
                    //    Console.WriteLine("Thank you for playing.");
                    //    break;
                    //case "turn":
                    //    
                    //    break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

        private void CalculateNumberOfBombs()
        {
            int numberOfBombs = 0;

            if (row - 1 >= 0)
            {
                if (this.playingBoard.BoardWithMines[row - 1, col] == '*')
                {
                    numberOfBombs++;
                }
            }
            if (row + 1 <  this.playingBoard.Rows)
            {
                if (this.playingBoard.BoardWithMines[row + 1, col] == '*')
                {
                    numberOfBombs++;
                }
            }
            if (col - 1 >= 0)
            {
                if (this.playingBoard.BoardWithMines[row, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }
            if (col + 1 < this.playingBoard.Cols)
            {
                if (this.playingBoard.BoardWithMines[row, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (this.playingBoard.BoardWithMines[row - 1, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < this.playingBoard.Cols))
            {
                if (this.playingBoard.BoardWithMines[row - 1, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }
            if ((row + 1 <  this.playingBoard.Rows) && (col - 1 >= 0))
            {
                if (this.playingBoard.BoardWithMines[row + 1, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }
            if ((row + 1 <  this.playingBoard.Rows) && (col + 1 < this.playingBoard.Cols))
            {
                if (this.playingBoard.BoardWithMines[row + 1, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            this.playingBoard.BoardWithMines[row, col] = char.Parse(numberOfBombs.ToString());
            this.playingBoard.BoardWithHiddenMines[row, col] = char.Parse(numberOfBombs.ToString());
        }
    }
}
