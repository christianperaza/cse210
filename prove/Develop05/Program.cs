using System;

class Program
{
    static void Main(string[] args)
    {

        UserInterface userInterface = new UserInterface();
        // Goal goal = new Goal();
        Simple simple = new Simple();
        Eternal eternal = new Eternal();

        List<Goal> goals = new List<Goal>();

        
        int menuChoice;
        do
        {
            userInterface.DisplayMainMenu();
            string menuInput = Console.ReadLine();
            menuChoice = int.Parse(menuInput);

            if (menuChoice == 1)
            {
                userInterface.DisplayOptionGoals();
                string optionInput = Console.ReadLine();
                int goalChosen = int.Parse(optionInput);

                if (goalChosen == 1)
                {
                    simple.DisplayGoalPrompts();
                    goals.Add(simple);
                }
                else if (goalChosen == 2)
                {
                    eternal.DisplayGoalPrompts();
                    goals.Add(eternal);
                }
            }
            else if (menuChoice == 2)
            {
                userInterface.DisplayTitlesListGoals();

                int n = 1;
                
                foreach (Goal goal in goals)
                {     

                    string name = goal.GetNameGoal();
                    string description = goal.GetDescriptionGoal();
                    Console.WriteLine($"{n}. [ ] {name} ({description})");

                    n++;
                       
                }
            }
        

        } while(menuChoice != 6); 

    }
}