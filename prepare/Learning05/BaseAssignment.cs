public class Assignment
{
    protected string _studentName;
    protected string _topic;

    // Constructor to initialize student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}