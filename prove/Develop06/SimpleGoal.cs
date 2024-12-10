public class SimpleGoal:Goal
{
    private bool _completed;
    public SimpleGoal(string name ,string description,int points):base(name,description)
    {
        _completed = false;
        AddPoints(points)
    }
    public override void RecordEvent()
    {
        if(! _completed)
        {
            _completed = false;
            AddPoints(Points);
        }
    }
    public override void DisplayProgress()
    {
        string completionStatus = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{Name}:{completionStatus}(Points:{Points})");
        
    }
    public override void MarkComplete()
    {
        _completed = true;
    }
}