using System;
using System.Threading;



public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Now breathe out...";

    public BreathingActivity()//string activityName, string description)//: base (activityName, description)
    {
        // inherits parameters from base class Activity
    }

    public void GetBreathing()
    {

        GetCountdown(_breatheIn, 4);
        Console.WriteLine();
        GetCountdown(_breatheOut, 6);
        // Console.Write($"Breathe in...");
        // for (int i = 4; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        // Console.WriteLine();
        // Console.Write($"Now Breathe out...");
        // for (int i = 6; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        Console.WriteLine();
        Console.WriteLine();
    }
}