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

            Item b4 = new Book("Beowulf: A New Translation", "Maria Dahvana Headley", 2020, 176);
            Catalog.Add(b4);

            Item b5 = new Book("Pachinko", "Min Jin Lee", 2017, 490);
            Catalog.Add(b5);

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
        public List<Item> SearchByAuthor(string input)
        {
            List<Item> results = new List<Item>();
            foreach (Item itemMatch in Catalog)
            {
                if (itemMatch.Author.Contains(input))
                {
                    results.Add(itemMatch);
                }
            }
            return results;
        }
        public List<Item> SearchByTitle(string input)
        {
            List<Item> results = new List<Item>();
            foreach (Item itemMatch in Catalog)
            {
                if (itemMatch.Title.Contains(input))
                {
                    results.Add(itemMatch);
                }
            }
            return results;
        }
        public string Checkout(List<Item> itemsList)
        {
            Console.Clear();
            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.WriteLine($"{i+1}.");
                itemsList[i].PrintInfo();
            }

            string input = CnslFormatter.PromptForInput($"Please select the item you would like to checkout. [Enter 1 - {itemsList.Count}]: ");
            if (Int32.TryParse(input, out int num))
            {
                int index = num - 1;

                if (itemsList[index].ItemStatus.Equals("OnShelf"))
                {
                    return "You have successfully checked out this book!";
                }
                else
                {
                    return "Cannot be completed at this time.";
                }

            }
            return "scream";
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
            //}
        }
        public void CheckIn(Item m)
        {
            //enter code here
        }

    }
}
        

