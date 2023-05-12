using System;
using System.Collections.Generic;
using System.IO;



class Program

{
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)

            {   case "1":
                    AddEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    DisplayExit();
                    return;
            }

        }
    }


    public static void DisplayMenu()

    {
        //create start menu and welcoming message
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Add entry");
        Console.WriteLine("2. Display entries");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Exit");
        Console.WriteLine("What would you like to do ? ");
    }

   public static void AddEntry()
    {
        Entry entry = new Entry();
        List<String> journal = new List<String>();
        
        do{
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Random random = new Random();
      string[] journalQuestions = {
      "What was the best thing that happened to you today?",
      "What steps did you take today towards a goal you're working on?",
      "What are three things you're grateful for today?",
      "What do you look forward to tomorrow?",
      "How did you feel the Lord in your life today?"};                       
      int mIndex = random.Next(journalQuestions.Length);
      entry._prompt = journalQuestions[mIndex];
      Console.Write(journalQuestions[mIndex]);
      entry._input = Console.ReadLine();
      string currentDate1 = DateTime.Now.ToString("MM/dd/yyyy"); 
      entry._date = currentDate1;
          
        Console.WriteLine($"You entered: {journalQuestions[mIndex]} {entry._input} on {currentDate1}");
            journal.Add(journalQuestions[mIndex] + entry + currentDate1);
        Console.WriteLine("would you like to continue? Y/N?");
            } while(Console.ReadKey().Key ==ConsoleKey.Y);
        
        }


    public static void DisplayEntries()
    {
    
    }

    

    public static void LoadJournal()
    {

    }



    public static void SaveJournal()
    {

        Console.Write("What is the file name: ");
        string fileInput = Console.ReadLine();
        Console.WriteLine("Saving to file..." + fileInput);
        using(StreamWriter outputfile = new StreamWriter(fileInput))
        {
            
    
        }
        


    }

    public static void DisplayExit()
    {
         Console.Write("Good bye!");
    }

}







   