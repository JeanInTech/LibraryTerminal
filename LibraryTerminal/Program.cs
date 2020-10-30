using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Library L = new Library();
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
    }
}
