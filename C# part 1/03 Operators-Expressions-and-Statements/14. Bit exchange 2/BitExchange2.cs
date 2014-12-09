using System;

    class BitExchange2
    {
        static void Main()
        {
            // This program follows the logic of the previous one but it has some additional changes to meet the new requirements.
            
            uint number, numberOp1, bitStart, bitEnd;
            int p, k, q, offset; // These are the additional variables that I use. I simply replace the places of the numbers
                                 // used in the previous task with the new variables and put everything in a loop.
           // I also use "if" conditional statement for (q > p), (p > q) and (q = p), because they don't say anything about it.

            Console.WriteLine("This program exchanges bits following the rule -> exchange bits\n{p, p+1, ..., p+k-1) with bits {q, q+1, ..., q+k-1}.");
            Console.Write("Please type in the value of the number: ");
            number = uint.Parse(Console.ReadLine());
            Console.Write("Which in binary numerial system is: ");
            Console.WriteLine(Convert.ToString(number,2).PadLeft(32, '0'));
            Console.Write("Please type in the position of the first starting bit for exchange (p): ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Please type in the position of the scond starting bit for exchange (q): ");
            q = int.Parse(Console.ReadLine());
            Console.Write("Please type in how many bits you want to exhange (k): ");
            k = int.Parse(Console.ReadLine());


            if (q > p) // First case
            {
                offset = (q - p); // Yes I know I can use Math.Abs(q-p) for both "if" statements but it will probaply be slower.
                for (int i = 0; i < k; i++)
                {
                    bitStart = (uint)(1 << p); // p instead of 3 (if we compare this code to the one in the previous task)
                    bitStart &= number;

                    if (bitStart != 0)
                    {
                        bitStart <<= offset; // offset instead of 21
                        numberOp1 = number | bitStart;
                    }
                    else
                    {
                        bitStart = (uint)(1 << q); // q instead of 24
                        bitStart = ~bitStart;
                        numberOp1 = number & bitStart;
                    }

                    bitEnd = (uint)(1 << q); // q instead of 24
                    bitEnd &= number;

                    if (bitEnd != 0)
                    {
                        bitEnd >>= offset; // offset instead of 21
                        number = numberOp1 | bitEnd;
                    }
                    else
                    {
                        bitEnd = (uint)(1 << p); // p instead of 3
                        bitEnd = ~bitEnd;
                        number = numberOp1 & bitEnd;
                    }

                    p++; // This is how I go to the next bit for exchange.
                    q++; //
                }

                Console.WriteLine();
                Console.WriteLine("The value of the new number is: " + number);
                Console.Write("Which in binary numerial system is: ");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine();

            }
            else if (p > q) // Second case
            {
                offset = (p - q); // Here we have a difference -> (p - q) instead of (q - p). 
                for (int i = 0; i < k; i++)
                {
                    bitStart = (uint)(1 << p);
                    bitStart &= number;

                    if (bitStart != 0)
                    {
                        bitStart >>= offset; // Here we have a difference -> ">>" instead of "<<"
                        numberOp1 = number | bitStart;
                    }
                    else
                    {
                        bitStart = (uint)(1 << q);
                        bitStart = ~bitStart;
                        numberOp1 = number & bitStart;
                    }

                    bitEnd = (uint)(1 << q);
                    bitEnd &= number;

                    if (bitEnd != 0)
                    {
                        bitEnd <<= offset; // Here we have a difference -> "<<" instead of ">>"
                        number = numberOp1 | bitEnd;
                    }
                    else
                    {
                        bitEnd = (uint)(1 << p);
                        bitEnd = ~bitEnd;
                        number = numberOp1 & bitEnd;
                    }

                    p++;
                    q++;

                    //Everything else is the same as "First case" except the places where I've written a comment.
                }

                Console.WriteLine();
                Console.WriteLine("The value of the new number is: " + number);
                Console.Write("Which in binary numerial system is: ");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine();
            }
            else // Third case (p = q)
            {
                Console.WriteLine();
                Console.WriteLine("The value of the new number is: " + number);
                Console.WriteLine();
                Console.WriteLine("You are trying to exchange the places of one and the same bits (q = p).");
                Console.WriteLine("That is why the number is the same.");
                Console.WriteLine();
            }

            
        }
    }

