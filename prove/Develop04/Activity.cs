public abstract class Activity
{

    public string Name { get; set; }
    public int duration;


    public string Description { get; set; }

    public void SetDuration()
    {
        Console.WriteLine("Enter the duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
    } 

    public void Spinner()
    {
            Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("/");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(1000);
    }

    public abstract void RunActivity();

}