public class Simple : Goal
{
    // constructor to set the type SIMPLE...
    public Simple(string type = "Simple Goal") : base(type)
    {
    }

    // save goal overrided...
    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{GetTypeGoal()},{GetNameGoal()},{GetDescriptionGoal()},{GetPointsGoal()},{GetCompletedGoal()}");
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
            SetCheckGoal("X");
        }

        Console.WriteLine($"\nCongratulations! You have earned {GetPointsGoal()}");
        return SumPoints(GetPointsGoal(), 0);
    }
}