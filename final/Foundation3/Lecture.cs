public class Lecture : Event
{
    // attributes...
    private string _speakerName;
    private int _capacity;

    // constructor to set each value to corresponding attributes...
    public Lecture(string title, string description, string date, string time, string street, string city, string state, string country, string speaker, int capacity) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Lectures"); // set type

        _speakerName = speaker;
        _capacity = capacity;

        SetSpecificDetails($"SPEAKER: {_speakerName}.\nCAPACITY: {_capacity}."); // set specific lectures detail
    }
    
}