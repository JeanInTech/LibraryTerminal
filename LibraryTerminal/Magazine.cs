using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Magazine : Item
    {
        public int PublishMonth { get; set; }

        public Magazine(string Title, string Author, int ReleaseYear, int PublishMonth) : base(Title, Author, ReleaseYear)
        {
            this.PublishMonth = PublishMonth;
            this.Status = 0;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Publisher: {Author}");
            Console.WriteLine($"Issue: {PublishMonth}/{ReleaseYear}");
            if (Status.Equals(ItemStatus.CheckedOut))
            {
                Console.WriteLine($"Return Date: {DueDate:d}");
            }
            else
            {
                Console.WriteLine($"Status: {Status}");
            }
        }
    }
}
