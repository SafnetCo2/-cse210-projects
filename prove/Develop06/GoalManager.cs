public class GoalManager
{
    public List<Goal> Goals { get; private set; }
    public int TotalPoints { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
        UpdateTotalPoints();  // Recalculate points after adding a new goal
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goals[goalIndex].RecordEvent();
            UpdateTotalPoints();         }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGame(string userName)
    {
        const string fileName = "game_save.txt";
        List<string> fileLines = new List<string>();

        if (File.Exists(fileName))
        {
            fileLines.AddRange(File.ReadAllLines(fileName));
        }

        // Remove existing data for the current user
        int startIndex = fileLines.IndexOf($"{userName}|");
        if (startIndex != -1)
        {
            int endIndex = fileLines.IndexOf("END", startIndex);
            fileLines.RemoveRange(startIndex, endIndex - startIndex + 1);
        }

        // Add updated data for the current user
        fileLines.Add($"{userName}|{TotalPoints}");
        foreach (var goal in Goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                fileLines.Add($"{goal.GetType().Name}|{goal.Name}|{goal.Description}|{goal.Points}|{checklistGoal.TargetCount}|{checklistGoal.CompletedCount}|{checklistGoal.BonusPoints}");
            }
            else
            {
                fileLines.Add($"{goal.GetType().Name}|{goal.Name}|{goal.Description}|{goal.Points}");
            }
        }
        fileLines.Add("END");

        // Write all data back to the file
        File.WriteAllLines(fileName, fileLines);
    }

    public void LoadGame(string userName)
    {
        const string fileName = "game_save.txt";

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            int startIndex = Array.IndexOf(lines, $"{userName}|");
            if (startIndex != -1)
            {
                Goals.Clear();
                TotalPoints = int.Parse(lines[startIndex].Split('|')[1]);

                for (int i = startIndex + 1; i < lines.Length; i++)
                {
                    if (lines[i] == "END") break;

                    var parts = lines[i].Split('|');
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (goalType == "SimpleGoal")
                    {
                        Goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int targetCount = int.Parse(parts[4]);
                        int completedCount = int.Parse(parts[5]);
                        int bonusPoints = int.Parse(parts[6]);

                        var checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints)
                        {
                            CompletedCount = completedCount
                        };
                        Goals.Add(checklistGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        Goals.Add(new EternalGoal(name, description, points));
                    }
                }

                Console.WriteLine($"Game loaded successfully. You have {TotalPoints} points.");
            }
            else
            {
                TotalPoints = 0;
                Console.WriteLine("No saved game found, starting fresh.");
            }
        }
        else
        {
            TotalPoints = 0;
            Console.WriteLine("No saved game found, starting fresh.");
        }
    }

    public void ListGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            var goal = Goals[i];
            // Display goal with completion status and points
            Console.WriteLine($"{i + 1}. [{(goal.IsCompleted ? "X" : " ")}] {goal.Name}: {goal.Description} - Points: {goal.Points}");

            // If it's a ChecklistGoal, display additional completion details
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"    Completed {checklistGoal.CompletedCount}/{checklistGoal.TargetCount} times.");
            }
        }
    }

    private void UpdateTotalPoints()
    {
        TotalPoints = 0;
        foreach (var goal in Goals)
        {
            if (goal.IsCompleted) // Adds points only for completed goals
            {
                TotalPoints += goal.Points;
            }
        }
    }
}
