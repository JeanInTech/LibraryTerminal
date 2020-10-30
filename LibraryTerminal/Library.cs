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
            Item b1 = new Book("How Much of These Hills Is Gold", "C Pam Zhang", 2020, 368);
            Catalog.Add(b1);
          
            Item b2 = new Book("Jade City", "Fonda Lee", 2017, 560);
            Catalog.Add(b2);

            Item b3 = new Book("The Poppy War", "R F Kuang", 2018, 544);
            Catalog.Add(b3);

            Item b4 = new Book("Beowulf: A New Translation", "Maria Dahvana Headley", 2020, 176);
            Catalog.Add(b4);

            Item b5 = new Book("Pachinko", "Min Jin Lee", 2017, 490);
            Catalog.Add(b5);
          
            //put items here
            Item mag1 = new Magazine("They're Making Another Super Mario Movie", "WIRED", 2018, 8);
            Item mag2 = new Magazine("The World's Rarest Pair of Tweezers", "Collectors", 2015, 9);
            Item mag3 = new Magazine("Mount Everest: The Secrets it Holds", "National Geographic", 1999, 2);
            Catalog.Add(mag1);
            Catalog.Add(mag2);
            Catalog.Add(mag3);
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

