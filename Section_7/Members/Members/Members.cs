using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely
        // start with a capital letter
        public int JobTitle { get; set; }

        // public member method - can be called from other classes
        public void Introducing (bool isFriend) 
        {
            Console.WriteLine("Hello, my name is {0}, I work as a {1}.", memberName, jobTitle);
            if (isFriend) 
            {
                SharingPrivateInfo();
            }
        }

        private void SharingPrivateInfo() 
        {
            Console.WriteLine("My salary is {0}.", salary);
        }

        // member constructor
        public Members() 
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created.");
        }

        // member - finalizer - destructor
        // can only be written once
        // empty finalizers should not be used - uneccessarily added to the queue
        ~Members() 
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members object.");
        }
    }
}
