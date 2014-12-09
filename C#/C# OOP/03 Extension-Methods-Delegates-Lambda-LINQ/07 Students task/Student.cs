namespace _07_Students_task
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(string fName, string lName, int fn, string tel, string email, List<int> marks, Group studentInfo)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FacultyNumber = fn;
            this.PhoneNumber = tel;
            this.EMail = email;
            this.Marks = marks;
            //this.GroupNumber = groupNum; (In task 16 they ask us to create GroupNumber in seperate class. This property was used for the previous tasks but now it is not needed.)
            this.StudentGroup = studentInfo;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int FacultyNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public string EMail { get; private set; }
        public List<int> Marks { get; private set; }

        // public int GroupNumber { get; private set; } // (In task 16 they ask us to creaate GroupNumber in seperate class. This property was used for the previous tasks but now it is not needed.)
        public Group StudentGroup { get; set; }

        public override string ToString()
        {
            // I decided not to display all information so that it is more readable on the console. 
            // (the student info takes just one line). On some tasks you may need to check the declaration of the 
            // student in order to see the additional info (e.g. task 9 where st. group is not printed on the console)
            string result = this.FirstName + " " + this.LastName + ", FN: " + this.FacultyNumber + 
                ", tel: " + this.PhoneNumber + ", email: " + this.EMail;
            return result;
        }
    }
}
