using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Book : Item
    {
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string Title, int ReleaseYear, string Author, int PageCount) : base(Title, ReleaseYear)
        {
            this.Author = Author;
            this.PageCount = PageCount;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type: Book");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"# of Pages: {PageCount}");
        }
    }
}
