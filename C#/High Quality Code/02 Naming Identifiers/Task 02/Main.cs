// 02 Refactor the following examples to produce code with well-named identifiers in C#:
// class Hauptklasse
// {
// enum Пол { ултра_Батка, Яка_Мацка };
// class чуек
// {
// public Пол пол { get; set; }
// public string име_на_Чуека { get; set; }
// public int Възраст { get; set; }
// }
//     public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
// {
// чуек new_Чуек = new чуек();
// new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
// if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
// {
// new_Чуек.име_на_Чуека = "Батката";
// new_Чуек.пол = Пол.ултра_Батка;
// }
// else
// {
// new_Чуек.име_на_Чуека = "Мацето";
// new_Чуек.пол = Пол.Яка_Мацка;
// }
// }
// }

namespace HW_Naming_Identifiers
{
    using System;

    public class Main
    {
        private enum Sex
        {
            Male, Female
        }

        public void CreatePerson(int personAge)
        {
            Person newPerson = new Person();
            newPerson.Age = personAge;
            if (personAge % 2 == 0)
            {
                newPerson.Name = "Ivan";
                newPerson.PersonSex = Sex.Male;
            }
            else
            {
                newPerson.Name = "Mariq";
                newPerson.PersonSex = Sex.Female;
            }
        }
        
        public class Person
        {
            public Sex PersonSex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
