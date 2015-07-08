using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamingIdentifiers.Task4 // mini4ki
{
    public class ProgramStart
    {
        


        

        


        static void Main()
        {
            var game = new Game();
            game.Start();


            //do
            //{
            //    if (flag)
            //    {

                    
            //        flag = false;
            //    }

                
       

                
            //    if (grum)
            //    {
            //        PrintPlayingBoard(bombsBoard);
            //        Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
            //            "Daj si niknejm: ", counter);
            //        string niknejm = Console.ReadLine();
            //        Player t = new Player(niknejm, counter);
            //        if (players.Count < 5)
            //        {
            //            players.Add(t);
            //        }
            //        else
            //        {
            //            for (int i = 0; i < players.Count; i++)
            //            {
            //                if (players[i].Points < t.Points)
            //                {
            //                    players.Insert(i, t);
            //                    players.RemoveAt(players.Count - 1);
            //                    break;
            //                }
            //            }
            //        }
            //        players.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
            //        players.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
            //        PrintHighscores(players);

            //        playingBoard = CreatePlayingBoard();
            //        bombsBoard = slojibombite();
            //        counter = 0;
            //        grum = false;
            //        flag = true;
            //    }
            //    if (flag2)
            //    {
            //        Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
            //        PrintPlayingBoard(bombsBoard);
            //        Console.WriteLine("Daj si imeto, batka: ");
            //        string imeee = Console.ReadLine();
            //        Player to4kii = new Player(imeee, counter);
            //        players.Add(to4kii);
            //        PrintHighscores(players);
            //        playingBoard = CreatePlayingBoard();
            //        bombsBoard = slojibombite();
            //        counter = 0;
            //        flag2 = false;
            //        flag = true;
            //    }
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