public abstract class Goal
{
    private string _nameGoal; // name of Goal
    private string _descriptionGoal; // description of Goal
    private int _pointsGoal; // points of Goal
    private string _typeGoal; // type of Goal
    private bool _completedGoal; // goal is completed? true or false?
    private string _check; // check: [X] or []

    // constructor to get the type: Simple, Eternal, or Checklist?
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

    // sum total points
    public int SumPoints(int points, int bonus)
    {
        return points + bonus;
    }


    // ---------- VIRTUAL AND ABSTRACT METHODS ---------- //

    // display list... is virtual because Simple and Eternal use it, but Checklist override
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

    // save... is abstract because each type of goal save their goals in a different way
    public abstract void SaveGoal(string filename);

    // is completed...
    public abstract void IsCompleted();
    
    // record event...
    public abstract int RecordEvent();
}