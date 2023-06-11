using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int durationInt): base (activityName, description, durationInt)
    {
        // inherits activityName, description, and durationInt from Activity class
    }
    public void DisplayBreathing()
    {

        DisplayCountdown("Breathe in...", 4);
        Console.WriteLine();

        DisplayCountdown("Now breathe out...", 6);
        Console.WriteLine();
        Console.WriteLine();
    }
    
}