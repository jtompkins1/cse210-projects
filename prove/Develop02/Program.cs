using System;

class Program
{
    static void Main(string[] args)
    {
        string selection = "";
      
        while (selection != "5")
        {
            
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices. \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.WriteLine("What would you like to do? (Enter a number 1-5: )");
            selection = Console.ReadLine();

            if (selection == "1") 
            {
                // code for Write entry

            }
            else if (selection == "2") 
            {
                // code for Display entries

            }
            else if (selection == "3") 
            {
                // code for Load file

            }
            else if (selection == "4") 
            {
                // code for Save file
            }
            else if (selection == "5") 
            {
                // code for Quit
            }
            else 
            {
                // if user enters character other than 1-5
                Console.WriteLine("Invalid Selection. Select an option number 1-5.");
            }
        }

    }
}