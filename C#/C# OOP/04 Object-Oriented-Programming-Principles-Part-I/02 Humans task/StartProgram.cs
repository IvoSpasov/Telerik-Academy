namespace _02_Humans_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartProgram
    {
        public static void Print<T>(IEnumerable<T> listForPrinting)
        {
            foreach (var item in listForPrinting)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            List<Student> listOfStudents = new List<Student>() 
            { 
                new Student("Margaret", "Morton", 8),
                new Student("Janie", "Elliott", 9),
				new Student("Eunice", "Robinson", 4),
				new Student("Ivan", "King", 10),
				new Student("Bobby", "Fuller", 12),
				new Student("Alonzo", "Garza", 3),
				new Student("Delbert", "Cooper", 4),
				new Student("Tiffany", "Shaw", 7),
				new Student("Joann", "Gray", 2),
				new Student("Elias", "Farmer", 12),
            };

            var sortedByGrade = listOfStudents
                .OrderBy(st => st.Grade);

            Print(sortedByGrade);

            List<Worker> listOfWorkers = new List<Worker>()
            {
                new Worker("Bobby", "Hansen", 50, 10),
                new Worker("Jeanette", "Caldwell", 500, 5),
                new Worker("Margaret", "Griffin", 250, 8),
                new Worker("Cornelius", "Osborne", 138, 4),
                new Worker("Jaime", "Ward", 156, 6),
                new Worker("Dianne", "Vargas", 210, 8),
                new Worker("Tiffany", "Ballard", 350, 12),
                new Worker("Earl", "Greene", 256, 10),
                new Worker("Lois", "Walton", 115, 2),
                new Worker("Yolanda", "Brock", 680, 10),
            };

            var sortedByMoneyPerHour = listOfWorkers
                .OrderByDescending(wr => wr.MoneyPerHour());

            Console.WriteLine(new string('-', 50));
            Print(sortedByMoneyPerHour);

            List<Human> people = new List<Human>(listOfStudents);
            people.AddRange(listOfWorkers);
            
            var sortedByName = people
                .OrderBy(pe => pe.FirstName)
                .ThenBy(pe => pe.LastName);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Merged and sorted by fisrt and last name.");
            Print(sortedByName);
        }
    }
}
