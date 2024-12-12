public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CompletedCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (CompletedCount < TargetCount)
        {
            CompletedCount++;
            if (CompletedCount == TargetCount)
            {
                IsCompleted = true;
                Points += BonusPoints;
            }
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {Description} - Points: {Points} - Completed {CompletedCount}/{TargetCount} times";
    }
}
