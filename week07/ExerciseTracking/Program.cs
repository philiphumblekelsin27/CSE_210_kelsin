using System;
using System.Collections.Generic;

/*
CREATIVITY REPORT:
I exceeded the foundation requirements by adding a GetCalories() 
method to the base class and overriding it in all derived classes.
Each activity uses a specific formula to estimate calories burned 
based on distance or laps, which is then included in the final summary.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();
        Running running = new Running("10 April 2024", 30, 4.8);
        activities.Add(running);
        Cycling cycling = new Cycling("11 April 2024", 45, 18.5);
        activities.Add(cycling);
        Swimming swimming = new Swimming("12 April 2024", 25, 40);
        activities.Add(swimming);
        Console.WriteLine("Exercise Tracking System - Summary Report");
        Console.WriteLine("=========================================");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}