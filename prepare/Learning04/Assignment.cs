public class Assignment
{

    private string _studentName; // Variable to store the student name
    private string _topic; // Variable to store the topic

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    } // Constructor to get the student name and topic

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    } // Method to return the student name and topic well formatted

    public string GetStudentName()
    {
        return _studentName;
    } // Method to return the student name. It will be called by WritingAssignment class

}