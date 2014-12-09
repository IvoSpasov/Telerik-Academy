namespace _01_School_task
{
    using System;

    class StartProgram
    {
        static void Main()
        {
            SchoolClass first = new SchoolClass("A-clas");
            Console.WriteLine(first.TextIdentifier);
            // Please have in mind that all setters are private and you can create instances only through the constructors.
            // I did it in this way because I don't know what I'll need and where but I get a better encapsulation.
            // When I need to set a property somewhere at some point I can always remove the access modifier "private".
        }
    }
}
