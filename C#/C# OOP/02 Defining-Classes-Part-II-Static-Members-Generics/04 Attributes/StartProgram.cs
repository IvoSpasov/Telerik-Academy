namespace _04_Attributes
{
    using System;

    [Version(2.11)]
    class StartProgram
    {
        static void Main()
        {
            Type type = typeof(StartProgram);
            var attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in attributes)
            {
                Console.WriteLine("The version of the class is: {0}", attr.Version);
            }
        }
    }
}
