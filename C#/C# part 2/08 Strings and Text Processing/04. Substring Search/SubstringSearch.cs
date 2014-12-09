// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
// Example: The target substring is "in". The text is as follows:
// We are living in an yellow submarine. We don't have anything else. 
// Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9.

using System;

class SubstringSearch
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else." +
            " Inside the submarine is very tight. So we are drinking all the day. We will move" +
            " out of it in 5 days.";
        text = text.ToLower();
        string substring = "In".ToLower();

        int counter = 0;
        int index = text.IndexOf(substring);

        while (index != -1)
        {
            counter++;
            index = text.IndexOf("in", index + 1);
        }
        Console.WriteLine("The substring \"{0}\" is present {1} times in the text.", substring, counter);
    }
}
