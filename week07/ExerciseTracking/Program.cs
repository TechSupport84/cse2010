using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List <Activity> activities = new List<Activity>{
            new Running("03 Nov 2022",30,4.8),
            new Cycling("03 Nov 2022",40, 20.0),
            new Swimming("03 Nov 2022", 25,30)
        };

        foreach (var activity in activities)
        {
             Console.WriteLine(activity.GetSummary());
            
        }
    }
}