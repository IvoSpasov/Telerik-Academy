// 04. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value).
//     Override ToString() to display the information of a person and if age is not specified – to say so.
//     Write a program to test this functionality.

namespace _04.Person_task
{
    using System;

    public class StartProgram
    {
        static void Main()
        {
            var mitko = new Person();
            mitko.Name = "Mitko";
            Console.WriteLine(mitko);

            var andrei = new Person();
            andrei.Name = "Andrei";
            andrei.Age = 25;
            Console.WriteLine(andrei);
        }
    }
}
