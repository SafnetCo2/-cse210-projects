//comment.cs
//represents ca comments and provides a method to return formatted string of the comment

public class Comment
{
public  string ViewersCommentName { get; set; }
public string ViewersCommentText{ get; set; }
//Constructor
public Comment(string viewersCommentName,string viewersCommentText)
{
        ViewersCommentName = viewersCommentName;
        ViewersCommentText = viewersCommentText;
}
    //method to display viewers comment
    public override string ToString()
    {
        return $"{ViewersCommentName}:{ViewersCommentText}";
    }

}
