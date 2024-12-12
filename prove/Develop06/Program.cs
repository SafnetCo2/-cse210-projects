public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        GoalManager goalManager = new GoalManager();
        goalManager.LoadGame(userName);

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine($"\nWelcome back, {userName}!");
            Console.WriteLine($"You have {goalManager.TotalPoints} points.");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Save Game");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Checklist Goal");
                    Console.WriteLine("3. Eternal Goal");

                    string goalTypeInput = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    Goal goal = null;

                    switch (goalTypeInput)
                    {
                        case "1":
                            goal = new SimpleGoal(goalName, goalDescription, goalPoints);
                            break;
                        case "2":
                            goal = new ChecklistGoal(goalName, goalDescription, goalPoints, 3, 50);
                            break;
                        case "3":
                            goal = new EternalGoal(goalName, goalDescription, goalPoints);
                            break;
                    }

                    if (goal != null)
                    {
                        goalManager.AddGoal(goal);
                        Console.WriteLine($"Goal '{goalName}' added successfully.");
                    }
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    Console.WriteLine("Enter goal number to record event: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    goalManager.RecordEvent(goalIndex);
                    break;
                case "4":
                    goalManager.SaveGame(userName);
                    Console.WriteLine("Game saved.");
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
