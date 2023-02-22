using System;

namespace Challenge3
{
    /// <summary>
    /// Checks temperature.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // retrieve temperature
            int temperature;
            Console.WriteLine("Please input a temperature.");
            Console.Write("Temperature: ");
            bool success = int.TryParse(Console.ReadLine(), out temperature);

            // check conditions
            string response = !success ? "Not a valid temperature.": 
                temperature <= 15 ? "it is too cold here" : 
                temperature <= 28 ? "it is ok" : 
                "it is hot here";

            Console.WriteLine(response);
            Console.Read();
        }
    }
}
