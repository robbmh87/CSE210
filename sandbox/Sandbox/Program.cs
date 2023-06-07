using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        ListingActivity listingActivity = new ListingActivity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        while (true)
        {

            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");

            string choice = Console.ReadLine();
            Console.WriteLine("Choose an activity:");
            switch (choice)
            {
                case "1":
                    breathingActivity.Activity();
                    break;
                case "2":
                    reflectionActivity.RunActivity();
                    break;
                case "3":
                    listingActivity.RunActivity();
                    break;
                case "4":
                    displayExit();
                    return;
            }
        }
    }

    public static void display()

    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.WriteLine("What would you like to do ? ");
    }

    public static void displayExit()
    {
        Console.Write("Good bye!");
    }
    abstract class Activity
    {
        private int duration;
        private string name;
        private string description;

        public Activity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public abstract void Start();
        public abstract void End();

        public void SetDuration()
        {
            Console.WriteLine("Enter the duration in seconds: ");
            duration = Convert.ToInt32(Console.ReadLine());
        }
    }
}

}

}
