using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasics
{
    /// <summary>
    /// Datatype blueprint/basic structure.
    /// </summary>
    class Human
    {
        // Members - can be variables, methods, etc.
        // member variable
        //string firstName; // protected, as it lacks a public. 
        // Cannot be altered

        /* When variables are used with a constructor, they can be set to
         * private and still accessed whenever the class is called.
         */
        private string firstName, lastName, eyeColor;
        private int age;

        //Private variables
        //private string lastName = "Todd"; // cannot be altered/accessed


        /* Access Modifiers
         * private, public, protected, inernal, protected-internal and private-protected
         * private = accessed only inside a class or structure
         * public = accessible from everywhere in the project
         * protected = accessible inside the class and all classes that derive from it
         * internal = accessible only inside its own assembly but not in other assemblies
         * protected internal = access in the same assembly or in a derived class in other assemblies
         * private protected = only accessed in the same assembly (can inherit)
         */

        /* Constructor
         * Parameters are local variables, while public string variables
         * exist within the class.
         * Akin to a method that is called whenever the human class is
         * created within a program.
         */
        //default constructor
        public Human() 
        {
            Console.WriteLine("Constructor called. Object created.");
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // alternative constructor
        public Human(string firstName, string lastName) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        //Member method
        public void IntroduceMyself() 
        {
            if (age != 0)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My eyes are {2} and I am {3} years old.",
                firstName, lastName, eyeColor, age);
            }
            else if (!String.IsNullOrEmpty(firstName) && String.IsNullOrEmpty(eyeColor))
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else 
            {
                Console.WriteLine("This person was not given a name.");
            }
        }

    }
}
