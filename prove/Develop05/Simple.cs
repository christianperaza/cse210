public class Simple : Goal
{

    public Simple(string type = "Simple Goal") : base(type)
    {

    }


    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{GetTypeGoal()},{GetNameGoal()},{GetDescriptionGoal()},{GetPointsGoal()},{GetCompletedGoal()}");
        }
    }

    public override void IsCompleted()
    {
        SetCompletedGoal(true);
    }


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