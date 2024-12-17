using System;
using System.Collections.Generic;
using System.IO;
using ExerciseTracking.Core;
using ExerciseTracking.Activities;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exercise Tracking App!\n");

            List<Activity> activities = new List<Activity>();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Choose activity type: 1: Running | 2: Cycling | 3: Swimming | 0: Exit");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    keepRunning = false;
                    break;
                }

                Console.Write("Enter the date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter duration in minutes: ");
                int minutes = int.Parse(Console.ReadLine());

                Activity activity = null;

                switch (choice)
                {
                    case "1": // Running
                        Console.Write("Enter distance (km): ");
                        double distance = double.Parse(Console.ReadLine());
                        activity = new Running(date, minutes, distance);
                        break;

                    case "2": // Cycling
                        Console.Write("Enter speed (kph): ");
                        double speed = double.Parse(Console.ReadLine());
                        activity = new Cycling(date, minutes, speed);
                        break;

                    case "3": // Swimming
                        Console.Write("Enter number of laps: ");
                        int laps = int.Parse(Console.ReadLine());
                        activity = new Swimming(date, minutes, laps);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        continue;
                }

                activities.Add(activity);
            }

            // Display summaries
            Console.WriteLine("\nActivity Summaries:");
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            // Display total summary
            double totalDistance = 0;
            double totalSpeed = 0;
            int totalMinutes = 0;
            foreach (var activity in activities)
            {
                totalDistance += activity.GetDistance();
                totalSpeed += activity.GetSpeed();
                totalMinutes += activity.Minutes;
            }

            double averageSpeed = totalSpeed / activities.Count;

            Console.WriteLine("\nSummary for All Activities:");
            Console.WriteLine($"Total Time: {totalMinutes} min");
            Console.WriteLine($"Total Distance: {Math.Round(totalDistance, 2)} km");
            Console.WriteLine($"Average Speed: {Math.Round(averageSpeed, 2)} kph");

            // Display distance graph
            Console.WriteLine("\nDistance Graph:");
            foreach (var activity in activities)
            {
                double scaledDistance = Math.Min(100, activity.GetDistance());
                string graph = new string('*', (int)(scaledDistance));
                Console.WriteLine($"{activity.GetType().Name}: {graph} {Math.Round(scaledDistance, 2)} km");
            }

            // Export to text file
            using (StreamWriter file = new StreamWriter("activities_summary.txt"))
            {
                foreach (var activity in activities)
                {
                    file.WriteLine(activity.GetSummary());
                }
            }

            Console.WriteLine("\nActivities have been exported to 'activities_summary.txt'. Goodbye!");
        }
    }
}
