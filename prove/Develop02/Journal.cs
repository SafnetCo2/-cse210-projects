using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("----"); 
            }
        }
        Console.WriteLine("Saved journal to file");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string date = reader.ReadLine();
                    string promptText = reader.ReadLine(); 
                    string entryText = reader.ReadLine(); 
                    reader.ReadLine(); 

                    Entry entry = new Entry(date, promptText, entryText);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Just loaded journal");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
