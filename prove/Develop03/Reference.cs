using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetStartVerse(verse);
        SetEndVerse(verse);
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetStartVerse(startVerse);
        SetEndVerse(endVerse);
    }
    public string GetBook()
    {
        return _book;
    }
    private void SetBook(string book)
    {
        _book = book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    private void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    private void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    private void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
}