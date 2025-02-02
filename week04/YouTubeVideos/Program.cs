using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("CSE 210", "Goodluck Sobere", 600);
        Video video2 = new Video("Abstraction", "Ephraim Ewane", 900);
        Video video3 = new Video("Encapsulation", "Eli Morrison", 1200);

        video1.AddComment(new Comment("User1", "Great explanation!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "I finally understand C#!"));

        video2.AddComment(new Comment("DevGuy", "Clear and concise."));
        video2.AddComment(new Comment("Coder123", "OOP is so powerful!"));

        video3.AddComment(new Comment("Techie", "Love this tutorial."));
        video3.AddComment(new Comment("Learner", "This helped me so much!"));
        video3.AddComment(new Comment("Student", "Awesome content!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Commenter}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40)); 
        }
    }
}
