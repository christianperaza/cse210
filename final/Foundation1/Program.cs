using System;

class Program
{
    static void Main(string[] args)
    {
        // --------- video 1 --------- //

        // create and instance of a new Video object...
        Video video1 = new();
        video1._title = "Lewis Capaldi - Before You Go (Official Video)";
        video1._author = "Lewis Capaldi";
        video1._lengthInSeconds = 247;

        // comments of video 1...
        Comment comment1 = new Comment(); // 1
        comment1._personName = "jackie";
        comment1._comment = "I love so much this song!";
        Comment comment2 = new Comment(); // 2
        comment2._personName = "PuffingTom";
        comment2._comment = "I can remember my mom with this song. It's so beautiful.";
        Comment comment3 = new Comment(); // 3
        comment3._personName = "pablo-19";
        comment3._comment = "¡Qué delicia de canción! Ya la he reproducido un par de veces y no me canso.";

        // now, we add comments to list of comments in video1...
        video1._listOfComments.Add(comment1);    
        video1._listOfComments.Add(comment2);
        video1._listOfComments.Add(comment3);
        video1._numberOfComments = video1._listOfComments.Count; // set number of comments counting the comments in list

        // display video 1...
        video1.DisplayVideoInfo();


        


        
        
    }
}