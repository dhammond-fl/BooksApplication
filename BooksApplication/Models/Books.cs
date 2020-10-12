using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

using System.Data.Entity;

namespace BooksApplication.Models
{
    public class Book
    { 
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Details { get; set; }

    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

}