using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public void SaveToFile(string filename)
    {
        // Using StreamWriter to save journal entries to the specified file
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved successfully!");

        string sampleFileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(sampleFileName))
        {
        
            outputFile.WriteLine("first line in the file.");
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return;
        }

        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                var entry = new Entry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}
