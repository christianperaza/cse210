public class Simple : Goal
{



    public Simple(string type = "Simple Goal") : base(type)
    {

    }



    // public void SetCheck(string check)
    // {
    //     base.SetCheckGoal();
    // }


    public override void RecordEvent()
    {
        if (GetCompletedGoal() == true)
        {
            SetCheckGoal("X");
        }


    }



}