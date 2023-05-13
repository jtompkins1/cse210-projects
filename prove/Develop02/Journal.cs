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
    public List<Entry> _allEntries = new List<Entry>();
    public List<string> _stringEntries = new List<string>();
    Entry addEntry = new Entry();
    

    public void AddEntry(string entry)
    {
        //add new entries to _allEntries list
        _entry = addEntry.CombineEntryElements();
        _stringEntries.Add(_entry);

    }

    public void DisplayEntries()
    {
        //code to display all Journal entries
        Console.WriteLine();
        Console.WriteLine("My Journal Entries: ");

        foreach (Entry entry in _allEntries)
        {
            entry.CombineEntryElements();
        }
    }

    // public string SaveToFile(List<string> _allEntries)
    // {
    //     // TODO:
    //         // currently writes over old entries if you load this file, then save new entries 

    //     Console.Write("Name a .txt file to save: ");
    //     _nameFile = Console.ReadLine();

    //     Console.WriteLine("Saving to file...");

    //     using (StreamWriter outputFile = new StreamWriter(_nameFile))
    //     {
    //         foreach (var entry in _allEntries)
    //         {
    //             outputFile.WriteLine(entry);
    //         }
            
    //     }
    //     return _nameFile;
    // }
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