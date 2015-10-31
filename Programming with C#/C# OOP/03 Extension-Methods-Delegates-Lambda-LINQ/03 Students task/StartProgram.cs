// Task 3 -> Write a method that from a given array of students finds all students whose first name is before its
// last name alphabetically. Use LINQ query operators.
// Task 4 -> Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
// Task 5 -> Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
// name and last name in descending order. Rewrite the same with LINQ.

namespace _03_Students_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartProgram
    {
        public static void Main()
        {
            // using anonymous type
            var students = new[] 
            {
                new { FirstName = "Ivan", LastName = "Spasov", Age = 10 } ,
                new { FirstName = "Petur", LastName = "Georgiev", Age = 18 },
                new { FirstName = "Angel", LastName = "Manolov", Age = 23 },
                new { FirstName = "Vihra", LastName = "Simeonova", Age = 35 },
                new { FirstName = "Vihra", LastName = "Zetkova", Age = 28 },
            };

            // task 3
            var studentsNameQuery =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            // or using query with lambda expression
            //var studentsNameQuery = students
            //    .Where(st => st.FirstName.CompareTo(st.LastName) == -1)
            //    .Select(st => st.FirstName + " " + st.LastName);

            Console.WriteLine("All students whose first name is alphabetically before its last:");
            Printing.Print(studentsNameQuery);

            // task 4 
            var studentsAgeQuery =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student.FirstName + " " + student.LastName;

            // or using lambda expression
            //var studentsAgeQuery = students
            //    .Where(st => st.Age >= 18 && st.Age <= 24)
            //    .Select(st => st.FirstName + " " + st.LastName);

            Console.WriteLine();
            Console.WriteLine("All students with age between 18 and 24:");
            Printing.Print(studentsAgeQuery);

            // task 5
            // using lambda expression
            var studentsSort = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);
                //.Select(st => st.FirstName + " " + st.LastName);

            Console.WriteLine();
            Console.WriteLine("Ordered students using lambda:");
            Printing.Print(studentsSort);

            // using LINQ
            var studentsSortLINQ =
                from student in students
                orderby student.LastName descending
                orderby student.FirstName descending
                select student;

            Console.WriteLine();
            Console.WriteLine("Ordered students using LINQ:");
            Printing.Print(studentsSortLINQ);
        }
    }
}
