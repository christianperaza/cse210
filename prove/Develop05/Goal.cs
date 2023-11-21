public abstract class Goal
{
    private string _nameGoal;
    private string _descriptionGoal;
    private int _pointsGoal;
    private string _typeGoal;

    private bool _completedGoal;

    private string _check;


    

    public Goal(string type)
    {
        _typeGoal = type;
    }


    // name...
    public void SetNameGoal(string name)
    {
        _nameGoal = name;
    }
    public string GetNameGoal()
    {
            
        return _nameGoal;
        
    }

    // description...
    public void SetDescriptionGoal(string description)
    {
        _descriptionGoal = description;
    }
    public string GetDescriptionGoal()
    {
        return _descriptionGoal;
    }

    // points...
    public void SetPointsGoal(int points)
    {
        _pointsGoal = points;
    }
    public int GetPointsGoal()
    {
        return _pointsGoal;
    }

    // type...
    public string GetTypeGoal()
    {
        return _typeGoal;
    }

    // completed?...
    public void SetCompletedGoal(bool completed)
    {
        _completedGoal = completed;
    }
    public bool GetCompletedGoal()
    {
        return _completedGoal;
    }

    // check...
    public void SetCheckGoal(string check)
    {
        _check = check;
    }
    public string GetCheckGoal()
    {
        return _check;
    }

    // promts...
    public void DisplayGoalPrompts()
    {
        Console.WriteLine("");
        Console.Write("What is the name of your goal? ");
        _nameGoal = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _descriptionGoal = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string _userPoint = Console.ReadLine();
        _pointsGoal = int.Parse(_userPoint);
    }

    public virtual string DisplayListOfGoal(){
        return $"[{GetCheckGoal()}] {GetNameGoal()} ({GetDescriptionGoal()})";
    }

    public void SaveGoal(Goal goal, string filename, int time, int bonus)
    {
        string type = goal.GetTypeGoal();
        string name = goal.GetNameGoal();
        string description = goal.GetDescriptionGoal();
        int points = goal.GetPointsGoal();
        bool completed = goal.GetCompletedGoal();


        using (StreamWriter outputFile = File.AppendText(filename))
        {

            

        

            if (type == "Simple Goal")
            {
                outputFile.WriteLine($"{type},{name},{description},{points},{completed}");
            }
            else if (type == "Eternal Goal")
            {
                outputFile.WriteLine($"{type},{name},{description},{points}");
            }
            else if (type == "Checklist Goal")
            {
                outputFile.WriteLine($"{type},{name},{description},{points},{bonus},{time}");
            }
                        
        }   
    }

    // display lits of goals to record event
    public void ChooseGoalToCompleted(Goal goal, int n)
    {
        string name = goal.GetNameGoal();
                    
        Console.WriteLine($"{n}. {name}");
    }

    public abstract void RecordEvent();


    

    

}