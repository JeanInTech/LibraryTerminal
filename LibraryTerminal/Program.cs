﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemsLoaded = new List<Item>();            
            StreamReader reader = new StreamReader("../../../SavedItems.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] itemEntryInfo = line.Split("|"); // Record line
                Item newItem = GenerateItem(itemEntryInfo);
                itemsLoaded.Add(newItem);
                line = reader.ReadLine();
            }
            reader.Close();

            //Library L = new Library();
            Library L = new Library(itemsLoaded);
            L.PrintItems();

            bool userContinue = true;
            Console.WriteLine("Welcome to the Library!");
            while (userContinue)
            {
                LibraryMenu();
                string input = GetUserInput($"What would you like to do?");
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().Trim();
            return input;
        }
        public static void LibraryMenu()
        {
            Console.WriteLine($"1. Display items.");
            Console.WriteLine($"2. Search for a book by author.");
            Console.WriteLine($"3. Search for a book by title.");
            Console.WriteLine($"4. Show items you have checked out.");
            Console.WriteLine($"5. Return a book.");
            Console.WriteLine($"6. Quit.");
        }
        public static bool UserContinue(string message)
        {
            Console.WriteLine(message);
            string proceed = Console.ReadLine().Trim().ToLower();

            while (proceed != "n" && proceed != "y")
            {
                Console.WriteLine("Invalid input. Please enter 'y' to continue or 'n' to exit.");
                proceed = Console.ReadLine().Trim().ToLower();
            }

            if (proceed == "y")
            {
                return true;
            }
            else
                return false;
        }

        public static Item GenerateItem(string[] itemInfo)
        {
            string itemType = itemInfo[0].ToLower();
            if (itemType.Equals("book"))
            {
                return new Book(itemInfo[1], itemInfo[2],int.Parse(itemInfo[3]), int.Parse(itemInfo[4]));
            }
            else if (itemType.Equals("cd"))
            {
                return new CD(itemInfo[1], itemInfo[2], int.Parse(itemInfo[3]), itemInfo[4]);
            }
            else if (itemType.Equals("dvd"))
            {
                return new DVD(itemInfo[1], itemInfo[2], int.Parse(itemInfo[3]), int.Parse(itemInfo[4]));
            }
            else if (itemType.Equals("magazine"))
            {
                return new Magazine(itemInfo[1], itemInfo[2], int.Parse(itemInfo[3]), int.Parse(itemInfo[4]));
            }
            return null;
        }
    }
}
