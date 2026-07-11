using System;
using System.Collections.Generic;
//https://www.w3schools.com/CS/cs_files.php
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        
        _entries.Add(newEntry);
    }

    public void DisplayAll()

    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(String file)
    {
        //https://stackoverflow.com/questions/7569904/easiest-way-to-read-from-and-write-to-files
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText} ");

            }


        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)

        {
            string[] parts = line.Split('|');

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);

        }

        Console.WriteLine("Journal loaded successfully.");

    }

}
