using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "Origin Stories";
        v1._author = "MJ Films";
        v1._seconds = 450;
        
        Comment c1 = new Comment();
        c1._name = "Mr.Name";
        c1._text = "Here is a comment.";
        Comment c2 = new Comment();
        c2._name = "iCommented";
        c2._text = "I like your video";
        Comment c3 = new Comment();
        c3._name = "Someone";
        c3._text = "Thanks for the video.";

        v1._comments.Add(c1);
        v1._comments.Add(c2);
        v1._comments.Add(c3);

        Video v2 = new Video();
        v2._title = "Marvel Universe";
        v2._author = "Stan Lee";
        v2._seconds = 600;
        
        Comment c4 = new Comment();
        c4._name = "Ant Man";
        c4._text = "This comment is small.";
        Comment c5 = new Comment();
        c5._name = "Spider Man";
        c5._text = "With great power comes great responsibility";
        Comment c6 = new Comment();
        c6._name = "Number1Fan";
        c6._text = "Cool video.";

        v2._comments.Add(c4);
        v2._comments.Add(c5);
        v2._comments.Add(c6);
        
        
        Video v3 = new Video();
        v3._title = "Volcanoe Erupts";
        v3._author = "Weather Man";
        v3._seconds = 999;
        
        Comment c7 = new Comment();
        c7._name = "WouldURather";
        c7._text = "Scary Volcanoe.";
        Comment c8 = new Comment();
        c8._name = "Banana";
        c8._text = "I saw this before.";
        Comment c9 = new Comment();
        c9._name = "Mrs. Name";
        c9._text = "Good job.";

        v3._comments.Add(c7);
        v3._comments.Add(c8);
        v3._comments.Add(c9);


        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);


        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }

    }
}