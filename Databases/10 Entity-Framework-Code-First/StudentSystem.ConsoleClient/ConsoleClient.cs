namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System.Data.Entity;
    using StudentSystem.Data.Migrations;

    class ConsoleClient
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            
            var db = new StudentSystemDbContext();

            var student = new Student 
            { 
                Name = "Pesho", 
                Number = 21,
                Email = "pesho@pesho.com"
            };

            db.Students.Add(student);
            db.SaveChanges();

            var savedStudent = db.Students.First();

            Console.WriteLine(savedStudent.StudentID + "-" + savedStudent.Name);
        }
    }
}
