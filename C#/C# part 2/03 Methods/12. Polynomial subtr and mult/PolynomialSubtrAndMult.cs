// Extend the program to support also subtraction and multiplication of polynomials.

using System;

class PolynomialSubtrAndMult
{
    // this method transfers the numbers read from the console (string) to int[] array
    static int[] PolyAsArray(string poly)
    {
        string[] separators = { " ", ", ", ",", " ,", "\t" };
        string[] polyStrArray = poly.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] polyIntArray = new int[polyStrArray.Length];

        for (int i = 0; i < polyIntArray.Length; i++)
        {
            polyIntArray[i] = int.Parse(polyStrArray[i]);
        }

        return polyIntArray;
    }

    // this method prints a polynomial from a given array
    static void PrintPoly(int[] polyArray)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        int power = polyArray.Length - 1;
        for (int i = 0; i < polyArray.Length - 2; i++)
        {
            if (polyArray[i] != 0)
            {
                if (polyArray[i] > 0)
                {
                    if (polyArray[i] != 1)
                    {
                        Console.Write("{0}x^{1} + ", polyArray[i], power);
                    }
                    else
                    {
                        Console.Write("x^{0} + ", power);
                    }
                }
                else
                {
                    if (polyArray[i] != -1)
                    {
                        Console.Write("({0}x^{1}) + ", polyArray[i], power);
                    }
                    else
                    {
                        Console.Write("(-x^{0}) + ", power);
                    }
                }
            }
            power--;

        }

        if (polyArray.Length > 1)
        {
            if (polyArray[polyArray.Length - 2] != 0)
            {
                if (polyArray[polyArray.Length - 2] > 0)
                {
                    if (polyArray[polyArray.Length - 2] != 1)
                    {
                        Console.Write("{0}x + ", polyArray[polyArray.Length - 2]);
                    }
                    else
                    {
                        Console.Write("x + ");
                    }
                }
                else
                {
                    if (polyArray[polyArray.Length - 2] != -1)
                    {
                        Console.Write("({0}x) + ", polyArray[polyArray.Length - 2]);
                    }
                    else
                    {
                        Console.Write("(-x) + ");
                    }
                }
            }
        }
        if (polyArray[polyArray.Length - 1] >= 0)
        {
            Console.WriteLine("{0}", polyArray[polyArray.Length - 1]);
        }
        else
        {
            Console.WriteLine("({0})", polyArray[polyArray.Length - 1]);
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    // this method sums two int arrays
    static int[] ArraySum(int[] first, int[] second)
    {
        // This method also works if the two arrays have different lenghts.
        Array.Reverse(first);
        Array.Reverse(second);
        bool check = false;
        int lenght = second.Length;
        if (first.Length > second.Length)
        {
            lenght = first.Length;
            check = true;
        }

        int[] firstArray = new int[lenght];
        int[] secondArray = new int[lenght];

        if (check)
        {
            firstArray = first; // no need to clone it
            for (int i = 0; i < second.Length; i++)
            {
                secondArray[i] = second[i];
            }
        }
        else
        {
            secondArray = second; // no need to clone it
            for (int i = 0; i < first.Length; i++)
            {
                firstArray[i] = first[i];
            }
        }

        int[] result = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            result[i] = firstArray[i] + secondArray[i];
        }

        Array.Reverse(result);
        return result;
    }

    // this method subtracts two int arrays
    static int[] ArraySubtraction(int[] first, int[] second)
    {
        // This method also works if the two arrays have different lenghts.
        Array.Reverse(first);
        Array.Reverse(second);
        bool check = false;
        int lenght = second.Length;
        if (first.Length > second.Length)
        {
            lenght = first.Length;
            check = true;
        }

        int[] firstArray = new int[lenght];
        int[] secondArray = new int[lenght];

        if (check)
        {
            firstArray = first; // no need to clone it
            for (int i = 0; i < second.Length; i++)
            {
                secondArray[i] = second[i];
            }
        }
        else
        {
            secondArray = second; // no need to clone it
            for (int i = 0; i < first.Length; i++)
            {
                firstArray[i] = first[i];
            }
        }

        int[] result = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            result[i] = firstArray[i] - secondArray[i];
        }

        Array.Reverse(result);
        return result;
    }

    // this method multiplies two int arrays
    static int[] ArrayMultiplication(int[] first, int[] second)
    {
        Array.Reverse(first);
        Array.Reverse(second);

        int[] result = new int[first.Length + second.Length];

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                result[i + j] += (first[i] * second[j]);
            }
        }

        Array.Reverse(result);
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the coefficients of the polynomials using spaces or commas.");
        Console.WriteLine("If you like to skip some of the memebers just type in 0 for the coefficient.");
        Console.WriteLine("e.g. 5 0 3 will look like 5x^2 + 3");
        Console.WriteLine("Please type in the first one:");
        string firstPoly = Console.ReadLine();
        Console.Write("which looks like: ");
        PrintPoly(PolyAsArray(firstPoly));

        Console.WriteLine("Type in the seond one");
        string secondPoly = Console.ReadLine();
        Console.Write("which looks like: ");
        PrintPoly(PolyAsArray(secondPoly));

        Console.WriteLine("The result after sum is: ");
        PrintPoly(ArraySum(PolyAsArray(firstPoly), PolyAsArray(secondPoly)));

        Console.WriteLine("The result after subtraction is:");
        PrintPoly(ArraySubtraction(PolyAsArray(firstPoly), PolyAsArray(secondPoly)));

        Console.WriteLine("The result after multiplication is: ");
        PrintPoly(ArrayMultiplication(PolyAsArray(firstPoly), PolyAsArray(secondPoly)));
    }
}

