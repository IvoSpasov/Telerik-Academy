namespace _07_Students_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using _03_Students_task;

    public static class ExtensionOfClassStudent
    {
        // this is the extension method for printing the students form class two (taks 10)
        public static void GroupTwo(this List<Student> studentsList)
        {
            var studentsFromGroupTwo =
            from student in studentsList
            where student.StudentGroup.GroupNumber == 2
            select student;

            Console.WriteLine();
            Console.WriteLine("Printing the students from group two using my extension method (task 10):");
            Printing.Print(studentsFromGroupTwo);
        }

        // I decided to use my "Print" method directly in the body of the extension 
        // method above. This way I don't have to call the "Print" method in the body of "Main" in "StartProgram".

        //public static IEnumerable<Student> GroupTwo(this List<Student> studentsList)
        //{
        //    IEnumerable<Student> studentsFromGroupTwo =
        //    from student in studentsList
        //    where student.GroupNumber == 2
        //    select student;

        //    return studentsFromGroupTwo;
        //}

        // this is the extension method for ordering the students (taks 10)
        public static void Order(this List<Student> studentsList)
        {
            var orderedStudentsByFirstName =
                from student in studentsList
                orderby student.FirstName
                select student;

            Console.WriteLine();
            Console.WriteLine("This are the ordered students using my extension method (taks 10):");
            Printing.Print(orderedStudentsByFirstName);
        }

        // this is the extension method for extracting students with only two marks "2" (task 14)
        public static void StudentsWithTwoMraksTwo(this List<Student> studentList)
        {
            // first way usinq LINQ
            //var extractByMarkTwo =
            //    from student in studentList
            //    where student.Marks.FindAll(x => x == 2).Count == 2
            //    select student;

            // second way using Lambda expressions
            var extractedByMarkTwo = studentList
                .Where(st => st.Marks.FindAll(x => x == 2).Count == 2);

            Console.WriteLine();
            Console.WriteLine("All students with exactly  two marks \"2\": (task 14)");

            foreach (var student in extractedByMarkTwo)
            {
                var result = new { firstName = student.FirstName, lastName = student.LastName, marks = student.Marks };
                Console.WriteLine(result.firstName + " " + result.lastName + ", marks: " + string.Join(", ", result.marks));
            }
        }

        // task 19
        public static void StudentsGroupedByGroupName(this List<Student> studentList)
        {
            var studentsGroupedByGroupName =
            from student in studentList
            orderby student.StudentGroup.GroupName
            select student;

            Console.WriteLine();
            Console.WriteLine("All students grouped by GroupName using extension method (task 19)");
            foreach (var student in studentsGroupedByGroupName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", group name: " + student.StudentGroup.GroupName);
            }
        }

    }
}
