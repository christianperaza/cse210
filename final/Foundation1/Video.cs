public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    //public int _numberOfComments;
    //public List<Comment> _listOfComments = new List<Comment>();

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"by {_author}");
        Console.WriteLine($"Duration: {_lengthInSeconds} seconds");
    }
}