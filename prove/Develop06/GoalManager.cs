using System;
using System.Collections.Generic;
using System.IO;

public class GeneralManager
{
    private string playerName;
    private int totalPoints;
    private List<Goal> goals;
    private const string saveFile = "gameSave.txt";

    public GeneralManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    public int TotalPoints
    {
        get { return totalPoints; }
    }

    // Load game logic
    public void LoadGame()
    {
        if (File.Exists(saveFile))
        {
            var lines = File.ReadAllLines(saveFile);
            playerName = lines[0]; // First line is player name
            totalPoints = int.Parse(lines[1]); // Second line is total points

            Console.WriteLine($"{playerName}, you have {totalPoints} points.");

            // Load goals from the save file
            goals.Clear();
            for (int i = 2; i < lines.Length; i++)
            {
                string[] goalData = lines[i].Split(',');
                Goal goal = GoalFactory(goalData);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
            Console.WriteLine("Game loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved game found, starting fresh.");
        }
    }

    // Save game logic
    public void SaveGame()
    {
        using (StreamWriter writer = new StreamWriter(saveFile))
        {
            writer.WriteLine(playerName);
            writer.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToSaveFormat());
            }
        }
        Console.WriteLine("Game saved successfully!");
    }

    // Add goal
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        totalPoints += goal.Points;  // Add the points of the new goal to total points
    }

    // List goals
    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStringRepresentation()}");
        }
    }

    // Show player info
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"{playerName}, you have {totalPoints} points.");
    }

    // Record event logic (updates total points as needed)
    public void RecordEvent(int goalIndex)
    {
        Goal goal = goals[goalIndex];
        goal.RecordEvent();
        totalPoints += goal.Points;  // Update the total points when an event is recorded
    }

    // Factory method to create goal objects from the save data
    private Goal GoalFactory(string[] goalData)
    {
        string goalType = goalData[0];
        string name = goalData[1];
        string description = goalData[2];
        int points = int.Parse(goalData[3]);

        if (goalType == "SimpleGoal")
        {
            return new SimpleGoal(name, description, points);
        }
        else if (goalType == "ChecklistGoal")
        {
            int targetCount = int.Parse(goalData[4]);
            int bonusPoints = int.Parse(goalData[5]);
            int currentCount = int.Parse(goalData[6]);
            var goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints)
            {
                CurrentCount = currentCount
            };
            return goal;
        }
        else if (goalType == "EternalGoal")
        {
            return new EternalGoal(name, description, points);
        }

        return null;
    }
}
