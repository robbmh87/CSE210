
public class BreathingActivity
{

    public void RunActivity()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        if (currentTime == futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
        else
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(duration * 1000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(duration * 1000);
        }

        Console.WriteLine("You have done a good job");
        Console.WriteLine("You have completed Breathing activity for " + duration + " seconds");
    }
}

