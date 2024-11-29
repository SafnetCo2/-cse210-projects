// Represents a Comment and provides a method to return a formatted string of the comment
public class Comment
{
    public string ViewersCommentName { get; set; }
    public string ViewersCommentText { get; set; }

    // Constructor
    public Comment(string viewersCommentName, string viewersCommentText)
    {
        ViewersCommentName = viewersCommentName;
        ViewersCommentText = viewersCommentText;
    }

    // Method to display the viewer's comment in a formatted way
    public override string ToString()
    {
        return $"{ViewersCommentName}: {ViewersCommentText}";
    }
}
