using System;

class Program
{
    static void Main(string[] args)
    {
        int totalScore = 0;
        List<string> mainMenu = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };
        string menuSelection; 

        string goalType;

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