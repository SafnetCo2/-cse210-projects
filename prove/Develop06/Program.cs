using System;

public class Program
{
    public static void Main()
    {
        GeneralManager manager = new GeneralManager();

        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        manager.SetPlayerName(playerName);
        manager.LoadGame();  // Loads the previous game state

        bool isRunning = true;

        // Display points if user has played before
        Console.WriteLine($"{playerName}, you have {manager.TotalPoints} points.");

        while (isRunning)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Player Info");
            Console.WriteLine("5. Save Game");
            Console.WriteLine("6. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add goal logic
                    Console.WriteLine("Select Goal Type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Checklist Goal");
                    Console.WriteLine("3. Eternal Goal");
                    string goalType = Console.ReadLine();
                    Goal newGoal = null;

                    if (goalType == "1")
                    {
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter goal points: ");
                        int points = int.Parse(Console.ReadLine());

                        newGoal = new SimpleGoal(name, description, points);
                    }
                    else if (goalType == "2")
                    {
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter goal points: ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter goal points: ");
                        int points = int.Parse(Console.ReadLine());

                        newGoal = new EternalGoal(name, description, points);
                    }

                    if (newGoal != null)
                    {
                        manager.AddGoal(newGoal);
                    }

                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    Console.Write("Enter goal number to record: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(goalIndex);
                    break;

                case "4":
                    manager.DisplayPlayerInfo();
                    break;

                case "5":
                    manager.SaveGame();
                    break;

                case "6":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("Game Over. Thank you for playing!");
    }
}
