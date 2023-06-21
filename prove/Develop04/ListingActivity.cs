public class ListingActivity : Activity
{

    public List<string> Prompts { get; set; }
 

    public override void RunActivity()
    {
        SetDuration();
        Console.WriteLine($"Starting {Name} which will last for {duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        System.Threading.Thread.Sleep(3000);

        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);

        System.Threading.Thread.Sleep(duration * 1000);

        Console.WriteLine("Start listing...");
        int itemCount = 0;
        while (duration > 0)
        {
            string input = Console.ReadLine();
            itemCount++;
            duration--;
        }

        Spinner();
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {duration} seconds and listed {itemCount} items.");
        Console.WriteLine("Thank you for participating.");
    }
}
