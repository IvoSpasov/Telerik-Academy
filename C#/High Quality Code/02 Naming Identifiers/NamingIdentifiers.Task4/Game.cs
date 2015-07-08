using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingIdentifiers.Task4
{
    public class Game
    {
        private PlayingBoard playingBoard; 

        public void Start()
        {
            playingBoard = new PlayingBoard(5, 10);
            string command;

            Console.WriteLine("Let's play “mines”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                            " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
            playingBoard.Print();

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
    }
}
