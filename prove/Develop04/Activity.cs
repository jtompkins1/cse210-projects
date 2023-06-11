using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _description;
    protected int _durationInt;
    private string _durationString;
    private string _menuSelection;
    private Random random = new Random();
    private string _randomPrompt;
    protected Stopwatch sw = new Stopwatch();
    private double lastFrame;
    protected double dt;
    private int _elapsedAcc;

    public Activity()
    {
        _activityName = GetActivityName(_menuSelection);
        _description = GetDescription();
    }
    public Activity(string activityName, string description, int durationInt)
    {
        _activityName = activityName;
        _description = description;
        _durationInt = durationInt;
    }
    public string GetMenuSelection()
    {
        Console.Write("Select an option from the menu (1-4): ");
        _menuSelection = Console.ReadLine();
        return _menuSelection;
    }
    // public GetActivityName() : string
    public string GetActivityName(string menuSelection)
    {
        if (_menuSelection == "1")
        {
            _activityName = "Breathing Activity";
        }
        else if (_menuSelection == "2")
        {
            _activityName = "Reflection Activity";
        }
        else if (_menuSelection == "3")
        {
            _activityName = "Listing Activity";
        }
        else if (_menuSelection == "4")
        {
            _menuSelection = "4";
        }

        return _activityName;
    }
    // public GetDescription() : string
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string activityName)
    {
        if (activityName == "Breathing Activity")
        {
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }else if (activityName == "Reflection Activity")
        {
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }else if (activityName == "Listing Activity")
        {
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }else
        {
            _description = "";
        }
    }
    // public DisplayStartMessage() : string
    public void DisplayStartMessage(string menuSelection, string activityName)
    {
        if (_menuSelection != "4")
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName}.");
            Console.WriteLine();
            SetDescription(_activityName);
            _description = GetDescription();
            Console.WriteLine(_description);
        }
    }
    // public GetDuration() : int
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _durationString = Console.ReadLine();
        _durationInt = int.Parse(_durationString);
        return _durationInt;
    }
    // public PausingAnimation() : void
    public void PausingAnimation(int seconds)
    {
        List<string> animationStrings = new List<string>() {"|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    // public DisplayEndMessage() : string
    public void DisplayEndMessage(string activityName, int durationInt)
    {
        Console.WriteLine("Well done!");
        PausingAnimation(5);
        Console.WriteLine($"You performed the {_activityName} for {_durationInt.ToString()} seconds.");
    }
    // public GetRandom(): string
    public string GetRandom(List<string> prompts)
    {
        int i = random.Next(prompts.Count);
        _randomPrompt = prompts[i];
        return _randomPrompt;
    }
    public void DisplayCountdown(string myText, int countdownStart)
    {
        Console.Write($"{myText}");
        for (int i = countdownStart; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public double DeltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalMilliseconds;
        return dt;
    }
    public int GetAccumulatedTime(double acc)
    {
        _elapsedAcc = (int)acc / 1000;
        return _elapsedAcc;
    }

}
