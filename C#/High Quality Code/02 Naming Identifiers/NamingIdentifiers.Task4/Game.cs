namespace NamingIdentifiers.Task4
{
    using System;

    public class Game
    {
        private const int NumberOfRows = 5;
        private const int NumberOfCols = 10;
        private const string GreetingMessage = "Let's play \"mines\". Try to guess the boxes without mines." +
                            "\nCommands:\n\"scores\": shows highscores\n\"restart\": starts a new game\n\"exit\": ends the game";

        private const int Max = 35;

        private PlayingBoard playingBoard;
        private int selectedRow = 0;
        private int selectedCol = 0;
        private bool mineIsHit = false;
        private bool commandIsExit = false;
        private bool gameIsWon = false;
        private bool showGreetingMessage = true;
        private int correctGuessesCounter = 0;
        private Highscores highscores = new Highscores();

        public void Start()
        {
            if (this.showGreetingMessage)
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

            if (this.mineIsHit)
            {
                string mes = string.Format("You hit a mine. Your score is: {0} ", this.correctGuessesCounter);
                this.EndGame(mes);
            }

            if (this.gameIsWon)
            {
                this.EndGame("You win.");
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
                    this.CalculateNumberOfBombs();
                    this.correctGuessesCounter++;

                    if (Max == this.correctGuessesCounter)
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
                        this.RestartGame();
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
                                    this.selectedRow <= this.playingBoard.Rows &&
                                    this.selectedCol <= this.playingBoard.Cols;

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

        private void EndGame(string message)
        {
            this.playingBoard.PrintBoardWithMines();
            Console.WriteLine(message);
            this.highscores.AddPlayerToScoreBoard(this.correctGuessesCounter);
            this.highscores.PrintPlayersHighscores();
            this.RestartGame();
        }
    }
}
