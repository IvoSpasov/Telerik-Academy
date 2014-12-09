// 01. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
//     mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities
//     and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() 
//     and operators == and !=.
// 02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into
//     a new object of type Student.
// 03. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic 
//     order) and by social security number (as second criteria, in increasing order).

namespace _01.Student_task
{
    using System;

    public class StartProgram
    {
        static void Main()
        {
            var ivan = new Student();
            ivan.FirstName = "Ivan";
            ivan.LastName = "Georgiev";
            ivan.Address = "Sofia";
            ivan.University = University.TUSofia;
            ivan.Faculty = Faculty.FETT;
            ivan.Specialty = Specialty.Electronics;
            ivan.Course = 3;

            var peter = new Student();
            peter.FirstName = "Peter";
            peter.LastName = "Nikolov";
            peter.Address = "Sofia";
            peter.University = University.SU;
            peter.Faculty = Faculty.FMI;
            peter.Specialty = Specialty.ComputerScience;
            peter.Course = 1;

            var georgi = new Student();
            georgi.FirstName = "Georgi";
            georgi.University = University.TUSofia;
            georgi.Faculty = Faculty.FETT;
            georgi.SocailSecurityNumber = 10;

            var anotherGeorgi = new Student();
            anotherGeorgi.FirstName = "Georgi";
            anotherGeorgi.SocailSecurityNumber = 5;

            #region Task 01
            Console.WriteLine("The students are: (task 01)");
            Console.WriteLine(ivan);
            Console.WriteLine(peter);
            Console.WriteLine(georgi);

            bool areEqual = object.Equals(ivan, peter);
            Console.WriteLine("Are {0} and {1} equal: {2}", peter.FirstName, ivan.FirstName, areEqual);

            areEqual = ivan.Equals(georgi);
            Console.WriteLine("Are {0} and {1} equal: {2}", georgi.FirstName, ivan.FirstName, areEqual);

            areEqual = peter == georgi;
            Console.WriteLine("Are {0} and {1} equal: {2}", peter.FirstName, georgi.FirstName, areEqual);

            Console.WriteLine("The hash code of Ivan is: " + ivan.GetHashCode());
            #endregion

            #region Task 02
            // task 02
            var copiedStudent = ivan.Clone();

            Console.WriteLine();
            Console.WriteLine("Original Ivan (task 02):");
            Console.WriteLine(ivan);
            Console.WriteLine("Copied Ivan:");
            Console.WriteLine(copiedStudent);
            #endregion

            #region Task 03
            // task 03
            Console.WriteLine();
            Console.WriteLine("(Task 03)");
            if (ivan.CompareTo(georgi) > 0)
            {
                Console.WriteLine(georgi + "\nhas smaller SSN (or is alphabetically before)\n" + ivan);
            }
            Console.WriteLine();
            if (georgi.CompareTo(anotherGeorgi) > 0)
            {
                Console.WriteLine(anotherGeorgi + "\nhas smaller SSN (or is alphabetically before)\n" + georgi);
            }
            #endregion
        }
    }
}
