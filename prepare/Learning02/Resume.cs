public class Resume
{

    public string _personName = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void DisplayResume()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        _jobs[0].DisplayJobDetails();
        _jobs[1].DisplayJobDetails();
        Console.WriteLine("-----------------------------------------");
    }

}