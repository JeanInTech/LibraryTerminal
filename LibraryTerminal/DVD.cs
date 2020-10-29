using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LibraryTerminal
{
    class DVD : Item
    {
            public string Genre { get; set; }



        public DVD(string Title, ItemStatus ItemStatus, DateTime DueDate, int ReleaseYear, string Genre)
        : base(Title, ItemStatus, DueDate, ReleaseYear)
        {
            this.Genre = Genre;
        }

    }
}
