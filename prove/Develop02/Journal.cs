using System;
using System.Collections.Generic;
using System.IO;


public class Journal

{
  public List<Entry> entries = new List<Entry>();

public void AddEntry()
{
    public static void AddEntry()
    {
      Entry entry = new Entry(); string[] journalQuestions =
      {
      "What was the best thing that happened to you today?",
      "What steps did you take today towards a goal you're working on?",
      "What are three things you're grateful for today?",
      "What do you look forward to tomorrow?",
      "How did you feel the Lord in your life today?"
      };

      Random random = new Random(); int mIndex = random.Next(journalQuestions.Length - 1);
      entry._prompt = journalQuestions[mIndex];
      Console.Write(journalQuestions[mIndex]); entry._input = Console.ReadLine();
      entry._date = DateTime.Now.ToString("MM/dd/yyyy");
      entries.Add(entry);
    }
}

public void Display()
{
      foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
}

public void Load()
{
  string filename="";
Console.WriteLine("Please enter file name you wish to display");
filename = Console.ReadLine();
Console.WriteLine("Displaying file" + filename);
foreach (Entry j in entries)
{
  Console.WriteLine(j);
}

}

public void Save()
{
    string filename = "";
    Console.WriteLine("What would you like to save your file as?");
    filename = Console.ReadLine();
    Console.WriteLine("Savings file" + filename + ".txt");
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Entry j in entries)
        {
            outputFile.WriteLine(j);
        }

    }
}

}


    

