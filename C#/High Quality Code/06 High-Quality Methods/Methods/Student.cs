namespace Methods
{
    using System;

    class Student
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = other.DateOfBirth;
            return firstDate > secondDate;
        }
    }
}
