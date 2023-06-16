using System;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        List<string> mainMenu = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };
        string menuSelection; 
        List<string> goalMenu = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};
        string goalType;
       
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

                for (int i = 0; i < goalMenu.Count; i++)
                {
                    string goalItem = goalMenu[i];
                    Console.WriteLine($" {i + 1}. {goalItem}");
                }

                Console.Write("Which type of goal would you like to create (1-3): ");
                goalType = Console.ReadLine();
                Console.Write("What is the name of your goal? ");
                Console.ReadLine();
                Console.Write("Briefly describe this goal: ");
                Console.ReadLine();
                Console.Write("How many points are associated with this goal? ");
                Console.ReadLine();

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