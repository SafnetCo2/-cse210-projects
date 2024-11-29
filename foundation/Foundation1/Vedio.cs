using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

//represents a Vedio,stores comments,and provides methods for managing them
public class vedio
{
public string Title{ get; set; }
public string Author{ get; set; }
public int Length{ get; set; }
private List<Comment>Comments{ get; set; }
//constructor
public vedio(string title,string author,int length){
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
}
// adds comments in a vedio
public void AddComment(Comment comment)
{
        Comments.Add(comment);

}
//gets number  of comments
public int CommentsTotalCount()
{
        return Comments.Count;
}
//display Vedio with comments
public void DisplayVedioComments()
{
        Console.WriteLine($"Title:{Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"Length:{Length} seconds");
        Console.WriteLine($"total Comments:{CommentsTotalCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" -{comment}");
        }


    }
}