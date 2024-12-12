public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        // In this example, we assume the goal is completed immediately after being recorded
        // For a real-world app, logic would be added to handle specific events (e.g., time-based)
        Console.WriteLine($"Goal '{Name}' completed! Earned {Points} points.");
    }

    public override string ToSaveFormat()
    {
        return $"SimpleGoal,{Name},{Description},{Points}";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {Description} - Points: {Points}";
    }
}
