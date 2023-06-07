using System;
using System.Threading;

public class BreathingActivity2 : Activity2
{
//     private string _breatheIn = "Breathe in...";
//     private string breatheOut = "Breathe out...";

    public BreathingActivity()//string activityName, string description)//: base (activityName, description)
    {
        // inherits parameters from base class Activity
    }

    public void GetBreathing()
    {
        Console.Write($"Breathe in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
        Console.Write($"Now Breathe out...");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}