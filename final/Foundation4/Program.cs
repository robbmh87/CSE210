using System;
using System.Collections.Generic;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some activities
            RunningActivity running = new RunningActivity(DateTime.Parse("11/03/2022"), 30, 3.0);
            CyclingActivity cycling = new CyclingActivity(DateTime.Parse("11/03/2022"), 45, 20);
            SwimmingActivity swimming = new SwimmingActivity(DateTime.Parse("11/03/2022"), 60, 10);

            // Add them to a list
            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            // Display the summaries
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            // Wait for user input to exit
            Console.ReadLine();
        }
    }

}