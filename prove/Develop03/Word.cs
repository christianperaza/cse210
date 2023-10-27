class Word
{

    private List<string> _wordText;

    public Word(List<string> text)
    {
        _wordText = text;
    }

    public void ScriptureComplete()
    {
        foreach (var item in _wordText)
        {
            Console.Write($"{item} ");
        }
       Console.WriteLine("");
    }

    public void HideRandomsWords(string refer)
    {
		
        List<int> listNumbers = new List<int>();
        string userInput;

		do {
            Console.WriteLine("");
            Console.WriteLine("Press 'Enter' to keep. Type 'quit' if you want to end.");
            Console.Write("> ");
            userInput = Console.ReadLine();

            if(userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();

		        Random rnd = new Random();
		        int randomNumber;

                for (int i = 0; i < 1; i++)
                {
                    do 
                    {
                        randomNumber = rnd.Next(0, _wordText.Count);

                        _wordText.RemoveAt(randomNumber);
		                _wordText.Insert(randomNumber, "____");

                    } while (listNumbers.Contains(randomNumber));
                    listNumbers.Add(randomNumber);
                }

                int nNumbers = listNumbers.Count;
                int nWords = _wordText.Count;

                if (nNumbers == nWords)
                {
                    break;
                }
            
            
                Console.Write($"{refer} - ");
                foreach (string text in _wordText)
		        {
                
		            Console.Write($"{text} ");
                
		        }
                Console.WriteLine("");
                }
		    
		} while(userInput.ToLower() != "quit");
        
    }

    public void CompletelyHidden(string refer)
    {
        Console.Clear();
        Console.Write($"{refer} - ");
        foreach (string text in _wordText)
		{
		    Console.Write($"{text} ");
		}

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("End.");
    }

}