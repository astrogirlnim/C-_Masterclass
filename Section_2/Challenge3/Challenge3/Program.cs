using System;

namespace Challenge3
{
    class Program
    {
        /// <summary>
        /// Demonstrates all primitive datatypes and parsing.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num = 1;
            float num2 = num;
            double num3 = num;
            decimal num4 = num;
            short num5 = -32768;
            ushort num6 = 0;
            long num7 = num;
            ulong num8 = 1;
            char letter = 'A';
            bool real = true;
            string phrase = "My name is Nataly";
            string numberString = "14";


            Console.WriteLine("Parsed string '14': " + Int32.Parse(numberString));
            Console.Read();
        }
    }
}
