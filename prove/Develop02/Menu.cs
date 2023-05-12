using System;

public class Menu
{
    public string _selection;
    public string _menu = "Please select one of the following choices. \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? (Enter a number 1-5): ";

    
    public string GetSelection()
    {
        Console.WriteLine();
        Console.Write(_menu);
        _selection = Console.ReadLine();
        return _selection;

    }


}