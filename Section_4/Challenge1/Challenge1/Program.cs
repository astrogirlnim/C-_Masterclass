using System;

namespace Challenge1
{
    class Program
    {
        static string username, password;
        /// <summary>
        /// Create a user Login System, where the user can 
        /// first register and then Login in. The Program should 
        /// check if the user has entered the correct username 
        /// and password, wenn login in (so the same ones that 
        /// he used when registering).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Register
            register();

            // Verify login
            if(Console.ReadKey().Key == ConsoleKey.Enter) {

                if (login())
                {
                    Console.WriteLine("You are logged in.");
                }
                else 
                {
                    Console.WriteLine("Error: incorrect username or password. Restart Program.");
                }
            }

            Console.Read();
        }

        /// <summary>
        /// Registers the username and password.
        /// </summary>
        public static void register() 
        {
            Console.WriteLine("Please register by entering a username and password.\nAfterwards, press enter to log in.");
            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        /// <summary>
        /// Login protocol which returns a boolean true for successful login.
        /// </summary>
        /// <returns></returns>
        public static bool login() 
        {
            Console.Clear();

            Console.WriteLine("Please log in by entering a username and password.");
            Console.Write("Username: ");
            if(!string.Equals(username, Console.ReadLine())) {
                return false;
            }

            Console.Write("Password: ");
            if (!string.Equals(password, Console.ReadLine()))
            {
                return false;
            }

            // Passes if all conditions match
            return true;

        }
    }
}
