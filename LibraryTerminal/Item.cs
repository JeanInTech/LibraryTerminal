using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    abstract class Item
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public DateTime DueDate { get; set; }
        public int ReleaseYear { get; set; }
      
        public Item() { }
        public Item(string Title, string Author, int ReleaseYear)
        {
            this.Title = Title;
            this.Author = Author;
            this.ItemStatus = ItemStatus.OnShelf;
            this.DueDate = DateTime.Now;
            this.ReleaseYear = ReleaseYear;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Released: {ReleaseYear}");
            if (ItemStatus.Equals("CheckedOut"))
            {
                Console.WriteLine($"Return Date: {DueDate}");
            }
            else
            {
                Console.WriteLine($"Status: {ItemStatus}");
            }
        }
    }
}

