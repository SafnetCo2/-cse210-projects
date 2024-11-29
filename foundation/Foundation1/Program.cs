using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create comments
        Comment viewerComment1 = new Comment("Joseph", "Gave me confidence to know what's genuine and not.");
        Comment viewerComment2 = new Comment("Dachy", "Best company which sells parts.");
        Comment viewerComment3 = new Comment("Molly", "Informative.");
        Comment viewerComment4 = new Comment("Joyce", "Liked it.");
        Comment viewerComment5 = new Comment("Ebuka", "Nice video.");

        // Create videos
        Video video1 = new Video("How to Replace Car Brake Pads", "Joty n John", 240);
        Video video2 = new Video("Installing a New Car Battery", "Mike", 180);
        Video video3 = new Video("Replacing Car Tires for Beginners", "May", 220);

        // Add comments to the videos
        video1.AddComment(viewerComment1);
        video1.AddComment(viewerComment2);
        video1.AddComment(viewerComment3);

        video2.AddComment(viewerComment4);

        video3.AddComment(viewerComment5);

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Use foreach to loop through the list of videos and display comments
        foreach (var video in videos)
        {
            video.DisplayVideoComments();
            Console.WriteLine();
        }
    }
}
