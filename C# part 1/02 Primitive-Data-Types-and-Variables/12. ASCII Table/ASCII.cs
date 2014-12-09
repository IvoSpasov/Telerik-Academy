using System;


    class ASCII
    {
        static void Main()
        {

            Console.WindowHeight = 35;


            int column1, column2, column3, column4; //Variables used for the real numbers in the four columns.
            char a, b, c, d;                        //Varaibles used to cast int to char for the four columns.

            for (column1 = 0; column1 < 32; column1++)
            {
                a = (char)column1;

                column2 = column1 + 32;
                b = (char)column2;

                column3 = column2 + 32;
                c = (char)column3;

                column4 = column3 + 32;
                d = (char)column4;

                // The idea is that I use the "if" and "else if" statements to fix the "broken" lines of the ASCII table.
                // With the "else" statement I print the rest of the table. 
                // There could be a better solution, but for now this is what I've come up with. 
                // I did it in this way, beacuse I wanted the table to have 4 columns, each one starting from (+32) -> 0, 32, 64, 96 
                // and the next number to be on a new line.

                if (column1 == 0)
                {
                    Console.WriteLine("0 -> Null\t 32 -> Space\t\t {0} -> {1}\t\t {2} -> {3}",
                    column3, c, column4, d);
                }
                else if (column1 == 7)
                {
                    Console.WriteLine("7 -> Bell\t {0} -> {1}\t\t {2} -> {3}\t\t {4} -> {5}",
                    column2, b, column3, c, column4, d);
                }
                else if (column1 == 8)
                {
                    Console.WriteLine("8 -> Backspace\t {0} -> {1}\t\t {2} -> {3}\t\t {4} -> {5}",
                    column2, b, column3, c, column4, d);
                }
                else if (column1 == 9)
                {
                    Console.WriteLine("9 -> Tab\t {0} -> {1}\t\t {2} -> {3}\t\t {4} -> {5}",
                    column2, b, column3, c, column4, d);
                }
                else if (column1 == 10)
                {
                    Console.WriteLine("10 -> New line\t {0} -> {1}\t\t {2} -> {3}\t\t {4} -> {5}",
                    column2, b, column3, c, column4, d);
                }
                else if (column1 == 13)
                {
                    Console.WriteLine("13 -> Carr. RTN\t {0} -> {1}\t\t {2} -> {3}\t\t {4} -> {5}",
                    column2, b, column3, c, column4, d);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}\t\t {2} -> {3}\t\t {4} -> {5}\t\t {6} -> {7}",
                    column1, a, column2, b, column3, c, column4, d);
                }


            }
        }
    }

