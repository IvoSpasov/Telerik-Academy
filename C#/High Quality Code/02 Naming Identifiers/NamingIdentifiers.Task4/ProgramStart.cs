using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamingIdentifiers.Task4 // mini4ki
{
    public class minite
    {
        private PlayingBoard playingBoard; 

        static int counter = 0;
        static bool grum = false;
        static var players = new List<Player>();
        static int row = 0;
        static int col = 0;
        static bool flag = true;
        static const int maks = 35;
        static bool flag2 = false;

        public static void ProcessCommand(string command)
        {
            switch (command)
            {
                case "top":
                    PrintHighscores(players);
                    break;
                case "restart":
                    playingBoard = CreatePlayingBoard();
                    bombsBoard = slojibombite();
                    PrintPlayingBoard(playingBoard);
                    grum = false;
                    flag = false;
                    break;
                case "exit":
                    Console.WriteLine("Thank you for playing.");
                    break;
                case "turn":
                    if (bombsBoard[row, col] != '*')
                    {
                        if (bombsBoard[row, col] == '-')
                        {
                            tisinahod(playingBoard, bombsBoard, row, col);
                            counter++;
                        }
                        if (maks == counter)
                        {
                            flag2 = true;
                        }
                        else
                        {
                            PrintPlayingBoard(playingBoard);
                        }
                    }
                    else
                    {
                        grum = true;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

        public void StartGame()
        {
            playingBoard = new PlayingBoard(5, 10);

            string command;

            Console.WriteLine("Let's play “mines”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                            " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
            //PrintPlayingBoard(playingBoard);

            while (true)
            {
                Console.Write("Please enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command == "exit")
                {
                    break;
                }

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= playingBoard.GetLength(0) && col <= playingBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                ProcessCommand(command);
            }
        }


        static void Main()
        {
            StartGame();


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

        private static void tisinahod(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }



        

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
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