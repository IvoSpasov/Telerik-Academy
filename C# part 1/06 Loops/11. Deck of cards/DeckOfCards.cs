using System;

    class DeckOfCards
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("This program prints all possible cards from a standard deck of 52 cards.");
            Console.WriteLine();

            for (int suits = 1; suits <= 4; suits++)
            {
                for (int cards = 1; cards <= 13; cards++)
                {
                    switch (cards)
                    {
                        case 1: Console.Write("Ace of ".PadLeft(12)); break;
                        case 2: Console.Write("Two of ".PadLeft(12)); break;
                        case 3: Console.Write("Three of ".PadLeft(12)); break;  // With offset it looks better on the console.
                        case 4: Console.Write("{0,12}", "Four of "); break;     // I intentioanlly used two types of having string
                        case 5: Console.Write("{0,12}", "Five of "); break;     // offset, so that I can remember them and help you
                        case 6: Console.Write("{0,12}", "Six of "); break;      // to see them too.
                        case 7: Console.Write("{0,12}", "Seven of "); break;
                        case 8: Console.Write("{0,12}", "Eight of "); break;
                        case 9: Console.Write("{0,12}", "Nine of "); break;
                        case 10: Console.Write("{0,12}", "Ten of "); break;
                        case 11: Console.Write("{0,12}", "Jack of "); break;
                        case 12: Console.Write("{0,12}", "Queen of "); break;
                        case 13: Console.Write("{0,12}", "King of "); break;
                        default:
                            break;
                    }
                    switch (suits)
                    {
                        case 1: Console.WriteLine("clubs " + '\u2663'); break;
                        case 2: Console.WriteLine("diamonds " + '\u2666'); break;
                        case 3: Console.WriteLine("hearts " + '\u2665'); break;
                        case 4: Console.WriteLine("spades " + '\u2660'); break;
                        default:
                            break;
                    }
                    
                }

            }

        }
    }

