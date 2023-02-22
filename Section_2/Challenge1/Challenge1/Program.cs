using System;

namespace Challenge1
{
    class Program
    {
        /// <summary>
        /// Alters/reformats a user provided string.
        /// 
        /// Returns:
        /// 1. uppercase string.
        /// 2. lowercase string.
        /// 3. trimmed string.
        /// 4. substring beginning at index 2.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Get string
            string name;
            Console.WriteLine("Please enter your name and press enter:");
            name = Console.ReadLine();

            // Return altered string
            Console.WriteLine("Uppercase: {0}", name.ToUpper());
            Console.WriteLine("Lowercase: {0}", name.ToLower());
            Console.WriteLine("Trimmed: {0}", name.Trim());
            Console.WriteLine("Substring 2-5: {0}",name.Substring(2, 5));

            Console.ReadKey();
        }
    }
}
