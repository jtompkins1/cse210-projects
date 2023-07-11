using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(4, 45);
        Swimming swimming = new Swimming(20, 60);
        Cycling cycling = new Cycling(7, 20);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();

        }



    }
}