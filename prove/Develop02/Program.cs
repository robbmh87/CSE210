using System;
using System.Collections.Generic;
using System.IO;



class Program

{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Display();
            string choice = Console.ReadLine();
            switch (choice)

            {   case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    journal.Save();
                    break;
                case "4":
                    journal.Load();
                    break;
                case "5":
                    DisplayExit();
                    return;
            }

        }
    }


    public static void Display()

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

  

    public static void DisplayExit()
    {
         Console.Write("Good bye!");
    }

}







   