public class ReflectionActivity : Activity
{

    public List<string> Prompts { get; set; }


    public List<string> Questions { get; set; }


    public override void RunActivity()
    {
        SetDuration();

        Console.WriteLine($"Starting {Name} which will last for {duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        System.Threading.Thread.Sleep(3000);

 
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

 
        for (int i = 0; i < Questions.Count; i++)
        {
            Console.WriteLine(Questions[i]);
            System.Threading.Thread.Sleep(duration * 1000);

            Spinner();
        }

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}