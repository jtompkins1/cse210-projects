using System;

public class Menu
{
    public string _selection;
    public string _menu = "Please select one of the following choices: \n\n1. Write \n2. View list of prompts\n3. Display \n4. Load \n5. Save \n6. Quit \n\nWhat would you like to do? (Enter a number 1-6): ";

    
    public string GetSelection()
    {
        Console.WriteLine();
        Console.Write(_menu);
        _selection = Console.ReadLine();
        return _selection;

    }


}