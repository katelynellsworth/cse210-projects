using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Polymorphism with Exercise Tracking");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        Running running = new Running("30 Mar 2023", 30, 4.5);
        Swimming swimming = new Swimming("30 Mar 2023", 60, 25);
        Cycling cycling = new Cycling("30 Mar 2023", 45, 10);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach (var activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}