namespace Bookstore.Data.Interfaces
{
    using System.Data.Entity;

    using Bookstore.Models;

    interface IBookstoreDbContext
    {
        IDbSet<Author> Authors { get; set; }

        IDbSet<Book> Books { get; set; }

        IDbSet<Review> Reviews { get; set; }
    }
}
