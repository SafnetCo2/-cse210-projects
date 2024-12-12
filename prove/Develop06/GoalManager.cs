using System;
using System.Collections.Generic;
using System.IO;

public class GeneralManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;
    private string playerName;

    // Set the player's name
    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    // Get the total points
    public int GetTotalPoints()
    {
        return totalPoints;
    }

    // Add a goal
    public void AddGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Goal goal = null;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal();
                break;
            case "2":
                goal = new EternalGoal();
                break;
            case "3":
                goal = new ChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        goal.CreateGoal();
        goals.Add(goal);
        Console.WriteLine("Goal added successfully!");
    }

    // List all goals
    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetGoalInfo());
        }
    }

    // Record an event for a goal
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetGoalInfo()}");
        }

        Console.Write("Enter goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            totalPoints += goals[goalNumber].RecordEvent();
            Console.WriteLine($"Event recorded! Total points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    // Show player information
    public void ShowPlayerInfo()
    {
        Console.WriteLine($"Player: {playerName}, Total Points: {totalPoints}");
    }

    // Save the game to a file
    public void SaveGame(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(playerName);
            writer.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetGoalSaveInfo());
            }
        }
        Console.WriteLine("Game saved successfully!");
    }

    // Load the game from a file
    public void LoadGame(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            playerName = reader.ReadLine();
            totalPoints = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = Goal.LoadGoalFromString(line);
                goals.Add(goal);
            }
        }
    }
}
