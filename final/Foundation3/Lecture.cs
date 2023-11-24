public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string street, string city, string state, string country, string speaker, int capacity) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Lecture");

        _speakerName = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Speaker: {_speakerName}. Capacity: {_capacity}.");
    }

    public void DisplayMarketingMessages()
    {
        Console.WriteLine("Standard Details:");
        DisplayStandardDetails();
        Console.WriteLine("");

        Console.WriteLine("Full Details:");
        DisplayFullDetails();
        Console.WriteLine("");

        Console.WriteLine("Short Description:");
        DisplayShortDescription();
        Console.WriteLine("");
    }

    

    
}