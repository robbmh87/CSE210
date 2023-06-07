
class ReflectionActivity
{

    public void RunActivity()
    {
        Console.WriteLine("ReflectionACtivity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Enter the duration in seconds you'll need to think about this: ");
        Console.WriteLine(prompts[new Random().Next(prompts.Count)]);
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
         DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        if (currentTime == futureTime)
        {
            Console.WriteLine("Its not time yet!");
        }
        else
        {
            Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;
            Console.Write("/");
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(questions[new Random().Next(questions.Count)]);
            Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;
            Console.Write("/");
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(2000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(2000);
    
        }
        Console.WriteLine("You have done a good job");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

    private List<string> prompts = new List<string>
{
"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."
};

    private List<string> questions = new List<string>
{
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
};

}

