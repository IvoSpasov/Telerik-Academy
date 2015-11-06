namespace MusicSystem.Server.Api
{
    using Data;
    using System.Data.Entity;
    using Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicSystemDbContext, Configuration>());
            MusicSystemDbContext.Create().Database.Initialize(true);
        }
    }
}