using System;
using System.Security.Cryptography.X509Certificates;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
