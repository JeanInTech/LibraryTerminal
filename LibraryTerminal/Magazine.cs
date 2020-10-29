using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Magazine : Item
    {
        public string Publisher { get; set; }
        public int PublishMonth { get; set; }

        public Magazine(string Title, int ReleaseYear, string Publisher, int PublishMonth) : base(Title,ReleaseYear)
        {
            this.Publisher = Publisher;
            this.PublishMonth = PublishMonth;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type: Magazine");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Publish Month: {PublishMonth}");
        }
    }
}
