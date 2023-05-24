using System;

public class Scripture
{   
    private string _scripture;
    private Reference _reference;
    private string _text;
    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _text = text;

    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
    }
    // public string GetText()
    // {
    //     return _text;
    // }
    // public void SetText(string text)
    // {
    //     _text = text;
    // }
    public string GetScripture()
    {
        return _scripture;
    }
    public void SetScripture(Reference reference, string text)
    {
        _scripture = ($"{_reference} {_text}");
    }

}