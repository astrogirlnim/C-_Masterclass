using System;

namespace Variable_Practice
{
    class Program 
    {
        /// <summary>
        /// Overview of character and numerical data type usage.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            // ::NUMERICAL DATA TYPES::
            //---------------------------

            // declaring multiple variables at once
            int num3, num4, num5;

            // declaring a variable
            int num1;

            //assigning a value
            num1 = 13;

            //declaring and initializing a variable
            int num2 = 69;
            int sum = num1 + num2;

            // using concatenation
            Console.WriteLine("NUMERICAL EXAMPLES");
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);

            double d1 = 3.14159;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("Quotient is: " + dDiv);

            // not as precise as doubles, require f
            float f1 = 3.14159f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("Float Quotient is:" + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("Double Int Quotient is: " + dIDiv);


            // ::CHARACTER DATA TYPES::
            // --------------------------------
            string myname = "Nataly";
            string message = "My name is";
            Console.WriteLine();
            Console.WriteLine("CHARACTER EXAMPLES");

            // concatenation
            Console.WriteLine("String: " + myname);
            Console.WriteLine(message + " " + myname);

            string cmessage = message.ToUpper();

            Console.WriteLine("Uppercase: " + cmessage + " " + myname);
            Console.WriteLine();

            // Getting user input and console methods
            Console.Write("Input String: ");
            string userresponse = Console.ReadLine();
            Console.WriteLine("You wrote: " + userresponse);

            Console.WriteLine();
            Console.Write("Enter a character and press enter: ");
            int inpt = Console.Read();
            Console.WriteLine("ASCII value is {0}.", inpt);

            


            //::VARIABLE CONVERSION::
            //----------------------------

            //explicit conversion
            // casting a double to int
            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;

            Console.WriteLine("Double: " + myDouble + ", Cast to int: " + myInt);
            
            //implicit conversion
            int num = 12345678;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            string myString = myFloat.ToString();

            bool sunIsShining = true;
            string newString = sunIsShining.ToString();

            Console.WriteLine("String Conversion: " + myString + " " + newString);


            //::PARSING::
            //-------------------

            // Parsing only works when converting numbers into integers
            // or doubles (so characters will not work)
            string firstString = "15";
            string secondString = "13";
            int num7 = Int32.Parse(firstString) + Int32.Parse(secondString);

            Console.WriteLine();
            Console.WriteLine("PARSING");
            Console.WriteLine("Sum = " + num7);


            //::STRING MANIPULATION::
            //-----------------------------------
            Console.WriteLine();
            Console.WriteLine("STRING FORMATTING");

            //define new variables
            int age = 31;
            string name = "Frederik";

            // 1. string concatenation
            string poo = name + "'s age is " + age;

            // 2. string formatting
            // uses index
            Console.WriteLine("Hello, my name is {0} and I am {1} years old", name, age);

            // 3. string interpolation
            // uses$ at the start to allow us to write our variables
            Console.WriteLine($"My name is also {name} and I am {age - 2} years old");

            // 4. verbatim string
            /* start with @ and tell the compiler to take the string
             literally and ignore any spaces or escape characters like \n
            Good way to write file paths, so that we don't need to use \\ for
            escape characters.*/
            Console.WriteLine(@"Pipi name love guud 





             aaAAAA \n");

            
            Console.ReadKey();
        }
    }
}
