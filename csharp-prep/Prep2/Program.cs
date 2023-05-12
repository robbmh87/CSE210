using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letter = "";

     if (percent >= 97)
        {
            letter = "A+";
        }
        else if (percent >= 94 && percent <=96)
        {
            letter = "A";
        }
        else if (percent >= 90 && percent <=93)
        {
            letter = "A-";
        }
        else if (percent >= 87 && percent <= 89)
        {
            letter = "B+";
        }
        else if (percent >= 84 && percent <= 86)
        {
            letter = "B";
        }
        else if (percent >= 80 && percent <=83)
        {
            letter = "B-";
        }
        else if (percent >= 77)
        {
            letter = "C+";
        }
        else if (percent >= 74 && percent <=76)
        {
            letter = "C";
        }
        else if (percent >= 70 && percent <=73)
        {
            letter = "C-";
        }
       else if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent >= 64 && percent <=66)
        {
            letter = "D";
        }
        else if (percent >= 60 && percent <= 63)
        {
            letter = "D-";
        }
        else if (percent >= 57)
        {
            letter = "F+";
        }
        else if (percent >= 54 && percent <=56)
        {
            letter = "F";
        }
        else if (percent >= 50 && percent <=53)
        {
            letter = "F-";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}