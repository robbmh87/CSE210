using System.Diagnostics;

public class ListingActivity : Activity
{

    public List<string> Prompts { get; set; }


    public override void RunActivity()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Enter the duration in seconds you'll need to think about this: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();

        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        Console.WriteLine("Start listing...");
        int itemCount = 0;
        var sw = new Stopwatch();
        sw.Start();
        while(sw.ElapsedMilliseconds < duration*1000)
        {
            string input = Console.ReadLine();
            itemCount++;
        }
        sw.Stop(); 
        
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the Listing activity for {duration} seconds and listed {itemCount} items.");
        Console.WriteLine("Thank you for participating.");
    }
}

