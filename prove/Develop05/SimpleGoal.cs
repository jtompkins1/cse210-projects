using System;

public class SimpleGoal: Goal
{
    private bool _complete = false;
    private string _goalStr;
    private Goal _goal;

    public SimpleGoal(string name, string description, int points, bool complete) : base (name, description, points)
    {
        _complete = complete;
        _goal = this;
    }
    public override int RecordEvent()
    {
        _complete = true;
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return _complete;
    }
    public void SetComplete(bool complete)
    {
        _complete = complete;
    }
    public override string GoalToString()
    {
        if (_goal.IsComplete()== true)
        {
            _goalStr = ($"Simple Goal | {_goal.GetName} | {_goal.GetDescription()} | {_goal.GetPoints()}, True");
        }else
        {
            _goalStr = ($"Simple Goal | {_goal.GetName} | {_goal.GetDescription()} | {_goal.GetPoints()}, False");
        }
        return _goalStr;
    }
}

