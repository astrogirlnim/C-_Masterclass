using System;

namespace Challenge2
{
    class Program
    {
        /// <summary>
        /// String character search and concatenation practice. Prompts the user for questions and returns results.
        /// </summary>
        static void Main(string[] args)
        {
            string phrase, firstName, lastName;

            // attain phrase and character of interest
            Console.Write("Enter a string here: ");
            phrase = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            char charOfInterest = Console.ReadLine()[0];

            // search and return
            Console.WriteLine("Index of first instance of {0} in string {1}: {2}", charOfInterest, phrase, phrase.IndexOf(charOfInterest));

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();

                // attain first and last name and return
                Console.Write("Please input first name: ");
                firstName = Console.ReadLine();

                Console.Write("Please input last name: ");
                lastName = Console.ReadLine();

                Console.WriteLine("Full name: " + firstName + " " + lastName);
            }
            
            Console.Read();

        }
    }
}
