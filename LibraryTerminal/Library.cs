using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryTerminal
{
    class Library
    {
        public List<Item> Catalog { get; set; } = new List<Item>();
        public Library()
        {
            //put items here
        }
        public void PrintItems()
        {
            //for (int i = 0; i < Catalog.Count; i++)
            //{
            //Item item = Catalog[i]
            //Console.WriteLine($"{i}: {item.Title}");
            //}
        }
        public List<Item> SearchByAuthor(string input)
        {
            //search by author method
            List<Item> results = new List<Item>();
            foreach (Item itemMatch in Catalog)
            {
                //item.author == "input")
            }

        }
        public List<Item> SearchByTitle(string input)
        {
            //search by author
        }
        public Item Checkout()
        {
            Console.WriteLine($"Please select which item from the list:");
            PrintItems();
            Console.WriteLine($"Please select the item you would like to check out [Enter 1 - Catalog.Count]: ");
            string input = Console.ReadLine().Trim();

            //while (true)
            //{
            //    try
            //    {
            //        if (Int32.TryParse(input, out int index) && ItemStatus.Equals("OnShelf"))
            //        {
            //            Catalog output = Catalog[index];
            //            return output;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Item not available, try again.");
            //            Console.Write($"Please select a movie you want to watch [Enter 1 - {Catalog.Count}]: ");
            //            input = Console.ReadLine().Trim();
            //            continue;
            //        }
            //    }
            //    catch (ArgumentOutOfRangeException)
            //    {
            //        Console.WriteLine("Item not available, try again.");
            //        Console.Write($"Please select a movie you want to watch [Enter 1 - {Catalog.Count}]: ");
            //        input = Console.ReadLine().Trim();
            //        continue;
            //    }
            }
        public void CheckIn(Item)
        {
            //enter code here
        }
        }
    }
}
