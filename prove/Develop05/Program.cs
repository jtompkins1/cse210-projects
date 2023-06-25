using System;
using System.Collections.Generic;


//To exceed requirements I added the Animation() method which displays blinking words of encouragement when the user accomplishes a goal. Also, when the goal names are shown for the user to record an event, already completed goal names are crossed out.
class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        List<string> mainMenu = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };
        string menuSelection = "";
        string name;
        string description;
        int points;
        int requiredCount = 0;
        int completedCount = 0;
        int bonus = 0;
 
        List<Goal> goals = new List<Goal>();

        Goal goal = null;

        Console.WriteLine("Welcome to the Eternal Quest program!");

        do
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalScore} points.");
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
                Console.WriteLine();
                Console.WriteLine("Types of goals:");

                List<string> goalMenu = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};

                for (int i = 0; i < goalMenu.Count; i++)
                {
                    string menuItem2 = goalMenu[i];
                    Console.WriteLine($" {i + 1}. {menuItem2}");
                }

                Console.Write("Which type of goal would you like to create (1-3): ");
                string selection = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                
                Console.Write("Briefly describe this goal: ");
                description = Console.ReadLine();
                
                Console.Write("How many points are associated with this goal? ");
                string pointsStr = Console.ReadLine();
                points = int.Parse(pointsStr);

                if (selection == "1")
                {
                   //"Simple Goal"
                    SimpleGoal sg = new SimpleGoal(name, description, points, false);
                    goals.Add(sg);
             
                }else if (selection == "2")
                {
                    //"Eternal Goal"
                    EternalGoal eg = new EternalGoal(name, description, points);
                    goals.Add(eg);

                }else if (selection == "3")
                {
                    //"Checklist Goal"
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string countStr = Console.ReadLine();
                    requiredCount = int.Parse(countStr);

                    Console.Write("How many bonus points do you earn for accomplishing it that many times? ");
                    string bonusStr = Console.ReadLine();
                    bonus = int.Parse(bonusStr);

                    ChecklistGoal cg = new ChecklistGoal(name, description, points, bonus, completedCount, requiredCount);
                    goals.Add(cg);

                }
                
            }
            else if (menuSelection == "2")
            {
                Console.WriteLine();
                Console.WriteLine("The goals are: ");
                //List Goals
                int counter = 0;

                foreach (Goal goalItem in goals)
                {
                    string checkComplete = goalItem.IsComplete() ? "[x]" : "[ ]";
                
                    string completedStatus = goalItem is ChecklistGoal ? $"--- Currently Completed: {((ChecklistGoal)goalItem).GetCompletedCount()}/{((ChecklistGoal)goalItem).GetRequiredCount()}": "";

                    counter += 1;
                    
                    Console.WriteLine($"{counter}. {checkComplete} {goalItem.GetName()} ({goalItem.GetDescription()}) {completedStatus}");
                }
            }
            else if (menuSelection == "3")
            {
                //Save Goals
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                FileManagement f1 = new FileManagement();
                f1.SaveGoals(fileName, totalScore, goals);
                Console.WriteLine($"Your goals have been saved to the {fileName} file.");

            }
            else if (menuSelection == "4")
            {
                //Load Goals
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                FileManagement f2 = new FileManagement();
                totalScore = f2.LoadGoals(fileName, goals);
                Console.WriteLine($"The {fileName} file has loaded. ");

            }
            else if (menuSelection == "5")
            {
                //Record Event
                Console.WriteLine();
                Console.WriteLine("The goals are: ");
                Console.WriteLine("(Completed goals are crossed out.)");
                for (int i = 0; i < goals.Count; i++)
                {
                    goal = goals[i];

                    if (goal.IsComplete() == true)
                    {
                        Console.WriteLine($"{i+1}. \u001b[9m{goal.GetName()}\u001b[0m");
                    }else
                    {
                        Console.WriteLine($"{i+1}. {goal.GetName()}");
                    }
                }
                Console.Write("What goal did you accomplish? ");
                string choice = Console.ReadLine();

                int index;
                if(int.TryParse(choice, out index))
                {
                    if (index > 0 && index <= goals.Count)
                    {
                        Goal selectedGoal = goals[index - 1];
                        int earnedPoints = selectedGoal.RecordEvent();
                        totalScore += earnedPoints;

                        goal.Animation();

                        Console.WriteLine();
                        Console.WriteLine($"Congratulations! You earned {earnedPoints} points!");
                        Console.WriteLine($"You now have a total of {totalScore} points.");
                    }
                }
            }

        }while (menuSelection != "6");

    Console.WriteLine("Thank you for using the Eternal Quest program!");

    }
}