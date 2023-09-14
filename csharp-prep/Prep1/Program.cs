using System;

class Program
{
    static void Main(string[] args)
    {
        // This next line is just design
        Console.WriteLine("-------------------------------------");
        
        // Ask user his first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask user his last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // An space
        Console.WriteLine("");

        // Print the sentence
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        // Line just to design
        Console.WriteLine("-------------------------------------");
    }
}