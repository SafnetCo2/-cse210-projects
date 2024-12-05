using System;
using System.Collections.Generic;
using System.IO;

public abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_activityName}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_activityName}. Well done!");
        LogActivity();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i} seconds...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("\rLet's begin!       ");
    }

    private void LogActivity()
    {
        if (activityLog.ContainsKey(_activityName))
        {
            activityLog[_activityName]++;
        }
        else
        {
            activityLog[_activityName] = 1;
        }

        SaveActivityLog();
    }

    private void SaveActivityLog()
    {
        string filePath = "activity_log.txt";
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            foreach (var entry in activityLog)
            {
                writer.WriteLine($"{entry.Key}: {entry.Value} times");
            }
        }
    }

    public abstract void DoActivity();
}
