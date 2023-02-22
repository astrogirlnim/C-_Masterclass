using System;

namespace Challenge1
{
    class Program
    {
        /// <summary>
        /// Small console bot which requests input from a user and checks the input type.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // request value
            string[] typeVariables = new string[] { "String", "Integer", "Boolean" };

            Console.Write("Enter a value:");
            string value = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered." +
                "\nPress 1 for String" +
                "\nPress 2 for Integer" +
                "\nPress 3 for Boolean");
            int valueType = int.Parse(Console.ReadLine());

            // Check second input type as well as input validity
            int result = CheckValue(value);

            if (valueType <= 3 && valueType >= 1) 
            {
                switch (result, valueType) 
                {
                    case (1,1):
                        Console.WriteLine("You have entered a value: String");
                        break;
                    case (2,2):
                        Console.WriteLine("You have entered a value: Integer");
                        break;
                    case (3,3):
                        Console.WriteLine("You have entered a value: Boolean");
                        break;
                    default:
                        Console.Write("It is an invalid: " + typeVariables[result - 1]);
                        break;
                }
                   
                    
            }
            else
            {
                Console.WriteLine("Error: Second input must be an integer between 1 and 3.");
            }

            Console.Read();
        }

        /// <summary>
        /// Checks the type of an input value and returns corresponding type.
        /// </summary>
        public static int CheckValue(string value) 
        {
            // Type verification
            bool valueBool;
            bool isBool = Boolean.TryParse(value, out valueBool);

            int valueInt;
            bool isInt = int.TryParse(value, out valueInt);

            bool isString = true;
            foreach(char k in value) 
            {
                if ((!char.IsLetter(k) && !char.IsWhiteSpace(k)) || isBool) 
                {
                    isString = false;
                    break;
                }
            }

            switch ((isBool, isInt, isString)) 
            {
                // check for boolean
                case (true, false, false):
                    return 3;
                // check for integer
                case (false, true, false):
                    return 2;
                // check for string
                case (false, false, true):
                    return 1;
                // error default
                default:
                    return 4;
            }

        }


    }
}
