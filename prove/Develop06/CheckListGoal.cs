public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0; // Starts with 0 completions
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Console.WriteLine($"Goal '{Name}' progress: {CurrentCount}/{TargetCount} completed.");
            if (CurrentCount == TargetCount)
            {
                Console.WriteLine($"Goal '{Name}' completed! Earned {Points + BonusPoints} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override string ToSaveFormat()
    {
        return $"ChecklistGoal,{Name},{Description},{Points},{TargetCount},{BonusPoints},{CurrentCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {Description} - Points: {Points} - Bonus: {BonusPoints} - Completed {CurrentCount}/{TargetCount} times";
    }
}
