namespace NamingIdentifiers.Task4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PlayingBoard
    {
        private readonly int totalCells;
        private int rows;
        private int cols;
        private int numberOfMines;

        public PlayingBoard(int rows, int cols, int numberOfMines)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.totalCells = this.Rows * this.Cols;
            this.NumberOfMines = numberOfMines;
            this.NumberOfSafeCells = this.totalCells - this.NumberOfMines;
            this.BoardWithHiddenMines = this.CreateBoardWithHiddenMines();
            this.BoardWithMines = this.CreateBoardWithMines();
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rows", "The rows cannot be zero or less");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cols", "The columns cannot be zero or less");
                }

                this.cols = value;
            }
        }

        public int NumberOfSafeCells { get; private set; }

        public char[,] BoardWithHiddenMines { get; private set; }

        public char[,] BoardWithMines { get; private set; }

        private int NumberOfMines
        {
            get
            {
                return this.numberOfMines;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("NumberOfMines", "The mines cannot be zero or less.");
                }

                if (value > this.totalCells)
                {
                    throw new ArgumentException("The mines cannot be more that the free cells.");
                }

                this.numberOfMines = value;
            }
        }

        public void PrintBoardWithHiddenMines()
        {
            this.Print(this.BoardWithHiddenMines);
        }

        public void PrintBoardWithMines()
        {
            this.Print(this.BoardWithMines);
        }

        private void Print(char[,] board)
        {
            Console.WriteLine("\n     " + this.GenerateSequentialNumbers());
            Console.WriteLine("    " + this.GenerateDashedLine());

            for (int i = 0; i < this.Rows; i++)
            {
                Console.Write("{0,2} | ", i);
                for (int j = 0; j < this.Cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("    " + this.GenerateDashedLine() + "\n");
        }

        private string GenerateSequentialNumbers()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < this.Cols; i++)
            {
                if (i < 10)
                {
                    builder.AppendFormat("{0} ", i);
                }
                else
                {
                    builder.AppendFormat("{0}", i);
                }
            }

            return builder.ToString();
        }

        private string GenerateDashedLine()
        {
            return new string('-', this.Cols * 2);
        }

        private char[,] CreateBoardWithHiddenMines()
        {
            return this.CreateMatrixFilledWithSymbols('?');
        }

        private char[,] CreateBoardWithMines()
        {
            var board = this.CreateMatrixFilledWithSymbols('-');
            var randomNumbers = this.GenerateRandomNumbers();
            int mineRow;
            int mineCol;

            foreach (int number in randomNumbers)
            {
                mineRow = number / this.Cols;
                mineCol = number % this.Cols;
                board[mineRow, mineCol] = '*';
            }

            return board;
        }

        private char[,] CreateMatrixFilledWithSymbols(char symbol)
        {
            var board = new char[this.Rows, this.Cols];
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    board[i, j] = symbol;
                }
            }

            return board;
        }

        private List<int> GenerateRandomNumbers()
        {
            var randomNumbers = new List<int>();
            while (randomNumbers.Count < this.NumberOfMines)
            {
                Random random = new Random();
                int currentNumber = random.Next(this.totalCells);
                if (!randomNumbers.Contains(currentNumber))
                {
                    randomNumbers.Add(currentNumber);
                }
            }

            return randomNumbers;
        }
    }
}
