using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal() { }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
    {
        Name = name;
        Description = description;
        Points = points;
        TargetCount = targetCount;
        CompletedCount = 0;
        Bonus = bonus;
    }

    public override void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        Name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        Description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        Points = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        TargetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        Bonus = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        CompletedCount++;
        int pointsEarned = Points;
        Console.WriteLine($"Goal '{Name}' completed {CompletedCount}/{TargetCount}! You earned {pointsEarned} points.");

        if (CompletedCount == TargetCount)
        {
            pointsEarned += Bonus;
            Console.WriteLine($"Bonus of {Bonus} points awarded for completing the checklist goal!");
        }

        return pointsEarned;
    }

    public override string GetGoalInfo()
    {
        return $"[ ] {Name}: {Description} - Points: {Points}, Bonus: {Bonus} - Completed {CompletedCount}/{TargetCount} times";
    }

    public override string GetGoalSaveInfo()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{Bonus}";
    }
}
