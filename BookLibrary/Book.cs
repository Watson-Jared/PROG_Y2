using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public int Year { get; set; }
    }
}
