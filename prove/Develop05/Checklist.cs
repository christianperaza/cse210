public class Checklist : Goal
{
    private int _timesToCheck;
    private int _bonusPoints;
    private int _counterTimes;

    public Checklist(string type = "Checklist Goal") : base(type)
    {

    }

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

    // times...
    public void SetTimesToCheck(int times)
    {
        _timesToCheck =  times;
    }
    public int GetTimesToCheck()
    {
        return _timesToCheck;
    }

    // bonus...
    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    // counter...
    public void SetCounterTimes(int counter)
    {
        _counterTimes = counter;
    }
    public int GetCounterTimes()
    {
        return _counterTimes;
    }

    public override string DisplayListOfGoal()
    {
        return $"[{GetCheckGoal()}] {GetNameGoal()} ({GetDescriptionGoal()}) -- Currently completed {_counterTimes}/{_timesToCheck}";
    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{GetTypeGoal()},{GetNameGoal()},{GetDescriptionGoal()},{GetPointsGoal()},{_bonusPoints},{_timesToCheck},{_counterTimes}");
        }
    }


    public override void RecordEvent()
    {
        if (GetCompletedGoal() == true)
        {
            SetCheckGoal("X");
        }
    }
}