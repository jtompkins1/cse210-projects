using System;
using System.Collections.Generic;

public class Journal
{
    public string _nameFile;
    public string _entry;
    public string _loadFile;
    public List<string> _allEntries = new List<string>();

    public List<string> AddEntry(string entry)
    {
        //add user entry to _allEntries list
        _allEntries.Add(entry);
        return _allEntries;
    }

    public void DisplayEntries(List<string> _allEntries)
    {
        //code to display all Journal entries
        Console.WriteLine();
        Console.WriteLine("Displaying entries... ");

        foreach (var entry in _allEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public string SaveToFile()
    {
        Console.Write("Name a .txt file to save: ");
        _nameFile = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = File.AppendText(_nameFile))
        {
            foreach (var entry in _allEntries)
            {
                outputFile.WriteLine(entry);
            }
        }
        return _nameFile;
    }
    public string LoadFile()
    {
        //load existing Journal file
        Console.Write("Enter the name of your file: ");
        _nameFile = Console.ReadLine();
        _loadFile = File.ReadAllText(_nameFile);
        Console.WriteLine();
        Console.WriteLine($"Viewing {_nameFile}...");
        Console.WriteLine(_loadFile);

        return _nameFile;
    } 
}