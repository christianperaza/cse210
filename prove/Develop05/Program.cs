using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        UserInterface userInterface = new UserInterface();
        Checklist checklist = new Checklist();
        List<Goal> goals = new List<Goal>();

        
        int menuChoice;
        do
        {
            menuChoice = userInterface.DisplayMainMenu();
            
            // create...
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
                    checklist.DisplayChecklistPrompts();
                    goals.Add(checklist);
                }

            }
            // display list...
            else if (menuChoice == 2)
            {
                userInterface.DisplayTitlesListGoals();

                int n = 1;

                foreach (Goal goal in goals)
                {   
                    Console.WriteLine($"{n}. {goal.DisplayListOfGoal()}");
                    n++;   
                }
            }
            // save...
            else if (menuChoice == 3)
            {
                userInterface.DisplayTitlesSaving();
                int totalPoints = userInterface.ReturnTotalPoints();
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = File.AppendText(filename))
                {

                    outputFile.WriteLine($"{totalPoints}");
                }
        

                foreach (Goal goal in goals)
                {  
                    
                    int time = checklist.GetTimesToCheck();
                    int bonus = checklist.GetBonusPoints();



                    goal.SaveGoal(goal, filename, time, bonus);
                    
                    
                       
                }

            }
            else if (menuChoice == 4)
            {
                Console.Write("The name of your file? ");
                string filename = Console.ReadLine();

              
                string[] lines = File.ReadAllLines(filename);

                string total = lines[0];

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(",");
                    string type = parts[0];
                    string name = parts[1];
                    string desc = parts[2];
                    string points = parts[3];
                    int pointsInt = int.Parse(points);

                    if (type == "Simple Goal")
                    {
                        string completed = parts[4].ToLower();
                        bool completedBool = Convert.ToBoolean(completed);

                        Simple simple = new Simple();
                        simple.SetNameGoal(name);
                        simple.SetDescriptionGoal(desc);
                        simple.SetPointsGoal(pointsInt);
                        simple.SetCompletedGoal(completedBool);
                        goals.Add(simple);
                    }
                    else if (type == "Eternal Goal")
                    {
                        Eternal eternal = new Eternal();
                        eternal.SetNameGoal(name);
                        eternal.SetDescriptionGoal(desc);
                        eternal.SetPointsGoal(pointsInt);
                        goals.Add(eternal);
                    }
                    
                }
                
            }
            else if (menuChoice == 5)
            {

                int n = 1;

                foreach (Goal goal in goals)
                {   
                    goal.ChooseGoalToCompleted(goal, n);
                    n++;
                }

                userInterface.AskingGoal(goals);
            }
        

        } while(menuChoice != 6); 

    }
}