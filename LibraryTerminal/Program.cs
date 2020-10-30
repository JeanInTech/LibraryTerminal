using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                string input = CnslFormatter.PromptForInput($"What would you like to do? ");

                if(input == "1")
                {
                    L.PrintItems();
                    bool proceed = CnslFormatter.AskYesOrNo($"Would you like to check out an item?");
                    if(proceed)
                    {
                        string test = L.Checkout(L.Catalog);
                        Console.WriteLine(test);
                    }
                }
                else if (input == "2")
                {
                    input = CnslFormatter.PromptForInput("Please enter name to search: ");
                    List<Item> resultsAuthor = L.SearchByAuthor(input);

                    if (resultsAuthor.Count == 0)
                    {
                        Console.WriteLine("No items found.");
                        CnslFormatter.PauseByAnyKey();
                    }
                    else if (resultsAuthor.Count >= 1)
                    {
                        foreach (Item result in resultsAuthor)
                        {
                            result.PrintInfo();
                        }
                        bool proceed = CnslFormatter.AskYesOrNo($"Would you like to check out an item?");
                        if (proceed)
                        {
                            L.Checkout(resultsAuthor);
                        }
                    }
                }
                else if (input == "3")
                {
                    input = CnslFormatter.PromptForInput("Please enter title to search: ");
                    List<Item> resultsTitle = L.SearchByTitle(input);

                    if (resultsTitle.Count == 0)
                    {
                        Console.WriteLine("No items found.");
                        CnslFormatter.PauseByAnyKey();
                    }
                    else if (resultsTitle.Count >= 1)
                    {
                        foreach (Item result in resultsTitle)
                        {
                            result.PrintInfo();
                        }
                        bool proceed = CnslFormatter.AskYesOrNo($"Would you like to check out an item?");
                        if (proceed)
                        {
                            L.Checkout(resultsTitle);
                        }
                    }
                }
                else if (input == "4")
                {
                    //Show items you have checked out 
                }
                else if (input == "5")
                {
                    //return a book 
                }
                else if (input == "6")
                {
                    userContinue = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again. ");
                    CnslFormatter.PauseByAnyKey();
                }
            }
            Console.WriteLine("Goodbye!");
        }
        public static void LibraryMenu()
        {
            Console.WriteLine($"\t1. Display items.");
            Console.WriteLine($"\t2. Search for a book by author.");
            Console.WriteLine($"\t3. Search for a book by title.");
            Console.WriteLine($"\t4. Show items you have checked out.");
            Console.WriteLine($"\t5. Return a book.");
            Console.WriteLine($"\t6. Quit.");
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
