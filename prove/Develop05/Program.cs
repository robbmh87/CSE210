using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        EternalQuest quest = new EternalQuest();
        quest.DisplayStatus();
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Read Scriptures for 100 points.");
            Console.WriteLine("2. Attend Temple for 50 points");
            Console.WriteLine("3. Run a Marathon for 1000 points!");
            Console.WriteLine("4. Display Status");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    quest.RecordEvent("Read Scriptures");
                    quest.AddGoal(new EternalGoal("Read Scriptures", 100));
                    break;
                case "2":
                    quest.RecordEvent("Attend Temple");
                    quest.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));
                    break;
                case "3":
                    quest.RecordEvent("Run a Marathon");
                    quest.AddGoal(new SimpleGoal("Run a Marathon", 1000));
                    break;
                case "4":
                     quest.DisplayStatus();
                     break;
                case "5":
                    displayExit();
                    return;

            }
        }
    }

    public static void displayExit()
    {
        Console.Write("Good bye!");
    }

}