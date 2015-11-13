namespace WcfServiceWeekDay.Library
{
    using System;

    public class ServiceStringCount : IServiceStringCount
    {
        public int StringCount(string text, string searchedWord)
        {
            string[] separators = { ".", " ", ",", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] wordsArray = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            foreach (var word in wordsArray)
            {
                if (word == searchedWord.ToLower())
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
