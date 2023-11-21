public class UserInterface
{

    private int _totalPoints;


    

    public int DisplayMainMenu()
    {
        Console.WriteLine($"\nYou have {_totalPoints} points.\n");

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

    public void DisplayTitlesListGoals()
    {
        Console.Write("\nThe goals are:\n");

        
    }

    public void DisplayTitlesSaving()
    {
        Console.WriteLine("What is the filename for the goal file?");
        Console.Write("> ");
    }

    public void AskingGoal(List<Goal> goals)
    {
        Console.Write("What goal you accomplished? ");
        string goalAccomplished = Console.ReadLine();
        int number = int.Parse(goalAccomplished);

        int points = goals[number-1].GetPointsGoal();
        goals[number-1].SetCompletedGoal(true);
        goals[number-1].RecordEvent();
        
        SetTotalPoints(points);
    }

    public void SetTotalPoints(int points)
    {
        _totalPoints += points;
    }
    public int ReturnTotalPoints()
    {
        return _totalPoints;
    }

   

}