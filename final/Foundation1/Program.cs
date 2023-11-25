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
        


        // --------- video 3 --------- //

        // create and instance of a new Video object...
        Video video3 = new();
        video3._title = "How to use Lists in C# - Tutorial";
        video3._author = "FunPrograming";
        video3._lengthInSeconds = 480;

        // comments of video 3...
        Comment comment1Video3 = new Comment(); // 3.1
        comment1Video3._personName = "hector_zambrano";
        comment1Video3._comment = "Bro, you saved my semester. I was struggling with that. Thaaaanks!";
        Comment comment2Video3 = new Comment(); // 3.2
        comment2Video3._personName = "liza52";
        comment2Video3._comment = "boring. you talk so slow...";
        Comment comment3Video3 = new Comment(); // 3.3
        comment3Video3._personName = "ChrisK6";
        comment3Video3._comment = "Men, can you submit a tutorial about abstraction, please. I like how you teach.";
        Comment comment4Video3 = new Comment(); // 3.4
        comment4Video3._personName = "callmeCarl";
        comment4Video3._comment = "10/10.";

        // now, we add comments to list of comments in video3...
        video3._listOfComments.Add(comment1Video3);    
        video3._listOfComments.Add(comment2Video3);
        video3._listOfComments.Add(comment3Video3);
        video3._listOfComments.Add(comment4Video3);



        // put each of the videos in a list...
        List<Video> videos = new()
        {
            video1,
            video2,
            video3
        };

        // iterate through the list of videos and display info of each one...
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}