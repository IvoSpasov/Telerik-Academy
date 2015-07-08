using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingIdentifiers.Task4
{
    public class PlayingBoard
    {
        private const int NumberOfMines = 15;
        private int rows;
        private int cols;
        private char[,] boardWithHiddenMines;
        private char[,] boardWithMines;

        public PlayingBoard(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
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

        public void Print()
        {
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < this.rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < this.cols; j++)
                {
                    Console.Write(string.Format("{0} ", this.boardWithHiddenMines[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private char[,] CreateBoardWithHiddenMines()
        {
            return this.CreateMatrixFilledWithSymbols('?', this.rows, this.cols);
        }

        private char[,] CreateBoardWithMines()
        {
            var board = this.CreateMatrixFilledWithSymbols('-', this.rows, this.cols);

            //TODO: fix logic
            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < NumberOfMines)
            {
                Random random = new Random();
                int currentNumber = random.Next(50);
                if (!randomNumbers.Contains(currentNumber))
                {
                    randomNumbers.Add(currentNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int col = (number / this.cols);
                int row = (number % this.cols);
                if (row == 0 && number != 0)
                {
                    col--;
                    row = this.cols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private char[,] CreateMatrixFilledWithSymbols(char symbol, int rows, int cols)
        {
            var board = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = symbol;
                }
            }

            return board;
        }
    }
}
