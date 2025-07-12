using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();

    public void AddEntry(string content)
    {
        JournalEntry newEntry = new JournalEntry(content);
        journalEntries.Add(newEntry);
        Console.WriteLine($"Entry added on {newEntry.Date}.");
    }

    public void ViewEntries()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            Console.WriteLine("\n--- Your Journal Entries ---");
            foreach (var entry in journalEntries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        try
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File '{fileName}' does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);
            journalEntries.Clear();  // Clear current entries before loading new ones

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                {
                    string content = parts[1];
                    journalEntries.Add(new JournalEntry(content, date));
                }
                else
                {
                    Console.WriteLine($"Skipping line due to invalid format: {line}");
                }
            }

            Console.WriteLine($"Journal loaded from {fileName}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Failed to load journal: {e.Message}");
        }
    }

    public void SaveJournal(string fileName)
    {
        try
        {
            // The StreamWriter defaults to overwriting the file, not appending
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Content}");
                }
            }
            Console.WriteLine($"Journal saved to {fileName} on {DateTime.Now}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Failed to save journal: {e.Message}");
        }
    }
}
