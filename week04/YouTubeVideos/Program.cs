using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Agnes", 600);

        video1.AddComment(new Comment("Mary", "This was very helpful!"));
        video1.AddComment(new Comment("John", "I learned a lot."));
        video1.AddComment(new Comment("Peter", "Great explanation!"));

        Video video2 = new Video("Introduction to Python", "David", 480);

        video2.AddComment(new Comment("Ann", "Very interesting."));
        video2.AddComment(new Comment("Brian", "Thanks for sharing."));
        video2.AddComment(new Comment("Jane", "I enjoyed this video."));

        Video video3 = new Video("Object Oriented Programming", "Sarah", 720);

        video3.AddComment(new Comment("Mike", "Good lesson."));
        video3.AddComment(new Comment("Lucy", "The examples helped me."));
        video3.AddComment(new Comment("James", "Excellent explanation."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}