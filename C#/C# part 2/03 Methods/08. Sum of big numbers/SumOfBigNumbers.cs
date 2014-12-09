// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] 
// contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up 
// to 10 000 digits.

using System;
using System.Numerics;

class SumOfBigNumbers
{
    static string SumOfNumbers(string firstNumber, string secondNumber)
    {
        // With the code below I get the greater lenght of the two numbers.
        int greaterNumLenght = secondNumber.Length;
        if (firstNumber.Length >= secondNumber.Length)
        {
            greaterNumLenght = firstNumber.Length;
        }

        // The arrays for the numbers have equal lenght on purpose.
        int[] firstArray = new int[greaterNumLenght];
        int[] secondArray = new int[greaterNumLenght];

        // In the worst case the lenght of the number that I get as a result will have one more digit than the greater 
        // of the numbers I sum. (e.g 99 + 1 = 100). That is why I add "+ 1" to the lenght of the array where I'll put the result.
        int[] resultArray = new int[greaterNumLenght + 1];
        string result = "";

        // With the code below I reverse the numbers and fill them in the appropriate for them arrays.
        // Pay attention that I use the numbers length to fill in the arrays. In this way the rest of the array will have zeros.
        // This is only in case the number lenght is different (e.g. 1 + 200 = 001 + 200 = 100 + 002 (reversed))
        for (int i = 0; i < firstNumber.Length; i++)
        {
            firstArray[i] = firstNumber[firstNumber.Length - i - 1] - '0';
        }
        for (int i = 0; i < secondNumber.Length; i++)
        {
            secondArray[i] = secondNumber[secondNumber.Length - i - 1] - '0';
        }

        // With the code below I calculate the sum of the numbers in the two arrays.
        for (int i = 0; i < greaterNumLenght; i++)
        {
            resultArray[i + 1] = (resultArray[i] + firstArray[i] + secondArray[i]) / 10;
            resultArray[i] = (resultArray[i] + firstArray[i] + secondArray[i]) % 10;
        }

        // Reverse the "resultArray"
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
        // To check and proove that my method works properly I compare it with the way "BigInteger" works.

        Console.WriteLine("This program can sum two big integer numbers.");
        Console.Write("Please eneter the first number: ");
        string firstNumber = Console.ReadLine();
        BigInteger bigTN1 = BigInteger.Parse(firstNumber);

        Console.Write("Please eneter the second number: ");
        string secondNumber = Console.ReadLine();
        BigInteger bigTN2 = BigInteger.Parse(secondNumber);

        // On the first line is the result from summing two "BigInteger" numbers and on the second one -> using my method.

        Console.WriteLine(bigTN1 + bigTN2);
        Console.WriteLine(SumOfNumbers(firstNumber, secondNumber));


        // Test.

        //string testNumber1 = "000000000134567890123567890312414241461245414614651421614126421412465142611";
        //string testNumber2 = "000100005345325231243210101452315404523";

        //BigInteger bigTN1 = BigInteger.Parse(testNumber1);
        //BigInteger bigTN2 = BigInteger.Parse(testNumber2);

        // On the first line is the result from summing two "BigInteger" numbers and on the second one -> using my method.

        //Console.WriteLine(bigTN1 + bigTN2);
        //Console.WriteLine(SumOfNumbers(testNumber1, testNumber2));
    }
}








        // The code below represents the first variant of the code responsible for cleaning the zeros in front of
        // the number but it doesn't work when you try to sum 0 + 0 or many zeros + many zeros. I discovered this 
        // bug completely by accident and I think I fixied it with the new code above.


        // Check if there are any zeros left at the beggining of the number.
        //if (resultArray[0] == 0) // If there are....
        //{
        //    int zerosCounter = 0;
        //    while (resultArray[zerosCounter] == 0) // ... count how many they are and...
        //    {
        //        zerosCounter++;
        //    }

        //    string[] resultStringArray = new string[resultArray.Length - zerosCounter];

        //    for (int i = zerosCounter; i < resultArray.Length; i++) // ... get rid of the them by creating new array without the zeros.
        //    {
        //        resultStringArray[i - zerosCounter] = resultArray[i].ToString();
        //    }

        //    result = string.Join("", resultStringArray);
        //}
        //else // else don't bother cleaning the zeros.
        //{
        //    result = string.Join("", resultArray);
        //}