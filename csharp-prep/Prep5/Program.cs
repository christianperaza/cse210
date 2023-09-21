using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        // For this assignment, write a C# program that has several simple functions:

        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
            Console.WriteLine("");
        }

        // PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Enter you name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Enter you favorite number: ");
            string userAnswer = Console.ReadLine();
            int userNumber = int.Parse(userAnswer);
            return userNumber;
        }

        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // DisplayResult - Accepts the user's name and the squared number and displays them
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }

        Console.WriteLine("---------------------------------------------------");

        // Call the functions
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

        Console.WriteLine("---------------------------------------------------");

    }
}