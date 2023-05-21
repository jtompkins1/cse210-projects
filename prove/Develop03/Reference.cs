using System;


public class Reference
{
    private string _reference;
    private string _book = "Moroni";
    private int _chapter = 10;
    private int _startVerse = 3;
    private int _endVerse = 5;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;

    }
    public string GetBook()
    {
        return _book;
    } 
    public void SetBook(string book)
    {
        _book = book;
    } 
    public int GetChapter() 
    {
        return _chapter;
    } 
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetMultipleReference()
    {
        return _reference;
    }
    public void SetMultipleReference(string book, int chapter, int startVerse, int endVerse)
    {
        _reference = ($"{_book} {_chapter}: {_startVerse}-{_endVerse}");
    }
    public string GetSimpleReference()
    {
        return _reference;
    }
    public void SetSimpleReference(string book, int chapter, int startVerse)
    {
        _reference = ($"{_book} {_chapter}: {_startVerse}");
    }



}