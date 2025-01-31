using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
               Video video1 = new Video("Learn C# in 10 Minutes", "John Doe", 600);
        video1.SetAddComment(new Comment("Alice", "Great tutorial!"));
        video1.SetAddComment(new Comment("Bob", "Very helpful."));

        Video video2 = new Video("Mastering Object-Oriented Programming", "Jane Smith", 1200);
        video2.SetAddComment(new Comment("Charlie", "I love this course!"));
        video2.SetAddComment(new Comment("Diana", "Clear explanations."));

        Video video3 = new Video("Introduction to Data Structures", "Mark Lee", 800);
        video3.SetAddComment(new Comment("Eve", "This is a must-watch!"));
        video3.SetAddComment(new Comment("Frank", "Very informative."));
        video3.SetAddComment(new Comment("Grace", "The examples were great."));


        List<Video> videos = new List<Video> { video1, video2, video3 };

    
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }

    }
}
