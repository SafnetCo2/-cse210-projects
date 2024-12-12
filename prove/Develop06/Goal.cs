using System;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public abstract void CreateGoal();
    public abstract int RecordEvent();
    public abstract string GetGoalInfo();
    public abstract string GetGoalSaveInfo();

    public static Goal LoadGoalFromString(string goalData)
    {
        // Parse and create goal object based on saved data
        string[] parts = goalData.Split('|');
        if (parts[0] == "SimpleGoal")
        {
            return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (parts[0] == "EternalGoal")
        {
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (parts[0] == "ChecklistGoal")
        {
            return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        }
        return null;
    }
}
