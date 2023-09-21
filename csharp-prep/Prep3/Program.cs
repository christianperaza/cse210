using System;

class Program
{
    static void Main(string[] args)
    {
        
        string keepPlaying = "";

        do 
        {

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Guess a number between 1 to 100");
            Console.WriteLine("");

            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 101);

            int userNumber;

            do
            {
                Console.Write("What is your guess? ");
                string userAnswer = Console.ReadLine();
                userNumber = int.Parse(userAnswer);

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