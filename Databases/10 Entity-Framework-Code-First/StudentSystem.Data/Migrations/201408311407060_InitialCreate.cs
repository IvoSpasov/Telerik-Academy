namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Materials = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Homeworks",
                c => new
                    {
                        HomeworkId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        TimeSent = c.DateTime(nullable: false),
                        Course = c.Int(nullable: false),
                        Student = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HomeworkId)
                .ForeignKey("dbo.Course", t => t.Course, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student, cascadeDelete: true)
                .Index(t => t.Course)
                .Index(t => t.Student);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_StudentID = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentID, t.Course_CourseId })
                .ForeignKey("dbo.Students", t => t.Student_StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Homeworks", "Student", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_CourseId", "dbo.Course");
            DropForeignKey("dbo.StudentCourses", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Homeworks", "Course", "dbo.Course");
            DropIndex("dbo.StudentCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "Student_StudentID" });
            DropIndex("dbo.Homeworks", new[] { "Student" });
            DropIndex("dbo.Homeworks", new[] { "Course" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Students");
            DropTable("dbo.Homeworks");
            DropTable("dbo.Course");
        }
    }
}
