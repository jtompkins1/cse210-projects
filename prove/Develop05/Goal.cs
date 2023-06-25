using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points = 0;

    public Goal(string name, string description, int points)
    { 
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract string GoalToString();
    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public void Animation()
    {
        List<string> animations = new List<string>() {"Great Job", "You did it!", "Way to go!", "Good work!", "Awesome!", "Well done!"};

        Random random = new Random();
        int i = random.Next(animations.Count);
        string animation = animations[i]; 

        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(3);

        while (DateTime.Now - startTime < duration)
        {

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', animation.Length));
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(animation);
            Thread.Sleep(500);

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', animation.Length));
            Thread.Sleep(500);

        }
    }

}