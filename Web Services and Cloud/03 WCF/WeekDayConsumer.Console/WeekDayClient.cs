namespace WeekDayConsumer.Console
{
    using ServiceWeekDay;
    using System;

    class WeekDayClient
    {
        static void Main()
        {
            ServiceWeekDayClient client = new ServiceWeekDayClient();
            var date = new DateTime(2015, 11, 13);
            string dayOfWeek = client.GetWeekDay(date);
            Console.WriteLine("The day of the week on {0} is {1}", date.ToShortDateString(), dayOfWeek);
        }
    }
}
