using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points = 0;

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
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public abstract string GoalToString();
    public abstract int RecordEvent();

    public abstract bool IsComplete();





}