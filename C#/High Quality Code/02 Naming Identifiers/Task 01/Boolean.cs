// 01 Refactor the following examples to produce code with well-named C# identifiers:
// class class_123 {
// const int max_count=6;
// class InClass_class_123 {
// void Метод_нА_class_InClass_class_123(bool promenliva) {
// string promenlivaKatoString=promenliva.ToString();
// Console.WriteLine(promenlivaKatoString); }
// }
// public static void Метод_За_Вход() {
// class_123.InClass_class_123 инстанция =
// new class_123.InClass_class_123();
// инстанция.Метод_нА_class_InClass_class_123(true);
// }
// }

namespace HW_Naming_Identifiers
{
    using System;

    public class Boolean
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            Handling instance = new Handling();
            instance.Print(true);
        }

        public class Handling
        {
            public void Print(bool variable)
            {
                string variableAsString = variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}