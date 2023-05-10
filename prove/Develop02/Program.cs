using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {

        string selection;
        MenuSelection getSelection = new MenuSelection();
        PromptGenerator getPrompt = new PromptGenerator();
        string _prompt;
        string _entry;
        Entry getEntry = new Entry();
        Journal journal = new Journal();
        List<string> _allEntries = new List<string>();

        

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
        //display menu and get users selection
        // 1. Write, 2. Display, 3. Load, 4. Save, 5. Quit
        selection = getSelection.GetSelection();

        if (selection == "1") 
        {
            // code to get random prompt, get user entry, add entry to journal
            _prompt = getPrompt.GetPrompt();
            _entry = getEntry.GetUserEntry();
            _allEntries = journal.AddEntry(_entry);
        }
        else if (selection == "2") 
        {
            // code for Display entries
            journal.DisplayEntries(_allEntries);

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


        } while (selection != "5");


    }
}