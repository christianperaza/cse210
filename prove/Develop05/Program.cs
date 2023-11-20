using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        UserInterface userInterface = new UserInterface();
        // Goal goal = new Goal();
        Simple simple = new Simple();
        Eternal eternal = new Eternal();
        Checklist checklist = new Checklist();

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
                else if (goalChosen == 3)
                {
                    checklist.DisplayGoalPrompts();
                    checklist.DisplayChecklistPrompts();
                    goals.Add(checklist);
                }

            }
            else if (menuChoice == 2)
            {
                userInterface.DisplayTitlesListGoals();

                int n = 1;
                
                foreach (Goal goal in goals)
                {     
                    int timesToCheck = checklist.GetTimesToCheck();
                    
                    goal.DisplayListOfGoal(goal, n, timesToCheck);

                    n++;
                       
                }
            }
            else if (menuChoice == 3)
            {
                userInterface.DisplayTitlesSaving();
                string filename = Console.ReadLine();

                foreach (Goal goal in goals)
                {     
                    int timesToCheck = checklist.GetTimesToCheck();
                    int bonus = checklist.GetBonusPoints();
                    

                    goal.SaveGoal(goal, filename, timesToCheck, bonus);
                       
                }

            }
        

        } while(menuChoice != 6); 

    }
}