public class Eternal : Goal
{
    public Eternal(string type = "Eternal Goal") : base(type)
    {

    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{GetTypeGoal()},{GetNameGoal()},{GetDescriptionGoal()},{GetPointsGoal()}");
        }
    }

    public override void IsCompleted()
    {
        SetCompletedGoal(false);
    }




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
