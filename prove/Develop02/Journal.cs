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
    public List<string> _allEntries = new List<string>();



    public List<string> AddEntry(string entry)
    {
        //add users entry to _allEntries list
        // Entry entry = new Entry();
        // entry._allEntries.Add(_entry);
        // return _allEntries;
        _allEntries.Add(entry);
        return _allEntries;
    }

    public void DisplayEntries(List<string> _allEntries)
    {
        //code to display all Journal entries
        foreach (var entry in _allEntries)

        {
            Console.WriteLine(entry);
        }

        // Console.WriteLine(string.Join(Environment.NewLine,_allEntries));
    }

    public void SaveToFile()
    {
        //saves entry to file
    }

    public void LoadFile()
    {
        //load existing Journal file
    }

}