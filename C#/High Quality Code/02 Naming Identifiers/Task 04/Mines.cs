namespace Task_04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mines
    {
        const int BOARD_ROWS = 5;
        const int BOARD_COLS = 10;
        const int NUMBER_OF_MINES = 15;

        static void Main()
        {
            const int MARKS = 35;
            string playerCommand = string.Empty;
            char[,] playingBoard = CreatePlayingBoard();
            char[,] mines = CreateMines();
            int counter = 0;
            bool steppedOnMine = false;
            List<Points> players = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Let's play “Mines”. Try to find the fields without mines. " +
                                      "Command 'top' shows the score, 'restart' starts a new game, 'exit' exits the game!");
                    CreateLegend(playingBoard);
                    flag = false;
                }
                Console.Write("Enter row and column: ");
                playerCommand = Console.ReadLine().Trim();
                if (playerCommand.Length >= 3)
                {
                    if (int.TryParse(playerCommand[0].ToString(), out row) &&
                        int.TryParse(playerCommand[2].ToString(), out col) &&
                        row <= playingBoard.GetLength(0) && col <= playingBoard.GetLength(1))
                    {
                        playerCommand = "turn";
                    }
                }
                switch (playerCommand)
                {
                    case "top":
                        Score(players);
                        break;
                    case "restart":
                        playingBoard = CreatePlayingBoard();
                        mines = CreateMines();
                        CreateLegend(playingBoard);
                        steppedOnMine = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                tisinahod(playingBoard, mines, row, col);
                                counter++;
                            }
                            if (MARKS == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                CreateLegend(playingBoard);
                            }
                        }
                        else
                        {
                            steppedOnMine = true;
                        }
                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Error! Invalid command" + Environment.NewLine);
                        break;
                }
                if (steppedOnMine)
                {
                    CreateLegend(mines);
                    Console.Write(Environment.NewLine + "You died with {0} points. " +
                                  "Type in your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Points t = new Points(nickname, counter);
                    if (players.Count < 5)
                    {
                        players.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].NumberOfPoints < t.NumberOfPoints)
                            {
                                players.Insert(i, t);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }
                    players.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    players.Sort((Points r1, Points r2) => r2.NumberOfPoints.CompareTo(r1.NumberOfPoints));
                    Score(players);

                    playingBoard = CreatePlayingBoard();
                    mines = CreateMines();
                    counter = 0;
                    steppedOnMine = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine(Environment.NewLine +
                                      "Congratulations. You've opened all cells without triggering a bomb.");
                    CreateLegend(mines);
                    Console.WriteLine("Please type in your name: ");
                    string imeee = Console.ReadLine();
                    Points to4kii = new Points(imeee, counter);
                    players.Add(to4kii);
                    Score(players);
                    playingBoard = CreatePlayingBoard();
                    mines = CreateMines();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (playerCommand != "exit");

            Console.Read();
        }

        private static void Score(List<Points> points)
        {
            Console.WriteLine(Environment.NewLine + "Points:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, points[i].Name, points[i].NumberOfPoints);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No score available." + Environment.NewLine);
            }
        }

        private static void tisinahod(char[,] board, char[,] mines, int row, int col)
        {
            char kolkoBombi = kolko(mines, row, col);
            mines[row, col] = kolkoBombi;
            board[row, col] = kolkoBombi;
        }

        private static void CreateLegend(char[,] playingBoard)
        {
            int rows = playingBoard.GetLength(0);
            int cols = playingBoard.GetLength(1);
            Console.WriteLine(Environment.NewLine + "    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", playingBoard[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------" + Environment.NewLine);
        }

        private static char[,] CreatePlayingBoard()
        {
            char[,] playingBoard = new char[BOARD_ROWS, BOARD_COLS];
            for (int i = 0; i < BOARD_ROWS; i++)
            {
                for (int j = 0; j < BOARD_COLS; j++)
                {
                    playingBoard[i, j] = '?';
                }
            }

            return playingBoard;
        }

        private static char[,] CreateMines()
        {
            char[,] playingBoardWithMines = new char[BOARD_ROWS, BOARD_COLS];

            for (int i = 0; i < BOARD_ROWS; i++)
            {
                for (int j = 0; j < BOARD_COLS; j++)
                {
                    playingBoardWithMines[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < NUMBER_OF_MINES)
            {
                Random random = new Random();
                int position = random.Next(50);
                if (!mines.Contains(position))
                {
                    mines.Add(position);
                }
            }

            foreach (int mine in mines)
            {
                int col = (mine / BOARD_COLS);
                int row = (mine % BOARD_COLS);
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = BOARD_COLS;
                }
                else
                {
                    row++;
                }

                playingBoardWithMines[col, row - 1] = '*';
            }

            return playingBoardWithMines;
        }

        private static void Calculations(char[,] board) // bad name but no time
        {
            int col = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char kolkoo = kolko(board, i, j);
                        board[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            return char.Parse(brojkata.ToString());
        }
    }
}