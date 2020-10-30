using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace LibraryTerminal
{
    class Library
    {
        public List<Item> Catalog { get; set; }
        public Library()
        {
            Catalog = new List<Item>();

            Item b1 = new Book("How Much of These Hills Is Gold", "C Pam Zhang", 2020, 368);
            Item b2 = new Book("Jade City", "Fonda Lee", 2017, 560);
            Item b3 = new Book("The Poppy War", "R F Kuang", 2018, 544);
            Item b4 = new Book("Beowulf: A New Translation", "Maria Dahvana Headley", 2020, 176);
            Item b5 = new Book("Pachinko", "Min Jin Lee", 2017, 490);
            Catalog.Add(b1);
            Catalog.Add(b2);
            Catalog.Add(b3);
            Catalog.Add(b4);
            Catalog.Add(b5);

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

            Item mag1 = new Magazine("They're Making Another Super Mario Movie", "WIRED", 2018, 8);
            Item mag2 = new Magazine("The World's Rarest Pair of Tweezers", "Collectors", 2015, 9);
            Item mag3 = new Magazine("Mount Everest: The Secrets it Holds", "National Geographic", 1999, 2);
            Catalog.Add(mag1);
            Catalog.Add(mag2);
            Catalog.Add(mag3);
        }

        public Library(List<Item> Catalog)
        {
            this.Catalog = Catalog;
        }

        public void PrintItems()
        {
            for (int i = 0; i < Catalog.Count; i++)
            {
                Item item = Catalog[i];
                item.PrintInfo();
                CnslFormatter.MakeLineSpace(1);
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
        public void Checkout(List<Item> itemsList)
        {
            Console.Clear();
            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.Write($"{Environment.NewLine}Item {i+1}.");
                itemsList[i].PrintInfo();
            }

            string input = CnslFormatter.PromptForInput($"Please select the item you would like to checkout. [Enter 1 - {itemsList.Count}]: ");
            if (Int32.TryParse(input, out int num))
            {
                int index = num - 1;

                if (itemsList[index].ItemStatus == ItemStatus.OnShelf)
                {
                    Console.WriteLine(Environment.NewLine + "You have checked out: ");
                    Console.WriteLine($"   {itemsList[index].Title} by {itemsList[index].Author}");
                    DateTime checkoutDate = DateTime.Now;
                    DateTime dueDate = checkoutDate.AddDays(14);
                    Console.WriteLine($"   Due back by {dueDate:d}");
                    itemsList[index].ItemStatus = ItemStatus.CheckedOut;
                    CnslFormatter.PauseByAnyKey();
                }
                else if(itemsList[index].ItemStatus == ItemStatus.CheckedOut)
                {
                    Console.WriteLine("Item is already checked out. Cannot complete checkout at this time.");
                }
                else
                {
                    Console.WriteLine("Cannot complete checkout at this time.");
                }
            }
        }
        public void CheckIn(Item m)
        {
            //enter code here
        }

    }
}
        

