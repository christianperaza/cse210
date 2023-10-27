using System;

class Program
{
    static void Main(string[] args)
    {

        string book = "John";
        int chapter = 3;
        int startVerse = 16;
        int endVerse = 0;
        string verseText = "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference reference1 = new Reference(book, chapter, startVerse);
        string refer1 = reference1.OneVerse();

        Reference reference2 = new Reference(book, chapter, startVerse, endVerse);
        string refer2 = reference2.ManyVerses();

        Scripture scripture;

        if (endVerse == 0)
        {
            scripture = new Scripture(refer1, verseText);
        }
        else
        {
            scripture = new Scripture(refer2, verseText);
        }

        Console.Clear();

        scripture.DisplayReference();
        scripture.DisplayScriptureComplete();
        scripture.DisplatHideRandomsWords();
        scripture.DisplayCompletlyHidden();

    }
}