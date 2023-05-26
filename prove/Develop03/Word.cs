using System;
using System.Collections.Generic;
public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public bool GetIsHidden()
    {
        return _hidden;
    }
    public void SetIsHidden()
    {
        _hidden = true;
    }
    public bool GetIsShown()
    {
        return _hidden;
    }
    public void SetIsShown()
    {
        _hidden = false;
    }



}