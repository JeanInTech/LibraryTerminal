using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Text;

namespace LibraryTerminal
{
    class CD : Item
    {
        public string Tracks { get; set; }

        public CD(string Title, string Author, int ReleaseYear, string Tracks) : base(Title, Author, ReleaseYear)
        {
            this.Tracks = Tracks;
        }
        public CD(string Title, string Author, ItemStatus Status, DateTime DueDate, int ReleaseYear, string Tracks) : base(Title, Author, Status, DueDate, ReleaseYear)
        {
            this.Tracks = Tracks;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Artist: {Author}");
            Console.WriteLine($"Year Released: {ReleaseYear}");
            Console.WriteLine($"Track List: {Tracks}");
            CheckDueDate();
        }
    }
}
