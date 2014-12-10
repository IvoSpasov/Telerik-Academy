namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Students")]
    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        [Key, Column("StudentId")]
        public int StudentID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Number")]
        public int Number { get; set; }

        public string Email { get; set; }

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

    }
    
}
