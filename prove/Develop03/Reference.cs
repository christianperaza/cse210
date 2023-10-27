public class Reference
{

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }


    public string OneVerse()
    {
        return $"{_book} {Convert.ToString(_chapter)}:{Convert.ToString(_startVerse)}";
    }

    public string ManyVerses()
    {
        return $"{_book} {Convert.ToString(_chapter)}:{Convert.ToString(_startVerse)}-{Convert.ToString(_endVerse)}";
    }



}