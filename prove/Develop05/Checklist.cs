public class Checklist : Goal
{
    private int _timesToCheck;
    private int _bonusPoints;

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

    public int GetTimesToCheck()
    {
        return _timesToCheck;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    // public override void SaveGoal()
    // {
        
    // }

    public override string DisplayListOfGoal()
    {
        return $"[{GetCheckGoal()}] {GetNameGoal()} ({GetDescriptionGoal()}) -- Currently completed 0/{_timesToCheck}";
    }

    public override void RecordEvent()
    {
        if (GetCompletedGoal() == true)
        {
            SetCheckGoal("X");
        }
    }
}