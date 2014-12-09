namespace _07_Students_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _03_Students_task;

    public class StartProgram
    {
        public static void Main()
        {
            List<Student> listOfStudents = new List<Student>()
            {
                new Student("Ivan", "Petkov", 150902563, "(02) 9132 268", "petkov@abv.bg", new List<int>(){2, 4, 2, 5}, new Group(1, "Mathemtaics", "First")),
                new Student("Petur", "Petrov", 150906523, "0887123456", "petur@yahoo.com", new List<int>(){5, 4, 3}, new Group(2, "Physics", "Second")),
                new Student("Georgi", "Dimitrov", 150906156, "(02) 9552 143", "dimi@yahoo.com", new List<int>(){2, 5, 6, 6, 4}, new Group(3, "Mathematics", "Third")),
                new Student("Vasil", "Georgiev", 150907837, "0888156962", "vasko@gmail.com", new List<int>(){3, 4, 2, 5, 3}, new Group(2, "Mathematics", "Second")),
                new Student("Dimitrichka", "Penkova", 150906938, "0883659436", "penkova@abv.bg", new List<int>(){2, 2, 3, 5, 6}, new Group(2, "Physics", "Second")),
            };

            // query form task 9 (selecting students form group 2)
            var studentsFromGroupTwo =
                from student in listOfStudents
                where student.StudentGroup.GroupNumber == 2
                select student;

            Console.WriteLine("Students from group 2 are: (task 9)");
            Printing.Print(studentsFromGroupTwo);

            // ordering students (taks 9)
            var orderedStudentsByFirstName =
                from student in listOfStudents
                orderby student.FirstName
                select student;

            Console.WriteLine();
            Console.WriteLine("Ordered students by first name: (task 9)");
            Printing.Print(orderedStudentsByFirstName);

            // task 10
            ExtensionOfClassStudent.GroupTwo(listOfStudents);
            ExtensionOfClassStudent.Order(listOfStudents);

            // task 11
            var studentsWithAbvEmails =
                from student in listOfStudents
                where student.EMail.Contains("@abv.bg")
                select student;

            Console.WriteLine();
            Console.WriteLine("All students with emails in abv.bg: (task 11)");
            Printing.Print(studentsWithAbvEmails);

            // task 12
            string sofiaPhoneCode = "(02)";
            var studentsWithPhonesInSofia =
                from student in listOfStudents
                where student.PhoneNumber.Substring(0, 4) == sofiaPhoneCode
                select student;

            Console.WriteLine();
            Console.WriteLine("All studenst with phone numbers from Sofia: (task 12)");
            Printing.Print(studentsWithPhonesInSofia);

            // task 13
            var studentsWithAtLeastOneMarkSix =
                from students in listOfStudents
                where students.Marks.Contains(6)
                select students;

            Console.WriteLine();
            Console.WriteLine("All students that have at least one mark Excellent (6): (task 13)");

            foreach (var student in studentsWithAtLeastOneMarkSix)
            {
                var result = new { firstName = student.FirstName, lastName = student.LastName, marks = student.Marks };
                Console.WriteLine(result.firstName + " " + result.lastName + ", marks: " + string.Join(", ", result.marks));
            }

            // task 14
            ExtensionOfClassStudent.StudentsWithTwoMraksTwo(listOfStudents);

            // task 15
            var studentsMarksFrom2006 = listOfStudents
                .Where(st => st.FacultyNumber.ToString()[4] == '0' && st.FacultyNumber.ToString()[5] == '6');

            Console.WriteLine();
            Console.WriteLine("All marks of students that enrolled in 2006: (task 15)");

            foreach (var student in studentsMarksFrom2006)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", " + student.FacultyNumber
                    + ", marks: " + string.Join(", ", student.Marks));
            }

            // task 16
            var studentsFromMathemtaics = listOfStudents
                .Where(st => st.StudentGroup.DepartmentName.Equals("Mathematics"))
                .Select(st => st.FirstName + " " + st.LastName);

            Console.WriteLine();
            Console.WriteLine("All students from Mathematics department are: (task 16)");
            Console.WriteLine(string.Join(", ", studentsFromMathemtaics));

            // task 17
            var stringWithMaxLenght =
                from student in listOfStudents
                orderby student.FirstName.Length descending
                select student;

            Console.WriteLine();
            Console.WriteLine("The longest first name is: (task 17)");
            //Printing.Print(stringWithMaxLenght);
            Console.WriteLine(stringWithMaxLenght.ToList()[0].FirstName);

            // task 18
            // Using lambda expression
            //var studentsGroupedByGroupName = listOfStudents
            //    .OrderBy(st => st.StudentGroup.GroupName);

            var studentsGroupedByGroupName =
                from student in listOfStudents
                orderby student.StudentGroup.GroupName
                select student;

            Console.WriteLine();
            Console.WriteLine("All students grouped by GroupName (task 18)");

            foreach (var student in studentsGroupedByGroupName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", group name: " + student.StudentGroup.GroupName);
            }

            // task 19
            ExtensionOfClassStudent.StudentsGroupedByGroupName(listOfStudents);
        }
    }
}
