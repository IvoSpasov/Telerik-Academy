﻿namespace Bookstore.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Author
    {
        private ICollection<Book> books;
        private ICollection<Review> reviews;

        public Author()
        {
            this.books = new HashSet<Book>();
            this.reviews = new HashSet<Review>();
        }

        public int Id { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Book> Books 
        {
            get { return this.books; }
            set { this.books = value; }
        }

        public virtual ICollection<Review> Reviews 
        {
            get { return this.reviews; }
            set { this.reviews = value; } 
        }
    }
}
