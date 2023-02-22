using System;

namespace MultiplierMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplier(2,3));
        }

        public static int Multiplier(int num1, int num2) 
        {
            return num1 * num2;
        }
    }
}
