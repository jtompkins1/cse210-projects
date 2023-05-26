using System;

public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public void IsHidden()
    {
        _hidden = true;
    }
    public void IsShown()
    {
        _hidden = false;
    }



}