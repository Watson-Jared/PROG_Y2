using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class BookService
    {
        private readonly List<Book> _books = new()
        {
            new Book {Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008},
            new Book {Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999}
        };

        public List<Book> GetAll() => _books;

        public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public Book? Add(int id) => _books.FirstOrDefault(b => b.Id == id);

        public Book Add(Book book)
        {
            book.Id = _books.Count == 0 ? 1 : _books.Max(b => b.Id) + 1;
            _books.Add(book);
            return book;
        }

        public bool Delete(int id)
        {
            var book = GetById(id);
            if (book is null) return false;

            _books.Remove(book);
            return true;
        }
    }
}
