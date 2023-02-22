using System;

namespace ClassesBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //::CALLING A CLASS/ CLASS BASICS::
            //-------------------------------------
            // Creating an object of a class
            // an instance of the class "human"
            // When creating the variable, private variables can be
            // accessed through the constructor.
            Human denis = new Human("Denis","Marron","blue",21);
            Human beth = new Human("Beth", "Harmon");
            // accesing public variables from outside class 
            // and changing them
            // denis.firstName = "Dom";

            // calling a method from the class
            denis.IntroduceMyself();
            beth.IntroduceMyself();

            //outputs default member variable when called
            Human michael = new Human("Michael","Phelps","red",40);
            michael.IntroduceMyself();

            //Using default constructors
            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
