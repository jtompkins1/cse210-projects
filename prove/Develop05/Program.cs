using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        List<string> mainMenu = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };
        string menuSelection = "";
        string goalType = "";
        string name;
        string description;
        int points;
        int requiredCount;
        int bonus;
 
        List<Goal> goals = new List<Goal>();

        do
        {
            Console.WriteLine($"You have {totalScore} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");

            for (int i = 0; i < mainMenu.Count; i++)
            {
                string menuItem = mainMenu[i];
                Console.WriteLine($" {i + 1}. {menuItem}");
            }

            Console.Write("Select a choice (1-6) from the menu: ");
            menuSelection = Console.ReadLine();

            if (menuSelection == "1")
            {
                Console.WriteLine("Types of goals:");

                List<string> goalMenu = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};

                for (int i = 0; i < goalMenu.Count; i++)
                {
                    string goalItem = goalMenu[i];
                    Console.WriteLine($" {i + 1}. {goalItem}");
                }

                Console.Write("Which type of goal would you like to create (1-3): ");
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    goalType = "Simple Goal";
                }else if (selection == "2")
                {
                    goalType = "Eternal Goal";
                }else if (selection == "3")
                {
                    goalType = "Checklist Goal";
                }

                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                
                Console.Write("Briefly describe this goal: ");
                description = Console.ReadLine();
                
                Console.Write("How many points are associated with this goal? ");
                string pointsStr = Console.ReadLine();
                points = int.Parse(pointsStr);

                if (goalType == "Checklist Goal")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string countStr = Console.ReadLine();
                    requiredCount = int.Parse(countStr);

                    Console.Write("How many bonus points do you earn for accomplishing it that many times? ");
                    string bonusStr = Console.ReadLine();
                    bonus = int.Parse(bonusStr);

                    ChecklistGoal newGoal = new ChecklistGoal(goalType, name, description, points, bonus, requiredCount);
                    goals.Add(newGoal);
                }else
                {
                    Goal newGoal = new Goal(goalType, name, description, points);
                    goals.Add(newGoal);
                }
                



            }
            else if (menuSelection == "2")
            {
                //
            }
            else if (menuSelection == "3")
            {
                //
            }
            else if (menuSelection == "4")
            {
                //
            }
            else if (menuSelection == "5")
            {
                //
            }

        }while (menuSelection != "6");

    }
}