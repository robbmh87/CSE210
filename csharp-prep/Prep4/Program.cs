using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int enteredNumber = -1;
        while (enteredNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 to quit): ");
            
            string userResponse = Console.ReadLine();
            enteredNumber = int.Parse(userResponse);
            
         
            if (enteredNumber != 0)
            {
                numbers.Add(enteredNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

       
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    
        
        numbers.Sort();
        
        for (int i = 0; i <numbers.Count; ++i)
        {
            Console.WriteLine("The Lowest Positive numbers is: " + numbers[1]);
        }
            Console.WriteLine("The sorted list is: " );

        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}