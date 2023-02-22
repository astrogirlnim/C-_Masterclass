using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
        }

        // Getting out of scope to demonstrate finalizer
        // calling outside the method

    }
}
