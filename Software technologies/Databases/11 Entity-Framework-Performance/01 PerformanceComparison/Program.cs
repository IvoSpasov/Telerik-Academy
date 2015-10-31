namespace _01_PerformanceComparison
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Please change the path to your server in the app.config file (ot both rows). 
            // Otherwise the program won't start.
            Stopwatch sw = new Stopwatch();
            
            // Executed SQL statements = 343.
            sw.Start();
            SlowPrint();
            sw.Stop();
            var slowPrintTime = sw.Elapsed;

            // Executed SQL statements = 1
            sw.Reset();
            sw.Start();
            FastPrint();
            sw.Stop();
            var fastPrintTime = sw.Elapsed;

            Console.WriteLine("Slow Print elapsed = {0}", slowPrintTime);
            Console.WriteLine("Fast Print elapsed = {0}", fastPrintTime);
        }

        private static void SlowPrint()
        {
            var db = new TelerikAcademyEntities1();
            using (db)
            {
                var employees = db.Employees;
                foreach (var employee in employees)
                {
                    Console.WriteLine("{0} form {1} in {2}", 
                        employee.FirstName, employee.Department.Name, employee.Address.Town.Name);
                }
            }
        }

        private static void FastPrint()
        {
            var db = new TelerikAcademyEntities1();
            using (db)
            {
                var query = db.Employees.Include("Department").Include("Address.Town");
                foreach (var empl in query)
                {
                    Console.WriteLine("{0} form {1} in {2}",
                        empl.FirstName, empl.Department.Name, empl.Address.Town.Name);
                }
            }
        }
    }
}
