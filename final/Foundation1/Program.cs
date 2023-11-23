using System;

class Program
{
    static void Main(string[] args)
    {
        // video 1...
        Video video1 = new Video();
        video1._title = "Lewis Capaldi - Before You Go (Official Video)";
        video1._author = "Lewis Capaldi";
        video1._lengthInSeconds = 247;
        video1.DisplayVideoInfo();

        Comment comment1 = new Comment();
        comment1._personName = "jackie";
        comment1._comment = "I love so much this song!";
        comment1.DisplayComment();
        
    }
}