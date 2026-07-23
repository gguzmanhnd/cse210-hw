using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        //Video N#1//
        Video video1 = new Video("C# Basic in 10 minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great summary, super easy to follow"));
        video1.AddComment(new Comment("Bob", "This saved my homework deadline. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you do a deeper dive into object-oriented concepts next?"));
        videos.Add(video1);

        //Video N#2//

        Video video2 = new Video("Top 10# Abstraction Examples", "DevTips", 400);
        video2.AddComment(new Comment("David", "The coffee machine analogy made so much sense!"));
        video2.AddComment(new Comment("Eva", "Nice clear explanation."));
        video2.AddComment(new Comment("Frank", "Loved the graphics in this video."));
        videos.Add(video2);


       // --- Video 3 ---
        Video video3 = new Video("Build a Console App in C#", "TechWithTim", 1200);
        video3.AddComment(new Comment("Grace", "Watching this in 2026 and it still works flawlessly!"));
        video3.AddComment(new Comment("Hannah", "The step-by-step pace was perfect for beginners."));
        video3.AddComment(new Comment("Ian", "Subscribed instantly. Keep 'em coming!"));
        videos.Add(video3);



        {
            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
            }
        }

        }}
