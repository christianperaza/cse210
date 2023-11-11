public class Goal
{
    private int _totalPoints = 0;
    
    private string _nameGoal;
    private string _descriptionGoal;
    private int _pointGoal;

    private int _timesCheck; //check
    private int _bonusCheck; //check

    private List<string> _listOfGoals = new List<string>();

    public void TotalPoints()
    {
        Console.WriteLine($"\nYou have {_totalPoints} points.\n");
    }

    public void GoalPrompts()
    {
        Console.WriteLine("");
        Console.Write("What is the name of your goal? ");
        _nameGoal = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _descriptionGoal = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string _userPoint = Console.ReadLine();
        _pointGoal = int.Parse(_userPoint);
    }

    public void CheckGoalPrompts()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string _userTimes = Console.ReadLine();
        _timesCheck = int.Parse(_userTimes);

        Console.Write("Whats is the bonus for accomplishing it that many times? ");
        string _userBonus = Console.ReadLine();
        _bonusCheck = int.Parse(_userBonus);
    }

    public void PutGoalsInList()
    {
        string _goalInList = $"[ ] {_nameGoal} ({_descriptionGoal})";
        _listOfGoals.Add(_goalInList);
    }

    public void CheckPutGoalsInList()
    {
        string _checkGoalInList = $"[ ] {_nameGoal} ({_descriptionGoal}) -- Currently completed: 0/{_timesCheck}";
        _listOfGoals.Add(_checkGoalInList);
    }

    public void ListGoals()
    {
        int _number = 1;

        Console.Write("\nThe goals are:");

        for (int i = 0; i < _listOfGoals.Count; i++)
        {
            Console.Write($"\n{_number}. {_listOfGoals[i]}");

            _number++;
        }
    }

    


    
}