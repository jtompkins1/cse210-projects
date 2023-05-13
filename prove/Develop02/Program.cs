using System;
using System.Collections.Generic;
using System.IO;
class Program
{

    static void Main(string[] args)
    {

        Menu getSelection = new Menu();
        PromptGenerator getPrompt = new PromptGenerator();
        Entry getEntry = new Entry();
        Journal journal = new Journal();

        string selection;
        string _random;
        string _prompt;
        string _response;
        string _entry;
        string _date;
        string _nameFile;
        List<string> _allEntries = new List<string>();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
        //display menu and get users selection
        // 1. Write, 2. Display, 3. Load, 4. Save, 5. Quit
        selection = getSelection.GetSelection();

        if (selection == "1") 
        {
            // code to get random prompt, get user entry, add entry to journal
            // code to get random prompt, get user entry, add entry to journal
            _random = getPrompt.GetPrompt();
            _prompt = getEntry.DisplayPrompt();
            _response = getEntry.GetUserResponse();
            _date = getEntry.GetDate();
            _entry = getEntry.GetEntry(_date, _prompt, _response);
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
            _nameFile = journal.LoadFile();
        }
        else if (selection == "4") 
        {
            // code for Save file
            // _nameFile = journal.SaveToFile();
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