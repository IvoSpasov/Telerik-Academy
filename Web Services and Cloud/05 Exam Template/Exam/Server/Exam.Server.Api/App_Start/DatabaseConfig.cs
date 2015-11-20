namespace Exam.Server.Api
{
    using System.Data.Entity;

    using Data;
    using Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ExamDbContext, Configuration>());
            ExamDbContext.Create().Database.Initialize(true);
        }
    }
}