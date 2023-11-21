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



    public override void RecordEvent()
    {
        if (GetCompletedGoal() == true)
        {
            SetCheckGoal("");
        }


    }
}
