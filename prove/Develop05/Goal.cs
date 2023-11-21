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

    // display list...
    public virtual string DisplayListOfGoal()
    {
        if (_completedGoal == true)
        {
            SetCheckGoal("X");
        }
        else
        {
            SetCheckGoal("");
        }
        
        return $"[{GetCheckGoal()}] {GetNameGoal()} ({GetDescriptionGoal()})";
    }

    // save...
    public abstract void SaveGoal(string filename);

    // is completed...
    public abstract void IsCompleted();
    
    // record event...
    public abstract int RecordEvent();

    // sum total points
    public int SumPoints(int points, int bonus)
    {
        return points + bonus;
    }
    

    


    

    

}