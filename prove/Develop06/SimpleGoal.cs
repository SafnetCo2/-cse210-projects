using System;

public class SimpleGoal : Goal
{
    public SimpleGoal() { }

    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        Name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        Description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        Points = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        return Points;
    }

    public override string GetGoalInfo()
    {
        return $"[ ] {Name}: {Description} - Points: {Points}";
    }

    public override string GetGoalSaveInfo()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}";
    }
}
