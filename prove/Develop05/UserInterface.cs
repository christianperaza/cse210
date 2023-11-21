public class UserInterface
{

    private int _totalPoints;
    private string _level = "BRONZE";

    public void SetLevel()
    {
        if (_totalPoints > 100)
        {
            _level = "SILVER";
        }

        if (_totalPoints > 300)
        {
            _level = "GOLD";
        }
        
        if (_totalPoints > 550)
        {
            _level = "DIAMOND";
        }
    }

    // menu...
    public int DisplayMainMenu()
    {
        SetLevel();
        Console.WriteLine($"\nYou have {_totalPoints} points.");
        Console.WriteLine($"You are level '{_level}'.\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

        Console.WriteLine("Select a choice from the menu");
        Console.Write("> ");
        string menuInput = Console.ReadLine();
        int menuChoice = int.Parse(menuInput);
        return menuChoice;
    }

    // option goals...
    public int DisplayOptionGoals()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create?");
        Console.Write("> ");
        string optionInput = Console.ReadLine();
        int goalChosen = int.Parse(optionInput);
        return goalChosen;
    }

    // list titles...
    public int DisplayTitlesListGoals()
    {
        Console.Write("\nThe goals are:\n");
        return 1;
    }

    // saving...
    public string Saving()
    {
        Console.WriteLine("\nWhat is the filename for the goal file?");
        Console.Write("> ");
        string filename = Console.ReadLine();
        return filename;
    }
    public void SaveTotalPoints(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_totalPoints}");
        }
    }

    // load...
    public void LoadGoal(List<Goal> goals)
    {
        Console.WriteLine("\nWhat is the filename for the goal file?");
        Console.Write("> ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        string totalPoints = lines[0];
        _totalPoints = int.Parse(totalPoints);

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
            else if (type == "Checklist Goal")
            {
                string bonus = parts[4];
                int bonusInt = int.Parse(bonus);

                string times = parts[5];
                int timesInt = int.Parse(times);

                string counter = parts[6];
                int counterInt = int.Parse(counter);

                Checklist checklist = new Checklist();
                checklist.SetNameGoal(name);
                checklist.SetDescriptionGoal(desc);
                checklist.SetPointsGoal(pointsInt);
                checklist.SetBonusPoints(bonusInt);
                checklist.SetTimesToCheck(timesInt);
                checklist.SetCounterTimes(counterInt);
                goals.Add(checklist);
            }    
                    
        }
    }

    // record event...
    public void ChooseGoalToCompleted(Goal goal, int n)
    {
        string name = goal.GetNameGoal();           
        Console.WriteLine($"{n}. {name}");
    }
    public void AskingGoal(List<Goal> goals)
    {
        Console.Write("\nWhich goal did you accomplish? ");
        string goalAccomplished = Console.ReadLine();
        int number = int.Parse(goalAccomplished);

        goals[number - 1].GetPointsGoal();
   
        goals[number - 1].IsCompleted();
        int point = goals[number - 1].RecordEvent();
        
        SumTotalPoints(point);
    
    }

    public void SumTotalPoints(int points)
    {
        _totalPoints += points;
    }
    public int ReturnTotalPoints()
    {
        return _totalPoints;
    }

   

}