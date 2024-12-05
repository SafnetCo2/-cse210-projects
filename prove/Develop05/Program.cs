using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************************************");
            Console.WriteLine("*           Welcome to the                 *");
            Console.WriteLine("*         Mindfulness Program              *");
            Console.WriteLine("********************************************");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.ResetColor();
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BeginActivity(new BreathingActivity("Breathing", "Focus on your breath"));
                    break;
                case "2":
                    BeginActivity(new ReflectionActivity());
                    break;

                case "3":
                    BeginActivity(new ListingActivity("Listing", "List your thoughts"));
                    break;
                case "4":
                    running = false;
                    DisplayGoodbyeMessage();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }

            if (running)
            {
                Console.Write("Would you like to perform another activity? (yes/no): ");
                string response = Console.ReadLine()?.ToLower();
                if (response == "no")
                {
                    running = false;
                    DisplayGoodbyeMessage();
                }
            }
        }
    }

    static void BeginActivity(Activity activity)
    {
        activity.SetDuration(GetDuration());
        activity.DisplayStartingMessage();
        activity.DoActivity();
        activity.DisplayEndingMessage();
    }

    static int GetDuration()
    {
        Console.Write("Enter activity duration in seconds: ");
        return int.TryParse(Console.ReadLine(), out int duration) && duration > 0 ? duration : 0;
    }

    static void DisplayGoodbyeMessage()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("****************************************************");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("*               THANK YOU FOR USING                *");
        Console.WriteLine("*             THE MINDFULNESS PROGRAM!             *");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("****************************************************");
        Console.WriteLine();
        Console.WriteLine("We hope this program helped you find peace and clarity.");
        Console.WriteLine("Remember to take time for yourself every day. Goodbye!");
        Console.ResetColor();
    }
}
