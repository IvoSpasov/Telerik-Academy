namespace _01.Student_task
{
    using System;

    public enum University
    {
        SU, TUSofia, UNSS, UASG
    }

    public enum Faculty
    {
        FA, EF, EMF, MTF, FETT, FKTT, FKSU, TF, SF, FPMI, FMI,
    }
    public enum Specialty
    {
        ComputerScience, Electronics, Machines, Mathematics, Physics
    }

    public class Student : ICloneable, IComparable<Student>
    {
        #region Task 01
        public Student()
        {

        }

        public Student(string firstName, string lastName, string phone, int course, University university,
            Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SocailSecurityNumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                throw new ArgumentException("The passed object is not from type Student.");
            }

            // compare by University and Faculty
            else if (!(this.University == student.University))
            {
                return false;
            }

            else if (!(this.Faculty == student.Faculty))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !object.Equals(first, second);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + ", " + this.University + ", " + this.Faculty + ", "
                + this.Specialty + ", course: " + this.Course + ", SSN: " + this.SocailSecurityNumber;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode()
                ^ this.LastName.GetHashCode()
                ^ this.Course.GetHashCode();
        }
        #endregion

        #region Task 02
        // all properties are value types so they are copied without a problem.
        public object Clone()
        {
            var result = this.MemberwiseClone() as Student;
            return result;
        }
        #endregion

        #region Task 03
        public int CompareTo(Student other)
        {
            int firstCriteria = this.FirstName.CompareTo(other.FirstName);
            int secondCriteria = this.SocailSecurityNumber.CompareTo(other.SocailSecurityNumber);

            if (firstCriteria != 0)
            {
                return firstCriteria;
            }
            else
            {
                return secondCriteria;
            }
        }
        #endregion
    }
}
