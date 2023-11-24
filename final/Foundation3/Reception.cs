public class Reception : Event
{
    // attribute...
    private string _email;

    // constructor to set each value to corresponding attributes...
    public Reception(string title, string description, string date, string time, string street, string city, string state, string country, string email) : base(title, description, date, time, street, city, state, country)
    {
        SetType("Receptions"); // set type

        _email = email;

        SetSpecificDetails($"EMAIL FOR RSVP: {_email}"); // set specific receptions detail
    }
    
}