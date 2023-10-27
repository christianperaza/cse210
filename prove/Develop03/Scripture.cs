class Scripture
{

    private string _reference;
    private List<string> _words;
    private Word word;

    public Scripture(string reference, string verseText)
    {
        _reference = reference;
        
        _words = new List<string>();
        string[] verseTextSplited = verseText.Split(" ");
        foreach (string text in verseTextSplited)
        {
            _words.Add(text);
        }

        word = new Word(_words);
    }

    public void DisplayReference()
    {
        Console.Write($"{_reference} - ");
    }

    public void DisplayScriptureComplete()
    {
        word.ScriptureComplete();
    }

    public void DisplatHideRandomsWords()
    {
        word.HideRandomsWords(_reference);
    }

    public void DisplayCompletlyHidden()
    {
        word.CompletelyHidden(_reference);
    }


    






    
    

    


}