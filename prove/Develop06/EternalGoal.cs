using System.Security.Cryptography.X509Certificates;

public class EternalGoal:Goal{
    private int _pointsPerEvent;
    public EternalGoal(string name,string description,int pointsPerEvent):base(name,description)
    {
        _pointsPerEvent = pointsPerEvent;

    }
    public override void RecordEvent()
    {
        AddPoints(_pointsPerEvent);
        _progress++;
    }
    public override void DisplayProgress()
    {
        Console.WriteLine($"{Name}:[EternalGoal](Progress:{Progress}events, Points:{Points})");
    }

            public override void MarkComplete()
        {}
}
