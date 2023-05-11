//Class: Journal
// Attributes:
// * _nameFile : string
// * _entries: list

// Behaviors:
// DisplayEntries(): string
// AddEntry(): void
// SaveToFile(): void
// LoadFile(): void


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
        Console.WriteLine("My Journal Entries: ");

        foreach (var entry in _allEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public string SaveToFile(List<string> _allEntries)
    {
        //saves entry to file
        Console.Write("Name a .txt file to save: ");
        _nameFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_nameFile))
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
        Console.WriteLine(_loadFile);

        return _nameFile;

    }

}