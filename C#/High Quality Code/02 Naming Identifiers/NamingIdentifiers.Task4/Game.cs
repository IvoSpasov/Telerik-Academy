namespace NamingIdentifiers.Task4
{
    using System;

    public class Game
    {
        private const int NumberOfRows = 6;
        private const int NumberOfCols = 10;
        private const int NumberOfMines = 15;
        private readonly Highscores highscores;
        private PlayingBoard playingBoard;
        private int selectedRow;
        private int selectedCol;
        private bool mineIsHit;
        private bool commandIsExit;
        private bool gameIsWon;
        private bool showGreetingMessage;
        private int correctGuessesCounter;

        public Game(Highscores highscores)
        {
            this.highscores = highscores;
            this.mineIsHit = false;
            this.commandIsExit = false;
            this.gameIsWon = false;
            this.showGreetingMessage = true;
            this.correctGuessesCounter = 0;
        }

        public void Start()
        {
            if (this.showGreetingMessage)
            {
                Console.WriteLine("Let's play \"mines\". Try to guess the boxes without mines." +
                            "\nCommands:\n\"scores\": shows highscores\n\"restart\": starts a new game\n\"exit\": ends the game");
            }

            this.playingBoard = new PlayingBoard(NumberOfRows, NumberOfCols, NumberOfMines);
            this.playingBoard.PrintBoardWithHiddenMines();
            string command;

            while (!this.mineIsHit && !this.commandIsExit && !this.gameIsWon)
            {
                Console.Write("Please enter command or row and column: ");
                command = Console.ReadLine();
                this.ProcessCommand(command);
            }

            if (this.mineIsHit)
            {
                this.EndCurrentGame(string.Format("You hit a mine. Your score is: {0} ", this.correctGuessesCounter));
            }

            if (this.gameIsWon)
            {
                this.EndCurrentGame("You win.");
            }
        }

        private void ProcessCommand(string command)
        {
            if (this.CheckForValidRowAndCol(command))
            {
                if (this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol] == '*')
                {
                    this.mineIsHit = true;
                }
                else
                {
                    this.ApplyNumberOfBombsToCurrentCellOfBoard();
                    this.correctGuessesCounter++;

                    if (this.correctGuessesCounter == this.playingBoard.NumberOfSafeCells)
                    {
                        this.gameIsWon = true;
                    }
                    else
                    {
                        this.playingBoard.PrintBoardWithHiddenMines();
                    }
                }
            }
            else
            {
                switch (command)
                {
                    case "scores":
                        this.highscores.PrintPlayersHighscores();
                        break;
                    case "restart":
                        this.Restart();
                        break;
                    case "exit":
                        this.commandIsExit = true;
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
                                    this.selectedRow < this.playingBoard.Rows &&
                                    this.selectedCol < this.playingBoard.Cols;

            return isValidRowAndCol;
        }

        private void ApplyNumberOfBombsToCurrentCellOfBoard()
        {
            int numberOfBombs = this.CalculateNumberOfBombs();
            this.playingBoard.BoardWithMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
            this.playingBoard.BoardWithHiddenMines[this.selectedRow, this.selectedCol] = char.Parse(numberOfBombs.ToString());
        }

        private int CalculateNumberOfBombs()
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

            return numberOfBombs;
        }

        private void Restart()
        {
            this.mineIsHit = false;
            this.showGreetingMessage = false;
            this.gameIsWon = false;
            this.correctGuessesCounter = 0;
            this.Start();
        }

        private void EndCurrentGame(string message)
        {
            this.playingBoard.PrintBoardWithMines();
            Console.WriteLine(message);
            this.highscores.AddPlayerToScoreBoard(this.correctGuessesCounter);
            this.highscores.PrintPlayersHighscores();
            this.Restart();
        }
    }
}
