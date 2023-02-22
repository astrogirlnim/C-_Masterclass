using System;

namespace ConstantsC
{
    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program.

    class Program
    {
        // defined in the class as fields
        const double PI = 3.14159265358979;
        const int weeks = 52, months = 12;
        const string birthday = "04.22.1999";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is {0}", birthday);
            Console.Read();
        }
    }
}
