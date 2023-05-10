using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        // string selection = "";
        PromptGenerator getPrompt = new PromptGenerator();
        string _prompt;
        string _entry;
        Entry getEntry = new Entry();
        Menu selection = new Menu();

        string selection = new Program.getSelection();
        


        if (selection == "1") 
        {
            // code to get random prompt
            _prompt = getPrompt.GetPrompt();
            _entry = getEntry.GetUserEntry();
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
            // code for Quit (selection == "5")
            Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid Entry. Select an option number 1-5.");
        }

    }
}