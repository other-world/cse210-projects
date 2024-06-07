using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking");
        List<Activity> activities = new List<Activity>();

        Cycling cycling = new Cycling(45.0, 2, "13 March 2024");
        Running running = new Running(3.0, 30, "15 March 2024");
        Swimming swimming = new Swimming(20.0, 2, "16 March 2024");

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}