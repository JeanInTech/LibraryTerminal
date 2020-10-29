using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Text;

namespace LibraryTerminal
{
    class CD : Item
    {
        public string Artist { get; set; }


        public CD(string Title, ItemStatus ItemStatus, DateTime DueDate, int ReleaseYear, string Artist)
            : base(Title, ItemStatus, DueDate, ReleaseYear)
        {
            
        }

        
        
    }
}
