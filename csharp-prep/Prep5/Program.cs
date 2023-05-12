using System;

class Program
{
    static void Main(string[] args) 
    {
        WelcomeMessage();

        string userName = UsersName();
        int usersNumber = UserNumber();
        int numberSquare = SquaredNumber(usersNumber);
        DisplayResult(userName, numberSquare);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

     static string UsersName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int usersNumber)
    {
        int squared = usersNumber * usersNumber;

        return squared;
    }

    static void DisplayResult(string UserName, int square)
    {
        Console.WriteLine($"{UserName}, the square of your favorite number is {square}");
    }
}