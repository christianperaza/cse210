using System;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        
        Menu menu = new Menu();

        int userChoice;

        do
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.\n");
            menu.DisplayMenu();
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);  

        } while (userChoice != 6);
        

        

    }
}