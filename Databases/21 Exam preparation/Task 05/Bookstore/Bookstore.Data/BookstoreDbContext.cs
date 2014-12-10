namespace Bookstore.Data
{
    using System.Data.Entity;

    using Bookstore.Data.Interfaces;
    using Bookstore.Data.Migrations;
    using Bookstore.Models;

    public class BookstoreDbContext : DbContext, IBookstoreDbContext
    {
        public BookstoreDbContext()
            : base("Bookstore")
        {
            // Package manager console (in the search) and then type "Enable-Migrations in the data project"
            // Run stylecop from time to time
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookstoreDbContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<BookstoreDbContext>());
        }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
