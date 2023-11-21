public class Eternal : Goal
{
    public Eternal(string type = "Eternal Goal") : base(type)
    {

    }



    public override void RecordEvent()
    {
        if (GetCompletedGoal() == true)
        {
            SetCheckGoal("");
        }


    }
}
