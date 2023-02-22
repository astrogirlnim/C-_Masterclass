using System;

namespace MethodPractice
{
    /// <summary>
    /// A program to practice calling and using methods with user input
    /// as well as using try and catch and operators.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Adding two user provided numbers
            Console.WriteLine("Please input two integers, pressing enter after each.");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            // ::TRY AND CATCH::
            //-------------------------------
            /* If an error is returned (i.e. parsing the wrong type),
             * prints a format exception error message to the user.
             * An exception is a very generic error, and will crash while 
             * describing what the error was (if we substitue the writline
             * code for "throw;", which will crash the program and describe 
             * the error).
             */
            try
            {
                int result = Add(int.Parse(num1), int.Parse(num2));
                double result2 = Divide(int.Parse(num1), int.Parse(num2));
                Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result2);
            }
            // for a specific type of exception
            catch (FormatException)
            {
                //throw;
                Console.WriteLine("Format exception: please only input numbers, not letters or symbols.");
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Divide by zero exception: please input a nonzero second number.");
            }
            // general/all other exceptions
            catch (Exception)
            {
                //throw;
                Console.WriteLine("General exception: please enter only numbers which classify as int32s.");
            }
            /* called whether or not an error was returned
             * useful for trying to close a connection/things that must
             * happen regardless of errors. */
            finally
            {
                Console.WriteLine("\nNext: Parsing.");
            }

            //::TRYPARSE::
            //-------------------------------
            /* Can also use float.TryParse and double.TryParse.
             * Returns a boolean if successful parsing, which is passed 
             * to an out value.
             */
            string numberAsString = "123";
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);
            if (success) 
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            } else {
                Console.WriteLine("Parsing failed.");
            }

            // ::OPERATORS::
            // ------------------------------
            //unary operator
            int num3 = 4;
            int num4 = -num3;
            Console.WriteLine("\nUnary operator: {0} = -{1}", num4, num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            //increment operators
            int num5 = 0;
            Console.WriteLine(num5++);
            Console.WriteLine(num5++); // post-increment
            Console.WriteLine(++num5); // pre-increment

            //decrement operators
            Console.WriteLine(num5--);
            Console.WriteLine(num5--); // post-decrement
            Console.WriteLine(--num5); // pre-decrement

            // additive and multiplicative operators
            Console.WriteLine($"result of 5 + 4 = {5 + 4}");
            Console.WriteLine($"result of 5 / 4 = {(double)5 / 4}");
            Console.WriteLine($"result of 5 * 4 = {5 * 4}");
            Console.WriteLine($"result of 5 % 4 = {5 % 4}");

            //relational and type operators
            bool isLower;
            isLower = int.Parse(num1) < int.Parse(num2);
            Console.WriteLine($"num1 < num2 = {isLower}");

            // equality operator
            bool isEqual = int.Parse(num1) == int.Parse(num2);
            bool isNotEqual = int.Parse(num1) != int.Parse(num2);
            Console.WriteLine($"num1 == num2 = {isEqual} or {!isNotEqual}");

            // conditional operators
            bool isLorS = isLower || isSunny;
            Console.WriteLine(isLorS);

        }

        /// <summary>
        /// Adds two numbers together.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Add(int number1, int number2) 
        {
            return number1 + number2;
        }

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
