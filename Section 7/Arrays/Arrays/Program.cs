using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an array and foreach loops
            string[] friends = {"Jake","Dameon","Kellen"};
            int[] ages = new int[] { 23, 26, 22 };
            
            foreach(string k in friends) 
            {
                Console.WriteLine("{0} is my friend.", k);
            }

            for(int i  = 0; i < ages.Length; i++) 
            {
                Console.WriteLine("Age {0} is {1}", i + 1, ages[i]);
            }

            Console.ReadKey();
        }
    }
}
