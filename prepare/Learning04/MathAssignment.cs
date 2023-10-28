public class MathAssignment : Assignment // With the colon let us to inheritance of Assignment class
{

    private string _textbookSection; // Variable to store the text section
    private string _problems; // Variable to store the math problems

    public MathAssignment(string textbookSection, string problems, string name, string topic) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    } // Constructor to get the text section, math problems, student name, and topic. The student name and the topic will be set in the base (Assignment) constructor

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    } // Method to return the text section and problems well formatted

}