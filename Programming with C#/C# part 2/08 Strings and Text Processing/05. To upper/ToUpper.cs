// You are given a text. Write a program that changes the text in all regions surrounded by the
// tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
// We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
// The expected result:
// We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;

class ToUpper
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>." + 
            " We don't have <upcase>anything</upcase> else.";

        StringBuilder copy = new StringBuilder();
        copy.Append(text);

        int indexOpen = text.IndexOf("<upcase>");
        int indexClose = text.IndexOf("</upcase>", indexOpen);

        while (indexOpen != -1 || indexClose != -1)
        {
            string word = text.Substring(indexOpen + 8, indexClose - (indexOpen + 8));
            word = word.ToUpper();
            string remove = text.Substring(indexOpen, indexClose + 9 - indexOpen);
            copy.Replace(remove, word);
            indexOpen = text.IndexOf("<upcase>", indexClose);
            indexClose = text.IndexOf("</upcase>", indexClose + 1);
        }

        Console.WriteLine("Before:");
        Console.WriteLine(text);
        Console.WriteLine("After:");
        Console.WriteLine(copy.ToString());
    }
}
