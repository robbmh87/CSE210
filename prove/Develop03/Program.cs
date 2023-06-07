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
            display();
            string choice = Console.ReadLine();
            switch (choice)

            {
                case "1":
                    reference.scriptureOne();
                    break;
                case "2":
                    reference.scriptureTwo();
                    break;
                case "3":
                    displayExit();
                    return;
            }

        }
    }

    public static void display()

    {
        //create start menu and welcoming message
        Console.WriteLine("Welcome to the scripture mastery!");
        Console.WriteLine("Please select one of the following scriptures to memorize: ");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Exit");
        Console.WriteLine("What would you like to do ? ");
    }



    public static void displayExit()
    {
        Console.Write("Good bye!");
    }


}



