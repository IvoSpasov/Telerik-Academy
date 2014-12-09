// Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies
// a number represented as array of digits by given integer number. 

using System;

// Please pay attention that this algorithum will work only if one of the numbers is of type int.
// The other number is represented as array of integers. (Just like what the hint says!)
// This program uses the logic of task 8 but with some changes.

class Factorial
{
    static string NumberMultiplication(string firstNumber, int secondNumber)
    {
        int[] firstNumberArray = new int[firstNumber.Length];
        // The result from multiplication of two numbers in the worst case will be the sum of the lenghts of both numbers
        // e.g (99*999 = 989901) or (2 digits * 3 digits = (2+3)digits = 5 digits).
        int[] resultArray = new int[firstNumber.Length + secondNumber.ToString().Length];
        string result = "";
        
        // With the code below I reverse the "firsNumber" and fill it in the "arrayNumberArray".
        for (int i = 0; i < firstNumber.Length; i++)
        {
            firstNumberArray[i] = firstNumber[firstNumber.Length - i - 1] - '0';
        }

        // To calculate the result from multiplication of two numbers I use more or less the same logic like the one in task 8.
        for (int i = 0; i < firstNumberArray.Length; i++)
        {
            resultArray[i + 1] = (resultArray[i] + (firstNumberArray[i] * secondNumber)) / 10;
            resultArray[i] = (resultArray[i] + (firstNumberArray[i] * secondNumber)) % 10;
        }

        Array.Reverse(resultArray);

        // Check if there are any zeros left at the beggining of the number.
        if (resultArray[0] == 0) // If there are....
        {
            int zerosCounter = 0;
            // ... count how many they are and...
            while (resultArray[zerosCounter] == 0 && zerosCounter != resultArray.Length - 1)
            {
                zerosCounter++;
            }

            if (resultArray[zerosCounter] != 0) // ... if the last element of "resultArray" is NOT zero...
            {
                string[] resultStringArray = new string[resultArray.Length - zerosCounter];

                for (int i = zerosCounter; i < resultArray.Length; i++) // ... get rid of the them by creating new array without the zeros.
                {
                    resultStringArray[i - zerosCounter] = resultArray[i].ToString();
                }
                result = string.Join("", resultStringArray);
            }
            else // else print one zero.
            {
                result = "0"; // This case is reachable only if we try to sum 0 + 0 or many zeros + many zeros!
            }

        }
        else // else don't bother cleaning the zeros. (this "else" is reachable when you have 7 + 5 for example)
        {
            result = string.Join("", resultArray);
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("This program calculates n!");
        Console.Write("Please type in n: ");
        int n = int.Parse(Console.ReadLine());
        string result = "1";

        for (int i = 1; i <= n; i++)
        {
            result = NumberMultiplication(result, i);
        }

        Console.WriteLine(result);
    }
}
