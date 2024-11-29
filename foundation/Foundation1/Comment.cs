// Represents a Comment and provides a method to return a formatted string of the comment
public class Comment
{
    private string _viewersCommentName;
    private string _viewersCommentText;

    public string ViewersCommentName
    {
        get => _viewersCommentName;
        set => _viewersCommentName = value;
    }

    public string ViewersCommentText
    {
        get => _viewersCommentText;
        set => _viewersCommentText = value;
    }

    // Constructor
    public Comment(string viewersCommentName, string viewersCommentText)
    {
        _viewersCommentName = viewersCommentName;
        _viewersCommentText = viewersCommentText;
    }

    // Method to display the viewer's comment in a formatted way
    public override string ToString()
    {
        return $"{_viewersCommentName}: {_viewersCommentText}";
    }
}
