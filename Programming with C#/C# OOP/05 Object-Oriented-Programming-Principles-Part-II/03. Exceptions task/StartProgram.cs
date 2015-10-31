namespace _03.Exceptions_task
{
    using System;

    public class StartProgram
    {
        public static void Main()
        {
            int number = 120;
            // number = 50;// remove the comment ot this line to test the second exception.
            int lowRange = 0;
            int highRange = 100;

            if (!(lowRange < number && number <= highRange))
            {
                throw new InvalidRangeException<int>("Invalid number.", lowRange, highRange);
            }

            DateTime lowerDate = new DateTime(1980, 1, 1);
            DateTime higheDate = new DateTime(2013, 12, 31);

            throw new InvalidRangeException<DateTime>("Invalid date.", lowerDate, higheDate);
        }
    }
}
