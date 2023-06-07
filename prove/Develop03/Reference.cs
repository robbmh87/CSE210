using System;
using System.Collections.Generic;
using System.Linq;

class Reference
{
    Scripture scripture = new Scripture();
    public void scriptureOne()
    {
        while (true)
        {
            string john = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            Console.WriteLine("Please enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("John 3:16");
            Console.WriteLine(john);

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.displayScripture(john);
                scripture.hideWord(john);
                if (scripture.allwordsHidden(john))
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                    break;
                }
            }

        }
    }

    public void scriptureTwo()
    {
        while (true)
        {
            string proverbs = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            Console.WriteLine("Please enter to hide a word or type quit to exit");
            string userINput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Proverbs 3: 5-6");
            Console.WriteLine(proverbs);

            if (userINput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.displayScripture(proverbs);
                scripture.hideWord(proverbs);
                if (scripture.allwordsHidden(proverbs))
                {
                    Console.WriteLine("Congratulations, yuou have memorized the scripture!");
                    break;
                }
            }

        }

    }




}
