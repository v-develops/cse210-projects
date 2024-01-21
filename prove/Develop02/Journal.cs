using System;
using System.Runtime.CompilerServices;

public class Journal
{
// ENTRY LIST //
    public List<Entry> _entries = new List<Entry>();

// ADD ENTRY //
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

// DISPLAY LIST //
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

// SAVE FILE //
    public void SaveToFile(string filePath)
    {
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
    }

// LOAD FILE //
    public void LoadFromFile(string filePath)
    {
        _entries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split(',');
                    if (entryData.Length == 3)
                    {
                        Entry entry = new Entry
                        {
                            _date = entryData[0],
                            _promptText = entryData[1],
                            _entryText = entryData[2]
                        };
                        _entries.Add(entry);
                    }
                }

            }
        }
        catch
        {
            Console.WriteLine("");
            Console.WriteLine("Error! This file doesn't exist.");
        }
    }

    public void RemoveFromList()
    {
        if (_entries.Any())
        {
            _entries.RemoveAt(_entries.Count - 1);
        }

        else
        {
            Console.WriteLine("");
            Console.WriteLine("Error! No entrys to remove.");
        }
    }
}