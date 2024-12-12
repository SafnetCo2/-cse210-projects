public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {Description} - Points: {Points}";
    }
}
