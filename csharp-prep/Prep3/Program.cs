using System;

class Program
{
    static void Main(string[] args)
    {
      Random randomGenerator = new Random();
      int number = randomGenerator.Next(1,101);  

      int guess = -1;
      int guesses = 0;

      while (guess != number)
      {
        Console.Write("What is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (number > guess)
        {
            Console.WriteLine("Higher");
            guesses++;
        }
        else if (number < guess)
        {
            Console.WriteLine("Lower");
            guesses++;
        }
        else
        {
            guesses++;
            Console.WriteLine("You guessed it!");
            Console.Write("This took you ");
            Console.Write(guesses);
            Console.Write(" attempts");

        }
      }
    }
}