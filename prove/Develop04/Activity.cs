public class Activity
{
    private string _nameActivity;
    private string _descriptionActivity;
    private int _timeActivity;

    public Activity(string nameActivity, string descriptionActivity)
    {
        _nameActivity = nameActivity;
        _descriptionActivity = descriptionActivity;
    }

    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameActivity}.\n");
        Console.WriteLine($"{_descriptionActivity}\n");

        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.Write("> ");
        string userInputTimeString = Console.ReadLine();
        _timeActivity = int.Parse(userInputTimeString);

        Console.Clear();
        Console.WriteLine("Get ready...");

        SpinnerAnimation(5);
    }

    public int SetTime()
    {
        return _timeActivity;
    }

    public void SpinnerAnimation(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            // Console.Write("");
            // Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");

            // Console.Write(".");
            // Thread.Sleep(500);
            // Console.Write("\b \b");
            
            // Console.Write("..");
            // Thread.Sleep(500);
            // Console.Write("\b \b");
            // Console.Write("");
            // Console.Write("\b \b");

            // Console.Write("...");
            // Thread.Sleep(500);
            // Console.Write("\b \b");
            // Console.Write("");
            // Console.Write("\b \b");
            // Console.Write("");
            // Console.Write("\b \b");
        }   
    }

    public void CounterAnimation(int number)
    {
        for (int i = number; i != 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void EndingMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Well done!!");
        SpinnerAnimation(5);

        Console.WriteLine($"\nYou have completed another {_timeActivity} seconds of the {_nameActivity}.");
        SpinnerAnimation(5);
    }       
}

