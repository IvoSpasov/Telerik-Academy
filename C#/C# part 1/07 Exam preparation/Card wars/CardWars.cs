using System;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        int numberOfGames = int.Parse(Console.ReadLine());
        BigInteger totalScorePlayer1 = 0, totalScorePlayer2 = 0;
        int gamesPlayer1Won = 0, gamesPlayer2Won = 0;

        for (int i = 0; i < numberOfGames; i++)
        {
            BigInteger handStrenghtPlayer1 = 0, handStrenghtPlayer2 = 0;
            bool cardXPlayer1 = false, cardXPlayer2 = false;

            for (int card = 0; card < 3; card++) // calculating score for player 1
            {
                string cardPlayer1 = Console.ReadLine();

                switch (cardPlayer1)
                {
                    case "2": handStrenghtPlayer1 += 10; break;
                    case "3": handStrenghtPlayer1 += 9; break;
                    case "4": handStrenghtPlayer1 += 8; break;
                    case "5": handStrenghtPlayer1 += 7; break;
                    case "6": handStrenghtPlayer1 += 6; break;
                    case "7": handStrenghtPlayer1 += 5; break;
                    case "8": handStrenghtPlayer1 += 4; break;
                    case "9": handStrenghtPlayer1 += 3; break;
                    case "10": handStrenghtPlayer1 += 2; break;
                    case "A": handStrenghtPlayer1 += 1; break;
                    case "J": handStrenghtPlayer1 += 11; break;
                    case "Q": handStrenghtPlayer1 += 12; break;
                    case "K": handStrenghtPlayer1 += 13; break;
                    case "Z": totalScorePlayer1 *= 2; break;
                    case "Y": totalScorePlayer1 -= 200; break;
                    case "X": cardXPlayer1 = true; break;
                    default:
                        break;
                }
            }

            for (int card = 0; card < 3; card++) // calculating score for player 2
            {
                string cardPlayer2 = Console.ReadLine();

                switch (cardPlayer2)
                {
                    case "2": handStrenghtPlayer2 += 10; break;
                    case "3": handStrenghtPlayer2 += 9; break;
                    case "4": handStrenghtPlayer2 += 8; break;
                    case "5": handStrenghtPlayer2 += 7; break;
                    case "6": handStrenghtPlayer2 += 6; break;
                    case "7": handStrenghtPlayer2 += 5; break;
                    case "8": handStrenghtPlayer2 += 4; break;
                    case "9": handStrenghtPlayer2 += 3; break;
                    case "10": handStrenghtPlayer2 += 2; break;
                    case "A": handStrenghtPlayer2 += 1; break;
                    case "J": handStrenghtPlayer2 += 11; break;
                    case "Q": handStrenghtPlayer2 += 12; break;
                    case "K": handStrenghtPlayer2 += 13; break;
                    case "Z": totalScorePlayer2 *= 2; break;
                    case "Y": totalScorePlayer2 -= 200; ; break;
                    case "X": cardXPlayer2 = true; break;
                    default:
                        break;
                }
            }

            // Code below -> for X card
            if (cardXPlayer1 && cardXPlayer2)
            {
                totalScorePlayer1 += 50;
                totalScorePlayer2 += 50;
            }
            else if (cardXPlayer1 && !cardXPlayer2)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (cardXPlayer2 && !cardXPlayer1)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            // Code below -> getting the bigger hand strenght of the two players and adding it to the total score 
            if (handStrenghtPlayer1 > handStrenghtPlayer2)
            {
                totalScorePlayer1 += handStrenghtPlayer1;
                gamesPlayer1Won++;

            }
            else if (handStrenghtPlayer1 < handStrenghtPlayer2)
            {
                totalScorePlayer2 += handStrenghtPlayer2;
                gamesPlayer2Won++;
            }
        }

        if (totalScorePlayer1 > totalScorePlayer2)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", totalScorePlayer1);
            Console.WriteLine("Games won: {0}", gamesPlayer1Won);
        }
        else if (totalScorePlayer1 < totalScorePlayer2)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", totalScorePlayer2);
            Console.WriteLine("Games won: {0}", gamesPlayer2Won);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", totalScorePlayer1);
        }

    }
}

// Score 100/100