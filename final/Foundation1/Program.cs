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
        Comment comment1Video1 = new Comment(); // 1.1
        comment1Video1._personName = "jackie";
        comment1Video1._comment = "I love so much this song!";
        Comment comment2Video1 = new Comment(); // 1.2
        comment2Video1._personName = "PuffingTom";
        comment2Video1._comment = "I can remember my mom with this song. It's so beautiful.";
        Comment comment3Video1 = new Comment(); // 1.3
        comment3Video1._personName = "pablo-98";
        comment3Video1._comment = "Que delicia de cancion! Ya la he reproducido un par de veces y no me canso.";

        // now, we add comments to list of comments in video1...
        video1._listOfComments.Add(comment1Video1);    
        video1._listOfComments.Add(comment2Video1);
        video1._listOfComments.Add(comment3Video1);
        video1._numberOfComments = video1._listOfComments.Count; // set number of comments counting the comments in list

        // display video 1...
        video1.DisplayVideoInfo();


        // --------- video 2 --------- //

        // create and instance of a new Video object...
        Video video2 = new();
        video2._title = "I Tell You Spiderman 1 in 10 min";
        video2._author = "ITellYouNow";
        video2._lengthInSeconds = 600;

        // comments of video 2...
        Comment comment1Video2 = new Comment(); // 2.1
        comment1Video2._personName = "hollyholly96";
        comment1Video2._comment = "Hey men! I love your film summaries. I enjoy each video, hahahaha.";
        Comment comment2Video2 = new Comment(); // 2.2
        comment2Video2._personName = "Miriam2002";
        comment2Video2._comment = "Estava procurando esse video para entender o proximo filme. Obrigado irmao.";
        Comment comment3Video2 = new Comment(); // 2.3
        comment3Video2._personName = "peter";
        comment3Video2._comment = "bro, you need to dedicate yourself to something else. I don't like your videos";
        Comment comment4Video2 = new Comment(); // 2.4
        comment4Video2._personName = "iamtrixi-77";
        comment4Video2._comment = "You inspire me. Keep doing your videos, please!";

        // now, we add comments to list of comments in video2...
        video2._listOfComments.Add(comment1Video2);    
        video2._listOfComments.Add(comment2Video2);
        video2._listOfComments.Add(comment3Video2);
        video2._listOfComments.Add(comment4Video2);
        video2._numberOfComments = video2._listOfComments.Count; // set number of comments counting the comments in list

        // display video 2...
        video2.DisplayVideoInfo();


        


        


        
        
    }
}