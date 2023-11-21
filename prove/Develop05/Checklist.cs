public class Checklist : Goal
{
    private int _timesToCheck; // times to check all
    private int _bonusPoints; // bonus point
    private int _counterTimes; // counter of times. Ex: counter/timesToCheck
    private int _bonus0; // value 0. This variable is just to add until the user gain real bonus point

    // constructor to set the type CHECKLIST...
    public Checklist(string type = "Checklist Goal") : base(type)
    {
    }

    // times to check...
    public void SetTimesToCheck(int times)
    {
        _timesToCheck =  times;
    }
    public int GetTimesToCheck()
    {
        return _timesToCheck;
    }

    // bonus point...
    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    // counter of times...
    public void SetCounterTimes(int counter)
    {
        _counterTimes = counter;
    }
    public int GetCounterTimes()
    {
        return _counterTimes;
    }

    // display prompts plus its own prompts...
    public void DisplayChecklistPrompts()
    {
        DisplayGoalPrompts();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string _userTimes = Console.ReadLine();
        _timesToCheck = int.Parse(_userTimes);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string _userBonus = Console.ReadLine();
        _bonusPoints = int.Parse(_userBonus);
    }

    // display list of goals and its own way...
    public override string DisplayListOfGoal()
    {
        if (_counterTimes == _timesToCheck)
        {
            SetCheckGoal("X");
        }
        else
        {
            SetCheckGoal("");
        }
        return $"[{GetCheckGoal()}] {GetNameGoal()} ({GetDescriptionGoal()}) -- Currently completed {_counterTimes}/{_timesToCheck}";
    }

    // save goal overrided...
    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{GetTypeGoal()},{GetNameGoal()},{GetDescriptionGoal()},{GetPointsGoal()},{_bonusPoints},{_timesToCheck},{_counterTimes}");
        }
    }

    // is completed overrided...
    public override void IsCompleted()
    {
        SetCompletedGoal(true);
    }

    // record event overrided...
    public override int RecordEvent()
    {
        if (GetCompletedGoal() == true)
        {
            _counterTimes++;
            Console.WriteLine($"\nCongratulations! You have earned {GetPointsGoal()}");
        }

        if (_counterTimes == _timesToCheck)
        {
            SetCheckGoal("X");
            _bonus0 = GetBonusPoints();
            Console.WriteLine($"And plus! A bonus of {_bonus0}");
        }

        return SumPoints(GetPointsGoal(), _bonus0);
    }
}