public class WritingAssignment : Assignment // With the colon let us to inheritance of Assignment class
{

    private string _title; // Variable to store the title of the book

    public WritingAssignment(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    } // Constructor to get the book title, student name, and topic. The student name and the topic will be set in the base (Assignment) constructor

    public string GetWritingInformation()
    {
        return $"{_title} by ";
    } // Method to return the book title well formatted

}