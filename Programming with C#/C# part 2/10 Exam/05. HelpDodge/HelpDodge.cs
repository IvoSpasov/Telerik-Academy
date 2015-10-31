namespace _05.HelpDodge
{
    using System;

    class HelpDodge
    {
        private static int possibleWays = 0;

        static void Main()
        {
            char[,] grid = CreateGrid();
            int dodgeXPos = 0;
            int dodgeYPos = 0;

            FindAllPaths(grid, dodgeXPos, dodgeYPos);
            Console.WriteLine(possibleWays);
        }

        static void FindAllPaths(char[,] grid, int row, int col)
        {
            if (row >= grid.GetLength(0) || col >= grid.GetLength(1))
            {
                return;
            }
            if (grid[row, col] == 'e')
            {
                return;
            }
            if (grid[row, col] == 'f')
            {
                possibleWays++;
                return;
            }

            FindAllPaths(grid, row, col + 1);
            FindAllPaths(grid, row + 1, col);
        }

        static char[,] CreateGrid()
        {
            string[] gridSizes = Console.ReadLine().Split(' ');
            int n = int.Parse(gridSizes[0]);
            int m = int.Parse(gridSizes[1]);
            string[] foodLocation = Console.ReadLine().Split(' ');
            int fx = int.Parse(foodLocation[0]);
            int fy = int.Parse(foodLocation[1]);
            int dodgeEnemies = int.Parse(Console.ReadLine());
            string[] currentEnemy;
            int currentEnemyXPos;
            int currentEnemyYPos;
            char[,] grid = new char[n, m];
            grid[fx, fy] = 'f';

            for (int i = 0; i < dodgeEnemies; i++)
            {
                currentEnemy = Console.ReadLine().Split(' ');
                currentEnemyXPos = int.Parse(currentEnemy[0]);
                currentEnemyYPos = int.Parse(currentEnemy[1]);
                grid[currentEnemyXPos, currentEnemyYPos] = 'e';
            }

            return grid;
        }
    }
}

// much faster solution

//namespace HelpDoge
//{
//    using System;
//    using System.Numerics;

//    internal class HelpDoge
//    {
//        private const int Enemy = -1;

//        private static int n, m, fx, fy;

//        private static BigInteger[,] field;

//        private static void Main()
//        {
//            Input();

//            var answer = Solve();

//            Console.WriteLine(answer);
//        }

//        private static void Input()
//        {
//            // On the first line there will be the numbers N and M, separated by a single space.
//            var line = Console.ReadLine().Split(' ');
//            n = int.Parse(line[0]);
//            m = int.Parse(line[1]);
//            field = new BigInteger[n, m];

//            // On the second line there will be the integer numbers Fx and Fy, separated by a single space.
//            line = Console.ReadLine().Split(' ');
//            fx = int.Parse(line[0]);
//            fy = int.Parse(line[1]);

//            // On the third line there will be the number K – the number of Doge`s enemies. Many enemies.
//            var k = int.Parse(Console.ReadLine());

//            for (int i = 0; i < k; i++)
//            {
//                // On the next K lines there will be the X and Y coordinates for each Doge`s enemy, separated by a space.
//                line = Console.ReadLine().Split(' ');
//                var enemyX = int.Parse(line[0]);
//                var enemyY = int.Parse(line[1]);

//                field[enemyX, enemyY] = Enemy;
//            }
//        }

//        /// <summary>
//        /// Solving the task using dynamic programming technique.
//        /// </summary>
//        private static BigInteger Solve()
//        {
//            for (int x = 0; x < n; x++)
//            {
//                for (int y = 0; y < m; y++)
//                {
//                    if (x == 0 && y == 0)
//                    {
//                        // Such Doge.
//                        field[x, y] = 1;
//                        continue;
//                    }

//                    if (field[x, y] == Enemy)
//                    {
//                        field[x, y] = 0;
//                        continue;
//                    }

//                    var left = y > 0 ? field[x, y - 1] : 0;
//                    var top = x > 0 ? field[x - 1, y] : 0;

//                    field[x, y] = left + top;

//                    if (x == fx && y == fy)
//                    {
//                        // Stop when find the answer. No need to continue. Much improvement.
//                        return field[fx, fy];
//                    }
//                }
//            }

//            return field[fx, fy]; // Wow.
//        }
//    }
//}

