using System;

public class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    protected int _points;

    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;

    }

    public string GetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }
    public string GetDescription()
    {
        Console.Write("Briefly describe this goal: ");
        _description = Console.ReadLine();
        return _description;
    }
    public int GetPoints()
    {
        Console.Write("How many points are associated with this goal? ");
        string pointsStr = Console.ReadLine();
        _points = int.Parse(pointsStr);
        return _points;
    }
    public string GetType()
    {
        Console.WriteLine("Types of goals:");

        List<string> goalMenu = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};

        for (int i = 0; i < goalMenu.Count; i++)
        {
            string goalItem = goalMenu[i];
            Console.WriteLine($" {i + 1}. {goalItem}");
        }

        Console.Write("Which type of goal would you like to create (1-3): ");
        _goalType = Console.ReadLine();
        return _goalType;
    }




}