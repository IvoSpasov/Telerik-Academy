namespace _02_Humans_task
{
    public abstract class Human
    {
        public Human()
        {
        }

        public Human(string firstName)
        {
            this.FirstName = firstName;
        }

        public Human(string firstName, string lastName)
            : this(firstName)
        {
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
