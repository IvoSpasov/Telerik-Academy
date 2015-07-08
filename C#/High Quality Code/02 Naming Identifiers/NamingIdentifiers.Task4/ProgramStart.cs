using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamingIdentifiers.Task4
{
    public class ProgramStart
    {
        public static void Main()
        {
            var game = new Game();
            game.Start();

            //do
            //{
            //    if (flag)
            //    {

            //        flag = false;
            //    }

            //    
            //}
            //while (command != "exit");
        }

        private static void PrintHighscores(List<Player> players)
        {
            Console.WriteLine("\nPoints:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores yet.\n");
            }
        }

        //private static void smetki(char[,] pole)
        //{
        //    int kol = pole.GetLength(0);
        //    int red = pole.GetLength(1);

        //    for (int i = 0; i < kol; i++)
        //    {
        //        for (int j = 0; j < red; j++)
        //        {
        //            if (pole[i, j] != '*')
        //            {
        //                char kolkoo = kolko(pole, i, j);
        //                pole[i, j] = kolkoo;
        //            }
        //        }
        //    }
        //}
    }
}