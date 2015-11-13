namespace WcfServiceWeekDay.Web
{
    using System;

    public class ServiceWeekDay : IServiceWeekDay
    {
        public string GetWeekDay(DateTime date)
        {
            var weekDay = date.DayOfWeek;

            switch (weekDay)
            {
                case DayOfWeek.Sunday:
                    return "Неделя";
                case DayOfWeek.Monday:
                    return "Понеделник";
                case DayOfWeek.Tuesday:
                    return "Вторник";
                case DayOfWeek.Wednesday:
                    return "Сряда";
                case DayOfWeek.Thursday:
                    return "Четвъртък";
                case DayOfWeek.Friday:
                    return "Петък";
                case DayOfWeek.Saturday:
                    return "Събота";
                default:
                    return "Invalid day";
            }
        }
    }
}
