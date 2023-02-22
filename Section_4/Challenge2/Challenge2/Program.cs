using System;

namespace Challenge2
{
    /// <summary>
    /// Create an application with a score, highscore and a highscorePlayer.
    /// Create a method which has two parameters, one for the score and one 
    /// for the playerName. When ever that method is called, it should be 
    /// checked if the score of the player is higher than the highscore, 
    /// if so, "New highscore is + " score" and in another line "New highscore 
    /// holder is " + playerName - should be written onto the console, if not 
    /// "The old highscore of " + highscore + " could not be broken and is still 
    /// held by " + highscorePlayer.
    /// </summary>
    class Program
    {
        static int score;
        static int highscore = 100;
        static string highscorePlayer = "Bob Ross";

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter username and score.");
            Console.Write("Username: ");
            string playerName = Console.ReadLine();

            Console.Write("Score: ");
            bool validScore = int.TryParse(Console.ReadLine(), out score);

            if (validScore || !string.IsNullOrEmpty(playerName))
            {
                CheckScore(score, playerName);
            }
            else
            {
                Console.WriteLine("Error: please enter a valid player name and score.");
            }

            Console.Read();

        }

        public static void CheckScore(int score, string playerName) 
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore player is "+ playerName);
            } else
            {
                Console.WriteLine("The old highscore of "+ highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }
    }
}
