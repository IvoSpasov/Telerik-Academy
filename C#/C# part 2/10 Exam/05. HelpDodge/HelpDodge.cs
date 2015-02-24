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
