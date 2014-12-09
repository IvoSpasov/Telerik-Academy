using System;

    class BonusScores
    {
        static void Main()
        {
            int score;
            bool parseSuccess = true;

            Console.WriteLine("This program applies bonus scores to a given score in the range [1..9].");

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a score in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out score);
                }
                else
                {
                    Console.Write("Please type in a score: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out score);
                }

            } while (parseSuccess == false);


            switch (score)
            {
                case 1:
                case 2: 
                case 3:
                    score *= 10;
                    Console.WriteLine("Your current score is: " + score);
                    break;
                case 4:
                case 5:
                case 6:
                    score *= 100;
                    Console.WriteLine("Your current score is: " + score);
                    break;
                case 7:
                case 8: 
                case 9:
                    score *= 1000;
                    Console.WriteLine("Your current score is: " + score);
                    break;
                default:
                    Console.WriteLine("You must enter a digit from 1 to 9");
                    break;
            }
        }
    }

