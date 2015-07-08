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
            this.rows = rows;
            this.cols = cols;
            this.boardWithHiddenMines = this.CreateBoardWithHiddenMines();
            this.boardWithMines = this.CreateBoardWithMines();
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
