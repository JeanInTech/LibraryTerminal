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
            Item b1 = new Book("How Much of These Hills Is Gold: A Novel", "C Pam Zhang", 2020, 368);
            Catalog.Add(b1);

            Item c1 = new CD("1", "The Beatles", 2000, "27");
            Item c2 = new CD("Thriller", "Michael Jackson", 1982, "9");
            Item c3 = new CD("21", "Adele", 2011, "11");
            Catalog.Add(c1);
            Catalog.Add(c2);
            Catalog.Add(c3);


            Item d1 = new DVD("Finding Nemo", "Andrew Stanton (Pixar)", 2003, 100);
            Item d2 = new DVD("Spider-Man", "Sam Raimi (Sony Pictures)",2002, 121);
            Item d3 = new DVD("Avatar", "James Cameron (20th Century Fox)", 2009, 162);
            Catalog.Add(d1);
            Catalog.Add(d2);
            Catalog.Add(d3);



            //put items here
        }
        public void PrintItems()
        {
            for (int i = 0; i < Catalog.Count; i++)
            {
                Item item = Catalog[i];
            item.PrintInfo();
            }
        }
        //public List<Item> SearchByAuthor(string input)
        //{
        //    //search by author method
        //    List<Item> results = new List<Item>();
        //    foreach (Item itemMatch in Catalog)
        //    {
        //        //item.author == "input")
        //    }

        //}
        //public List<Item> SearchByTitle(string input)
        //{
        //    //search by author
        //}
        //public Item Checkout()
        //{
        //    Console.WriteLine($"Please select which item from the list:");
        //    PrintItems();
        //    Console.WriteLine($"Please select the item you would like to check out [Enter 1 - Catalog.Count]: ");
        //    string input = Console.ReadLine().Trim();

        //    //while (true)
        //    //{
        //    //    try
        //    //    {
        //    //        if (Int32.TryParse(input, out int index) && ItemStatus.Equals("OnShelf"))
        //    //        {
        //    //            Catalog output = Catalog[index];
        //    //            return output;
        //    //        }
        //    //        else
        //    //        {
        //    //            Console.WriteLine("Item not available, try again.");
        //    //            Console.Write($"Please select a movie you want to watch [Enter 1 - {Catalog.Count}]: ");
        //    //            input = Console.ReadLine().Trim();
        //    //            continue;
        //    //        }
        //    //    }
        //    //    catch (ArgumentOutOfRangeException)
        //    //    {
        //    //        Console.WriteLine("Item not available, try again.");
        //    //        Console.Write($"Please select a movie you want to watch [Enter 1 - {Catalog.Count}]: ");
        //    //        input = Console.ReadLine().Trim();
        //    //        continue;
        //    //    }
        //    }
        //public void CheckIn(Item)
        //{
        //    //enter code here
            }
        }

