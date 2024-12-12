public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! Earned {Points} points.");
    }

    public override string ToSaveFormat()
    {
        return $"EternalGoal,{Name},{Description},{Points}";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {Description} - Points: {Points}";
    }
}
