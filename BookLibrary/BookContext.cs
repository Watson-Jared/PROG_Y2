using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class BookContext: DbContext
    {

        public BookContext(DbContextOptions<BookContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Books => Set<Book>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 },
                new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999 },
                new Book { Id = 3, Title = "Refractoring", Author = "Martin Fowler", Year = 2018 }
            );
        }
    }
}
