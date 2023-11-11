using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goal goal = new Goal();

        // Simple simple = new Simple();
        // Eternal eternal = new Eternal();
        // Checklist checklist = new Checklist();

        int menuChoice;
        do
        {
            goal.TotalPoints();

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
                    goal.GoalPrompts();
                    goal.PutGoalsInList();
                }
                else if (typeChoice == 2)
                {
                    goal.GoalPrompts();
                    goal.PutGoalsInList();
                } 
                else if (typeChoice == 3)
                {
                    goal.GoalPrompts();
                    goal.CheckGoalPrompts();
                    goal.CheckPutGoalsInList();
                } 
            }
            else if (menuChoice == 2)
            {
                goal.ListGoals();
            }

        } while (menuChoice != 6);
        

        

    }
}