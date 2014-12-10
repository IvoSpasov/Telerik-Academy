namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Models;

    public class StudentSystemDbContext: DbContext
    {
        public StudentSystemDbContext() 
            //the name of the base
            : base("StudentSystemCS")
        { 
        
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
    }
}
