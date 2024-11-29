using System;
using System.Collections.Generic;

// Represents a Video, stores comments, and provides methods for managing them
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Adds comments to a video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Gets the number of comments
    public int CommentsTotalCount()
    {
        return Comments.Count;
    }

    // Displays Video with comments
    public void DisplayVideoComments()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Total Comments: {CommentsTotalCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment}");
        }
    }
}
