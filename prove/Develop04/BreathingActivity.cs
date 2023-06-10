using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Now breathe out...";

    public BreathingActivity(string activityName, string description): base (activityName, description)
    {
        // inherits activityName and description from Activity class
    }
    

    public void GetBreathing()
    {

        DisplayCountdown(_breatheIn, 4);
        Console.WriteLine();

        DisplayCountdown(_breatheOut, 6);
        Console.WriteLine();
        Console.WriteLine();
    }
}