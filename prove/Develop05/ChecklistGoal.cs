using System;

public class ChecklistGoal: Goal
{
    protected int _bonus;
    private int _requiredCount;
    private int _completedCount;
    private bool _complete = false;
 
    public ChecklistGoal()
    {

    }
    public ChecklistGoal (string goalType, string name, string description, int points, int bonus, int requiredCount) : base (goalType, name, description, points)
    {
        _bonus = bonus;
        _requiredCount = requiredCount;
        // _completedCount = completedCount;
        // _complete = complete;
        
    }
    public int GetRequiredCount()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string countStr = Console.ReadLine();
        _requiredCount = int.Parse(countStr);
        return _requiredCount;
    }
    public int GetBonus()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string bonusStr = Console.ReadLine();
        _bonus = int.Parse(bonusStr);
        return _bonus;
    }
}