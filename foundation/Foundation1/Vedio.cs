using System;
using System.Collections.Generic;

// Represents a Video, stores comments, and provides methods for managing them
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public int Length
    {
        get => _length;
        set => _length = value;
    }

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Adds comments to a video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Gets the number of comments
    public int CommentsTotalCount()
    {
        return _comments.Count;
    }

    // Displays Video with comments
    public void DisplayVideoComments()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Total Comments: {CommentsTotalCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($" - {comment}");
        }
    }
}
