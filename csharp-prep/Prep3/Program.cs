using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Variable to store the user answer if he wanted to keep playing
        string keepPlaying = "";
        
        // This next loop will keep working until the user say "no"
        do 
        {

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Guess a number between 1 to 100");
            Console.WriteLine("");

            // Generate a random number from 1 to 100
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 101);

            // Variable to store the guessed user number
            int userNumber;

            // This next loop will keep working until the user number be the true number
            do
            {
                // Ask user for a guess
                Console.Write("What is your guess? ");
                string userAnswer = Console.ReadLine();
                // To convert the string into integer
                userNumber = int.Parse(userAnswer);

                // Conditions to know if the guessed user number is lower or higher than true number
                if (userNumber < number)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine("");
                }
                else if (userNumber > number)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("");
                }
                else 
                {
                    Console.WriteLine($"You guessed it! The number is {number}.");
                    Console.WriteLine("");

                    Console.Write("Do you want to play again? (yes/no) ");
                    keepPlaying = Console.ReadLine();
                    Console.WriteLine("--------------------------------");
                }
            } while (userNumber != number);

        } while (keepPlaying == "yes");
        
        Console.WriteLine("Thanks for playing!");
        Console.Write("--------------------------------");
        
    }
}