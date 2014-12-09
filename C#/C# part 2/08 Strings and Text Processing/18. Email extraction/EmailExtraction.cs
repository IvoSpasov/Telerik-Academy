// Write a program for extracting all email addresses from given text. All substrings that match the
// format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class EmailExtraction
{
    public static string[] ExtractEmails(string str)
    {
        string regexPattern = @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b";

        // Find matches
        MatchCollection matches
            = Regex.Matches(str, regexPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        string[] MatchList = new string[matches.Count];

        // add each match
        int c = 0;
        foreach (System.Text.RegularExpressions.Match match in matches)
        {
            MatchList[c] = match.ToString();
            c++;
        }

        return MatchList;
    }


    static void Main()
    {
        string text = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or" +
            " at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";

        string[] results = ExtractEmails(text);
        Console.WriteLine(string.Join(", ", results));
    }
}
