
using System;
using System.Collections.Generic;
using System.IO;

// Entry class to store user responses, prompts, and dates
public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

// Journal class to manage entries
public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>() {
        "How was your day?",
        "How did you feel?",
        "Who did you speak with today?",
        "What made you happy today?",
        "What made you sad today? ",
    };

    // Add a new entry
    public void AddEntry()
    {
        // Select a random prompt
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];

        // Get user response
        Console.Write(prompt + " ");
        string response = Console.ReadLine();

        // Create new entry and add to list
        Entry entry = new Entry {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };
        entries.Add(entry);
        Console.WriteLine("Entry saved successfully!");
    }

    // Display all entries
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.Date.ToString("MM/dd/yyyy") + " - " + entry.Prompt + " - " + entry.Response);
        }
    }

    // Save journal to file
    public void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.Date.ToString("MM/dd/yyyy") + " - " + entry.Prompt + " - " + entry.Response);
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Load journal from file
    public void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
                    Entry entry = new Entry {
                        Prompt = parts[1],
                        Response = parts[2],
                        Date = DateTime.ParseExact(parts[0], "MM/dd/yyyy", null)
                    };
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}

// Main program class
public class Program
{
    private static Journal journal = new Journal();

    static void Main(string[] args)
    {
        while (true)
        {
            // Display menu
            Console.WriteLine();
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            // Get user choice
            string choice = Console.ReadLine();

            // Perform action based on choice
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}
