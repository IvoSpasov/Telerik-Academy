using System;

    class DigitName
    {
        static void Main()
        {
            int digit;
            bool parseSuccess = true;

            Console.WriteLine("This program asks for a digit and depending on the input shows the name of\nthat digit.");
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please type in a digit in the correct format: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out digit);
                }
                else
                {
                    Console.Write("Please type in a digit: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out digit);
                }

            } while (parseSuccess == false);

            Console.Write("The name is: ");

            switch (digit)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;

                default: Console.WriteLine("\rThe digits consist of one symbol only -> from \"0\" to \"9\".");
                    break;
            }
        }
    }

