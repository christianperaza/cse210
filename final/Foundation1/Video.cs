public class Video
{
    // attributes...
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _listOfComments = new List<Comment>(); // Each video has responsibility to store a list of comments

    // methods...

    // return the numbers of comments
    public int ReturnNumberOfComments()
    {
        return _listOfComments.Count;
    }

    // display Video information
    public void DisplayVideoInfo()
    {
        Console.WriteLine("-----------------------------------------"); // design
        Console.WriteLine($"{_title}");
        Console.WriteLine($"by {_author}");
        Console.WriteLine($"Duration: {_lengthInSeconds} seconds\n");

        Console.WriteLine($"{ReturnNumberOfComments()} comments:\n"); // get the return from CalculateNumberOfComments method

        for (int i = 0; i < _listOfComments.Count; i++)
        {
            // these if conditions are just to avoid that last comment display a new white space after it
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

        Console.WriteLine("-----------------------------------------"); // design
    }
}