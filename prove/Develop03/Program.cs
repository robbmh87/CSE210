using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

static void Main(string[] args)
    {
        Reference reference = new Reference();
        while (true)
        {
            Display();
            string choice = Console.ReadLine();
            switch (choice)

            {   case "1":
                    reference.ScriptureOne();
                    break;
                case "2":
                    reference.ScriptureTwo();
                    break;
                case "3":
                    DisplayExit();
                    return;
            }

        }
    }

    public static void Display()

    {
        //create start menu and welcoming message
        Console.WriteLine("Welcome to the scripture mastery!");
        Console.WriteLine("Please select one of the following scriptures to memorize: ");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Exit");
        Console.WriteLine("What would you like to do ? ");
    }

  

    public static void DisplayExit()
    {
         Console.Write("Good bye!");
    }


}



    