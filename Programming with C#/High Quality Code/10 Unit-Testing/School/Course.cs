namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private List<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public int StudentsCount
        {
            get
            {
                return this.students.Count;
            }
        }

        public void AddStudent(Student newStudent)
        {
            if (newStudent == null)
            {
                throw new ArgumentNullException("newStudent", "New student cannot be null.");
            }

            if (this.students.Count >= 30)
            {
                throw new InvalidOperationException("Students in a course should be less than 30");
            }

            foreach (var student in this.students)
            {
                if (student.Number == newStudent.Number)
                {
                    throw new InvalidOperationException("There is a student who already has that id number.");
                }
            }

            this.students.Add(newStudent);
        }

        public void RemoveStudent(Student oldStudent)
        {
            if (oldStudent == null)
            {
                throw new ArgumentNullException("oldStudent", "Old student cannot be null.");
            }

            if (!this.students.Contains(oldStudent))
            {
                throw new ArgumentException("There is no such student in the list of students.");
            }

            this.students.Remove(oldStudent);
        }
    }
}
