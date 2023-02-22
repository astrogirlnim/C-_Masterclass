using System;

namespace Challenge4
{
    class Program
    {
        /*Imagine you are a developer and get a job in which 
         * you need to create a program for a teacher. He needs 
         * a program written in c# that calculates the average 
         * score of his students. So he wants to be able to enter 
         * each score individually and then get the final average 
         * score once he enters -1.
         * So the tool should check if the entry is a number and 
         * should add that to the sum. Finally once he is done 
         * entering scores, the program should write onto the console
         * what the average score is.*/
        static void Main(string[] args)
        {
            int score = 0, totalSum = 0, numOfStudents = 0;
            bool success = true;

            Console.WriteLine("Please enter a student's score followed by enter." +
                "\nWhen finished, input a -1 followed by enter to receive the score average.");

            while(success = (int.TryParse(Console.ReadLine(), out score) && (score <=20 || score >= 0)) 
                && score != -1)
            {
                totalSum += score;
                numOfStudents++;
            }

            Console.WriteLine(success ? $"The average score is {(double)totalSum / numOfStudents}" :
                "Please input a valid integer score (between 1 and 20).");
            Console.Read();

            
        }
    }
}
