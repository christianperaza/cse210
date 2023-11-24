public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string street, string city, string state, string country, string speaker, int capacity) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Lectures");

        _speakerName = speaker;
        _capacity = capacity;

        SetSpecificDetails($"SPEAKER: {_speakerName}.\nCAPACITY: {_capacity}.");
    }
    
}