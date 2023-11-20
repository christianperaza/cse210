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
            else if (menuChoice == 3)
            {
                Console.WriteLine("What is the filename for the goal file?");
                Console.Write("> ");
                string filename = Console.ReadLine();

                foreach (Goal goal in goals)
                {     
                    string type = goal.GetTypeGoal();
                    string name = goal.GetNameGoal();
                    string description = goal.GetDescriptionGoal();
                    int points = goal.GetPointsGoal();
                    bool completed = goal.GetCompletedGoal();

                    Console.WriteLine($"[ ] {name} ({description})");

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"{type}:{name},{description},{points},{completed}");
                    }   
                       
                }

            }
        

        } while(menuChoice != 6); 

    }
}