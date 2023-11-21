using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        UserInterface userInterface = new UserInterface(); // UserInterface class
        List<Goal> goals = new List<Goal>(); // list to add Goal classes

        int menuChoice; // store the user choice
        do
        {
            menuChoice = userInterface.DisplayMainMenu(); // display menu choice
            
            // option 1: create...
            if (menuChoice == 1)
            {
                int goalChosen = userInterface.DisplayOptionGoals(); // choose which type of goal you want to create

                // simple goal...
                if (goalChosen == 1)
                {
                    Simple simple = new Simple();
                    simple.DisplayGoalPrompts();
                    goals.Add(simple);
                }
                // eternal goal...
                else if (goalChosen == 2)
                {
                    Eternal eternal = new Eternal();
                    eternal.DisplayGoalPrompts();
                    goals.Add(eternal);
                }
                // checklist goal...
                else if (goalChosen == 3)
                {
                    Checklist checklist = new Checklist();
                    checklist.DisplayChecklistPrompts();
                    goals.Add(checklist);
                }

            }
            // option 2: display list...
            else if (menuChoice == 2)
            {
                int n = userInterface.DisplayTitlesListGoals(); // display 'The types of Goals are:' and store the number of the lists

                foreach (Goal goal in goals)
                {   
                    Console.WriteLine($"{n}. {goal.DisplayListOfGoal()}");
                    n++;   
                }
            }
            // option 3: save goals...
            else if (menuChoice == 3)
            {
                string filename = userInterface.CreateFilenameToSave();

                userInterface.SaveTotalPointsInFile(filename);

                foreach (Goal goal in goals)
                {  
                    goal.SaveGoal(filename);
                }
            }
            // option 4: load goals...
            else if (menuChoice == 4)
            {
                userInterface.LoadGoal(goals);
            }
            // option 5: record event...
            else if (menuChoice == 5)
            {
                int n = userInterface.DisplayTitlesListGoals(); // display 'The types of Goals are:' and store the number of the lists

                foreach (Goal goal in goals)
                {   
                    userInterface.DisplayNameOfGoalsList(goal, n); // display the goals you have
                    n++;
                }

                userInterface.AskWhichGoalYouCompleted(goals); // which goal did you accomplish?
            }

        } while(menuChoice != 6); // option 6: finish program.
    }
}