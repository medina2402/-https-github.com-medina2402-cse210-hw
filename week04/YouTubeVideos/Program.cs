using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C#", "Programming101", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Carlos", "Thanks!"));

        Video video2 = new Video("Cooking Pasta", "Chef Anna", 420);
        video2.AddComment(new Comment("David", "Looks delicious."));
        video2.AddComment(new Comment("Emma", "I will try it."));
        video2.AddComment(new Comment("Lucas", "Easy recipe."));

        Video video3 = new Video("Football Skills", "Sports TV", 900);
        video3.AddComment(new Comment("John", "Amazing!"));
        video3.AddComment(new Comment("Maria", "Nice tricks."));
        video3.AddComment(new Comment("Kevin", "Loved it."));

        Video video4 = new Video("Travel Brazil", "Travel Life", 720);
        video4.AddComment(new Comment("Sophia", "Beautiful places."));
        video4.AddComment(new Comment("Daniel", "I want to visit."));
        video4.AddComment(new Comment("Olivia", "Excellent video."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}