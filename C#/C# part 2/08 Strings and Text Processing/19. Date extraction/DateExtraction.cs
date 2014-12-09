using System;
using System.Collections.Generic;
using System.Globalization;

class DateExtraction
{
    static void Main()
    {
        string text = "I was born in 14.06.1980. My sister was born in 3.7.1984. In 5/1999 I graduated " +
            "my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        List<string> dates = new List<string>();

        string[] separators = { " ", "," };
        string[] textAsWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        DateTime date = new DateTime();

        // removing the dots at the end of the sentence ("words") and check for valid dates 
        for (int i = 0; i < textAsWords.Length; i++)
        {
            if (textAsWords[i][textAsWords[i].Length - 1] == '.')
            {
                textAsWords[i] = textAsWords[i].Substring(0, textAsWords[i].Length - 1);
            }

            if (DateTime.TryParseExact(textAsWords[i], "d.M.yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                dates.Add(date.ToString("d", new CultureInfo("en-CA")));
            }
        }

        Console.WriteLine(string.Join(", ", dates));
    }
}
