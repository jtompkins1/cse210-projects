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

    public double GetBreathingTime(int durationInt)
    {
        StartActivity();
        double _durationMill = _durationInt * 1000;
        double acc = 0.0;

        //start counting here
        while (acc <= _durationMill)
        {
            acc += this.DeltaTime();
            DisplayBreathing();
        }

        return acc;

    }

}



    // attempted to use accumulated time while accounting for thread sleep

    // public double GetBreathing()
    // {
    //     StartActivity();
    //     double _durationMill = _durationInt * 1000;
    //     double acc = 0.0;
    //     int countdownStart1 = 0;
    //     int countdownStart2 = 0;
    //     double countdownSleep = (countdownStart1 + countdownStart2) * 1000;

    //     while (acc <= _durationMill)
    //     {


    //         acc += this.DeltaTime() - countdownSleep;

    //         countdownStart1 = 4;
    //         countdownStart2 = 6;
    //         DisplayCountdown("Breathe in...", countdownStart1);
    //         Console.WriteLine();
    //         DisplayCountdown("Now breathe out...", countdownStart2);
    //         Console.WriteLine();
    //         Console.WriteLine();

    //     }

    //     Console.WriteLine(acc);
        
    //     return acc;
    // }


//}