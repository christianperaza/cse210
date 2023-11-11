public class Simple : Goal
{
    private string _typeGoal;
    private string _nameGoal;
    private string _descriptionGoal;
    private int _pointGoal;
    private bool _completed;

    private List<string> _listSimpleGoals = new List<string>();

    private List<string> _listAllSimpleGoals = new List<string>();

    public Simple()
    {
        _typeGoal = "SimpleGoal";
        _completed = false;
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

    public void PutAllItemsInList()
    {
        string _itemsOfSimpleGoal = $"{_typeGoal},{_nameGoal},{_descriptionGoal},{_pointGoal},{_completed}";
        _listSimpleGoals.Add(_itemsOfSimpleGoal);
    }




    
}