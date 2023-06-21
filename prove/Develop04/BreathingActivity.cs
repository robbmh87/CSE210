public class BreathingActivity : Activity
{

    public override void RunActivity()
    {
        SetDuration();
        Console.WriteLine($"Starting {Name} which will last for {duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");




        Console.WriteLine("Breathe in...");
        System.Threading.Thread.Sleep(duration * 1000);
        Console.WriteLine("Breathe out...");
        System.Threading.Thread.Sleep(duration * 1000);
        
        Spinner();
        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}
