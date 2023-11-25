public class Event
{
    // attributes...
    private string _titleEvent;
    private string _descriptionEvent;
    private string _dateEvent;
    private string _timeEvent;
    private Address _addressEvent;

    private string _typeEvent; // Lectures, Receptions, or Outdoor gatherings
    private string _specificDetail; // Lectures: speaker and capacity; Receptions: email; Outdoor gatherings: weather statement

    // constructor to set each attribute value and to create a new instance of Address...
    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _titleEvent = title;
        _descriptionEvent = description;
        _dateEvent = date;
        _timeEvent = time;

        _addressEvent = new Address(street, city, state, country); // to set Address attributes values
    }

    // method...

    // set type
    public void SetType(string type)
    {
        _typeEvent = type;
    }

    // set specific details
    public void SetSpecificDetails(string specificDetail)
    {
        _specificDetail = specificDetail;
    }

    // standard details
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"TITLE: {_titleEvent}.\nDESCRIPTION: {_descriptionEvent}.\nDATE: {_dateEvent}.\nTIME: {_timeEvent}\nADDRESS:\n{_addressEvent.DisplayAddress()}");
    }

    // full details...
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"{_specificDetail}"); // display the specific details. Lectures: speaker and capacity; Receptions: email; Outdoor gatherings: weather statement
    }

    // short description
    public void DisplayShortDescription()
    {
        Console.WriteLine($"TYPE: {_typeEvent}.\nTITLE: {_titleEvent}.\nDATE: {_dateEvent}.");
    }

    // all marketing messages
    public void DisplayMarketingMessages()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"{_typeEvent.ToUpper()}\n"); // display the type for title

        Console.WriteLine("*** STANDARD DETAILS ***");
        DisplayStandardDetails();
        Console.WriteLine("");

        Console.WriteLine("*** FULL DETAILS ***");
        DisplayFullDetails();
        Console.WriteLine("");

        Console.WriteLine("*** SHORT DESCRIPTION ***");
        DisplayShortDescription();
        Console.WriteLine("---------------------------------------");
    }
}