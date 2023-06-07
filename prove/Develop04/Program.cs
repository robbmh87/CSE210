class Program
{

    public static void Main()
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
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            Console.WriteLine("Choose an activity:");
            switch (choice)
            {
                case "1":
                    breathingActivity.RunActivity();
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



}