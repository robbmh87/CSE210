class Program
{

    public static void Main()
    {
        ListingActivity listingActivity = new ListingActivity
        {
            Name = "Listing Activity",
            Description = "This activity will help you list all the grea tthings in your life.",
            duration = 10,
            Prompts = new List<string>
        {
            "Who are some people that you appreciate?",
            "What are your biggest strengths?",
            "Who is someone that you have helped this week?",
            "When have you felt the Holy Ghost",
        }
        };

        ReflectionActivity reflectionActivity = new ReflectionActivity
        {
            Name = "Reflection Activity",
            Description = "This activity will help you reflect on times in your life when you have grown and showed improvements. This will help you realize how much you have done and you can better utilize it.",
            Prompts = new List<string>
        {
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when went out of your way to make someone smile"
        },
            Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "Were you nervous to do this?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
        }
        };


        BreathingActivity breathingActivity = new BreathingActivity
        {
            Name = "Breathing Activity",
            Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        };

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
                    break;
            }
        }
    }

    public static void displayExit()
    {
        Console.Write("Good bye!");
    }
}