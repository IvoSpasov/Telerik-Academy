// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;

class BracketsCheck
{
    static void CheckCorrectBrackets(string expression)
    {
        int counter = 0;
        int indexOpen = expression.IndexOf('(');
        while (indexOpen != -1)
        {
            counter++;
            indexOpen = expression.IndexOf('(', indexOpen + 1);
        }

        int indexClose = expression.IndexOf(')');
        while (indexClose != -1)
        {
            counter--;
            indexClose = expression.IndexOf(')', indexClose + 1);
        }

        if (counter == 0)
        {
            Console.WriteLine("The brackets in the expression \"{0}\" are put correctly.", expression);
        }
        else
        {
            Console.WriteLine("The brackets in the expression \"{0}\" are NOT put correctly.", expression);
        }
    }

    static void Main()
    {
        string expression = "((a+b)/5-d)";
        string expression2 = ")(a+b))";
        CheckCorrectBrackets(expression);
        CheckCorrectBrackets(expression2);

    }
}

