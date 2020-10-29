using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    abstract class Item
    {
        public string Title { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public DateTime DueDate { get; set; }
        public int ReleaseYear { get; set; }

        public Item() { }
        public Item(string Title, int ReleaseYear)
        {
            this.Title = Title;
            this.ItemStatus = ItemStatus.OnShelf;
            this.DueDate = DateTime.Now;
            this.ReleaseYear = ReleaseYear;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
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
