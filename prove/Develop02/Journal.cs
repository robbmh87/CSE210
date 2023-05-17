using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
  public List<Entry> entries = new List<Entry>();

  public void AddEntry()
  {
      Entry entry = new Entry(); 
      string[] journalQuestions =
      {
      "What was the best thing that happened to you today?",
      "What steps did you take today towards a goal you're working on?",
      "What are three things you're grateful for today?",
      "What do you look forward to tomorrow?",
      "How did you feel the Lord in your life today?"
      };

      Random random = new Random();
      int mIndex = random.Next(journalQuestions.Length - 1);
      entry._prompt = journalQuestions[mIndex];
      Console.Write(journalQuestions[mIndex] + " ");
      entry._input = Console.ReadLine();
      entry._date = DateTime.Now.ToString("MM/dd/yyyy");
      entries.Add(entry); 

  }

  public void Display()
  {
      foreach (Entry entry in entries)
          {
            Console.WriteLine($"{entry._date} {entry._prompt} {entry._input}");
          }
    
  }

  public void Load()
  {

    Console.WriteLine("Please enter file name you wish to load:");
    string filename = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Entry entry = new Entry();
      string[] parts = line.Split("~");
      string date = parts[0];
      string prompt = parts[1];
      string input = parts[2];
      entry._date=date;
      entry._prompt=prompt;
      entry._input=input;
      entries.Add(entry);
    }

  }

  public void Save()
  {
    Console.WriteLine("What would you like to save your file as?");
    string filename = Console.ReadLine() + ".txt";
    Console.WriteLine("Saving file: " + filename);
    using (StreamWriter outputFile = new StreamWriter(filename))
      {
        foreach (Entry entry in entries)
          {
            outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._input}");
          }

      }
  }

}


    

