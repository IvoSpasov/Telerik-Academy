namespace _02_Humans_task
{
    using System;
    public class Worker : Human
    {
        public Worker()
        {
        }

        public Worker(string firstName)
            : base(firstName)
        {
        }

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Worker(string firsName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firsName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double dailySalary = this.WeekSalary / 5; // If we presume that the worker's week has five working days.
            double perHour = dailySalary / this.WorkHoursPerDay;
            return perHour;
        }

        public override string ToString()
        {
            string template = "{0} {1} is working for {2:C2} per hour";
            string result = string.Format(template, this.FirstName.PadLeft(10), this.LastName.PadRight(10), MoneyPerHour());
            return result;
        }
    }
}
