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

        public Item() { }
        public Item(string Title, ItemStatus ItemStatus, DateTime DueDate)
        {
            this.Title = Title;
            this.ItemStatus = ItemStatus;
            this.DueDate = DueDate;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Status: {ItemStatus}");
        }
    }
}
