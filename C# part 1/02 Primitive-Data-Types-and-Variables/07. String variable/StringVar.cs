using System;

    class StringVar
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";
            object toghether = str1 + " " + str2;
            string str3 = (string)toghether;
            Console.WriteLine(str3);
        }
    }

