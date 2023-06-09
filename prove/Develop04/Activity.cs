using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Activity
{
    protected string _activityName;
    private string _description;
    private int _durationInt;
    private string _durationString;
    protected string _menuSelection;
    public Random random = new Random();
    public string _randomPrompt;

    protected Stopwatch sw = new Stopwatch();
    protected double lastFrame;


    public Activity()
    {
        _activityName = GetActivityName();
        _description = GetDescription();
    }
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public string GetMenuSelection()
    {
        Console.Write("Select an option from the menu (1-4): ");
        _menuSelection = Console.ReadLine();
        return _menuSelection;
    }
    // public GetActivityName() : string
    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string menuSelection)
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
    public void DisplayEndMessage(string menuSelection, string activityName, int durationInt)
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
    public void DisplayCountdown(string myText, int i)
    {
        Console.Write($"{myText}");
        for (i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    private double GetDeltaTime()
    {
        TimeSpan ts = sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        lastFrame = ts.TotalMilliseconds;
        return dt;
    }

    public void Run(int _durationInt)
    {
        sw.Start();
        double acc = 0.0;
        List<string> buf = new List<string>();
        double _durationMill = _durationInt / 1000;

        //start counting here
        while (acc <= _durationMill)
        {
            acc += GetDeltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n");
            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        //time is up

//         The run() method is the core of the program. It starts the stopwatch, initializes variables, and enters a loop that runs until the accumulated time (acc) exceeds 5000 milliseconds (5 seconds).

// Within the loop, the deltaTime() method is called to calculate the time difference between frames. If no key is available in the console, the loop continues without performing any further actions.

// If a key is available, the program reads the key using Console.ReadKey(). If the key is the Enter key, a newline character is added to the buf list. Otherwise, the typed character is converted to a string and added to the buf list.

// After the loop ends, a message "Time's up!" is displayed in the console. The buf list is joined into a single string (bufStr) using String.Join(). Finally, the program outputs the string along with a message indicating what the user typed.

        }

    }


}

