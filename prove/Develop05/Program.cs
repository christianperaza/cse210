using System;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        
        Menu menu = new Menu();
        Goal goal = new Goal();

        int menuChoice;
        do
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.\n");

            menu.DisplayMenu();
            string menuInput = Console.ReadLine();
            menuChoice = int.Parse(menuInput); 

            if (menuChoice == 1)
            {
                menu.DisplayTypeOfGoals();
                string typeInput = Console.ReadLine();
                int typeChoice = int.Parse(typeInput);

                if (typeChoice == 1)
                {
                    goal.DisplayPrompts();
                } 
            }

        } while (menuChoice != 6);
        

        

    }
}