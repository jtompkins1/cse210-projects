using System;
using System.Collections.Generic;
public class Word
{
    private string _text;
    // private bool _hidden;

    public Word(string text)
    {
        _text = text;
        // _hidden = false;
    }
    public string GetIsHidden()
    {
        return _text;
    }
    public void SetIsHidden(string text)
    {
        _text = text;
    }



}