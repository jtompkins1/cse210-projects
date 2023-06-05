using System;

public class Activity
{
    protected string _activityName;
    private string _description;
    private int _durationInt;
    private string _durationString;
    protected string _menuSelection;

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
            _menuSelection= "4";
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

    public void PausingAnimation()
    {
        List<string> animationStrings = new List<string>() {"|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        // Console.WriteLine("Get Ready...");

        while (DateTime.Now < endTime)
        {
            // Console.Write(".");
            // Thread.Sleep(1000);
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
    // // public DurationTimer() : void
    // public void DurationTimer(int durationInt)
    // {

    // }
    // public DisplayEndMessage() : string
    public void DisplayEndMessage(string activityName, int durationInt)
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        PausingAnimation();
        Console.WriteLine($"You performed the {_activityName} for {_durationInt.ToString()} seconds.");
        Console.WriteLine();

    }
    // public GetRandom(): string
    
}