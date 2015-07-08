namespace NamingIdentifiers.Task2
{
    public class ProgramStart
    {
        public static void Main()
        {
        }

        public Person CreatePerson(int personAge)
        {
            var person = new Person();
            person.Age = personAge;
            if (personAge % 2 == 0)
            {
                person.Name = "Mitko";
                person.Sex = Sex.Male;
            }
            else
            {
                person.Name = "Ani";
                person.Sex = Sex.Female;
            }

            return person;
        }
    }
}