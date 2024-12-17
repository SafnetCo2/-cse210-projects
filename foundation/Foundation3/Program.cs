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

            // Create a list of activities
            List<Activity> activities = new List<Activity>();

            // Predefined activities
            activities.Add(new Running(DateTime.Parse("2024-12-01"), 30, 10));  // 10 km running for 30 minutes
            activities.Add(new Cycling(DateTime.Parse("2024-12-02"), 45, 20)); // 20 kph cycling for 45 minutes
            activities.Add(new Swimming(DateTime.Parse("2024-12-03"), 30, 20)); // 20 laps swimming for 30 minutes

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
