using System;

class Program
{
    static void Main(string[] args)
    { 
        Addition addition = new Addition();
        Subtract subtract = new Subtract();

        int userInputInt;
        Console.Clear();
        Console.WriteLine("Hi! What do you want to do?");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction\n");

        Console.Write("Type your choice: ");
        string userInput = Console.ReadLine();
        userInputInt = int.Parse(userInput);

        if (userInputInt == 1)
        {
            addition.SetNumbers();
            addition.Add();
        }
        else if (userInputInt == 2)
        {
            subtract.SetNumbers();
            subtract.Sub();
        }
    }
}
