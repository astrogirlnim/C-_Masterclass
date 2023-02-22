using System;

namespace IfStatements
{
    /// <summary>
    /// Enhanced if statements explanations and practice.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //::TERNARY OPERATORS::
            //---------------------------------
            /* condition ? first_expression : second_expresion
             * condition has to be true or false.
             * conditional operator is right - associative
             * expression a ? b : c ? d : e
             * is evaluated as a ? b : (c ? d : e).
             * not as (a ? b :c) ? d : e.
             * conditional operator cannot be overloaded.
             */
            int temp = 20;
            string stateOfMatter;

            //original
            /*if (temp < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";*/

            // shorthand
            stateOfMatter = temp < 0 ? "solid" : temp < 30 ? "liquid" : "gas";

            Console.WriteLine("State of matter is " + stateOfMatter);
            Console.ReadKey();
        }
    }
}
