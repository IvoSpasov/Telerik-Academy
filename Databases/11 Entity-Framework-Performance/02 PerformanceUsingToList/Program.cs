namespace _02_PerformanceUsingToList
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stopwatch sw = new Stopwatch();

            // Executed SQL statements = 1293.
            sw.Start();
            SlowQuery();
            sw.Stop();
            var slowPrintTime = sw.Elapsed;

            // Executed SQL statements = 1
            sw.Reset();
            sw.Start();
            FastQuery();
            sw.Stop();
            var fastPrintTime = sw.Elapsed;

            Console.WriteLine("Slow Print elapsed = {0}", slowPrintTime);
            Console.WriteLine("Fast Print elapsed = {0}", fastPrintTime);
            Console.WriteLine();
        }

        private static void SlowQuery()
        {
            var db = new TelerikAcademyEntities();
            using (db)
            {
                var slowQuery = db.Employees
                    .ToList()
                    .Select(e => e.Address)
                    .ToList()
                    .Select(a => a.Town)
                    .ToList()
                    .Where(t => t.Name == "Sofia");

                foreach (var town in slowQuery)
                {
                    Console.WriteLine(town.Name);
                }
            }
        }

        private static void FastQuery()
        {
            var db = new TelerikAcademyEntities();
            using (db)
            {
                var fastQuery = db.Employees
                    .Select(e => e.Address)
                    .Select(a => a.Town)
                    .Where(t => t.Name == "Sofia");

                foreach (var town in fastQuery)
                {
                    Console.WriteLine(town.Name);
                }
            }
        }
    }
}
