namespace NamingIdentifiers.Task4
{
    using System;
    using System.Collections.Generic;

    public class PlayingBoard
    {
        private const int NumberOfMines = 15;
        private readonly int totalCells;
        private int rows;
        private int cols;
        private char[,] boardWithHiddenMines;
        private char[,] boardWithMines;

        public PlayingBoard(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.totalCells = this.Rows * this.Cols;
            this.BoardWithHiddenMines = this.CreateBoardWithHiddenMines();
            this.BoardWithMines = this.CreateBoardWithMines();
            this.NumberOfSafeCells = this.totalCells - NumberOfMines;
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
                    throw new ArgumentException("The rows cannot be zero or less");
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
                    throw new ArgumentException("The columns cannot be zero or less");
                }

                this.cols = value;
            }
        }

        public int NumberOfSafeCells { get; private set; }

        public char[,] BoardWithHiddenMines
        {
            get { return this.boardWithHiddenMines; }
            private set { this.boardWithHiddenMines = value; }
        }

        public char[,] BoardWithMines
        {
            get { return this.boardWithMines; }
            private set { this.boardWithMines = value; }
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
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < this.Rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < this.Cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
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
            while (randomNumbers.Count < NumberOfMines)
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
