using System;

namespace ConsoleVisuals
{
    // Class names like ClientActivity
    // Try to use nouns
    class Program
    {
        // Method names like CalculateValue
        // method arguments like firstNumber
        // usually are actions and can use verbs
        static void Main(string[] args)
        {
            //local variables like itemCount
            // avoid abbreviations for variable names
            // e.g. userControl vs usrCtrl
            // dont use numbers at start of variables
            // avoid underscores
            
            // Avoid
            // String myName;
            //Int32 lastNum;
            //Boolean isSaved;

            //Examples of console properties
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear(); //converts entire background to color

            // Console methods
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
