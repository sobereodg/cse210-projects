using System;

class Program
{
    static void Main()
    {
        // Create a list to hold different activities
        List<Activity> activities = new List<Activity>();

        // Add activities
        activities.Add(new Running(new DateTime(2025, 01, 30), 30, 3.0)); // Running for 30 minutes with 3 miles
        activities.Add(new Cycling(new DateTime(2025, 01, 30), 30, 12.0)); // Cycling for 30 minutes at 12 mph
        activities.Add(new Swimming(new DateTime(2025, 01, 30), 30, 40)); // Swimming for 30 minutes with 40 laps

        // Iterate through the activities and print summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}