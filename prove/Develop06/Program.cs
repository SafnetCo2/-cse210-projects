using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GeneralManager manager = new GeneralManager();
        string filePath = "GameData.txt";

        // Welcome message
        Console.WriteLine("Welcome to the Eternal Quest Program!");

        // Load game if the file exists, otherwise start a new game
        if (File.Exists(filePath))
        {
            manager.LoadGame(filePath);
            Console.WriteLine("Game loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved game found. Starting fresh!");
        }

        // Ask for player's name
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        manager.SetPlayerName(playerName);

        // Display player's current points
        Console.WriteLine($"Hello {playerName}, you have {manager.GetTotalPoints()} points.");

        bool exit = false;
        while (!exit)
        {
            // Main menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Player Info");
            Console.WriteLine("5. Save Game");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.AddGoal();
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.ShowPlayerInfo();
                    break;
                case "5":
                    manager.SaveGame(filePath);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}
