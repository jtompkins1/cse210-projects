using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference()
    {
        _book = "Matthew";
        _chapter = 11;
        _startVerse = 28;
        _endVerse = 30;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
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
}