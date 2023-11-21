using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        UserInterface userInterface = new UserInterface();
        List<Goal> goals = new List<Goal>();

        
        int menuChoice;
        do
        {
            menuChoice = userInterface.DisplayMainMenu();
            
            // 1 create...
            if (menuChoice == 1)
            {
                int goalChosen = userInterface.DisplayOptionGoals();

                if (goalChosen == 1)
                {
                    Simple simple = new Simple();
                    simple.DisplayGoalPrompts();
                    goals.Add(simple);
                }
                else if (goalChosen == 2)
                {
                    Eternal eternal = new Eternal();
                    eternal.DisplayGoalPrompts();
                    goals.Add(eternal);
                }
                else if (goalChosen == 3)
                {
                    Checklist checklist = new Checklist();
                    checklist.DisplayChecklistPrompts();
                    goals.Add(checklist);
                }

            }
            // 2 display list...
            else if (menuChoice == 2)
            {
                int n = userInterface.DisplayTitlesListGoals();

                foreach (Goal goal in goals)
                {   
                    Console.WriteLine($"{n}. {goal.DisplayListOfGoal()}");
                    n++;   
                }
            }
            // 3 save...
            else if (menuChoice == 3)
            {

                string filename = userInterface.Saving();

                userInterface.SaveTotalPoints(filename);

                foreach (Goal goal in goals)
                {  
                    goal.SaveGoal(filename);
                }

            }
            // 4 load...
            else if (menuChoice == 4)
            {
                userInterface.LoadGoal(goals);
            }
            // 5 record event...
            else if (menuChoice == 5)
            {
                int n = userInterface.DisplayTitlesListGoals();

                foreach (Goal goal in goals)
                {   
                    userInterface.ChooseGoalToCompleted(goal, n);
                    n++;
                }

                userInterface.AskingGoal(goals);
            
            }
        

        } while(menuChoice != 6); 

    }
}