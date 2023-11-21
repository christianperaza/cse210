public class Eternal : Goal
{
    // constructor to set the type ETERNAL...
    public Eternal(string type = "Eternal Goal") : base(type)
    {
    }

    // save goal overrided...
    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{GetTypeGoal()},{GetNameGoal()},{GetDescriptionGoal()},{GetPointsGoal()}");
        }
    }

    // is completed overrided...
    public override void IsCompleted()
    {
        SetCompletedGoal(false);
    }

    // record event overrided...
    public override int RecordEvent()
    {
        if (GetCompletedGoal() == false)
        {
            SetCheckGoal("");
        }

        Console.WriteLine($"\nCongratulations! You have earned {GetPointsGoal()}");
        
        return SumPoints(GetPointsGoal(), 0);
    }
}
