using System;

class NumberToText
{
    static void Main()
    {
        char digit1, digit2, digit3;
        string d1 = "", d2 = "", d3 = "", allDigits;
        int number1 = 0, number2 = 0, number3 = 0, number = 0;

        bool parseSuccess = false;

        Console.WriteLine("This program converts a number in the range [0...999] to a text corresponding\n" +
            "to its English pronunciation");


        while (parseSuccess == false)
        {
            Console.Write("Please type in a number: ");

            digit1 = (char)Console.Read(); // Takes the first character only.
            digit2 = (char)Console.Read(); // Takes the second character only.
            digit3 = (char)Console.Read(); // Takes the third character only.
            // The idea is that I take the information seperately by reading it character by character. In this way I 
            // can easily tell the program how to print the pronunciations of the numbers by using "if" and "switch"
            // conditional statements.

            if (digit1 != '\r')
            {
                d1 = Convert.ToString(digit1); // Convert the first char to string.
                parseSuccess = int.TryParse(d1, out number1); // Then convert the same string to int. Now we have the first digit in type int.
                //number = number1;
                allDigits = d1;                // Put the value of the firts string in the variable allDigits.
                parseSuccess = int.TryParse(allDigits, out number); // Then convert the string to nubmber. 
                // Here number1 and number will have the same int value (but only here).
                // In this case we can simply write "number = number1", but I'll leave it in this way so that it is not too 
                // confusing when you continue reading the code.
            }

            if (digit2 != '\r' && digit2 != '\n') // If we read at least one of the characters \r or \n do no enter in the loop.
            {
                d2 = Convert.ToString(digit2); // Convert the second char to string.
                parseSuccess = int.TryParse(d2, out number2); // Then convert the same string to int. Now we have the second digit in type int.
                allDigits = d1 + d2; // Put the value of the firts and second strings in the variable allDigits.
                parseSuccess = int.TryParse(allDigits, out number); // Then convert the string to nubmber. 
                // Here number2 and number will have different values.
            }

            if (digit3 != '\r' && digit3 != '\n')// If we read at least one of the characters \r or \n do no enter in the loop.
            {
                d3 = Convert.ToString(digit3); // Convert the third char to string.
                parseSuccess = int.TryParse(d3, out number3); // Then convert the same string to int. Now we have the third digit in type int.
                allDigits = d1 + d2 + d3;   // Put the value of the firts, second and third strings in the variable allDigits.
                parseSuccess = int.TryParse(allDigits, out number); // Then convert the string to nubmber.
                // Here "number3" and "number" will have different values.
            }

            // This statement is executed only if you enter something different than numbers.
            if (parseSuccess == false) // I try to clean the "char buffer" here. It works except if you enter only one charachter.
            {                          // I'm not sure how to fix it.
                Console.ReadLine();
            }
        }

        if (number >= 0 && number <= 9)
        {
            switch (number1)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default:
                    break;
            }
        }
        // Here is the end of the conditional statements for printing the pronunciation from 0 to 9.

        if (number > 9 && number <= 19)
        {
            switch (number2)
            {
                case 0: Console.WriteLine("Ten"); break;
                case 1: Console.WriteLine("Eleven"); break;
                case 2: Console.WriteLine("Twelve"); break;
                case 3: Console.WriteLine("Thirteen"); break;
                case 4: Console.WriteLine("Fourteen"); break;
                case 5: Console.WriteLine("Fifteen"); break;
                case 6: Console.WriteLine("Sixteen"); break;
                case 7: Console.WriteLine("Seventeen"); break;
                case 8: Console.WriteLine("Eighteen"); break;
                case 9: Console.WriteLine("Nineteen"); break;
                default:
                    break;
            }
        }
        // Here is the end of the conditional statements for printing the pronunciation from 10 to 19.

        if (number > 19 && number <= 99)
        {
            switch (number1)
            {
                case 2: Console.Write("Twenty"); break;
                case 3: Console.Write("Thirty"); break;
                case 4: Console.Write("Fourty"); break;
                case 5: Console.Write("Fifty"); break;
                case 6: Console.Write("Sixty"); break;
                case 7: Console.Write("Seventy"); break;
                case 8: Console.Write("Eighty"); break;
                case 9: Console.Write("Ninety"); break;
                default:
                    break;
            }

            Console.Write(" ");

            switch (number2)
            {
                case 0: Console.WriteLine(""); break;
                case 1: Console.WriteLine("one."); break;
                case 2: Console.WriteLine("two."); break;
                case 3: Console.WriteLine("three."); break;
                case 4: Console.WriteLine("four."); break;
                case 5: Console.WriteLine("five."); break;
                case 6: Console.WriteLine("six."); break;
                case 7: Console.WriteLine("seven."); break;
                case 8: Console.WriteLine("eight."); break;
                case 9: Console.WriteLine("nine."); break;
                default:
                    break;
            }
        }
        // Here is the end of the conditional statements for printing the pronunciation from 19 to 99.

        if (number > 99 && number <= 999)
        {
            switch (number1)
            {
                case 0: Console.Write(""); break;
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                default:
                    break;
            }

            Console.Write(" hundred and ");

            switch (number2)
            {
                case 0: Console.Write("\b"); break; // \b is backspace. I use it to delete "one space" when we have 208 or 304 or 501 for exapmple.
                case 2: Console.Write("twenty"); break;
                case 3: Console.Write("thirty"); break;
                case 4: Console.Write("fourty"); break;
                case 5: Console.Write("fifty"); break;
                case 6: Console.Write("sixty"); break;
                case 7: Console.Write("seventy"); break;
                case 8: Console.Write("eighty"); break;
                case 9: Console.Write("ninety"); break;
                default:
                    break;
            }

            Console.Write(" ");

            switch (number3)
            {
                case 0: Console.WriteLine("\b\b\b\b   "); break; // Here I use the backspace to the delete the "and" when we have 200 or 300 or 900 for example.
                case 1: Console.WriteLine("one."); break;
                case 2: Console.WriteLine("two."); break;
                case 3: Console.WriteLine("three."); break;
                case 4: Console.WriteLine("four."); break;
                case 5: Console.WriteLine("five."); break;
                case 6: Console.WriteLine("six."); break;
                case 7: Console.WriteLine("seven."); break;
                case 8: Console.WriteLine("eight."); break;
                case 9: Console.WriteLine("nine."); break;
                default:
                    break;
            }
        }
        // Here is the end of the conditional statements for printing the pronunciation from 99 to 999.
    }
}

// Ok so this is the idea I've come up with. Probably there is a better solution and the code can be optimized but I'm a 
// begginer so for now I'm just happy that it works properly when you enter up to three numbers.