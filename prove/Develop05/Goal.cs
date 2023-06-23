using System;
using System.Collections.Generic;
using System.IO;

public class Goal
{
    //protected string _goalType;
    private string _name;
    private string _description;
    protected int _points;
    // protected bool _complete = false;
    //protected string _status;
    //protected string _goal;

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
    // public string GetGoalType()
    // {
    //     return _goalType;
    // }
    // public virtual bool IsComplete(bool complete)
    // {
    //     _complete = complete;

    // }


    // public virtual string ToString()
    // {

    //     //IsComplete();
    //     return _goal = $"[] {_name} ({_description})";

    // }
    public void ListGoals()
    {

    }


    public virtual int RecordEvent()
    {
        return GetPoints();
    }
    public virtual bool IsComplete()
    {
        return true;
    }
    public void SaveGoals(string filename, int totalScore, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalScore);

            foreach(Goal goal in goals)
            {
                if(goal is SimpleGoal){
                    if (goal.IsComplete()== true)
                    {
                        outputFile.WriteLine($"Simple Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, True");
                    }else
                    {
                        outputFile.WriteLine($"Simple Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, False");
                    }
                }else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"Eternal Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}");
                }else if (goal is ChecklistGoal)
                {
                    outputFile.WriteLine($"Checklist Goal: {goal.GetName} | {goal.GetDescription()} | {goal.GetPoints()}, {((ChecklistGoal)goal).GetBonus()} | {((ChecklistGoal)goal).GetCompletedCount()} | {((ChecklistGoal)goal).GetRequiredCount()}");
                }
            }
        }

    }

}