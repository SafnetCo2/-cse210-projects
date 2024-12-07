public class BreathingActivity : Activity
{
        public BreathingActivity(string activityName, string description, int duration)
            : base(activityName, description)
        {
                SetDuration(duration); // Set the duration
        }

        public override void DoActivity()
        {
                // Display the welcome message with color
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;  // Set color to Cyan for the welcome message
                Console.WriteLine("Welcome to the Breathing Activity!");
                Console.ResetColor();
                Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine();

                // Ask the user for the duration of the activity
                Console.Write("Enter the duration for the activity in seconds: ");
                _duration = int.Parse(Console.ReadLine()); // Set the duration

                DisplayStartingMessage();

                // Show countdown before starting the activity
                ShowCountDown(5);

                // Log the activity start
                LogToFile("Starting Breathing Activity");

                // Show "Get Ready!" message with spinner animation
                Console.WriteLine("Get ready!");
                ShowSpinner(); // Show spinner for 3 seconds before starting

                // Perform the breathing activity
                while (_duration > 0)
                {
                        Console.WriteLine("Breathe in...");
                        System.Threading.Thread.Sleep(2000);  // Pause for 2 seconds

                        // Countdown before next action
                        Countdown(3);

                        Console.WriteLine("Hold...");
                        System.Threading.Thread.Sleep(2000);  // Pause for 2 seconds

                        // Countdown before next action
                        Countdown(3);

                        Console.WriteLine("Breathe out...");
                        System.Threading.Thread.Sleep(2000);  // Pause for 2 seconds

                        // Countdown before next action
                        Countdown(3);

                        // Decrease the duration by 6 seconds per cycle
                        _duration -= 6;
                }

                // Ending message and log
                DisplayEndingMessage();
                LogToFile("Ending Breathing Activity");

                // Thank the user for participating
                Console.WriteLine("Thank you for participating!");
                LogToFile("Thank you for participating");
        }

        // Countdown method
        private void Countdown(int seconds)
        {
                for (int i = seconds; i > 0; i--)
                {
                        Console.Write(i + " ");
                        System.Threading.Thread.Sleep(1000); // 1-second delay
                }
                Console.WriteLine();
        }

        // Method to show the spinner animation
        private void ShowSpinner()
        {
                string[] spinner = new string[] { "/", "-", "\\", "|" };
                for (int i = 0; i < 12; i++) // 3 seconds
                {
                        foreach (string spin in spinner)
                        {
                                Console.Write(spin);
                                System.Threading.Thread.Sleep(250); // Pause for 250 ms
                                Console.Write("\b"); // Move the cursor back
                        }
                }
                Console.WriteLine(); // Move to the next line after the spinner
        }

        // Method to save logs to a file
        private void LogToFile(string message)
        {
                string logFilePath = "breathing_activity_log.txt";
                try
                {
                        using (StreamWriter writer = new StreamWriter(logFilePath, true))
                        {
                                writer.WriteLine($"{DateTime.Now}: {message}");
                        }
                }
                catch (Exception ex)
                {
                        Console.WriteLine($"Error logging to file: {ex.Message}");
                }
        }

        // Method to load previous logs and display them
        private void LoadLogs()
        {
                string logFilePath = "breathing_activity_log.txt";
                if (File.Exists(logFilePath))
                {
                        Console.WriteLine("\nPrevious Breathing Activity Logs:\n");

                        try
                        {
                                string[] logs = File.ReadAllLines(logFilePath);
                                foreach (var log in logs)
                                {
                                        Console.WriteLine(log);
                                }
                        }
                        catch (Exception ex)
                        {
                                Console.WriteLine($"Error loading logs: {ex.Message}");
                        }

                        Console.WriteLine();
                }
                else
                {
                        Console.WriteLine("No previous logs found.\n");
                }
        }
}
