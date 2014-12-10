namespace Bookstore.ConsoleClient
{
    using System;
    using System.Linq;

    using Bookstore.Data;
    using Bookstore.Models;
    using System.Xml.Linq;

    public class ConsoleClient
    {
        private static BookstoreDbContext db;
        public static void Main()
        {
            db = new BookstoreDbContext();
            //db.Authors.Any();

            //var author = new Author
            //{
            //    Name = "Stephen King"
            //};

            //var book = new Book
            //{
            //    Title = "Book from stephen",
            //    ISBN = "1234567890126",        
            //};

            //author.Books.Add(book);
            //db.Authors.Add(author);
            //db.SaveChanges();

            //var savedAuthor = db.Authors.First();
            //Console.WriteLine(savedAuthor.Id + ": " + savedAuthor.Name);


            // Task 06 xml parser otdelen class, otdelen metod

            var xmlBooks = XElement.Load(@"..\..\..\complex-books.xml").Elements();

            //var books = xmlBooks.Elements();

            foreach (var xmlBook in xmlBooks)
            {
                var currentBook = new Book();
                currentBook.Title = xmlBook.Element("title").Value;

                // in methods
                var isbn = xmlBook.Element("isbn");
                if (isbn != null)
                {
                    var bookExists = db.Books.Any(b => b.ISBN == isbn.Value);
                    if (bookExists)
                    {
                        throw new ArgumentException("ISBN already exists");
                    }
                    currentBook.ISBN = isbn.Value;
                }

                var price = xmlBook.Element("price");
                if (price != null)
                {
                    currentBook.Price = decimal.Parse(price.Value);
                }

                var webSite = xmlBook.Element("web-site");
                if (webSite != null)
                {
                    currentBook.WebSite = webSite.Value;
                }

                var xmlAuthors = xmlBook.Element("authors");
                if (xmlAuthors != null)
                {
                    foreach (var xmlAuthor in xmlAuthors.Elements("author"))
                    {
                        var authorName = xmlAuthor.Value;
                        currentBook.Authors.Add(GetAuthor(authorName));
                    }
                }

                var xmlReviews = xmlBook.Element("reviews");
                if (xmlReviews != null)
                {
                    foreach (var xmlReview in xmlReviews.Elements("review"))
                    {
                        var reviewDate = xmlReview.Attribute("date");
                        var authorName = xmlReview.Attribute("author");

                        var currentReview = new Review
                        {
                            Content = xmlReview.Value,
                            DateOfCreation = reviewDate == null ? DateTime.Now : DateTime.Parse(reviewDate.Value)
                        };

                        if (authorName != null)
                        {
                            currentReview.Author = GetAuthor(authorName.Value);
                        }

                        currentBook.Reviews.Add(currentReview);
                    }
                }

                db.Books.Add(currentBook);
                db.SaveChanges();
            }
        }

        public static Author GetAuthor(string authorName)
        {
            var author = db.Authors.FirstOrDefault(a => a.Name == authorName);
            if (author == null)
            {
                author = new Author
                {
                    Name = authorName
                };
            }

            return author;
        }
    }
}
