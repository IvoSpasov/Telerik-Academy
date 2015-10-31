namespace _01_StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string filePath = "../../students.txt";
            var studentsSortedByCourse = new SortedDictionary<string, SortedDictionary<string, string>>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineParts = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = lineParts[0];
                    string lastName = lineParts[1];
                    string course = lineParts[2];

                    if (!studentsSortedByCourse.ContainsKey(course))
                    {
                        var studentsSortedByLastName = new SortedDictionary<string, string>();
                        studentsSortedByLastName.Add(lastName, firstName);
                        studentsSortedByCourse.Add(course, studentsSortedByLastName);
                    }
                    else
                    {
                        studentsSortedByCourse[course].Add(lastName, firstName);
                    }
                }
            }

            foreach (var course in studentsSortedByCourse)
            {
                Console.Write("{0}: ", course.Key);

                foreach (var student in course.Value)
                {
                    Console.Write("{0} {1}, ", student.Value, student.Key);
                }

                Console.WriteLine("\b\b ");
            }
        }
    }
}
