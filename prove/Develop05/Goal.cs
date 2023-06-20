using System;

public class Goal
{
    protected string _goalType;
    private string _name;
    private string _description;
    protected int _points;
    protected bool _complete;
    protected string _status;
    protected string _goal;

    public Goal()
    {

    }
    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
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
    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
    public string IsComplete()
    {
        if (_complete == true)
        {   
            _status = "[x]";
        }else
        {
            _status = "[ ]";
        }
        return _status;
    }

    public virtual string CompiledGoal(string name, string description)
    {
        return _goal = $"status {_name} ({_description})";

    }

}