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

public class Journal
{
    public string _nameFile;
    public string _entry;
    public List<string> _allEntries = new List<string>();



    public List<string> AddEntry()
    {
        //add users entry to _allEntries list
        return _allEntries;
    }

    public void DisplayEntries()
    {
        //code to display all Journal entries
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