public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public int _numberOfComments;
    public List<Comment> _listOfComments = new List<Comment>();

    public void DisplayVideoInfo()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{_title}");
        Console.WriteLine($"by {_author}");
        Console.WriteLine($"Duration: {_lengthInSeconds} seconds\n");

        Console.WriteLine($"{_numberOfComments} comments:\n");
        for (int i = 0; i < _listOfComments.Count; i++)
        {
            if (i + 1 < _listOfComments.Count)
            {
                _listOfComments[i].DisplayComment();
                Console.WriteLine("");
            }
            else if (i + 1 == _listOfComments.Count)
            {
                _listOfComments[i].DisplayComment();
            }
        }
        Console.WriteLine("-----------------------------------------");
    }
}